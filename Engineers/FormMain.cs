using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engineers
{
    public partial class FormMain : Form
    {
        private bool HideUnobtainableBlueprints = false;
        private bool HideMiningOnlyBlueprints = false;
        private int displayedBluePrints = 0;
        static Components AllComponents = new Components();
        //static Blueprints AllBlueprints = new Blueprints();
        static Blueprints AllBlueprints;
        public delegate void InvokeDelegate();

        public FormMain()
        {
            InitializeComponent();

            AllBlueprints = new Blueprints("blueprints.csv");

            Application.AddMessageFilter(new Filter());

            flowLayoutPanelCommodity.Width = flowLayoutPanelShoppingList.Width / flowLayoutPanelShoppingList.Controls.Count - 5;
            flowLayoutPanelManufactured.Width = flowLayoutPanelShoppingList.Width / flowLayoutPanelShoppingList.Controls.Count - 5;
            flowLayoutPanelData.Width = flowLayoutPanelShoppingList.Width / flowLayoutPanelShoppingList.Controls.Count - 5;
            flowLayoutPanelRawMaterials.Width = flowLayoutPanelShoppingList.Width / flowLayoutPanelShoppingList.Controls.Count - 5;
            flowLayoutPanelCommodity.Height = flowLayoutPanelShoppingList.Height - 2;
            flowLayoutPanelManufactured.Height = flowLayoutPanelShoppingList.Height - 2;
            flowLayoutPanelData.Height = flowLayoutPanelShoppingList.Height - 2;
            flowLayoutPanelRawMaterials.Height = flowLayoutPanelShoppingList.Height - 2;

            HideUnobtainableBlueprints = ignoreBlueprintsWithoutEngineersToolStripMenuItem.Checked;
            HideMiningOnlyBlueprints = ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem.Checked;
            buildBluePrintsMenu(HideUnobtainableBlueprints, HideMiningOnlyBlueprints);
        }

        class Filter : IMessageFilter
        {
            public delegate void InvokeDelegate();
            public bool PreFilterMessage(ref Message m)
            {
                FormMain mainApplication;
                if (m.Msg == 517)    // WM_RBUTTONUP 
                {
                    Control p = Control.FromHandle(m.HWnd);
                    if ((p != null) && (p.Name == "BlueprintDisplayControl" || p.GetType() == typeof(Label)))
                    {
                        mainApplication = (FormMain)p.TopLevelControl;
                        #region debug code
                        //var cm = new ContextMenu();
                        //cm.MenuItems.Add(p.Name);
                        //cm.MenuItems.Add(p.GetType().ToString());
                        //cm.Show(p, p.PointToClient(Control.MousePosition));
                        //if clicked on a label, get rid of the parent control otherwise get rid of the control
                        #endregion
                        BlueprintDisplayControl bdc;
                        if (p.GetType() == typeof(Label)) { bdc = (BlueprintDisplayControl)p.Parent; /*p.Parent.Dispose();*/ }
                        else
                        { bdc = (BlueprintDisplayControl)Control.FromHandle(m.HWnd); /*p.Dispose();*/ }

                        mainApplication.removeBlueprint(bdc);
                    }
                }
                return false;
            }
        }

        public void removeBlueprint(BlueprintDisplayControl bdc)
        {
            BeginInvoke(new InvokeDelegate(bdc.fadeOut));
        }

        #region event handlers
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void flowLayoutPanelBluePrints_ControlRemoved(object sender, ControlEventArgs e)
        {
            buildShoppingList();
        }

        private void flowLayoutPanelBluePrints_ControlAdded(object sender, ControlEventArgs e)
        {
            buildShoppingList();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ignoreBlueprintsWithoutEngineersToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(ignoreBlueprintsWithoutEngineersToolStripMenuItem.Checked)
            { HideUnobtainableBlueprints = true; }
            else
            { HideUnobtainableBlueprints = false; }

            buildBluePrintsMenu(HideUnobtainableBlueprints, HideMiningOnlyBlueprints);
        }

        private void igoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem.Checked)
            { HideMiningOnlyBlueprints = true; }
            else
            { HideMiningOnlyBlueprints = false; }

            buildBluePrintsMenu(HideUnobtainableBlueprints, HideMiningOnlyBlueprints);
        }

        private void alwaysOnTopToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(alwaysOnTopToolStripMenuItem.Checked) { this.TopMost = true; }
            else { this.TopMost = false; }
        }

        private void transparencyToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (transparencyToolStripMenuItem.Checked) { this.AllowTransparency = true; this.Opacity = .5; }
            else { this.AllowTransparency = false; this.Opacity = 1; }
        }

        public void menuItemBlueprint_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedMenuItem = (ToolStripMenuItem)sender;
            string[] Selection = clickedMenuItem.Name.Split(new char[] { '-' });
            string BlueprintModule = Selection[0];
            string BlueprintName = Selection[1].Trim();
            string BlueprintGrade = Selection[2];
            foreach (Blueprint bp in AllBlueprints.AllBlueprints)
            {
                if (bp.Module.Equals(BlueprintModule) && bp.Name.Equals(BlueprintName) && bp.Grade == Int32.Parse(BlueprintGrade))
                {
                    new BlueprintDisplayControl(bp, flowLayoutPanelBluePrints);
                }

            }

            if (flowLayoutPanelBluePrints.Controls.Count > 4) { flowLayoutPanelBluePrints.Controls[0].Dispose(); }

        }
        #endregion

        private void buildBluePrintsMenu(bool hideUnobtainable, bool hideMiningOnlyBlueprints)
        {
            blueprintsToolStripMenuItem.DropDownItems.Clear();
            displayedBluePrints = 0;

            foreach (Blueprint bp in AllBlueprints.AllBlueprints)
            {
                //****APPLY FILTERS
                //obtainable v unobtainable
                if (bp.OfferedBy.Count() == 0 && hideUnobtainable) { continue; }

                //mining v no mining
                bool miningRequired = false;
                //foreach (Component component in bp.RequiredComponents)
                foreach (Ingredient ing in bp.RequiredComponents)
                {
                    if (ing.ingredientComponent.MeansOfAcquiring.ToLower().Contains("mining") && !ing.ingredientComponent.MeansOfAcquiring.ToLower().Contains("prospecting"))
                    { miningRequired = true; }
                }
                if (miningRequired && hideMiningOnlyBlueprints) { continue; }
                //****END APPLY FILTERS

                //build MODULES menu item list
                ToolStripMenuItem menuItemModule = new ToolStripMenuItem(bp.Module);
                menuItemModule.Name = bp.Module;
                if(!blueprintsToolStripMenuItem.DropDownItems.ContainsKey(bp.Module))
                { blueprintsToolStripMenuItem.DropDownItems.Add(menuItemModule); }
                    
                //populate MODULES menu items with related blueprints
                ToolStripMenuItem menuItemBlueprint = new ToolStripMenuItem(bp.Name + " " + bp.Grade.ToString(), null, new EventHandler(menuItemBlueprint_Click));
                if(bp.OfferedBy.Count() == 0) { menuItemBlueprint.ForeColor = Color.Red; }
                menuItemBlueprint.Name = bp.Module + "-" + bp.Name + "-" + bp.Grade.ToString();
                ToolStripMenuItem tmp = (ToolStripMenuItem)blueprintsToolStripMenuItem.DropDownItems.Find(bp.Module, false)[0];
                tmp.DropDownItems.Add(menuItemBlueprint);

                displayedBluePrints++;
                
            }

            this.toolStripStatusLabel1.Text = displayedBluePrints.ToString() + " blueprints available.  Select up to 4 blueprints from the menu and right click a blueprint to dismiss it.";
        }

        //public void buildShoppingList()
        //{
        //    //flowLayoutPanelShoppingList.Controls.Clear();
        //    flowLayoutPanelManufactured.Controls.Clear();
        //    flowLayoutPanelRawMaterials.Controls.Clear();
        //    flowLayoutPanelData.Controls.Clear();
        //    flowLayoutPanelCommodity.Controls.Clear();

        //    Label genericHeaderLabel1 = new Label();
        //    genericHeaderLabel1.Font = new Font(genericHeaderLabel1.Font, FontStyle.Bold);
        //    genericHeaderLabel1.Text = "Manufactured";
        //    genericHeaderLabel1.Parent = flowLayoutPanelManufactured;
        //    Label genericHeaderLabel2 = new Label();
        //    genericHeaderLabel2.Font = new Font(genericHeaderLabel2.Font, FontStyle.Bold);
        //    genericHeaderLabel2.Text = "Raw Materials";
        //    genericHeaderLabel2.Parent = flowLayoutPanelRawMaterials;
        //    Label genericHeaderLabel3 = new Label();
        //    genericHeaderLabel3.Font = new Font(genericHeaderLabel3.Font, FontStyle.Bold);
        //    genericHeaderLabel3.Text = "Data";
        //    genericHeaderLabel3.Parent = flowLayoutPanelData;
        //    Label genericHeaderLabel4 = new Label();
        //    genericHeaderLabel4.Font = new Font(genericHeaderLabel4.Font, FontStyle.Bold);
        //    genericHeaderLabel4.Text = "Commodities";
        //    genericHeaderLabel4.Parent = flowLayoutPanelCommodity;

        //    List<Component> components = new List<Component>();
        //    List<int> componentsCount = new List<int>();
        //    List<Component> componentsRedux = new List<Component>();
        //    List<int> componentsCountRedux = new List<int>();
        //    foreach (Control control in flowLayoutPanelBluePrints.Controls)
        //    {

        //        if (control.GetType() == typeof(BlueprintDisplayControl))
        //        {
        //            BlueprintDisplayControl bpdc = (BlueprintDisplayControl)control;
        //            for (int i = 0; i < bpdc.associatedBlueprint.RequiredComponents.Count(); i++)
        //            {
        //                components.Add(bpdc.associatedBlueprint.RequiredComponents[i]);
        //                componentsCount.Add(bpdc.associatedBlueprint.RequiredComponentsCount[i]);
        //            }
        //        }
        //    }
        //    for (int i = 0; i < components.Count; i++) //combine the materials
        //    {
        //        if (!componentsRedux.Contains(components[i]))
        //        {
        //            componentsRedux.Add(components[i]);
        //            componentsCountRedux.Add(componentsCount[i]);
        //        }
        //        else
        //        {
        //            for (int j = 0; j < componentsRedux.Count; j++)
        //            {
        //                if (componentsRedux[j].Equals(components[i]))
        //                {
        //                    componentsCountRedux[j] += componentsCount[i];
        //                }
        //            }
        //        }
        //    }

        //    for (int i = 0; i < componentsRedux.Count(); i++)
        //    {
        //        string componentType = componentsRedux[i].Type.ToLower();
        //        if(componentType.Contains("manufactured")) { componentType = "manufactured good"; }
        //        Label newLabel = new Label();
        //        newLabel.AutoSize = true;
        //        newLabel.Text = componentsCountRedux[i].ToString() + "x " + componentsRedux[i].Name;
        //        ToolTip newToolTip = new ToolTip();
        //        newToolTip.SetToolTip(newLabel, componentsRedux[i].Occurence + " " + componentType + " acquired from " + componentsRedux[i].MeansOfAcquiring);
        //        if(componentsRedux[i].Type == "Data") { newLabel.Parent = flowLayoutPanelData; }
        //        else if (componentsRedux[i].Type == "Manufactured") { newLabel.Parent = flowLayoutPanelManufactured; }
        //        else if (componentsRedux[i].Type == "Commodity") { newLabel.Parent = flowLayoutPanelCommodity; }
        //        else if (componentsRedux[i].Type == "Raw material") { newLabel.Parent = flowLayoutPanelRawMaterials; }
        //        //newLabel.Parent = flowLayoutPanelShoppingList;
        //    }

        //}

        public void buildShoppingList()
        {
            //flowLayoutPanelShoppingList.Controls.Clear();
            flowLayoutPanelManufactured.Controls.Clear();
            flowLayoutPanelRawMaterials.Controls.Clear();
            flowLayoutPanelData.Controls.Clear();
            flowLayoutPanelCommodity.Controls.Clear();

            Label genericHeaderLabel1 = new Label();
            genericHeaderLabel1.Font = new Font(genericHeaderLabel1.Font, FontStyle.Bold);
            genericHeaderLabel1.Text = "Manufactured";
            genericHeaderLabel1.Parent = flowLayoutPanelManufactured;
            Label genericHeaderLabel2 = new Label();
            genericHeaderLabel2.Font = new Font(genericHeaderLabel2.Font, FontStyle.Bold);
            genericHeaderLabel2.Text = "Raw Materials";
            genericHeaderLabel2.Parent = flowLayoutPanelRawMaterials;
            Label genericHeaderLabel3 = new Label();
            genericHeaderLabel3.Font = new Font(genericHeaderLabel3.Font, FontStyle.Bold);
            genericHeaderLabel3.Text = "Data";
            genericHeaderLabel3.Parent = flowLayoutPanelData;
            Label genericHeaderLabel4 = new Label();
            genericHeaderLabel4.Font = new Font(genericHeaderLabel4.Font, FontStyle.Bold);
            genericHeaderLabel4.Text = "Commodities";
            genericHeaderLabel4.Parent = flowLayoutPanelCommodity;

            //List<Component> components = new List<Component>();
            //List<int> componentsCount = new List<int>();
            //List<Component> componentsRedux = new List<Component>();
            //List<int> componentsCountRedux = new List<int>();

            List<Ingredient> componentssss = new List<Ingredient>();
            List<Ingredient> componentsRedux = new List<Ingredient>();

            foreach (Control control in flowLayoutPanelBluePrints.Controls)
            {

                if (control.GetType() == typeof(BlueprintDisplayControl))
                {
                    BlueprintDisplayControl bpdc = (BlueprintDisplayControl)control;
                    //for (int i = 0; i < bpdc.associatedBlueprint.RequiredComponents.Count(); i++)
                    //{
                    //    components.Add(bpdc.associatedBlueprint.RequiredComponents[i]);
                    //    componentsCount.Add(bpdc.associatedBlueprint.RequiredComponentsCount[i]);
                    //}
                    foreach(Ingredient ing in bpdc.associatedBlueprint.RequiredComponents)
                    { componentssss.Add(new Ingredient(ing.ingredientCount, ing.ingredientComponent)); }
                }
            }
            for (int i = 0; i < componentssss.Count; i++) //combine the materials
            {
                bool alreadyInList = false;

                for(int a = 0; a < componentsRedux.Count; a++)
                {
                    if (componentsRedux[a].ingredientComponent.Name == componentssss[i].ingredientComponent.Name)
                    { alreadyInList = true; }
                }
                if(!alreadyInList)
                { componentsRedux.Add(componentssss[i]); }
                else
                {
                    for (int j = 0; j < componentsRedux.Count; j++)
                    {
                        if (componentsRedux[j].ingredientComponent.Equals(componentssss[i].ingredientComponent))
                        {
                            componentsRedux[j].ingredientCount += componentssss[i].ingredientCount;
                        }
                    }
                }
            }

            //for (int i = 0; i < componentsRedux.Count(); i++)
            foreach(Ingredient ing in componentsRedux)
            {
                string componentType = ing.ingredientComponent.Type.ToLower();
                if (componentType.Contains("manufactured")) { componentType = "manufactured good"; }
                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.Text = ing.ingredientCount.ToString() + "x " + ing.ingredientComponent.Name;
                ToolTip newToolTip = new ToolTip();
                newToolTip.SetToolTip(newLabel, ing.ingredientComponent.Occurence + " " + componentType + " acquired from " + ing.ingredientComponent.MeansOfAcquiring);
                if (ing.ingredientComponent.Type == "Data") { newLabel.Parent = flowLayoutPanelData; }
                else if (ing.ingredientComponent.Type == "Manufactured") { newLabel.Parent = flowLayoutPanelManufactured; }
                else if (ing.ingredientComponent.Type == "Commodity") { newLabel.Parent = flowLayoutPanelCommodity; }
                else if (ing.ingredientComponent.Type == "Raw material") { newLabel.Parent = flowLayoutPanelRawMaterials; }
                //newLabel.Parent = flowLayoutPanelShoppingList;
            }

        }

    }
}
