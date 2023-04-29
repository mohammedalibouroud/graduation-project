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
    public partial class Calender_CongeAdm : Form
    {
        public Calender_CongeAdm()
        {
            InitializeComponent();
        }

        Congé_annuelle ca;
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
        }

        private void Calender_CongeAdm_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void Calender_CongeAdm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //int debut = monthCalendar1.SelectionStart.Day;
            //SelectionRange d=monthCalendar1.SelectionRange; //MessageBox.Show(monthCalendar1.MinDate.ToString() + " " + monthCalendar1.MaxDate.ToString());
            //MessageBox.Show(d.ToString());
            try
            {
                Ajouter_un_congé.ac.txtduree.Text = Convert.ToString(Program.duree);
                Ajouter_un_congé.ac.LabelJour.Text = "Jours(s)";

                Ajouter_un_congé.ac.datedepart.Value = Program.depart;
                Ajouter_un_congé.ac.dateretour.Value = Program.fin;

            }
            catch { }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //int debut = monthCalendar1.SelectionStart.Day;
            //int fin = monthCalendar1.SelectionEnd.Day;
            //int calc = fin - debut;

            //this.label1.Text = calc.ToString();
           ca=new Congé_annuelle();
            int nb = 0;
            label1.Text = "";
            DateTime debut = monthCalendar1.SelectionStart;
            DateTime fin = monthCalendar1.SelectionEnd;
            DateTime retour = monthCalendar1.SelectionEnd.AddDays(1);
            DateTime verifier = debut;
            int a;
            a = int.Parse((fin - debut).Days.ToString()) + 1;

            for (int i = 0; i < a; i++)
            {
                if (!ca.Date("Jour_Firier", verifier) && verifier.DayOfWeek != DayOfWeek.Saturday && verifier.DayOfWeek != DayOfWeek.Sunday)
                {
nb++;
                }
                verifier = verifier.AddDays(1);                
            }
            label1.Text = "Entre " + debut.ToString().Replace("00:00:00", "") + " et " + fin.ToString().Replace("23:59:59", "") + " il y'a " + nb.ToString() + " jours";
            Program.duree = nb;
            Program.depart = debut;
            Program.fin = retour;
        }

      

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
 this.Close();
        }

        private void Calender_CongeAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try{
             Modifier_un_conge.mc.txtduree.Text = Convert.ToString(Program.duree);
                Modifier_un_conge.mc.datedepart.Value = Program.depart;
                Modifier_un_conge.mc.dateretour.Value = Program.fin;
            }
            catch{}
        }

  
    }
}
