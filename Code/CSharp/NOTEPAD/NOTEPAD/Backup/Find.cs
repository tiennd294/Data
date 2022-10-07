using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NOTEPAD
{
	/// <summary>
	/// Summary description for Find.
	/// </summary>
	public class Find : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		public string Find_String="";
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Find()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 24);
			this.button1.TabIndex = 4;
			this.button1.Text = "FIND WHAT";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Find
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 70);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Find";
			this.Text = "Find";
			this.ResumeLayout(false);

		}
		#endregion
	
		private void button1_Click_1(object sender, System.EventArgs e)
		{
			Find_String=textBox1.Text;			
			this.Dispose();
		}
	}
}
