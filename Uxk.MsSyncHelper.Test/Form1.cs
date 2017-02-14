using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            ProvisionHelper.ApplyServerProvision(txtServerConnectionString.Text, new List<string>() { "EMP", "DEPT" }, txtScopeName.Text);
            MessageBox.Show("Server Provisioned!");
        }

        private void btnProvisionClient_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder(txtClientConnectionString.Text);

            ProvisionHelper.ApplyClientProvision(txtServerConnectionString.Text, b.ConnectionString, txtScopeName.Text);

            b.InitialCatalog = @"DbScottClient2";
            ProvisionHelper.ApplyClientProvision(txtServerConnectionString.Text, b.ConnectionString, txtScopeName.Text);

            MessageBox.Show("Client Provisioned!");
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder(txtClientConnectionString.Text);

            SyncHelper.ExecuteSync(txtServerConnectionString.Text, b.ConnectionString, txtScopeName.Text);

            b.InitialCatalog = @"DbScottClient2";
            SyncHelper.ExecuteSync(txtServerConnectionString.Text, b.ConnectionString, txtScopeName.Text);

            MessageBox.Show("Sync Completed!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(Environment.SpecialFolder)))
            {
                Console.WriteLine("{1} : {0}", Environment.GetFolderPath((Environment.SpecialFolder)Enum.Parse(typeof(Environment.SpecialFolder), item)),item);
            }
        }
    }
}
