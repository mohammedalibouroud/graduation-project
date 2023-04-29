using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrejetStage_Library;
using System.Data.SqlClient;

namespace ProjetStage.Congé
{
    public partial class Ajouter_Congé : MetroFramework.Forms.MetroForm
    {
        public Ajouter_Congé()
        {
            InitializeComponent();
        }
        Congé_annuelle ca;
        private void button1_Click(object sender, EventArgs e)
        {
            bool trouve = false;
           for(int i=0;i<FormMajPers.maj.dataGridViewCongeAnuelle.Rows.Count;i++)
           {
               if (this.txtAnnee.Value == Convert.ToInt32(FormMajPers.maj.dataGridViewCongeAnuelle.Rows[i].Cells[1].Value))
                   trouve = true;
          
                
               }
           if (trouve)
               MessageBox.Show("Cette année déja ajouter à la liste de congé", "Pour votre information", MessageBoxButtons.OK, MessageBoxIcon.Error);
           else
           {
               ca = new Congé_annuelle(Convert.ToInt32(this.txtAnnee.Value), Convert.ToInt32(this.txtNbrjour.Text), Convert.ToInt32(this.txtPPR.Text), "Normale");
               ca.MAJ("AjouterConge");
               FormMajPers.maj.afficher(Program.ppr);
               this.Close();
           }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calender_CongeAdm f = new Calender_CongeAdm();
            //f.Show();
            this.Close();
        }

        private void Ajouter_Congé_Load(object sender, EventArgs e)
        {
            this.txtPPR.Text = Convert.ToString(Program.ppr);
            this.txtNom.Text = Program.NomComplet;
        }
    }
}
