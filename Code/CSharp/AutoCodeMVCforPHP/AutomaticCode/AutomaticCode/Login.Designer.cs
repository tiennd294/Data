namespace AutomaticCode
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btncn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncreatcode = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GVView = new System.Windows.Forms.DataGridView();
            this.lblinfoview = new System.Windows.Forms.Label();
            this.btnsetview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(101, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 21;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(101, 35);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(180, 20);
            this.txtServer.TabIndex = 19;
            // 
            // btncn
            // 
            this.btncn.Location = new System.Drawing.Point(101, 116);
            this.btncn.Name = "btncn";
            this.btncn.Size = new System.Drawing.Size(75, 23);
            this.btncn.TabIndex = 17;
            this.btncn.Text = "Connect";
            this.btncn.UseVisualStyleBackColor = true;
            this.btncn.Click += new System.EventHandler(this.btncn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Database Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server Name";
            // 
            // btncreatcode
            // 
            this.btncreatcode.Location = new System.Drawing.Point(101, 248);
            this.btncreatcode.Name = "btncreatcode";
            this.btncreatcode.Size = new System.Drawing.Size(75, 23);
            this.btncreatcode.TabIndex = 22;
            this.btncreatcode.Text = "Creat Code";
            this.btncreatcode.UseVisualStyleBackColor = true;
            this.btncreatcode.Click += new System.EventHandler(this.btncreatcode_Click);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.Enabled = false;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(101, 145);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(180, 21);
            this.cmbDatabase.TabIndex = 23;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(101, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 20);
            this.txtUsername.TabIndex = 26;
            // 
            // cmbTable
            // 
            this.cmbTable.Enabled = false;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(101, 172);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(180, 21);
            this.cmbTable.TabIndex = 27;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Table Name";
            // 
            // GVView
            // 
            this.GVView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVView.Location = new System.Drawing.Point(304, 35);
            this.GVView.Name = "GVView";
            this.GVView.Size = new System.Drawing.Size(454, 205);
            this.GVView.TabIndex = 29;
            // 
            // lblinfoview
            // 
            this.lblinfoview.AutoSize = true;
            this.lblinfoview.Location = new System.Drawing.Point(301, 258);
            this.lblinfoview.Name = "lblinfoview";
            this.lblinfoview.Size = new System.Drawing.Size(54, 13);
            this.lblinfoview.TabIndex = 30;
            this.lblinfoview.Text = "DS View :";
            // 
            // btnsetview
            // 
            this.btnsetview.Location = new System.Drawing.Point(101, 202);
            this.btnsetview.Name = "btnsetview";
            this.btnsetview.Size = new System.Drawing.Size(75, 23);
            this.btnsetview.TabIndex = 31;
            this.btnsetview.Text = "Set View";
            this.btnsetview.UseVisualStyleBackColor = true;
            this.btnsetview.Click += new System.EventHandler(this.btnsetview_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 333);
            this.Controls.Add(this.btnsetview);
            this.Controls.Add(this.lblinfoview);
            this.Controls.Add(this.GVView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.btncreatcode);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btncn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto code MVC for PHP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btncn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncreatcode;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GVView;
        private System.Windows.Forms.Label lblinfoview;
        private System.Windows.Forms.Button btnsetview;
    }
}

