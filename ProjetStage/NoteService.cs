using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ProjetStage
{
    public partial class NoteService : MetroFramework.Forms.MetroForm
    {
        public NoteService()
        {
            InitializeComponent();
        }

        private void NoteService_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            this.groupBox2.Enabled = true;
            this.panel1.Enabled = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            this.groupBox2.Enabled = false;
            this.panel1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();
            if (this.radioButtonR.Checked)
            {
                Word.Document doc = app.Documents.Open(Application.StartupPath + @"\Word\recrutement.docx");
                string bookmark = "ampliation";
                string bookmark1 = "ampliation2";
                string bookmark2 = "date";
                string bookmark3 = "decision";
                string bookmark4 = "decision_bor";
                string bookmark5 = "grade";
                string bookmark6 = "grade_bor";
                string bookmark7 = "nom";
                string bookmark8 = "nom_bor";
                string bookmark9 = "specialite";
                string bookmark10 = "fs";
                string bookmark11 = "date_bor";

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


                if (FormMajPers.maj.comboBoxEntite.Text == "Délégation")
                {
                    range.Text = "délégué";
                    doc.Bookmarks.Add(bookmark, range);

                    range1.Text = "délégué";
                    doc.Bookmarks.Add(bookmark1, range1);

                    range10.Text = "Délégation";
                    doc.Bookmarks.Add(bookmark10, range10);
                }

                if (FormMajPers.maj.comboBoxEntite.Text == "SRES")
                {
                    range.Text = "médecin chef du SRES";
                    doc.Bookmarks.Add(bookmark, range);

                    range1.Text = "médecin chef du SRES";
                    doc.Bookmarks.Add(bookmark1, range1);

                    range10.Text = FormMajPers.maj.comboBoxFSinitaire.Text;
                    doc.Bookmarks.Add(bookmark10, range10);
                }

                if (FormMajPers.maj.comboBoxEntite.Text == "CHP Med V")
                {
                    range.Text = "Médecin Directeur du CHP Med V";
                    doc.Bookmarks.Add(bookmark, range);

                    range1.Text = "Médecin Directeur du CHP Med V";
                    doc.Bookmarks.Add(bookmark1, range1);

                    range10.Text = "CHP Med V";
                    doc.Bookmarks.Add(bookmark10, range10);
                }

               
                    range2.Text = this.dateDecision.Value.ToShortDateString();
                doc.Bookmarks.Add(bookmark2, range2);

                range3.Text = this.txtDecision.Text;
                doc.Bookmarks.Add(bookmark3, range3);

                range4.Text = this.txtDecision.Text;
                doc.Bookmarks.Add(bookmark4, range4);

                range5.Text = FormMajPers.maj.comboBoxGrade.Text;
                doc.Bookmarks.Add(bookmark5, range5);

                range6.Text = FormMajPers.maj.comboBoxGrade.Text;
                doc.Bookmarks.Add(bookmark6, range6);
                if(FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range7.Text =FormMajPers.maj.radioButtonMonsieur.Text+"."+Program.NomComplet;
                doc.Bookmarks.Add(bookmark7, range7);
                }

                 if(FormMajPers.maj.radioButtonMme.Checked)
                {
                    range7.Text =FormMajPers.maj.radioButtonMme.Text+""+Program.NomComplet ;
                doc.Bookmarks.Add(bookmark7, range7);
                }

                if(FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range7.Text = FormMajPers.maj.radioButtonMlle.Text + "" + Program.NomComplet;
                doc.Bookmarks.Add(bookmark7, range7);
                }

                if(FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range7.Text =FormMajPers.maj.radioButtonMonsieur.Text+""+Program.NomComplet;
                doc.Bookmarks.Add(bookmark7, range7);

                range8.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + Program.NomComplet;
                doc.Bookmarks.Add(bookmark8, range8);
                }

                 if(FormMajPers.maj.radioButtonMme.Checked)
                {
                    range7.Text =FormMajPers.maj.radioButtonMme.Text+"."+Program.NomComplet ;
                doc.Bookmarks.Add(bookmark7, range7);

                range8.Text = FormMajPers.maj.radioButtonMme.Text + "." + Program.NomComplet;
                doc.Bookmarks.Add(bookmark8, range8);
                }

                if(FormMajPers.maj.radioButtonMlle.Checked)
                {
                range7.Text = FormMajPers.maj.radioButtonMlle.Text + "." + Program.NomComplet;
                doc.Bookmarks.Add(bookmark7, range7);

                range8.Text = FormMajPers.maj.radioButtonMlle.Text + "." + Program.NomComplet;
                doc.Bookmarks.Add(bookmark8, range8);
                }
                range9.Text = FormMajPers.maj.comboBoxSpecialite.Text;
                doc.Bookmarks.Add(bookmark9, range9);

                

                range11.Text = this.dateDecision.Value.ToShortDateString();
                doc.Bookmarks.Add(bookmark11, range11);

                app.Documents.Open(Application.StartupPath + @"\Word\recrutement.docx");
            }
            else  if (this.radioButtonM.Checked)
            {
                Word.Document doc = app.Documents.Open(Application.StartupPath + @"\Word\mutation.docx");
                string bookmark = "ampliation";
                string bookmark1 = "ampliation2";
                string bookmark2 = "date";
                string bookmark3 = "decision";
                string bookmark4 = "decision_bor";
                string bookmark5 = "grade";
                string bookmark6 = "grade_bor";
                string bookmark7 = "nom";
                string bookmark8 = "nom_bor";
                string bookmark9 = "specialite";
                string bookmark10 = "fs";
                string bookmark11 = "date_bor";
                string bookmark12 = "fsAncien";
                string bookmark13 = "mvt";
                string bookmark14 = "mvt_bor";
                string bookmark15 = "ppr";
                string bookmark16 = "ppr_bor";
                string bookmark17 = "annee";

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
                Word.Bookmark bm12 = doc.Bookmarks[bookmark12];
                Word.Range range12 = bm12.Range;
                Word.Bookmark bm13 = doc.Bookmarks[bookmark13];
                Word.Range range13 = bm13.Range;
                Word.Bookmark bm14 = doc.Bookmarks[bookmark14];
                Word.Range range14 = bm14.Range;
                Word.Bookmark bm15 = doc.Bookmarks[bookmark15];
                Word.Range range15 = bm15.Range;
                Word.Bookmark bm16 = doc.Bookmarks[bookmark16];
                Word.Range range16 = bm16.Range;
                Word.Bookmark bm17 = doc.Bookmarks[bookmark17];
                Word.Range range17 = bm17.Range;


                if (FormMajPers.maj.comboBoxEntite.Text == "Délégation")
                {
                    range.Text = "délégué";
                    doc.Bookmarks.Add(bookmark, range);

                    range1.Text = "délégué";
                    doc.Bookmarks.Add(bookmark1, range1);

                    range10.Text = "Délégation";
                    doc.Bookmarks.Add(bookmark10, range10);
                }

                if (FormMajPers.maj.comboBoxEntite.Text == "SRES")
                {
                    range.Text = "médecin chef du SRES";
                    doc.Bookmarks.Add(bookmark, range);

                    range1.Text = "médecin chef du SRES";
                    doc.Bookmarks.Add(bookmark1, range1);

                    range10.Text = FormMajPers.maj.comboBoxFSinitaire.Text;
                    doc.Bookmarks.Add(bookmark10, range10);
                }

                if (FormMajPers.maj.comboBoxEntite.Text == "CHP Med V")
                {
                    range.Text = "Médecin Directeur du CHP Med V";
                    doc.Bookmarks.Add(bookmark, range);

                    range1.Text = "Médecin Directeur du CHP Med V";
                    doc.Bookmarks.Add(bookmark1, range1);

                    range10.Text = "CHP Med V";
                    doc.Bookmarks.Add(bookmark10, range10);
                }


                range2.Text = this.dateDecision.Value.ToShortDateString();
                doc.Bookmarks.Add(bookmark2, range2);

                range3.Text = this.txtDecision.Text;
                doc.Bookmarks.Add(bookmark3, range3);

                range4.Text = this.txtDecision.Text;
                doc.Bookmarks.Add(bookmark4, range4);

                range5.Text = FormMajPers.maj.comboBoxGrade.Text;
                doc.Bookmarks.Add(bookmark5, range5);

                range6.Text = FormMajPers.maj.comboBoxGrade.Text;
                doc.Bookmarks.Add(bookmark6, range6);
                if (FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range7.Text = FormMajPers.maj.radioButtonMonsieur.Text + "." + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark7, range7);
                }

                if (FormMajPers.maj.radioButtonMme.Checked)
                {
                    range7.Text = FormMajPers.maj.radioButtonMme.Text + "" + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark7, range7);
                }

                if (FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range7.Text = FormMajPers.maj.radioButtonMlle.Text + "" + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark7, range7);
                }

                if (FormMajPers.maj.radioButtonMonsieur.Checked)
                {
                    range7.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark7, range7);

                    range8.Text = FormMajPers.maj.radioButtonMonsieur.Text + "" + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark8, range8);
                }

                if (FormMajPers.maj.radioButtonMme.Checked)
                {
                    range7.Text = FormMajPers.maj.radioButtonMme.Text + "." + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark7, range7);

                    range8.Text = FormMajPers.maj.radioButtonMme.Text + "." + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark8, range8);
                }

                if (FormMajPers.maj.radioButtonMlle.Checked)
                {
                    range7.Text = FormMajPers.maj.radioButtonMlle.Text + "." + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark7, range7);

                    range8.Text = FormMajPers.maj.radioButtonMlle.Text + "." + Program.NomComplet;
                    doc.Bookmarks.Add(bookmark8, range8);
                }
                range9.Text = FormMajPers.maj.comboBoxSpecialite.Text;
                doc.Bookmarks.Add(bookmark9, range9);

                

                range11.Text = this.dateDecision.Value.ToShortDateString();
                doc.Bookmarks.Add(bookmark11, range11);

                range12.Text = this.txtMute.Text;
                doc.Bookmarks.Add(bookmark12, range12);
                if(radioButtonExep.Checked)
                {
                range13.Text =this.radioButtonExep.Text ;
                doc.Bookmarks.Add(bookmark13, range13);

                range14.Text = this.radioButtonExep.Text;
                doc.Bookmarks.Add(bookmark14, range14);
                }
                if(radioButtonE.Checked)
                {
                range13.Text = this.radioButtonE.Text;
                doc.Bookmarks.Add(bookmark13, range13);

                range14.Text = this.radioButtonE.Text;
                doc.Bookmarks.Add(bookmark14, range14);
                }
                if(radioButtonEp.Checked)
                {
                range13.Text =this.radioButtonEp.Text ;
                doc.Bookmarks.Add(bookmark13, range13);

                range14.Text = this.radioButtonEp.Text;
                doc.Bookmarks.Add(bookmark14, range14);
                }
                if(radioButtonNL.Checked)
                {
                range13.Text =this.radioButtonNL.Text ;
                doc.Bookmarks.Add(bookmark13, range13);

                range14.Text = this.radioButtonNL.Text;
                doc.Bookmarks.Add(bookmark14, range14);
                }
                if(radioButtonNn.Checked)
                {
                range13.Text =this.radioButtonNn.Text ;
                doc.Bookmarks.Add(bookmark13, range13);

                range14.Text = this.radioButtonNn.Text;
                doc.Bookmarks.Add(bookmark14, range14);
                }
                if(radioButtonNR.Checked)
                {
                range13.Text =this.radioButtonNR.Text ;
                doc.Bookmarks.Add(bookmark13, range13);

                range14.Text = this.radioButtonNR.Text;
                doc.Bookmarks.Add(bookmark14, range14);
                }
                if(radioButtonZ.Checked)
                {
                range13.Text =this.radioButtonZ.Text ;
                doc.Bookmarks.Add(bookmark13, range13);

                range14.Text = this.radioButtonZ.Text;
                doc.Bookmarks.Add(bookmark14, range14);
                }

                range15.Text = Program.ppr.ToString();
                doc.Bookmarks.Add(bookmark15, range15);

                range16.Text = Program.ppr.ToString();
                doc.Bookmarks.Add(bookmark16, range16);

                range17.Text = this.txtAnneeMVT.Value.ToString();
                doc.Bookmarks.Add(bookmark17, range17);

                app.Documents.Open(Application.StartupPath + @"\Word\mutation.docx");
            }
        }
    }
}
