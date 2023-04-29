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
    public partial class Modifier_Conge : MetroFramework.Forms.MetroForm
    {
        public Modifier_Conge()
        {
            InitializeComponent();
        }

        Congé_annuelle ca;

        private void Modifier_Conge_Load(object sender, EventArgs e)
        {
            int row = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;
            this.txtPPR.Text = Program.ppr.ToString();
            this.txtNom.Text = Program.NomComplet;
            this.txtNbrjour.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[2].Value.ToString();
            if (FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[4].Value.ToString() != "Normale")
            {
                this.panelReporterConge.Enabled = true;
                this.radioButtonOui.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int rowindex = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;

           
            
             DialogResult confirmer = MessageBox.Show("Voulez-vous vraiment Modifier ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (confirmer == DialogResult.Yes)
             {
                 if (radioButtonNon.Checked)
                 {
                     ca = new Congé_annuelle(Convert.ToInt32(this.txtAnnee.Value.ToString()), Convert.ToInt32(this.txtNbrjour.Text), Convert.ToInt32(this.txtPPR.Text), "Normale");
                 }
                 else if (radioButtonOui.Checked)
                 {
                     ca = new Congé_annuelle(Convert.ToInt32(this.txtAnnee.Value.ToString()), Convert.ToInt32(this.txtNbrjour.Text), Convert.ToInt32(this.txtPPR.Text), FormMajPers.maj.dataGridViewCongeAnuelle.Rows[rowindex].Cells[2].Value.ToString() + " jour reporter à " +(this.txtAnnee.Value+1));
                 }
                 ca.MAJ("modifier_conger", "M", Convert.ToInt32(FormMajPers.maj.dataGridViewCongeAnuelle.Rows[rowindex].Cells[0].Value));
                 MessageBox.Show("Modification Réussi", "Pour votre information", MessageBoxButtons.OK, MessageBoxIcon.None);
                 FormMajPers.maj.afficher(Program.ppr);


             }
           
        }
    }
}
