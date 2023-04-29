using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrejetStage_Library;


namespace ProjetStage
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            if(this.textLogin.Text=="Login")
            {
                this.textLogin.Text = "";
                this.textLogin.ForeColor = Color.Black;
            }
        }

        private void textLogin_Leave(object sender, EventArgs e)
        {
            if (this.textLogin.Text == "")
            {
                this.textLogin.Text = "Login";
                this.textLogin.ForeColor = Color.Silver;
            }
        }

        private void textMps_Enter(object sender, EventArgs e)
        {
            if (this.textMps.Text == "MotDePasse")
            {
                this.textMps.Text = "";
                this.textMps.ForeColor = Color.Black;
            }
        }

        private void textMps_Leave(object sender, EventArgs e)
        {
            if (this.textMps.Text == "")
            {
                this.textMps.Text = "MotDePasse";
                this.textMps.ForeColor = Color.Silver;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textLogin.Text))
            {
                this.textLogin.BorderColorFocused = Color.Red;
                MessageBox.Show("le champ Login est obligatoire");
            }
            else if (String.IsNullOrEmpty(this.textMps.Text))
            {
                this.textMps.BorderColorFocused = Color.Red;
                MessageBox.Show("le champ Mot de passe est obligatoire");
            }
            else
            {
                if (MyDataBase.Log_In("log_in", this.textLogin.Text, this.textMps.Text))
                {
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorect", "pour votre information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void affichermotdepasse_CheckedChanged(object sender, EventArgs e)
        {
            if (affichermotdepasse.Checked)
            {
                this.textMps.isPassword = false;
            }
            else
            {
                this.textMps.isPassword = true;
            }
        }

        private void bunifuThinButton21_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
