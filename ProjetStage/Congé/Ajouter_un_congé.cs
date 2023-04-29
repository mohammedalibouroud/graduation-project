using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrejetStage_Library;

namespace ProjetStage.Congé
{
    public partial class Ajouter_un_congé : MetroFramework.Forms.MetroForm
    {
        public Ajouter_un_congé()
        {
            InitializeComponent();
        }
        Cumul_conge cumul;
        public static Ajouter_un_congé ac;
        
        private void Ajouter_un_congé_Load(object sender, EventArgs e)
        {
            ac = this;
            this.txtDisponibilite.Text = FormMajPers.maj.txtAdresseFr.Text;
        }

    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int rowindex = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;

            cumul = new Cumul_conge();
            
            cumul.Date_depart = this.datedepart.Value;
            cumul.Duree = Convert.ToInt32(this.txtduree.Text);
            cumul.Date_retour = this.dateretour.Value;
            cumul.Disponibilite = this.txtDisponibilite.Text;
            cumul.Observation = this.txtobservation.Text;
            cumul.Conge = Convert.ToInt32(FormMajPers.maj.dataGridViewCongeAnuelle.Rows[rowindex].Cells[0].Value);
            if (this.radioButtonOui.Checked)
            {
                cumul.CongeEtranger = true;
            }
            else if (this.radioButtonNon.Checked)
            {
                cumul.CongeEtranger = false;
            }
            cumul.MAJ("ajouter_cumuls");
            FormMajPers.maj.afficher(Program.ppr);
            //Program.conge = cumul.Conge;

            Mise_a_jour_conge.majc.afficher();

        }

       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Calender_CongeAdm calender = new Calender_CongeAdm();
            //calender.MdiParent = FormMenu.menu;
            calender.ShowDialog();
        }

       
    }
}
