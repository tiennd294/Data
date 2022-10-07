using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thu2222
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
             Form1 a = new Form1();
            //a.MdiParent = this;
            //a.Show();
                    //if (!checkedListBox1.GetItemChecked(1))
                    //  MessageBox.Show("check");
             //lấy ra chỉ số index mà Item bạn đang chọn
             //int myindex = listView2.FocusedItem.Index;
             //Remove Items ma ban dang chon khi nhan vao Button nay
             listView2.FocusedItem.Remove();
                    //string asd=textBox1.Text;
                    //string dsa = textBox2.Text;
                    //ListViewItem qwe = new ListViewItem(new string[] { asd, dsa });
                    //listView2.Items.Add(qwe);
             

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex.ToString())
            {
                case "0":
                    pictureBox1.Image = imageList1.Images[0];
                    break;
                case "1":
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case "2":
                    pictureBox1.Image = imageList1.Images[2];
                    break;
                case "3":
                    pictureBox1.Image = imageList1.Images[3];
                    break;
                case "4":
                    pictureBox1.Image = imageList1.Images[4];
                    break;
                case "5":
                    pictureBox1.Image = imageList1.Images[5];
                    break;
                default:
                    break;

            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex.ToString())
            {
                case "0":
                    MessageBox.Show("1111111111");
                    break;
                case "1":
                    MessageBox.Show("2222222222");
                    break;
                case "2":
                    MessageBox.Show("3333333333");
                    break;
                case "3":
                    MessageBox.Show("4444444444");
                    break;
                case "4":
                    MessageBox.Show("5555555555");
                    break;
                case "5":
                    MessageBox.Show("66666666666");
                    break;
                default:
                    break;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            checkedListBox1.Items.Add("Sunday", CheckState.Checked);
            checkedListBox1.Items.Add("Monday", CheckState.Unchecked);
            checkedListBox1.Items.Add("Tuesday", CheckState.Indeterminate);
            checkedListBox1.Items.Add("Wednesday", CheckState.Checked);
            checkedListBox1.Items.Add("Thursday", CheckState.Unchecked);
            checkedListBox1.Items.Add("Friday", CheckState.Indeterminate);
            checkedListBox1.Items.Add("Saturday", CheckState.Indeterminate);
            //listView2.CheckBoxes = true;
            
            listBox1.Items.Add("kkkkkkkk");

        }

        private void listView2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listView2.Items.ToString());
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //myListView.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //loi for (int i = listView2.SelectedIndices.Count; i >= 0;i-- )
            //loi listView2.Items.RemoveAt(listView2.SelectedIndices[i]);
            listView2.Clear();
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity=(float.Parse(trackBar1.Value.ToString()))/100;
        }

        
    }
}
