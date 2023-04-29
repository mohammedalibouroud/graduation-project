using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrejetStage_Library;
using Word = Microsoft.Office.Interop.Word;


namespace ProjetStage.Congé
{
    public partial class Mise_a_jour_conge : MetroFramework.Forms.MetroForm

    {
        public Mise_a_jour_conge()
        {
            InitializeComponent();
        }
        Cumul_conge c;

       public static Mise_a_jour_conge majc;

        public void afficher()
        {
            int rowindex = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;
            c = new Cumul_conge();
              c.Conge=Convert.ToInt32(FormMajPers.maj.dataGridViewCongeAnuelle.Rows[rowindex].Cells[0].Value);
           cUMULCONGEDataTableBindingSource.DataSource=c.cumul("liste_cumul");
        }
        private void Mise_a_jour_conge_Load(object sender, EventArgs e)
        {
            int row = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;
            if (Convert.ToInt32(FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[2].Value)== 0)
            {
               
                this.button1.Enabled = false;
            }
           majc=this;
            afficher();
            //c.Conge=Program.conge;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Congé.Ajouter_un_congé ac = new Congé.Ajouter_un_congé();
            ac.MdiParent = FormMenu.menu;
            ac.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex=this.dataGridView1.CurrentRow.Index;
            if (e.ColumnIndex == 12)
            {
                Modifier_un_conge mc = new Modifier_un_conge();
                mc.MdiParent = FormMenu.menu;
                mc.Show();
            }
            if (e.ColumnIndex == 13)
            {
               
                c.Id_cumul = Convert.ToInt32(this.dataGridView1.Rows[rowindex].Cells[0].Value);
                c.MAJ("delete_cumul");
                FormMajPers.maj.afficher(Program.ppr);
                Mise_a_jour_conge.majc.afficher();
            }
            if (e.ColumnIndex == 14)
            {

                Word.Application app = new Word.Application();
                
                if(FormMajPers.maj.comboBoxEntite.Text=="CHP Med V")
                {
                Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(Application.StartupPath + @"\Word\DecisionConge.docx");
                string bookmark = "AFFECTATION";
                string bookmark1 = "AnneeConge";
                string bookmark2 = "AnneeConge_";
                string bookmark3 = "CIN";
                string bookmark4 = "CiviliteNomPrenom";
                string bookmark5 = "CiviliteNomPrenom_";
                string bookmark6 = "DateDepart";
                string bookmark7 = "DUREE";
                string bookmark8 = "ETRANGER";
                string bookmark9 = "GRADE";
                string bookmark10 = "PPR";
                //string bookmark11 = "PROVINCE";

                Word.Bookmark bm = doc.Bookmarks[bookmark];
                Word.Range range = bm.Range;
               Word.Bookmark bm1 = doc.Bookmarks[bookmark1];
               Word.Range range1 = bm1.Range;
                Word.Bookmark bm2 = doc.Bookmarks[bookmark2];
                Word.Range range2 = bm2.Range;
                Word.Bookmark bm3 = doc.Bookmarks[bookmark3];
                Word.Range range3 = bm3.Range;
                Word.Bookmark bm4 = doc.Bookmarks[bookmark4];
                Word.Range range4 = bm4.Range;
                Word.Bookmark bm5 = doc.Bookmarks[bookmark5];
                Word.Range range5 = bm5.Range;
                Word.Bookmark bm6 = doc.Bookmarks[bookmark6];
               Word.Range range6 = bm6.Range;
               Word.Bookmark bm7 = doc.Bookmarks[bookmark7];
                Word.Range range7 = bm7.Range;
               Word.Bookmark bm8 = doc.Bookmarks[bookmark8];
                Word.Range range8 = bm8.Range;
               Word.Bookmark bm9 = doc.Bookmarks[bookmark9];
                Word.Range range9 = bm9.Range;
                Word.Bookmark bm10 = doc.Bookmarks[bookmark10];
                Word.Range range10 = bm10.Range;
                //Microsoft.Office.Interop.Word.Bookmark bm11 = doc.Bookmarks[bookmark11];
                //Microsoft.Office.Interop.Word.Range range11 = bm11.Range;

                int row = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;

                range.Text = FormMajPers.maj.comboBoxAffectation.Text;
                doc.Bookmarks.Add(bookmark, range);

                range1.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[1].Value.ToString();
                doc.Bookmarks.Add(bookmark1, range1);

                range2.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[1].Value.ToString();
                doc.Bookmarks.Add(bookmark2, range2);

                range3.Text = FormMajPers.maj.txtCin.Text;
                doc.Bookmarks.Add(bookmark3, range3);

                if (FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMlle.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMme.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMme.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                doc.Bookmarks.Add(bookmark4, range4);

                if (FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMlle.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMme.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMme.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                doc.Bookmarks.Add(bookmark5, range5);
                DateTime datepart=Convert.ToDateTime(this.dataGridView1.Rows[rowindex].Cells[1].Value);
                range6.Text = datepart.ToString("d");
                doc.Bookmarks.Add(bookmark6, range6);

                range7.Text = this.dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                doc.Bookmarks.Add(bookmark7, range7);

                if (this.dataGridView1.Rows[rowindex].Cells[11].Value.Equals(true))
                {
                    range8.Text = "à l'étranger";
                }
                else
                {
                    range8.Text = "";
                }
                doc.Bookmarks.Add(bookmark8, range8);

                range9.Text = FormMajPers.maj.comboBoxGrade.Text;
                doc.Bookmarks.Add(bookmark9, range9);

                range10.Text = FormMajPers.maj.txtPPR.Text;
                doc.Bookmarks.Add(bookmark10, range10);

                    //range11.Text = this.dataGridView1.Rows[rowindex].Cells[2].ToString();
                    //doc.Bookmarks.Add(bookmark11, range11);
                app.Documents.Open(Application.StartupPath + @"\Word\DecisionConge.docx");
                }
                else if(FormMajPers.maj.comboBoxEntite.Text=="Délégation")
                {
                Microsoft.Office.Interop.Word.Document doc= app.Documents.Open(Application.StartupPath + @"\Word\DecisionConge_del.docx");
                string bookmark = "AFFECTATION";
                string bookmark1 = "AnneeConge";
                string bookmark2 = "AnneeConge_";
                string bookmark3 = "CIN";
                string bookmark4 = "CiviliteNomPrenom";
                string bookmark5 = "CiviliteNomPrenom_";
                string bookmark6 = "DateDepart";
                string bookmark7 = "DUREE";
                string bookmark8 = "ETRANGER";
                string bookmark9 = "GRADE";
                string bookmark10 = "PPR";
                //string bookmark11 = "PROVINCE";

                Microsoft.Office.Interop.Word.Bookmark bm = doc.Bookmarks[bookmark];
                Microsoft.Office.Interop.Word.Range range = bm.Range;
                Microsoft.Office.Interop.Word.Bookmark bm1 = doc.Bookmarks[bookmark1];
                Microsoft.Office.Interop.Word.Range range1 = bm1.Range;
                Microsoft.Office.Interop.Word.Bookmark bm2 = doc.Bookmarks[bookmark2];
                Microsoft.Office.Interop.Word.Range range2 = bm2.Range;
                Microsoft.Office.Interop.Word.Bookmark bm3 = doc.Bookmarks[bookmark3];
                Microsoft.Office.Interop.Word.Range range3 = bm3.Range;
                Microsoft.Office.Interop.Word.Bookmark bm4 = doc.Bookmarks[bookmark4];
                Microsoft.Office.Interop.Word.Range range4 = bm4.Range;
                Microsoft.Office.Interop.Word.Bookmark bm5 = doc.Bookmarks[bookmark5];
                Microsoft.Office.Interop.Word.Range range5 = bm5.Range;
                Microsoft.Office.Interop.Word.Bookmark bm6 = doc.Bookmarks[bookmark6];
                Microsoft.Office.Interop.Word.Range range6 = bm6.Range;
                Microsoft.Office.Interop.Word.Bookmark bm7 = doc.Bookmarks[bookmark7];
                Microsoft.Office.Interop.Word.Range range7 = bm7.Range;
                Microsoft.Office.Interop.Word.Bookmark bm8 = doc.Bookmarks[bookmark8];
                Microsoft.Office.Interop.Word.Range range8 = bm8.Range;
                Microsoft.Office.Interop.Word.Bookmark bm9 = doc.Bookmarks[bookmark9];
                Microsoft.Office.Interop.Word.Range range9 = bm9.Range;
                Microsoft.Office.Interop.Word.Bookmark bm10 = doc.Bookmarks[bookmark10];
                Microsoft.Office.Interop.Word.Range range10 = bm10.Range;
                //Microsoft.Office.Interop.Word.Bookmark bm11 = doc.Bookmarks[bookmark11];
                //Microsoft.Office.Interop.Word.Range range11 = bm11.Range;

                int row = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;

                range.Text = FormMajPers.maj.comboBoxAffectation.Text;
                doc.Bookmarks.Add(bookmark, range);

                range1.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[1].Value.ToString();
                doc.Bookmarks.Add(bookmark1, range1);

                range2.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[1].Value.ToString();
                doc.Bookmarks.Add(bookmark2, range2);

                range3.Text = FormMajPers.maj.txtCin.Text;
                doc.Bookmarks.Add(bookmark3, range3);

                if (FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMlle.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMme.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMme.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                doc.Bookmarks.Add(bookmark4, range4);

                if (FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMlle.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMme.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMme.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                doc.Bookmarks.Add(bookmark5, range5);

                DateTime datepart = Convert.ToDateTime(this.dataGridView1.Rows[rowindex].Cells[1].Value);
                range6.Text = datepart.ToShortDateString();
                doc.Bookmarks.Add(bookmark6, range6);

                range7.Text = this.dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                doc.Bookmarks.Add(bookmark7, range7);

                if (this.dataGridView1.Rows[rowindex].Cells[11].Value.Equals(true))
                {
                    range8.Text = "à l'étranger";
                }
                else
                {
                    range8.Text = "";
                }
                doc.Bookmarks.Add(bookmark8, range8);

                range9.Text = FormMajPers.maj.comboBoxGrade.Text;
                doc.Bookmarks.Add(bookmark9, range9);

                range10.Text = FormMajPers.maj.txtPPR.Text;
                doc.Bookmarks.Add(bookmark10, range10);

                    //range11.Text = this.dataGridView1.Rows[rowindex].Cells[2].ToString();
                    //doc.Bookmarks.Add(bookmark11, range11);
                app.Documents.Open(Application.StartupPath + @"\Word\DecisionConge_del.docx");
                }
                else if(FormMajPers.maj.comboBoxEntite.Text=="SRES")
                {
                Microsoft.Office.Interop.Word.Document doc= app.Documents.Open(Application.StartupPath + @"\Word\DecisionConge_sres.docx");
                string bookmark = "AFFECTATION";
                string bookmark1 = "AnneeConge";
                string bookmark2 = "AnneeConge_";
                string bookmark3 = "CIN";
                string bookmark4 = "CiviliteNomPrenom";
                string bookmark5 = "CiviliteNomPrenom_";
                string bookmark6 = "DateDepart";
                string bookmark7 = "DUREE";
                string bookmark8 = "ETRANGER";
                string bookmark9 = "GRADE";
                string bookmark10 = "PPR";
                //string bookmark11 = "PROVINCE";

                Microsoft.Office.Interop.Word.Bookmark bm = doc.Bookmarks[bookmark];
                Microsoft.Office.Interop.Word.Range range = bm.Range;
                Microsoft.Office.Interop.Word.Bookmark bm1 = doc.Bookmarks[bookmark1];
                Microsoft.Office.Interop.Word.Range range1 = bm1.Range;
                Microsoft.Office.Interop.Word.Bookmark bm2 = doc.Bookmarks[bookmark2];
                Microsoft.Office.Interop.Word.Range range2 = bm2.Range;
                Microsoft.Office.Interop.Word.Bookmark bm3 = doc.Bookmarks[bookmark3];
                Microsoft.Office.Interop.Word.Range range3 = bm3.Range;
                Microsoft.Office.Interop.Word.Bookmark bm4 = doc.Bookmarks[bookmark4];
                Microsoft.Office.Interop.Word.Range range4 = bm4.Range;
                Microsoft.Office.Interop.Word.Bookmark bm5 = doc.Bookmarks[bookmark5];
                Microsoft.Office.Interop.Word.Range range5 = bm5.Range;
                Microsoft.Office.Interop.Word.Bookmark bm6 = doc.Bookmarks[bookmark6];
                Microsoft.Office.Interop.Word.Range range6 = bm6.Range;
                Microsoft.Office.Interop.Word.Bookmark bm7 = doc.Bookmarks[bookmark7];
                Microsoft.Office.Interop.Word.Range range7 = bm7.Range;
                Microsoft.Office.Interop.Word.Bookmark bm8 = doc.Bookmarks[bookmark8];
                Microsoft.Office.Interop.Word.Range range8 = bm8.Range;
                Microsoft.Office.Interop.Word.Bookmark bm9 = doc.Bookmarks[bookmark9];
                Microsoft.Office.Interop.Word.Range range9 = bm9.Range;
                Microsoft.Office.Interop.Word.Bookmark bm10 = doc.Bookmarks[bookmark10];
                Microsoft.Office.Interop.Word.Range range10 = bm10.Range;
                //Microsoft.Office.Interop.Word.Bookmark bm11 = doc.Bookmarks[bookmark11];
                //Microsoft.Office.Interop.Word.Range range11 = bm11.Range;

                int row = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;

                range.Text = FormMajPers.maj.comboBoxAffectation.Text;
                doc.Bookmarks.Add(bookmark, range);

                range1.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[1].Value.ToString();
                doc.Bookmarks.Add(bookmark1, range1);

                range2.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[1].Value.ToString();
                doc.Bookmarks.Add(bookmark2, range2);

                range3.Text = FormMajPers.maj.txtCin.Text;
                doc.Bookmarks.Add(bookmark3, range3);

                if (FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMlle.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMme.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMme.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range4.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                doc.Bookmarks.Add(bookmark4, range4);

                if (FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMlle.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMme.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMme.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                else if (FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range5.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; ;
                }
                doc.Bookmarks.Add(bookmark5, range5);

                DateTime datepart = Convert.ToDateTime(this.dataGridView1.Rows[rowindex].Cells[1].Value);
                range6.Text = datepart.ToString("d");
                doc.Bookmarks.Add(bookmark6, range6);

                range7.Text = this.dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                doc.Bookmarks.Add(bookmark7, range7);

                if (this.dataGridView1.Rows[rowindex].Cells[11].Value.Equals(true))
                {
                    range8.Text = "à l'étranger";
                }
                else
                {
                    range8.Text = "";
                }
                doc.Bookmarks.Add(bookmark8, range8);

                range9.Text = FormMajPers.maj.comboBoxGrade.Text;
                doc.Bookmarks.Add(bookmark9, range9);

                range10.Text = FormMajPers.maj.txtPPR.Text;
                doc.Bookmarks.Add(bookmark10, range10);

                    //range11.Text = this.dataGridView1.Rows[rowindex].Cells[2].ToString();
                    //doc.Bookmarks.Add(bookmark11, range11);
                    app.Documents.Open(Application.StartupPath + @"\Word\DecisionConge_sres.docx");
                }
              
            }

            if (e.ColumnIndex == 15)
            {
                CompteRendu cr = new CompteRendu();
                cr.MdiParent = FormMenu.menu;
                cr.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
