using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uxk.MsSyncHelper.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProvisionServer_Click(object sender, EventArgs e)
        {
            ProvisionHelper.ApplyServerProvision(txtServerConnectionString.Text, new List<string>() { "CUSTOMER", "PRODUCT" }, txtScopeName.Text);
            MessageBox.Show("Server Provisioned!");
        }

        private void btnProvisionClient_Click(object sender, EventArgs e)
        {
            ProvisionHelper.ApplyClientProvision(txtServerConnectionString.Text, txtClientConnectionString.Text, txtScopeName.Text);
            MessageBox.Show("Client Provisioned!");
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            SyncHelper.ExecuteSync(txtServerConnectionString.Text, txtClientConnectionString.Text, txtScopeName.Text);
            MessageBox.Show("Sync Completed!");
        }
    }
}
