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
    public partial class CompteRendu : MetroFramework.Forms.MetroForm
    {
        public CompteRendu()
        {
            InitializeComponent();
        }
        Cumul_conge cumul=new Cumul_conge();
        private void CompteRendu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int rowindex = Mise_a_jour_conge.majc.dataGridView1.CurrentRow.Index;
            int row = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;

            cumul.NumDecision= Convert.ToInt32(this.txtNumDec.Text);
            cumul.DateDecision=this.dateDecision.Value;
            cumul.DateCessationSvc=this.DateCessation.Value;
            cumul.DateRepriseSvc = this.DateReprise.Value;
            cumul.Id_cumul = Convert.ToInt32(Mise_a_jour_conge.majc.dataGridView1.Rows[rowindex].Cells[0].Value);

            if (cumul.MAJ("Modifier_cumuls"))
            {
                MessageBox.Show("Bien Ajouter", "Pour votre information", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.btnImprimer.Enabled = true;
                this.btnAjouter.Enabled = false;
            }
            else
                MessageBox.Show("Error","Pour votre information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
             int rowindex=Mise_a_jour_conge.majc.dataGridView1.CurrentRow.Index;
             int row = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(Application.StartupPath + @"\Word\cessationReprise.docx");
            string bookmark = "choix1";
            string bookmark1 = "choix2";
            string bookmark2 = "Nom";
            string bookmark3 = "Grade";
            string bookmark4 = "Duree";
            string bookmark5 = "Annee";
            string bookmark6 = "decision";
            string bookmark7 = "DateDecision";
            string bookmark8 = "Cessation";
            string bookmark9 = "Prise";
            string bookmark10 = "Annee_observation";
            string bookmark11 = "Duree_observation";
          

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
            Word.Bookmark bm11 = doc.Bookmarks[bookmark11];
            Word.Range range11 = bm11.Range;

            

            if (this.radioButtonC.Checked)
            {
                range.Text = "✔";
                doc.Bookmarks.Add(bookmark, range);

                range8.Text = this.DateCessation.Value.ToShortDateString();
                doc.Bookmarks.Add(bookmark8, range8);
            }
            if (this.radioButtonR.Checked)
            {
                range1.Text = "✔";
                doc.Bookmarks.Add(bookmark1, range1);

                range9.Text = this.DateReprise.Value.ToShortDateString();
                doc.Bookmarks.Add(bookmark9, range9);
            }
            if (this.radioButtonCR.Checked)
            {
                range.Text = "✔";
                doc.Bookmarks.Add(bookmark, range);

                range1.Text = "✔";
                doc.Bookmarks.Add(bookmark1, range1);

                range8.Text = this.DateCessation.Value.ToShortDateString();
                doc.Bookmarks.Add(bookmark8, range8);

                range9.Text = this.DateReprise.Value.ToShortDateString();
                doc.Bookmarks.Add(bookmark9, range9);
            }
            
            
            if (FormMajPers.maj.radioButtonMlle.Checked)
            {
                range2.Text = FormMajPers.maj.radioButtonMlle.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; 
            }
            else if (FormMajPers.maj.radioButtonMme.Checked)
            {
                range2.Text = FormMajPers.maj.radioButtonMme.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; 
            }
            else if (FormMajPers.maj.radioButtonMonsieur.Checked)
            {
                range2.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + FormMajPers.maj.txtNomFr.Text + " " + FormMajPers.maj.txtPrenomFr.Text; 
            }
            doc.Bookmarks.Add(bookmark2, range2);

            range3.Text = FormMajPers.maj.comboBoxGrade.Text; 
            doc.Bookmarks.Add(bookmark3, range3);

            range4.Text = Mise_a_jour_conge.majc.dataGridView1.Rows[rowindex].Cells[2].Value.ToString(); 
            doc.Bookmarks.Add(bookmark4, range4);

            range5.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[1].Value.ToString(); 
            doc.Bookmarks.Add(bookmark5, range5);

            range6.Text = this.txtNumDec.Text;
            doc.Bookmarks.Add(bookmark6, range6);

            range7.Text = this.dateDecision.Value.ToShortDateString();
            doc.Bookmarks.Add(bookmark7, range7);

            range10.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[1].Value.ToString();
            doc.Bookmarks.Add(bookmark10, range10);

            range11.Text = FormMajPers.maj.dataGridViewCongeAnuelle.Rows[row].Cells[2].Value.ToString();
            doc.Bookmarks.Add(bookmark11, range11);

            app.Documents.Open(Application.StartupPath + @"\Word\cessationReprise.docx");
        }
    }
}
