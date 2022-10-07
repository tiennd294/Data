using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceProcess;
using System.Drawing;

using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmServices : Form
    {
        public frmServices()
        {
            InitializeComponent();
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            lvData.View = View.Details;
            lvData.Columns.Add("Stt", 30);
            lvData.Columns.Add("Name", 300);
            lvData.Columns.Add("Display Name", 100);
            lvData.Columns.Add("Status", 100);
            ShowService();
        }
        void ShowService()
        {
            lvData.Items.Clear();
            ListViewItem lvi;
            int i = 0;
            myArray cls = new myArray();
            while (i < cls.GetMyServices().Count)
            {
                lvi = new ListViewItem((i + 1).ToString());
                clsItem Item = cls.GetMyServices()[i] as clsItem;
                lvi.SubItems.Add(Item.name );
                lvi.SubItems.Add(Item.displayname);
                lvi.SubItems.Add(Item.status );                
                lvData.Items.Add(lvi);
                i++;
            }
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem liv = lvData.FocusedItem;            
            Call(liv.SubItems[3].Text, liv.SubItems[1].Text);                        
        }
        void Call(string action,string name)
        {
            switch (action)
            {

                case "Stopped":
                    DoAction(1, name); break;
               
                case "Running":
                    DoAction(2, name);
                    break;
                case "Paused":
                    DoAction(4, name);
                    break;
            }
        }
        void DoAction(short action, string name)
        {           
            if (MessageBox.Show("Are you sure to " + name, "C# 2005", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ServiceController sv = new ServiceController(name);
                try
                {
                    switch (action)
                    {
                        case 1:
                            sv.Start(); break;
                        case 2:
                            sv.Stop(); break;
                        case 3:
                            sv.Pause(); break;
                        case 4:
                            sv.Continue(); break;
                    }
                    ShowService();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message );
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem liv = lvData.FocusedItem;    
            Call(liv.SubItems[3].Text, liv.SubItems[1].Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem liv = lvData.FocusedItem;    
            Call(liv.SubItems[3].Text, liv.SubItems[1].Text); 
        }
    }
}