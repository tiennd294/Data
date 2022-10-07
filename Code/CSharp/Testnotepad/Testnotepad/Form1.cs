using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;



namespace Testnotepad
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MainMenu mainmenu = new MainMenu();
            MenuItem filemenu = new MenuItem();
            filemenu.Text = "&File";
            MenuItem editmenu = new MenuItem();
            editmenu.Text = "&Edit";
            MenuItem formatmenu = new MenuItem();
            formatmenu.Text = "F&ormat";
            MenuItem helpmenu = new MenuItem();
            helpmenu.Text = "&Help";
            mainmenu.MenuItems.Add(filemenu);
            mainmenu.MenuItems.Add(editmenu);
            mainmenu.MenuItems.Add(formatmenu);
            mainmenu.MenuItems.Add(helpmenu);
            MenuItem openmenu = new MenuItem();
            openmenu.Text = "&Open";
            openmenu.Click += new EventHandler(Openmenuclick);
            openmenu.Shortcut = Shortcut.CtrlO;
            MenuItem savemenu = new MenuItem();
            savemenu.Text = "&Save";
            savemenu.Click += new EventHandler(Savemenuclick);
            savemenu.Shortcut = Shortcut.CtrlS;
            MenuItem exitmenu = new MenuItem();
            MenuItem saveasmenu = new MenuItem();
            saveasmenu.Text = "Save &As";
            saveasmenu.Click += new EventHandler(Saveasmenuclick);
            exitmenu.Text = "E&xit";
            exitmenu.Click += new EventHandler(Exitmenuclick);
            MenuItem fontmenu = new MenuItem();
            fontmenu.Text = "&Font";
            fontmenu.Click += new EventHandler(Fontmenuclick);
            formatmenu.MenuItems.Add(fontmenu);
            MenuItem colormenu = new MenuItem();
            colormenu.Text = "Color";
            colormenu.Click += new EventHandler(Colormenuclick);
            formatmenu.MenuItems.Add(colormenu);
            filemenu.MenuItems.Add(openmenu);
            filemenu.MenuItems.Add(savemenu);
            filemenu.MenuItems.Add(saveasmenu);
            filemenu.MenuItems.Add(exitmenu);
            this.Menu = mainmenu;

        }
        void Openmenuclick(Object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "TXT file(*.txt)|*.txt|HTML file(*.html)|*.html|XML file(*.xml)|*.xml|C Sharp file(*.cs)|*.cs";
            open.ShowDialog();
            if (open.FileName != "")
            {
                FileInfo f = new FileInfo(open.FileName);
                StreamReader reader = f.OpenText();
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
        void Savemenuclick(Object sender, EventArgs e)
        {
        }
        void Saveasmenuclick(Object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT file(*.txt)|*.txt|HTML file(*.html)|*.html|XML file(*.xml)|*.xml|C Sharp file(*.cs)|*.cs";
            save.ShowDialog();
            if (save.FileName != "")
            {
                FileInfo f = new FileInfo(save.FileName);
                StreamWriter writer = f.CreateText();
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }
        void Exitmenuclick(Object sender, EventArgs e)
        {
            Application.Exit();
        }
        void Fontmenuclick(Object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            richTextBox1.Font = font.Font;
        }
        void Colormenuclick(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            richTextBox1.ForeColor = color.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
