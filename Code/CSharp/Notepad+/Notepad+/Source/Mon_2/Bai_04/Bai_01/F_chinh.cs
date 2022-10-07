using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Mon_2.Bai_04.Bai_01
{
    public partial class F_chinh : Form
    {
        public F_chinh()
        {
            InitializeComponent();
        }
        int stt=0;
        void taomoi()
        {
            F_con fc = new F_con();
            fc.MdiParent = this;
            fc.Text = "Document " + (stt++).ToString();
            closeToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            tsmauto.Enabled = true;
            toolStripSave.Enabled = true;
            fc.Show();
        }
        void newopen(string s)
        {
            F_con fc = new F_con();
            fc.MdiParent = this;
            fc.Text = s;
            closeToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            toolStripSave.Enabled = true;
            fc.Show();
        }
        void openfile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (.txt)|*.txt|Ms Word Files (.doc)|*.doc|Rich Text Files (.rtf)|*.rtf|All Files (*.*)|*.*";
            open.Multiselect = true;
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                newopen(open.FileName);
                ((F_con)this.ActiveMdiChild).txtnoidung.LoadFile(open.FileName);
            }
        }
        void savefile_new()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text Files (.txt)|*.txt|Ms Word Files (.doc)|*.doc|Rich Text Files (.rtf)|*.rtf|All Files (*.*)|*.*";
            savefile.FilterIndex = 2;
            savefile.RestoreDirectory = true;

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                ((F_con)this.ActiveMdiChild).txtnoidung.SaveFile(savefile.FileName);
                ((F_con)this.ActiveMdiChild).Text = savefile.FileName;
            }
        }
        void SaveFileTong()
        {
            string s = this.ActiveMdiChild.Text;
            if (s.Substring(0, 8).Equals("Document"))
            {
                savefile_new();
            }
            else
            {
                ((F_con)this.ActiveMdiChild).txtnoidung.SaveFile(s);
            }
        }
        void taofont()
        {
            InstalledFontCollection thf = new InstalledFontCollection();
            foreach (FontFamily ff in thf.Families)
            {
                cbbfont.Items.Add(ff.Name);
            }
        }
        void taosize()
        {
            for (int i = 5; i <= 100; i++)
            {
                cbbsize.Items.Add(i);
            }
        }
        private FontStyle LayFontStyle()
        {
            FontStyle fontstate = FontStyle.Regular;
            if (bold.Checked == true)
            {
                fontstate = fontstate | FontStyle.Bold;//chon chu in dam nay
            }
            if (italic.Checked)
            {
                fontstate = fontstate | FontStyle.Italic;// chon chu in ngjeng nay
            }
            if (underline.Checked == true)
            {
                fontstate = fontstate | FontStyle.Underline;// chu gach chan nua. a oi??
            }
            return fontstate;
        }
        void thucthi()
        {
            FontFamily f = new FontFamily(cbbfont.Text);
            float size = float.Parse(cbbsize.Text);
            ((F_con)this.ActiveMdiChild).txtnoidung.SelectionFont = new Font(f, size, LayFontStyle());
        }
        void kt_layout()
        {
            if (cascadeToolStripMenuItem.Checked)
            {
                this.LayoutMdi(MdiLayout.Cascade);
                tileHorizostalhToolStripMenuItem.Checked = false;
                tileVertircalToolStripMenuItem.Checked = false;
            }
            else if (tileVertircalToolStripMenuItem.Checked)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
                tileHorizostalhToolStripMenuItem.Checked = false;
                cascadeToolStripMenuItem.Checked = false;
            }
            else if (tileHorizostalhToolStripMenuItem.Checked)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
                tileVertircalToolStripMenuItem.Checked = false;
                cascadeToolStripMenuItem.Checked = false;
            }
        }
        void tomau()
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = ((F_con)this.ActiveMdiChild).txtnoidung.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                ((F_con)this.ActiveMdiChild).txtnoidung.SelectionColor = MyDialog.Color;

        }
        void align()
        {
            if (canhgiua.Checked)
            {
                ((F_con)this.ActiveMdiChild).txtnoidung.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (canhphai.Checked)
            {
                ((F_con)this.ActiveMdiChild).txtnoidung.SelectionAlignment = HorizontalAlignment.Right;
            }
            else ((F_con)this.ActiveMdiChild).txtnoidung.SelectionAlignment = HorizontalAlignment.Left;

        }
        void chen_hinh()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "jpeg (.jpg)|*.jpg|bmp (.bmp)|*.bmp|gif (.gif)|*.gif|All Files (*.*)|*.*";
            open.Multiselect = true;
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
               //((F_con)this.ActiveMdiChild).txtnoidung
            }
        }
        private void F_chinh_Load(object sender, EventArgs e)
        {
            taofont();
            taosize();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            taomoi();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taomoi();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length>0)
                this.ActiveMdiChild.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileTong();
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            SaveFileTong();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile_new();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            tileHorizostalhToolStripMenuItem.Checked = false;
            tileVertircalToolStripMenuItem.Checked = false;
        }

        private void tileHorizostalhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            tileHorizostalhToolStripMenuItem.Checked = false;
            cascadeToolStripMenuItem.Checked = false;
        }

        private void tileVertircalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            tileVertircalToolStripMenuItem.Checked = false;
            cascadeToolStripMenuItem.Checked = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbfont_SelectedIndexChanged(object sender, EventArgs e)
        {
            thucthi();
        }

        private void cbbsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            thucthi();
        }

        private void bold_Click(object sender, EventArgs e)
        {
            thucthi();
        }

        private void underline_Click(object sender, EventArgs e)
        {
            thucthi();
        }

        private void italic_Click(object sender, EventArgs e)
        {
            thucthi();
        }

        private void canhtrai_Click(object sender, EventArgs e)
        {
            canhphai.Checked = false;
            canhgiua.Checked = false;
            align();
        }

        private void canhgiua_Click(object sender, EventArgs e)
        {
            canhphai.Checked = false;
            canhtrai.Checked = false;
            align();
        }

        private void canhphai_Click(object sender, EventArgs e)
        {
            canhgiua.Checked = false;
            canhtrai.Checked = false;
            align();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tomau();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tsbchenhinh_Click(object sender, EventArgs e)
        {
            chen_hinh();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbbsize_Click(object sender, EventArgs e)
        {

        }

     
    }
}
