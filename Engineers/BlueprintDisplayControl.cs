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
    public partial class BlueprintDisplayControl : FlowLayoutPanel
    {
        public Blueprint associatedBlueprint;
        public delegate void InvokeDelegate();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public BlueprintDisplayControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            associatedBlueprint = new Blueprint();

            this.FlowDirection = FlowDirection.TopDown;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.Transparent;

            labelModule.ForeColor = Color.OrangeRed;
            labelModule.BackColor = Color.Transparent;
            labelModule.Font = new Font(this.Font, FontStyle.Bold);
            labelModule.Parent = this;

            labelName.ForeColor = Color.OrangeRed;
            labelName.BackColor = Color.FromArgb(255, Color.Green);
            labelName.Parent = this;

            labelClass.ForeColor = Color.OrangeRed;
            labelClass.BackColor = Color.FromArgb(0, Color.Green);
            labelClass.Parent = this;

            labelMaterialsHeader.Text = "\rMaterials";
            labelMaterialsHeader.ForeColor = Color.OrangeRed;
            labelMaterialsHeader.BackColor = Color.Transparent;
            labelMaterialsHeader.Font = new Font(this.Font, FontStyle.Bold);
            labelMaterialsHeader.Parent = this;

            labelEngineerHeader.Text = "\r" + labelEngineerHeader.Text;
            labelEngineerHeader.ForeColor = Color.OrangeRed;
            labelEngineerHeader.BackColor = Color.Transparent; this.FlowDirection = FlowDirection.TopDown;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //this.BackColor = Color.Black;
            this.BackColor = Color.Transparent;

            labelModule.ForeColor = Color.OrangeRed;
            labelModule.BackColor = Color.Transparent;
            labelModule.Font = new Font(this.Font, FontStyle.Bold);
            labelModule.Parent = this;

            labelName.ForeColor = Color.OrangeRed;
            labelName.BackColor = Color.FromArgb(255, Color.Green);
            labelName.Parent = this;

            labelClass.ForeColor = Color.OrangeRed;
            labelClass.BackColor = Color.FromArgb(0, Color.Green);
            labelClass.Parent = this;

            labelMaterialsHeader.Text = "\rMaterials";
            labelMaterialsHeader.ForeColor = Color.OrangeRed;
            labelMaterialsHeader.BackColor = Color.Transparent;
            labelMaterialsHeader.Font = new Font(this.Font, FontStyle.Bold);
            labelMaterialsHeader.Parent = this;

            labelEngineerHeader.Text = "\r" + labelEngineerHeader.Text;
            labelEngineerHeader.ForeColor = Color.OrangeRed;
            labelEngineerHeader.BackColor = Color.Transparent;
            labelEngineerHeader.Font = new Font(this.Font, FontStyle.Bold);
            labelEngineerHeader.Parent = this;
            labelEngineerHeader.Font = new Font(this.Font, FontStyle.Bold);
            labelEngineerHeader.Parent = this;

        }

        public BlueprintDisplayControl(Blueprint blueprint, Control parent)
        {
            InitializeComponent();
            associatedBlueprint = blueprint;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            FlowDirection = FlowDirection.TopDown;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //BackColor = Color.Transparent;

            labelModule.ForeColor = Color.OrangeRed;
            labelModule.BackColor = Color.Transparent;
            labelModule.Font = new Font(this.Font, FontStyle.Bold);
            labelModule.Parent = this;

            labelName.ForeColor = Color.OrangeRed;
            labelName.BackColor = Color.Transparent;
            labelName.Parent = this;

            labelClass.ForeColor = Color.OrangeRed;
            labelClass.BackColor = Color.Transparent;
            labelClass.Parent = this;

            labelMaterialsHeader.Text = "\rMaterials";
            labelMaterialsHeader.ForeColor = Color.OrangeRed;
            labelMaterialsHeader.BackColor = Color.Transparent;
            labelMaterialsHeader.Font = new Font(this.Font, FontStyle.Bold);
            labelMaterialsHeader.Parent = this;

            labelEngineerHeader.Text = "\r" + labelEngineerHeader.Text;
            labelEngineerHeader.ForeColor = Color.OrangeRed;
            labelEngineerHeader.BackColor = Color.Transparent;
            labelEngineerHeader.Font = new Font(this.Font, FontStyle.Bold);
            labelEngineerHeader.Parent = this;

            labelModule.Text = blueprint.Module;
            labelName.Text = blueprint.Name + " " + blueprint.Grade.ToString();
            //AddMaterialLabels(blueprint.RequiredComponents, blueprint.RequiredComponentsCount);
            AddMaterialLabels(blueprint.RequiredComponents);
            AddEngineerLabels(blueprint.OfferedBy);

            int qWidth = parent.Width / 2 - this.Padding.All;
            int qHeight = parent.Height / 2 - this.Padding.All;
            Width = qWidth;
            Height = qHeight;

            BackColor = Color.FromArgb(255, 0, 0, 0);

            this.Name = "BlueprintDisplayControl";
            this.Parent = parent;
        }

        //public void AddMaterialLabels(Component[] newComponents, int[] counts)
        public void AddMaterialLabels(Ingredient[] newComponents)
        {
            int materialsHeaderLabelIndex = -1; //will hold the index of the label for the materials section of the blueprint so we can insert mats at the correct place
            foreach (Control control in this.Controls)
            {
                if (control.Name == "labelMaterialsHeader") { materialsHeaderLabelIndex = this.Controls.IndexOf(control); }
            }

            for (int i=0;i<newComponents.Count();i++)
            {
                ToolTip newToolTip = new ToolTip();
                Label newLabel = new Label();
                newLabel.AutoSize = true;
                //newLabel.Text = counts[i].ToString() + "x " + newComponents[i].Name + " (" + newComponents[i].Occurence + ")";
                newLabel.Text = newComponents[i].ingredientCount.ToString() + "x " + newComponents[i].ingredientComponent.Name + " (" + newComponents[i].ingredientComponent.Occurence + ")";
                newLabel.ForeColor = Color.White;
                newLabel.Parent = this;

                //newToolTip.SetToolTip(newLabel, newComponents[i].Type + " acquired from " + newComponents[i].MeansOfAcquiring);
                newToolTip.SetToolTip(newLabel, newComponents[i].ingredientComponent.Type + " acquired from " + newComponents[i].ingredientComponent.MeansOfAcquiring);

                this.Controls.SetChildIndex(newLabel, materialsHeaderLabelIndex + 1 + i);
            }
        }

        public void AddEngineerLabels(Engineer[] newEngineers)
        {
            int engineerHeaderLabelIndex = -1; //will hold the index of the label for the engineers section of the blueprint so we can insert mats at the correct place
            foreach (Control control in this.Controls)
            {
                if (control.Name == "labelEngineerHeader") { engineerHeaderLabelIndex = this.Controls.IndexOf(control); }
            }

            //no known engineers offer this blueprint
            if (newEngineers.Count() == 0)
            {
                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.Text = "-?-";
                newLabel.ForeColor = Color.White;
                newLabel.Parent = this;
                this.Controls.SetChildIndex(newLabel, engineerHeaderLabelIndex + 1);
                return;
            }

            if(newEngineers.Count() > 1) { labelEngineerHeader.Text = "\rEngineers"; } else { labelEngineerHeader.Text = "\rEngineer"; }


            for (int i = 0; i < newEngineers.Count(); i++)
            {
                ToolTip newToolTip = new ToolTip();
                Label newLabel = new Label();
                newLabel.Visible = true;

                newToolTip.SetToolTip(newLabel, newEngineers[i].Name);
                
                newLabel.AutoSize = true;
                newLabel.Text = newEngineers[i].Name;
                newLabel.ForeColor = Color.White;
                newLabel.MouseEnter += new EventHandler(engineerNameLabel_MouseEnter);
                newLabel.MouseLeave += new EventHandler(engineerNameLabel_MouseLeave);
                newLabel.MouseClick += new MouseEventHandler(engineerNameLabel_MouseClick);
                newLabel.Parent = this;
                this.Controls.SetChildIndex(newLabel, engineerHeaderLabelIndex + 1 + i);
            }
        }

        private void engineerNameLabel_MouseEnter(object sender, EventArgs e)
        {
            Label engLabel = (Label)sender;
            engLabel.Font = new Font(engLabel.Font, FontStyle.Underline);
            engLabel.Cursor = Cursors.Hand;
        }

        private void engineerNameLabel_MouseLeave(object sender, EventArgs e)
        {
            Label engLabel = (Label)sender;
            engLabel.Font = new Font(engLabel.Font, FontStyle.Regular);
            engLabel.Cursor = Cursors.Default;
        }

        private void engineerNameLabel_MouseClick(object sender, EventArgs e)
        {
            Label engLabel = (Label)sender;
            Engineers engs = new Engineers();
            foreach (Engineer eng in engs.AllEngineers)
            {
                if (engLabel.Text.Equals(eng.Name)) { System.Diagnostics.Process.Start(eng.OnlineInfo); }
            }
        }

        //private void fadeOut(object sender, EventArgs e)
        //{
        //    //TODO: maybe?
        //    //BeginInvoke(new InvokeDelegate(fade));
        //}

        public void fadeOut()
        {
            foreach(Control control in Controls)
            { control.BackColor = System.Drawing.Color.Transparent; control.ForeColor = System.Drawing.Color.FromArgb(255, control.BackColor); }

            for (int x = 255; x > 0; x = x - 4)
            {
                BackColor = System.Drawing.Color.FromArgb(x, 0, 0, 0);
                foreach (Control control in Controls)
                {
                    //control.BackColor = System.Drawing.Color.FromArgb(x, control.BackColor.R, control.BackColor.G, control.BackColor.B);
                    //control.BackColor = System.Drawing.Color.FromArgb(x, 0, 0, 0);
                    //control.ForeColor = System.Drawing.Color.FromArgb(x, control.ForeColor.R, control.ForeColor.G, control.ForeColor.B);
                    control.ForeColor = System.Drawing.Color.FromArgb(0, control.ForeColor);
                    //control.Invalidate();
                    //control.Refresh();
                }
                Refresh();
            }

            Dispose();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

    }
}
