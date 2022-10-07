using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using  HAPI;
namespace CS
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label GuiltyProb;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.RadioButton DNAStateNo;
		internal System.Windows.Forms.RadioButton DNAStateYes;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		Domain d ;
		Globals glob = new Globals();
		private int MurderYes = 0;
		private int MurderNo = 1;
		private int  DNAMatch = 0;
		private int  DNANoMatch = 1;
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
			this.Label2 = new System.Windows.Forms.Label();
			this.GuiltyProb = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.DNAStateNo = new System.Windows.Forms.RadioButton();
			this.DNAStateYes = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(8, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(208, 23);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "DNA-match:";
			// 
			// GuiltyProb
			// 
			this.GuiltyProb.Location = new System.Drawing.Point(104, 72);
			this.GuiltyProb.Name = "GuiltyProb";
			this.GuiltyProb.Size = new System.Drawing.Size(152, 23);
			this.GuiltyProb.TabIndex = 8;
			this.GuiltyProb.Text = "0.00000000%";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(104, 48);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(160, 23);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Probability for guilty:";
			// 
			// DNAStateNo
			// 
			this.DNAStateNo.Location = new System.Drawing.Point(8, 72);
			this.DNAStateNo.Name = "DNAStateNo";
			this.DNAStateNo.Size = new System.Drawing.Size(64, 16);
			this.DNAStateNo.TabIndex = 6;
			this.DNAStateNo.Text = "No";
			this.DNAStateNo.CheckedChanged += new System.EventHandler(this.DNAStateNo_CheckedChanged);
			// 
			// DNAStateYes
			// 
			this.DNAStateYes.Location = new System.Drawing.Point(8, 48);
			this.DNAStateYes.Name = "DNAStateYes";
			this.DNAStateYes.Size = new System.Drawing.Size(64, 16);
			this.DNAStateYes.TabIndex = 5;
			this.DNAStateYes.Text = "Yes";
			this.DNAStateYes.CheckedChanged += new System.EventHandler(this.DNAStateYes_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 109);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.GuiltyProb);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.DNAStateNo);
			this.Controls.Add(this.DNAStateYes);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.Form1_Closed);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// A collection to hold the found parseErrors
			HuginCollection hc = new HuginCollection();
			VBA.Collection  parseErrors ;
			parseErrors = hc.ToCollection();
	        //Load the domain from the murder.net file and compile it.
			d = glob.LoadDomainFromNet("C:\\murder.net", ref parseErrors, 10);
			d.Compile();

			// Initially the DNANoMatch state is selected - display the probability 
			DNAState_Click(DNANoMatch);        
		}
		void DNAState_Click(int index)
		{
			Node n ;
			//Fetch the node with label "DNA-match?" and name "DNA" from the domain
			n = d.GetNodeByName("DNA");
			// Instantiate the Node with state "index" as evidence and sum propagate it
			n.SelectState(index);
			d.Propagate(hEquilibriums.hEquilibriumSum, hEvidenceModes.hModeNormal);
			// Fetch the "Murderer?" node and display the probability for MurderYes
			n = d.GetNodeByName("M");
			
			GuiltyProb.Text = Convert.ToString(n.get_Belief(MurderYes)*100) + "%";
			// Format(n.Belief(MurderYes) * 100, "##0.00000000") & "%";
		}
		private void Form1_Closed(object sender, System.EventArgs e)
		{
			d.Delete();
		}

		private void DNAStateYes_CheckedChanged(object sender, System.EventArgs e)
		{
			if(DNAStateYes.Checked)
				DNAState_Click(0);
		}

		private void DNAStateNo_CheckedChanged(object sender, System.EventArgs e)
		{
			if(DNAStateNo.Checked)
				DNAState_Click(1);
		}
	}
}
