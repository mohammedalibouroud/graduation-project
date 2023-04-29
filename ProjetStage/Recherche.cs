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
    public partial class Recherche : MetroFramework.Forms.MetroForm
    {
        public Recherche()
        {
            InitializeComponent();
        }

        

        Agent ag=new Agent();
        private void Rrcherche_Load(object sender, EventArgs e)
        {
            //this.dataGridViewRecherche.DataSource = ag.rechercher("chercherAgent");
        }

       

        private void txtcherecheppr_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                    ag.Ppr = int.Parse(this.txtcherecheppr.Text);
                    this.dataGridViewRecherche.DataSource = ag.rechercher("chercherAgent");
            }
            catch 
            {
                ag.Ppr = 0;
               
                this.dataGridViewRecherche.DataSource = ag.rechercher("chercherAgent");
            }
            MyDataBase.deconnexion();
        }


        private void txtcherechenomfr_OnValueChanged(object sender, EventArgs e)
        {
                    try
            {
                ag.Nomfr = this.txtcherechenomfr.Text;
            }
            catch { }
 this.dataGridViewRecherche.DataSource = ag.rechercher("chercherAgent");
            MyDataBase.deconnexion();
        }

        private void txtcherecheprenomfr_OnValueChanged(object sender, EventArgs e)
        {
                    try
            {
                ag.Prenomfr = this.txtcherecheprenomfr.Text;
            }
            catch { }
 this.dataGridViewRecherche.DataSource = ag.rechercher("chercherAgent");
            MyDataBase.deconnexion();
        }

        private void txtcherecheprenomar_OnValueChanged(object sender, EventArgs e)
        {
          
                ag.PrenomAr = this.txtcherecheprenomar.Text;
       

          
 this.dataGridViewRecherche.DataSource = ag.rechercher("chercherAgent");
            MyDataBase.deconnexion();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewRecherche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             DialogResult confirmer = MessageBox.Show("Voulez-vous afficher cette agent ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (confirmer == DialogResult.Yes)
             {
                 int rowindex = dataGridViewRecherche.CurrentRow.Index;
                 Program.ppr = int.Parse(dataGridViewRecherche.Rows[rowindex].Cells[0].Value.ToString());
                 Program.NomComplet = dataGridViewRecherche.Rows[rowindex].Cells[1].Value.ToString() + " " + dataGridViewRecherche.Rows[rowindex].Cells[2].Value.ToString();
                 FormMajPers.maj.afficher(Program.ppr);
                 this.Close();
             }
            
        }

        private void dataGridViewRecherche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcherechenomar_OnValueChanged_1(object sender, EventArgs e)
        {
            ag.NomAr = this.txtcherechenomar.Text;
            this.dataGridViewRecherche.DataSource = ag.rechercher("chercherAgent");
            MyDataBase.deconnexion();
        }

        

        }
        
       
    }
