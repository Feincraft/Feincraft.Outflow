using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using Microsoft.Office.Tools;


namespace Feincraft.Outflow
{
    public partial class ThisAddIn
    {
        private FlowResultPane flowPane;
        public Microsoft.Office.Tools.CustomTaskPane customTaskPane;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            flowPane = new FlowResultPane();
            customTaskPane = this.CustomTaskPanes.Add(flowPane, "Outflow");

        }

        private void TaskPaneValue_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion

        /*
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
                return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                    new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { new FlowRibbon() });

        }
        */
    }
}
