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
    public partial class Modifier_un_conge : MetroFramework.Forms.MetroForm
    {
        public Modifier_un_conge()
        {
            InitializeComponent();
        }
        Cumul_conge cumul;
       public static Modifier_un_conge mc;
        private void Modifier_un_conge_Load(object sender, EventArgs e)
        {
            int row = Mise_a_jour_conge.majc.dataGridView1.CurrentRow.Index;
            mc = this;
            Program.duree = Convert.ToInt32(Mise_a_jour_conge.majc.dataGridView1.Rows[row].Cells[2].Value);
            Program.depart = Convert.ToDateTime(Mise_a_jour_conge.majc.dataGridView1.Rows[row].Cells[1].Value);
            Program.fin = Convert.ToDateTime(Mise_a_jour_conge.majc.dataGridView1.Rows[row].Cells[3].Value);
            this.txtduree.Text = Program.duree.ToString();
            this.datedepart.Value = Program.depart;
            this.dateretour.Value = Program.fin;
            this.txtDisponibilite.Text = Mise_a_jour_conge.majc.dataGridView1.Rows[row].Cells[4].Value.ToString();
            this.txtobservation.Text = Mise_a_jour_conge.majc.dataGridView1.Rows[row].Cells[5].Value.ToString();
            if (Mise_a_jour_conge.majc.dataGridView1.Rows[row].Cells[11].Value.Equals(true))
            {
                this.radioButtonOui.Checked = true;
            }
            else
            {
                this.radioButtonNon.Checked = true;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            int rowindex = Mise_a_jour_conge.majc.dataGridView1.CurrentRow.Index;

            cumul = new Cumul_conge();

            cumul.Date_depart = this.datedepart.Value;
            cumul.Duree = Convert.ToInt32(this.txtduree.Text);
            cumul.Date_retour = this.dateretour.Value;
            cumul.Disponibilite = this.txtDisponibilite.Text;
            cumul.Observation = this.txtobservation.Text;
            cumul.Conge = Convert.ToInt32(Mise_a_jour_conge.majc.dataGridView1.Rows[rowindex].Cells[0].Value);
            if (this.radioButtonOui.Checked)
            {
                cumul.CongeEtranger = true;
            }
            else if (this.radioButtonNon.Checked)
            {
                cumul.CongeEtranger = false;
            }
            cumul.MAJ("Modifier_cumul");
            FormMajPers.maj.afficher(Program.ppr);
            //Program.conge = cumul.Conge;
            Mise_a_jour_conge.majc.afficher();
           
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calender_CongeAdm calender = new Calender_CongeAdm();
            calender.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
