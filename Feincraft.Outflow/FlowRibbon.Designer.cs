namespace Feincraft.Outflow
{
    partial class FlowRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FlowRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabFlow = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnOutflow = this.Factory.CreateRibbonButton();
            this.tabFlow.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFlow
            // 
            this.tabFlow.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabFlow.ControlId.OfficeId = "TabMail";
            this.tabFlow.Groups.Add(this.group1);
            this.tabFlow.Label = "TabMail";
            this.tabFlow.Name = "tabFlow";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnOutflow);
            this.group1.Label = "Outflow";
            this.group1.Name = "group1";
            // 
            // btnOutflow
            // 
            this.btnOutflow.Image = global::Feincraft.Outflow.Properties.Resources.PAlogoC1;
            this.btnOutflow.Label = "Outflow";
            this.btnOutflow.Name = "btnOutflow";
            this.btnOutflow.ShowImage = true;
            this.btnOutflow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnOutflow_Click);
            // 
            // FlowRibbon
            // 
            this.Name = "FlowRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tabFlow);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.FlowRibbon_Load);
            this.tabFlow.ResumeLayout(false);
            this.tabFlow.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabFlow;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOutflow;
    }

    partial class ThisRibbonCollection
    {
        internal FlowRibbon FlowRibbon
        {
            get { return this.GetRibbon<FlowRibbon>(); }
        }
    }
}
