namespace MyLanChat
{
    partial class Lan
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
            this.grb_Me = new System.Windows.Forms.GroupBox();
            this.txtMyIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMyPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYouPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYouIP = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbListchat = new System.Windows.Forms.ListBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grb_Me.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Me
            // 
            this.grb_Me.Controls.Add(this.txtMyPort);
            this.grb_Me.Controls.Add(this.label2);
            this.grb_Me.Controls.Add(this.label1);
            this.grb_Me.Controls.Add(this.txtMyIP);
            this.grb_Me.Location = new System.Drawing.Point(13, 13);
            this.grb_Me.Name = "grb_Me";
            this.grb_Me.Size = new System.Drawing.Size(200, 76);
            this.grb_Me.TabIndex = 0;
            this.grb_Me.TabStop = false;
            this.grb_Me.Text = "Me";
            // 
            // txtMyIP
            // 
            this.txtMyIP.Location = new System.Drawing.Point(35, 19);
            this.txtMyIP.Name = "txtMyIP";
            this.txtMyIP.Size = new System.Drawing.Size(153, 20);
            this.txtMyIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txtMyPort
            // 
            this.txtMyPort.Location = new System.Drawing.Point(35, 45);
            this.txtMyPort.Name = "txtMyPort";
            this.txtMyPort.Size = new System.Drawing.Size(153, 20);
            this.txtMyPort.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYouPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYouIP);
            this.groupBox1.Location = new System.Drawing.Point(219, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Friend";
            // 
            // txtYouPort
            // 
            this.txtYouPort.Location = new System.Drawing.Point(35, 45);
            this.txtYouPort.Name = "txtYouPort";
            this.txtYouPort.Size = new System.Drawing.Size(153, 20);
            this.txtYouPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "IP";
            // 
            // txtYouIP
            // 
            this.txtYouIP.Location = new System.Drawing.Point(35, 19);
            this.txtYouIP.Name = "txtYouIP";
            this.txtYouIP.Size = new System.Drawing.Size(153, 20);
            this.txtYouIP.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(13, 94);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbListchat
            // 
            this.lbListchat.FormattingEnabled = true;
            this.lbListchat.Location = new System.Drawing.Point(13, 121);
            this.lbListchat.Name = "lbListchat";
            this.lbListchat.Size = new System.Drawing.Size(406, 173);
            this.lbListchat.TabIndex = 6;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 320);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(326, 20);
            this.txtMess.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(344, 318);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Lan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 352);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.lbListchat);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_Me);
            this.Name = "Lan";
            this.Text = "Lan";
            this.Load += new System.EventHandler(this.Lan_Load);
            this.grb_Me.ResumeLayout(false);
            this.grb_Me.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Me;
        private System.Windows.Forms.TextBox txtMyPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMyIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYouPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYouIP;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListBox lbListchat;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button btnSend;
    }
}