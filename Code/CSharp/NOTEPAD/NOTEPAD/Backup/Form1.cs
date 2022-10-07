using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace NOTEPAD
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.StatusBar statusBar1;
		public string Find_Str="";
		
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem29 = new System.Windows.Forms.MenuItem();
			this.menuItem30 = new System.Windows.Forms.MenuItem();
			this.menuItem31 = new System.Windows.Forms.MenuItem();
			this.menuItem32 = new System.Windows.Forms.MenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem11,
																					  this.menuItem26,
																					  this.menuItem29,
																					  this.menuItem31});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "New";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Open";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "Save";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "Save As";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "Print";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 6;
			this.menuItem8.Text = "PageSetUp";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 7;
			this.menuItem9.Text = "-";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 8;
			this.menuItem10.Text = "Exit";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 1;
			this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem12,
																					   this.menuItem13,
																					   this.menuItem14,
																					   this.menuItem15,
																					   this.menuItem16,
																					   this.menuItem17,
																					   this.menuItem18,
																					   this.menuItem19,
																					   this.menuItem23,
																					   this.menuItem24,
																					   this.menuItem25});
			this.menuItem11.Text = "Edit";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 0;
			this.menuItem12.Text = "Undo";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 1;
			this.menuItem13.Text = "-";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 2;
			this.menuItem14.Text = "Cut";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 3;
			this.menuItem15.Text = "Copy";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 4;
			this.menuItem16.Text = "Paste";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 5;
			this.menuItem17.Text = "Delete";
			this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 6;
			this.menuItem18.Text = "-";
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 7;
			this.menuItem19.Text = "Find";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 8;
			this.menuItem23.Text = "-";
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 9;
			this.menuItem24.Text = "SelectAll";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 10;
			this.menuItem25.Text = "Time/Date";
			this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 2;
			this.menuItem26.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem27,
																					   this.menuItem28});
			this.menuItem26.Text = "Format";
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 0;
			this.menuItem27.Text = "WordWrap";
			this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 1;
			this.menuItem28.Text = "Font";
			this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
			// 
			// menuItem29
			// 
			this.menuItem29.Index = 3;
			this.menuItem29.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem30});
			this.menuItem29.Text = "View";
			// 
			// menuItem30
			// 
			this.menuItem30.Index = 0;
			this.menuItem30.Text = "StatusBar";
			this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
			// 
			// menuItem31
			// 
			this.menuItem31.Index = 4;
			this.menuItem31.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem32});
			this.menuItem31.Text = "Help";
			// 
			// menuItem32
			// 
			this.menuItem32.Index = 0;
			this.menuItem32.Text = "AboutMe";
			this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(1024, 672);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 641);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(1028, 16);
			this.statusBar1.TabIndex = 1;
			this.statusBar1.Text = "statusBar1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 657);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.richTextBox1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "My Editor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			richTextBox1.Text="";
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Undo(); 
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Cut();
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
		this.richTextBox1.Copy();
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Paste();
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.SelectedText="";
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			
			Find f=new Find ();
			f.ShowDialog();
			Find_Str=f.Find_String;
			this.richTextBox1.Find(Find_Str);
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
		this.richTextBox1.SelectAll();
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Text=DateTime.Now.ToString();
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{
			if (menuItem27.Checked=!menuItem27.Checked)
			{
				this.richTextBox1.WordWrap =true;
			}
			else
			{
				this.richTextBox1.WordWrap =false;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.richTextBox1.WordWrap =false;
			this.statusBar1.Visible =false;
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			if (menuItem30.Checked=!menuItem30.Checked)
			{
					this.statusBar1.Visible =true;			
				this.statusBar1.Text =DateTime.Now.ToString();		
			}
			
			else
			{
				this.statusBar1.Visible =false;			
					
			}
			
		}

		

		private void menuItem32_Click(object sender, System.EventArgs e)
		{
			Form1.ActiveForm.Text="Developed By Niladri Biswas";
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			
			try
			{
			openFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*" ;
			openFileDialog1.FilterIndex = 2 ;	
			openFileDialog1.ShowDialog();
			string fileName = openFileDialog1.FileName;//gives the file name with the location
			StreamReader stReader = new StreamReader(fileName);
			richTextBox1.Text = stReader.ReadToEnd();				
			stReader.Close();
			}
			catch{}			
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
		string fileName="";
		if ( fileName == "")
		{
			saveFileDialog1.Filter = "TEXT Documents. (*.txt)|*.txt|All files|*.*";
			DialogResult resVal = saveFileDialog1.ShowDialog();
			if ( resVal == DialogResult.Cancel )
			{
				return;
			}
			fileName = saveFileDialog1.FileName;				
			}
			try
			{		StreamWriter stWriter = new StreamWriter(fileName);
					stWriter.WriteLine(richTextBox1.Text);				
					stWriter.Close();		
			}
			catch
			{
				MessageBox.Show(this, "The file "+fileName+" is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			string fileName="";
			if ( fileName == "")
			{
				saveFileDialog1.Filter = "TEXT Documents. (*.txt)|*.txt|All files|*.*";
				DialogResult resVal = saveFileDialog1.ShowDialog();
				if ( resVal == DialogResult.Cancel )
				{
					return;
				}
				fileName = saveFileDialog1.FileName;				
			}
			try
			{
				StreamWriter stWriter = new StreamWriter(fileName);
				stWriter.WriteLine(richTextBox1.Text);				
				stWriter.Close();				
			}
			catch
			{
				MessageBox.Show(this, "The file "+fileName+" is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			printDocument1.DocumentName = richTextBox1.Text;
			printDialog1.Document = printDocument1;
			printDialog1.ShowDialog();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			printDocument1.DocumentName = richTextBox1.Text;
			pageSetupDialog1.Document = printDocument1;
			pageSetupDialog1.ShowDialog();
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			fontDialog1.ShowColor = true;
			fontDialog1.ShowDialog();
			richTextBox1.Font = fontDialog1.Font;
			richTextBox1.ForeColor = fontDialog1.Color;
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
		
		}
		}
	}

