namespace Uxk.MsSyncHelper.Test
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerConnectionString = new System.Windows.Forms.TextBox();
            this.txtClientConnectionString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScopeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProvisionServer = new System.Windows.Forms.Button();
            this.btnProvisionClient = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Connection String :";
            // 
            // txtServerConnectionString
            // 
            this.txtServerConnectionString.Location = new System.Drawing.Point(149, 21);
            this.txtServerConnectionString.Name = "txtServerConnectionString";
            this.txtServerConnectionString.Size = new System.Drawing.Size(515, 20);
            this.txtServerConnectionString.TabIndex = 1;
            this.txtServerConnectionString.Text = "Data Source=LAP0000082\\SQLEXPRESS; Initial Catalog=DbScottServer; Integrated Secu" +
    "rity=True";
            // 
            // txtClientConnectionString
            // 
            this.txtClientConnectionString.Location = new System.Drawing.Point(149, 47);
            this.txtClientConnectionString.Name = "txtClientConnectionString";
            this.txtClientConnectionString.Size = new System.Drawing.Size(515, 20);
            this.txtClientConnectionString.TabIndex = 3;
            this.txtClientConnectionString.Text = "Data Source=LAP0000082\\SQLEXPRESS; Initial Catalog=DbScottClient1; Integrated Sec" +
    "urity=True";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " Client Connection String :";
            // 
            // txtScopeName
            // 
            this.txtScopeName.Location = new System.Drawing.Point(149, 73);
            this.txtScopeName.Name = "txtScopeName";
            this.txtScopeName.Size = new System.Drawing.Size(515, 20);
            this.txtScopeName.TabIndex = 5;
            this.txtScopeName.Text = "MySyncScope";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sync Scope Name :";
            // 
            // btnProvisionServer
            // 
            this.btnProvisionServer.Location = new System.Drawing.Point(53, 152);
            this.btnProvisionServer.Name = "btnProvisionServer";
            this.btnProvisionServer.Size = new System.Drawing.Size(147, 23);
            this.btnProvisionServer.TabIndex = 6;
            this.btnProvisionServer.Text = "Apply Provision to Server";
            this.btnProvisionServer.UseVisualStyleBackColor = true;
            this.btnProvisionServer.Click += new System.EventHandler(this.btnProvisionServer_Click);
            // 
            // btnProvisionClient
            // 
            this.btnProvisionClient.Location = new System.Drawing.Point(259, 152);
            this.btnProvisionClient.Name = "btnProvisionClient";
            this.btnProvisionClient.Size = new System.Drawing.Size(147, 23);
            this.btnProvisionClient.TabIndex = 7;
            this.btnProvisionClient.Text = "Apply Provision to Client";
            this.btnProvisionClient.UseVisualStyleBackColor = true;
            this.btnProvisionClient.Click += new System.EventHandler(this.btnProvisionClient_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(471, 152);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(147, 23);
            this.btnSync.TabIndex = 8;
            this.btnSync.Text = "Execute Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 258);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnProvisionClient);
            this.Controls.Add(this.btnProvisionServer);
            this.Controls.Add(this.txtScopeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientConnectionString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerConnectionString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerConnectionString;
        private System.Windows.Forms.TextBox txtClientConnectionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScopeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProvisionServer;
        private System.Windows.Forms.Button btnProvisionClient;
        private System.Windows.Forms.Button btnSync;
    }
}

