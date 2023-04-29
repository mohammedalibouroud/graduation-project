using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetStage
{
    public partial class FormMenu : MetroFramework.Forms.MetroForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public static FormMenu menu;
        private void Menu_Load(object sender, EventArgs e)
        {
            menu = this;
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                //this.bunifuImageButton3.BackgroundImage = "";
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized )
            {
                WindowState = FormWindowState.Minimized;
            }
          
        }

        private void majPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMajPers mp = new FormMajPers();
            mp.MdiParent = this;
            mp.Show();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
