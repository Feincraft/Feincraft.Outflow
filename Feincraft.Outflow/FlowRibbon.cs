using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feincraft.Outflow
{
    public partial class FlowRibbon
    {
        private void FlowRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnOutflow_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.customTaskPane.Visible = true;
            Globals.ThisAddIn.customTaskPane.Width = 500;
        }
    }
}
