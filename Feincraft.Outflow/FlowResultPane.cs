using Feincraft.Outflow.Properties;
using Microsoft.Office.Interop.Outlook;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feincraft.Outflow
{
    public partial class FlowResultPane : UserControl
    {
        public FlowResultPane()
        {
            InitializeComponent();
        }

        private async void PostRequest()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            String msg = txtResult.Text; 
            msg = JsonConvert.SerializeObject(msg, new JsonSerializerSettings
            {
                StringEscapeHandling = StringEscapeHandling.EscapeNonAscii
            });
            msg = @"{""message"":" + msg + "}";

            var data = new StringContent(msg, Encoding.UTF8, "application/json");

            var url = Settings.Default.FlowAddress;
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            result = result.Replace("\n", Environment.NewLine);

            if (InvokeRequired) Invoke(new System.Action(() =>
            {
                txtResult.Text = result;
                pnlLoading.Visible = false;
            }));
            else
            {
                txtResult.Text = result;
                pnlLoading.Visible = false;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Explorer explorer = Globals.ThisAddIn.Application.ActiveExplorer();
            Selection selection = explorer.Selection;

            if (selection.Count > 0)  
            {
                object selectedItem = selection[1];   
                MailItem mailItem = selectedItem as MailItem;

                if (mailItem != null) 
                {
                    // Get only last message
                    if (mailItem.Body.Contains("_____"))
                        txtResult.Text = mailItem.Body.Remove(mailItem.Body.IndexOf("_____"));
                    else txtResult.Text = mailItem.Body;

                    pnlLoading.Visible = true;
                    
                    // Send request
                    PostRequest();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            pnlTools.Visible = true;
            pnlSettings.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            pnlTools.Visible = true;
            pnlSettings.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlTools.Visible = false;
            pnlSettings.Visible = true;
        }

        private void btnSmaller_Click(object sender, EventArgs e)
        {
            if (txtResult.Font.Size > 6)
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size - 1);
        }

        private void btnLarger_Click(object sender, EventArgs e)
        {
            if (txtResult.Font.Size < 32)
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size + 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
