using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student_detail
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string result = "";
            string newline = Environment.NewLine;
            result += "Id:" + txtId.Text + newline;
            result += "Name:" + txtName.Text + newline;
            result += "Birthday:" + txtBirthday.Text + newline;
            result += "Country:" + cboCountry.SelectedItem.ToString() + newline;
            result += "Email:" + txtEmail.Text + newline;
            result += "Hobies:" + newline;
            for (int i = 0; i < lstHobies.SelectedItems.Count; i++)
                result += lstHobies.SelectedItems[i].ToString() + newline;
            MessageBox.Show(result, "Student Detail");



        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtId.Text = txtName.Text = txtEmail.Text = txtBirthday.Text = "";
            lstHobies.ClearSelected();
            txtId.Focus();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lstHobies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            //add countries to combobox
            cboCountry.Items.Add("VietNam");
            cboCountry.Items.Add("England");
            cboCountry.Items.Add("Thailand");
            cboCountry.Items.Add("France");
            cboCountry.Items.Add("Canada");

            //add hobies to listbox
            lstHobies.Items.Add("Game");
            lstHobies.Items.Add("Sport");
            lstHobies.Items.Add("Shopping");
            lstHobies.Items.Add("Reading");
            lstHobies.Items.Add("Watching TV");
        }
    }
}
