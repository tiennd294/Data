namespace Mon_2.Bai_04.Bai_01
{
    partial class F_con
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
            this.txtnoidung = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtnoidung
            // 
            this.txtnoidung.AcceptsTab = true;
            this.txtnoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtnoidung.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoidung.Location = new System.Drawing.Point(0, 0);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(580, 389);
            this.txtnoidung.TabIndex = 0;
            this.txtnoidung.Text = "";
            this.txtnoidung.TextChanged += new System.EventHandler(this.txtnoidung_TextChanged);
            // 
            // F_con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 389);
            this.Controls.Add(this.txtnoidung);
            this.Name = "F_con";
            this.Text = "F_con";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_con_FormClosing);
            this.Load += new System.EventHandler(this.F_con_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox txtnoidung;



    }
}