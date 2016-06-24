namespace Engineers
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueprintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelBluePrints = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxShoppingList = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelShoppingList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelRawMaterials = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRawMaterialsHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanelData = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDataHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanelManufactured = new System.Windows.Forms.FlowLayoutPanel();
            this.labelManufacturedHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanelCommodity = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCommodityHeader = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBoxShoppingList.SuspendLayout();
            this.flowLayoutPanelShoppingList.SuspendLayout();
            this.flowLayoutPanelRawMaterials.SuspendLayout();
            this.flowLayoutPanelData.SuspendLayout();
            this.flowLayoutPanelManufactured.SuspendLayout();
            this.flowLayoutPanelCommodity.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.blueprintsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem,
            this.ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem,
            this.toolStripSeparator1,
            this.alwaysOnTopToolStripMenuItem,
            this.transparencyToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // ignoreBlueprintsWithoutEngineersToolStripMenuItem
            // 
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem.Checked = true;
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem.CheckOnClick = true;
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem.Name = "ignoreBlueprintsWithoutEngineersToolStripMenuItem";
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem.Size = new System.Drawing.Size(376, 26);
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem.Text = "Ignore Blueprints without &engineers";
            this.ignoreBlueprintsWithoutEngineersToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ignoreBlueprintsWithoutEngineersToolStripMenuItem_CheckedChanged);
            // 
            // ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem
            // 
            this.ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem.CheckOnClick = true;
            this.ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem.Name = "ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem";
            this.ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem.Size = new System.Drawing.Size(376, 26);
            this.ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem.Text = "Ignore Blueprints with &mining only materials";
            this.ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.igoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(373, 6);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Checked = true;
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(376, 26);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            this.alwaysOnTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_CheckedChanged);
            // 
            // transparencyToolStripMenuItem
            // 
            this.transparencyToolStripMenuItem.CheckOnClick = true;
            this.transparencyToolStripMenuItem.Name = "transparencyToolStripMenuItem";
            this.transparencyToolStripMenuItem.Size = new System.Drawing.Size(376, 26);
            this.transparencyToolStripMenuItem.Text = "&50% transparency";
            this.transparencyToolStripMenuItem.CheckedChanged += new System.EventHandler(this.transparencyToolStripMenuItem_CheckedChanged);
            // 
            // blueprintsToolStripMenuItem
            // 
            this.blueprintsToolStripMenuItem.Name = "blueprintsToolStripMenuItem";
            this.blueprintsToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.blueprintsToolStripMenuItem.Text = "&Blueprints";
            // 
            // flowLayoutPanelBluePrints
            // 
            this.flowLayoutPanelBluePrints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelBluePrints.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelBluePrints.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelBluePrints.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flowLayoutPanelBluePrints.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanelBluePrints.Name = "flowLayoutPanelBluePrints";
            this.flowLayoutPanelBluePrints.Size = new System.Drawing.Size(875, 567);
            this.flowLayoutPanelBluePrints.TabIndex = 5;
            this.flowLayoutPanelBluePrints.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelBluePrints_ControlAdded);
            this.flowLayoutPanelBluePrints.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelBluePrints_ControlRemoved);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 796);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(875, 25);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(568, 20);
            this.toolStripStatusLabel1.Text = "Select up to 4 blueprints from the menu.  Right click to dismiss a displayed blue" +
    "print.";
            // 
            // groupBoxShoppingList
            // 
            this.groupBoxShoppingList.Controls.Add(this.flowLayoutPanelShoppingList);
            this.groupBoxShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxShoppingList.Location = new System.Drawing.Point(0, 595);
            this.groupBoxShoppingList.Name = "groupBoxShoppingList";
            this.groupBoxShoppingList.Size = new System.Drawing.Size(875, 201);
            this.groupBoxShoppingList.TabIndex = 7;
            this.groupBoxShoppingList.TabStop = false;
            this.groupBoxShoppingList.Text = "Shopping List";
            // 
            // flowLayoutPanelShoppingList
            // 
            this.flowLayoutPanelShoppingList.Controls.Add(this.flowLayoutPanelRawMaterials);
            this.flowLayoutPanelShoppingList.Controls.Add(this.flowLayoutPanelData);
            this.flowLayoutPanelShoppingList.Controls.Add(this.flowLayoutPanelManufactured);
            this.flowLayoutPanelShoppingList.Controls.Add(this.flowLayoutPanelCommodity);
            this.flowLayoutPanelShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelShoppingList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelShoppingList.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanelShoppingList.Name = "flowLayoutPanelShoppingList";
            this.flowLayoutPanelShoppingList.Size = new System.Drawing.Size(869, 180);
            this.flowLayoutPanelShoppingList.TabIndex = 0;
            // 
            // flowLayoutPanelRawMaterials
            // 
            this.flowLayoutPanelRawMaterials.AutoScroll = true;
            this.flowLayoutPanelRawMaterials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelRawMaterials.Controls.Add(this.labelRawMaterialsHeader);
            this.flowLayoutPanelRawMaterials.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRawMaterials.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelRawMaterials.Name = "flowLayoutPanelRawMaterials";
            this.flowLayoutPanelRawMaterials.Size = new System.Drawing.Size(279, 174);
            this.flowLayoutPanelRawMaterials.TabIndex = 2;
            // 
            // labelRawMaterialsHeader
            // 
            this.labelRawMaterialsHeader.AutoSize = true;
            this.labelRawMaterialsHeader.Location = new System.Drawing.Point(3, 0);
            this.labelRawMaterialsHeader.Name = "labelRawMaterialsHeader";
            this.labelRawMaterialsHeader.Size = new System.Drawing.Size(96, 17);
            this.labelRawMaterialsHeader.TabIndex = 0;
            this.labelRawMaterialsHeader.Text = "Raw Materials";
            // 
            // flowLayoutPanelData
            // 
            this.flowLayoutPanelData.AutoScroll = true;
            this.flowLayoutPanelData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelData.Controls.Add(this.labelDataHeader);
            this.flowLayoutPanelData.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelData.Location = new System.Drawing.Point(288, 3);
            this.flowLayoutPanelData.Name = "flowLayoutPanelData";
            this.flowLayoutPanelData.Size = new System.Drawing.Size(200, 174);
            this.flowLayoutPanelData.TabIndex = 0;
            // 
            // labelDataHeader
            // 
            this.labelDataHeader.AutoSize = true;
            this.labelDataHeader.Location = new System.Drawing.Point(3, 0);
            this.labelDataHeader.Name = "labelDataHeader";
            this.labelDataHeader.Size = new System.Drawing.Size(38, 17);
            this.labelDataHeader.TabIndex = 0;
            this.labelDataHeader.Text = "Data";
            // 
            // flowLayoutPanelManufactured
            // 
            this.flowLayoutPanelManufactured.AutoScroll = true;
            this.flowLayoutPanelManufactured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelManufactured.Controls.Add(this.labelManufacturedHeader);
            this.flowLayoutPanelManufactured.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelManufactured.Location = new System.Drawing.Point(494, 3);
            this.flowLayoutPanelManufactured.Name = "flowLayoutPanelManufactured";
            this.flowLayoutPanelManufactured.Size = new System.Drawing.Size(200, 174);
            this.flowLayoutPanelManufactured.TabIndex = 1;
            this.flowLayoutPanelManufactured.WrapContents = false;
            // 
            // labelManufacturedHeader
            // 
            this.labelManufacturedHeader.AutoSize = true;
            this.labelManufacturedHeader.Location = new System.Drawing.Point(3, 0);
            this.labelManufacturedHeader.Name = "labelManufacturedHeader";
            this.labelManufacturedHeader.Size = new System.Drawing.Size(95, 17);
            this.labelManufacturedHeader.TabIndex = 0;
            this.labelManufacturedHeader.Text = "Manufactured";
            // 
            // flowLayoutPanelCommodity
            // 
            this.flowLayoutPanelCommodity.AutoScroll = true;
            this.flowLayoutPanelCommodity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCommodity.Controls.Add(this.labelCommodityHeader);
            this.flowLayoutPanelCommodity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCommodity.Location = new System.Drawing.Point(700, 3);
            this.flowLayoutPanelCommodity.Name = "flowLayoutPanelCommodity";
            this.flowLayoutPanelCommodity.Size = new System.Drawing.Size(103, 174);
            this.flowLayoutPanelCommodity.TabIndex = 3;
            // 
            // labelCommodityHeader
            // 
            this.labelCommodityHeader.AutoSize = true;
            this.labelCommodityHeader.Location = new System.Drawing.Point(3, 0);
            this.labelCommodityHeader.Name = "labelCommodityHeader";
            this.labelCommodityHeader.Size = new System.Drawing.Size(77, 17);
            this.labelCommodityHeader.TabIndex = 0;
            this.labelCommodityHeader.Text = "Commodity";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 821);
            this.Controls.Add(this.groupBoxShoppingList);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.flowLayoutPanelBluePrints);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Elite: Dangerous Engineers Cheat Sheet";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxShoppingList.ResumeLayout(false);
            this.flowLayoutPanelShoppingList.ResumeLayout(false);
            this.flowLayoutPanelRawMaterials.ResumeLayout(false);
            this.flowLayoutPanelRawMaterials.PerformLayout();
            this.flowLayoutPanelData.ResumeLayout(false);
            this.flowLayoutPanelData.PerformLayout();
            this.flowLayoutPanelManufactured.ResumeLayout(false);
            this.flowLayoutPanelManufactured.PerformLayout();
            this.flowLayoutPanelCommodity.ResumeLayout(false);
            this.flowLayoutPanelCommodity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreBlueprintsWithoutEngineersToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBluePrints;
        private System.Windows.Forms.ToolStripMenuItem blueprintsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreBlueprintsWithminingOnlyMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparencyToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxShoppingList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelShoppingList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRawMaterials;
        private System.Windows.Forms.Label labelRawMaterialsHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelData;
        private System.Windows.Forms.Label labelDataHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelManufactured;
        private System.Windows.Forms.Label labelManufacturedHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCommodity;
        private System.Windows.Forms.Label labelCommodityHeader;
    }
}

