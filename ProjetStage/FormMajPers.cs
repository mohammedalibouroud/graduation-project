using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrejetStage_Library;
using System.Collections;
using System.IO;
using System.Data.SqlClient;


namespace ProjetStage
{
    public partial class FormMajPers : Form
    {
        public FormMajPers()
        {
            InitializeComponent();
        }
        public static FormMajPers maj;
        Agent ag;
        String image;
        Congé_annuelle ca;
        //public void insert()
        //{
        //    ag = new Agent();


            
        //}
        public void remplir_grid()
        {
            
            cONGESANNUELSDataTableBindingSource.DataSource = MyDataBase.Conge_Annuelle("Conge_Annulle", Convert.ToInt32(this.txtPPR.Text));
            //this.dataGridViewCongeAnuelle.DataSource=cONGESANNUELSDataTableBindingSource;
        }
        public void remplircombo()
        {
            cadreDataTableBindingSource.DataSource = MyDataBase.remplircombo("Cadre", "liste_cadre");
            gradeBindingSource.DataSource = MyDataBase.remplirGrade(Convert.ToInt32(this.comboBoxCadre.SelectedValue));
            specialiteBindingSource.DataSource = MyDataBase.remplirSpecialte(Convert.ToInt32(this.comboBoxCadre.SelectedValue));
            positionDataTableBindingSource.DataSource = MyDataBase.remplircombo("Position", "liste_position");
            entiteDataTableBindingSource.DataSource = MyDataBase.remplircombo("Entite", "liste_entite");
            affectationDataTableBindingSource.DataSource = MyDataBase.remplircombo("Affectation", "liste_Affectation", (Convert.ToInt32(this.comboBoxEntite.SelectedValue)).ToString(), "@entite");
            formationSanitaireDataTableBindingSource.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffectation.SelectedValue)).ToString(), "@affectation");
            entiteDataTableBindingSource1.DataSource = MyDataBase.remplircombo("Entite", "liste_entite");
            affectationDataTableBindingSource1.DataSource = MyDataBase.remplircombo("Affectation", "liste_Affectation", (Convert.ToInt32(this.comboBoxEntiteAffReelFR.SelectedValue)).ToString(), "@entite");
            formationSanitaireDataTableBindingSource1.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffReelFr.SelectedValue)).ToString(), "@affectation");
            entiteDataTableBindingSource2.DataSource = MyDataBase.remplircombo("Entite", "liste_entite");
            affectationDataTableBindingSource2.DataSource = MyDataBase.remplircombo("Affectation", "liste_Affectation", (Convert.ToInt32(this.comboBoxEntitePremiLieuAffFr.SelectedValue)).ToString(), "@entite");
            formationSanitaireDataTableBindingSource2.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffPremierLieuFR.SelectedValue)).ToString(), "@affectation");
            armoireDataTableBindingSource.DataSource = MyDataBase.remplircombo("Armoire", "Liste_Armoir");
            troireDataTableBindingSource.DataSource = MyDataBase.remplircombo("Troire", "Liste_Tiroire", (Convert.ToInt32(this.TxtArmoire.SelectedValue)).ToString(), "@aromoir");
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        
        public  void  afficher(int ppr)
        {
            ag = new Agent(ppr, "AfficherAgent");

            this.txtPPR.Text = ag.Ppr.ToString();
            this.txtNomFr.Text = ag.Nomfr;
            this.txtPrenomFr.Text = ag.Prenomfr;
            this.txtNomAr.Text = ag.NomAr;
            this.txtPrenomAr.Text = ag.PrenomAr;
            this.txtCin.Text = ag.Cin;
            this.txtTele.Text = ag.Telephone;
            this.DateN.Value = ag.Dn;
            this.DateAff.Value = ag.Da;
            this.DateRecru.Value = ag.Dr;

            if (ag.Situantion_familiale == "Marié(e)")
            {
                this.radioButtonMarie.Checked=true;
            }
            else if (ag.Situantion_familiale == "Célibataire")
            {
                this.radioButtonCelebataire.Checked=true;
            }
            else if (ag.Situantion_familiale == "Divorcé(e)")
            {
                this.radioButtonDivorce.Checked=true;
            }
            else if (ag.Situantion_familiale == "Veuf(ve)")
            {
               this.radioButtonVeuf.Checked=true;
            }

            if (ag.Sexe == "M")
            {
                radioButtonM.Checked=true;
            }
            else if ( ag.Sexe == "F")
            {
                radioButtonF.Checked=true;
            }

            if (ag.Civilite == "Mr.")
            {
                radioButtonMonsieur.Checked=true;
            }
            else if (ag.Civilite == "Mme.")
            {
                radioButtonMme.Checked=true;
            }
            else if (ag.Civilite == "Mlle")
            {
                radioButtonMlle.Checked=true;
            }

            this.comboBoxCadre.SelectedValue = ag.Cadre;
            this.comboBoxEntite.SelectedValue = ag.Entite;
            this.comboBoxAffectation.SelectedValue = ag.Affectation;

            this.comboBoxEntiteAffReelFR.SelectedValue = ag.Entite1;
            this.comboBoxAffReelFr.SelectedValue = ag.Affectation1;

            this.comboBoxEntitePremiLieuAffFr.SelectedValue = ag.Entite2;
            this.comboBoxAffPremierLieuFR.SelectedValue = ag.Affectation2;

            this.TxtArmoire.SelectedValue = ag.Armoire;

            this.comboBoxGrade.SelectedValue = ag.Grade;
            this.comboBoxSpecialite.SelectedValue = ag.Specialite;
            this.comboBoxFSinitaire.SelectedValue = ag.Affectation_ministerielle;
            this.comboBoxFSinitaireAffRellFR.SelectedValue = ag.Affectation_relle;
            this.comboBoxFSinitairePremierLieuFr.SelectedValue = ag.PremierLieuAffectation;
            this.txtFonctionFr.Text = ag.FonctionFR;
            this.txtFonctionAr.Text = ag.FonctionAR;
            this.comboBoxPosition.SelectedValue = ag.Position;
            this.txtAdresseFr.Text = ag.AdresseFR;
            this.txtAdresseAr.Text = ag.AdresseAR;
            this.txtNombreEnfant.Text = ag.Nombre_enfants.ToString();
            this.txtMutuelle.Text = ag.NumMutuelle;
            this.txtNomConjoint.Text = ag.Conjoint;
            this.txtFonctionConjoint.Text = ag.FonctionConj;
            this.txtVilleConjoint.Text = ag.VilleAffectConjoint;
            this.TxtTiroire.SelectedValue = ag.Tiroire.ToString();
            this.txtNuméroEmplacement.Text = ag.NumeroDossier.ToString();
            this.dateTimePickerAM.Value = ag.DatePosteActuel;
            this.dateTimePickerPremLieuAff.Value = ag.DatePremierLieu;
            this.pictureBox1.Image = ByteToImage(ag.Photo);

            remplir_grid();

            this.dataGridViewCongeAnuelle.Visible = true;
        }

        public byte[] converter_image()
        {
            byte[] img = null;
            FileStream fs;
            if (fd.FileName.CompareTo("") != 0)
                fs = new FileStream(image, FileMode.Open, FileAccess.Read);
            else
            {             image=Application.StartupPath.ToString()+"\\Photos\\image_nondispo.png";
                fs = new FileStream(image, FileMode.Open, FileAccess.Read);
}
          
            BinaryReader rd = new BinaryReader(fs);
            img = rd.ReadBytes((int)fs.Length);

            return img;
        }

   

        private void FormMajPers_Load(object sender, EventArgs e)
        {
           
            maj = this;
            
            //remplircombo();
           // afficher(Agent.Min_ppr());
          //  Program.ppr =int.Parse( txtPPR.Text.ToString());
            //comboBoxCadre.Refresh();
            Program.NomComplet = this.txtNomFr.Text + " " + this.txtPrenomFr.Text;
            this.btnEnrg.Enabled =false;
           // this.btnEnrg.BackColor = Color.Gray;
            this.btnAnnuler.Enabled = false;
           
            
          
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void comboBoxCadre_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradeBindingSource.DataSource = MyDataBase.remplirGrade(Convert.ToInt32(this.comboBoxCadre.SelectedValue));
            specialiteBindingSource.DataSource = MyDataBase.remplirSpecialte(Convert.ToInt32(this.comboBoxCadre.SelectedValue));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Modifier:

            ag = new Agent();
             DialogResult confirmer = MessageBox.Show("Voulez-vous vraiment modifier ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (confirmer == DialogResult.Yes)
             {
                 ag.Ppr = Convert.ToInt32(this.txtPPR.Text);
                 ag.Nomfr = this.txtNomFr.Text;
                 ag.Prenomfr = this.txtPrenomFr.Text;
                 ag.NomAr = this.txtNomAr.Text;
                 ag.PrenomAr = this.txtPrenomAr.Text;
                 ag.Cin = this.txtCin.Text;
                 ag.Telephone = this.txtTele.Text;
                 ag.Dn = this.DateN.Value;
                 ag.Da = this.DateAff.Value;
                 ag.Dr = this.DateRecru.Value;
                 if (this.radioButtonM.Checked)
                 {
                     ag.Sexe = "M";
                 }
                 else if (this.radioButtonF.Checked)
                 {
                     ag.Sexe = "F";
                 }
                 if (this.radioButtonMonsieur.Checked)
                 {
                     ag.Civilite = "Mr.";
                 }
                 if (this.radioButtonMme.Checked)
                 {
                     ag.Civilite = "Mme.";
                 }
                 if (this.radioButtonMlle.Checked)
                 {
                     ag.Civilite = "Mlle.";
                 }

                 if (this.radioButtonMarie.Checked)
                 {
                     ag.Situantion_familiale = "Marié(e)";
                 }
                 if (this.radioButtonCelebataire.Checked)
                 {
                     ag.Situantion_familiale = "Célibataire";
                 }
                 if (this.radioButtonDivorce.Checked)
                 {
                     ag.Situantion_familiale = "Divorcé(e)";
                 }
                 if (this.radioButtonVeuf.Checked)
                 {
                     ag.Situantion_familiale = "Veuf(ve)";
                 }
                 ag.Grade = Convert.ToInt32(this.comboBoxGrade.SelectedValue);
                 ag.Specialite = Convert.ToInt32(this.comboBoxSpecialite.SelectedValue);
                 ag.Affectation_ministerielle = Convert.ToInt32(this.comboBoxFSinitaire.SelectedValue);
                 ag.PremierLieuAffectation = Convert.ToInt32(this.comboBoxFSinitairePremierLieuFr.SelectedValue);
                 ag.Affectation_relle = Convert.ToInt32(this.comboBoxFSinitaireAffRellFR.SelectedValue);
                 ag.FonctionFR = this.txtFonctionFr.Text;
                 ag.FonctionAR = this.txtFonctionAr.Text;
                 ag.Position = Convert.ToInt32(this.comboBoxPosition.SelectedValue);
                 //this.comboBoxPositionAR.SelectedValue = ag.Position;
                 ag.AdresseFR = this.txtAdresseFr.Text;
                 ag.AdresseAR = this.txtAdresseAr.Text;
                 ag.Nombre_enfants = Convert.ToInt32(this.txtNombreEnfant.Text);
                 ag.NumMutuelle = this.txtMutuelle.Text;
                 ag.Conjoint = this.txtNomConjoint.Text;
                 ag.FonctionConj = this.txtFonctionConjoint.Text;
                 ag.VilleAffectConjoint = this.txtVilleConjoint.Text;
                 ag.Tiroire = Convert.ToInt32(this.TxtTiroire.SelectedValue);
                 ag.NumeroDossier = Convert.ToInt32(this.txtNuméroEmplacement.Text);
                 ag.DatePosteActuel = this.dateTimePickerAM.Value;
                 ag.DatePremierLieu = this.dateTimePickerPremLieuAff.Value;
                 ag.Photo = converter_image();
                 

                 //SL.Add("@Photo");
                 //SL.Add("@Syndicat");
                 //SL.Add("@Supprimer");

                 if (ag.MAJ("Modifier_Agent"))
                 {
                     MessageBox.Show("Bien Modifier");
                 }
                 else
                 {
                     MessageBox.Show("Error");
                 }
             }
             else
             {
                 MessageBox.Show("Modification Annulé");
             }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEntite_SelectedIndexChanged(object sender, EventArgs e)
        {
            affectationDataTableBindingSource.DataSource = MyDataBase.remplircombo("Affectation", "liste_Affectation", (Convert.ToInt32(this.comboBoxEntite.SelectedValue)).ToString(), "@entite");
            formationSanitaireDataTableBindingSource.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffectation.SelectedValue)).ToString(), "@affectation");
        }

        private void comboBoxEntiteAR_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAffectation_SelectedIndexChanged(object sender, EventArgs e)
        {
            formationSanitaireDataTableBindingSource.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffectation.SelectedValue)).ToString(), "@affectation");
        }

        private void comboBoxAffectation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            affectationDataTableBindingSource1.DataSource = MyDataBase.remplircombo("Affectation", "liste_Affectation", (Convert.ToInt32(this.comboBoxEntiteAffReelFR.SelectedValue)).ToString(), "@entite");
            formationSanitaireDataTableBindingSource1.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffReelFr.SelectedValue)).ToString(), "@affectation");
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            formationSanitaireDataTableBindingSource1.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffReelFr.SelectedValue)).ToString(), "@affectation");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //afficher(Convert.ToInt32(this.txtPPR.Text));
            Recherche search = new Recherche();
            search.MdiParent = FormMenu.menu;
            search.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ajouter:
            try
            {
                if (String.IsNullOrEmpty(this.txtPPR.Text))
                {
                    MessageBox.Show("Le champ PPR est obligatoire", "Pour Votre Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPPR.BorderColorIdle = Color.Red;
                }
                else
                {
                    ag = new Agent();
                    ag.Ppr = Convert.ToInt32(this.txtPPR.Text);
                    ag.Nomfr = this.txtNomFr.Text;
                    ag.Prenomfr = this.txtPrenomFr.Text;
                    ag.NomAr = this.txtNomAr.Text;
                    ag.PrenomAr = this.txtPrenomAr.Text;
                    ag.Cin = this.txtCin.Text;
                    ag.Telephone = this.txtTele.Text;
                    ag.Dn = this.DateN.Value;
                    ag.Da = this.DateAff.Value;
                    ag.Dr = this.DateRecru.Value;
                    if (this.radioButtonM.Checked)
                    {
                        ag.Sexe = "M";
                    }
                    else if (this.radioButtonF.Checked)
                    {
                        ag.Sexe = "F";
                    }
                    if (this.radioButtonMonsieur.Checked)
                    {
                        ag.Civilite = "Mr.";
                    }
                    if (this.radioButtonMme.Checked)
                    {
                        ag.Civilite = "Mme.";
                    }
                    if (this.radioButtonMlle.Checked)
                    {
                        ag.Civilite = "Mlle.";
                    }

                    if (this.radioButtonMarie.Checked)
                    {
                        ag.Situantion_familiale = "Marié(e)";
                    }
                    if (this.radioButtonCelebataire.Checked)
                    {
                        ag.Situantion_familiale = "Célibataire";
                    }
                    if (this.radioButtonDivorce.Checked)
                    {
                        ag.Situantion_familiale = "Divorcé(e)";
                    }
                    if (this.radioButtonVeuf.Checked)
                    {
                        ag.Situantion_familiale = "Veuf(ve)";
                    }
                    ag.Grade = Convert.ToInt32(this.comboBoxGrade.SelectedValue);
                    ag.Specialite = Convert.ToInt32(this.comboBoxSpecialite.SelectedValue);
                    ag.Affectation_ministerielle = Convert.ToInt32(this.comboBoxFSinitaire.SelectedValue);
                    ag.PremierLieuAffectation = Convert.ToInt32(this.comboBoxFSinitairePremierLieuFr.SelectedValue);
                    ag.Affectation_relle = Convert.ToInt32(this.comboBoxFSinitaireAffRellFR.SelectedValue);
                    ag.FonctionFR = this.txtFonctionFr.Text;
                    ag.FonctionAR = this.txtFonctionAr.Text;
                    ag.Position = Convert.ToInt32(this.comboBoxPosition.SelectedValue);
                    //this.comboBoxPositionAR.SelectedValue = ag.Position;
                    ag.AdresseFR = this.txtAdresseFr.Text;
                    ag.AdresseAR = this.txtAdresseAr.Text;
                    ag.Nombre_enfants = Convert.ToInt32(this.txtNombreEnfant.Text);
                    ag.NumMutuelle = this.txtMutuelle.Text;
                    ag.Conjoint = this.txtNomConjoint.Text;
                    ag.FonctionConj = this.txtFonctionConjoint.Text;
                    ag.VilleAffectConjoint = this.txtVilleConjoint.Text;
                    ag.Tiroire = Convert.ToInt32(this.TxtTiroire.SelectedValue);
                    ag.NumeroDossier = Convert.ToInt32(this.txtNuméroEmplacement.Text);
                    ag.DatePosteActuel = this.dateTimePickerAM.Value;
                    ag.DatePremierLieu = this.dateTimePickerPremLieuAff.Value;
                    ag.Photo = converter_image();

                    //SL.Add("@Photo");
                    //SL.Add("@Syndicat");
                    //SL.Add("@Supprimer");

                    if (ag.MAJ("Ajouter_Agent"))
                    {
                        MessageBox.Show("Bien Ajouter", "MAJ Agent", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        btnAnnuler_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Erreur", "MAJ Agent", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch(SqlException sqlex)
            {
                if(sqlex.Number==2627)
                    MessageBox.Show("Ppr déja existe", "Pour Votre Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            
        }

        private void comboBoxEntitePremiLieuAffFr_SelectedIndexChanged(object sender, EventArgs e)
        {
            affectationDataTableBindingSource2.DataSource = MyDataBase.remplircombo("Affectation", "liste_Affectation", (Convert.ToInt32(this.comboBoxEntitePremiLieuAffFr.SelectedValue)).ToString(), "@entite");
            formationSanitaireDataTableBindingSource2.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffPremierLieuFR.SelectedValue)).ToString(), "@affectation");
        
        }

        private void comboBoxAffPremierLieuFR_SelectedIndexChanged(object sender, EventArgs e)
        {
            formationSanitaireDataTableBindingSource2.DataSource = MyDataBase.remplircombo("FormationSanitaire", "liste_FormationSinitaire", (Convert.ToInt32(this.comboBoxAffPremierLieuFR.SelectedValue)).ToString(), "@affectation");
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmEtat.frmFicheRenseignement ffr = new FrmEtat.frmFicheRenseignement();
            ffr.MdiParent = FormMenu.menu;
            ffr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fd.FileName = "";
            this.txtPPR.ResetText();
            this.txtNomFr.ResetText();
            this.txtNomAr.ResetText();
            this.txtPrenomFr.ResetText();
            this.txtPrenomAr.ResetText();
            this.txtCin.ResetText();
            this.txtTele.ResetText();
            this.DateN.Value=DateTime.Now;
            this.DateRecru.Value = DateTime.Now;
            this.DateAff.Value = DateTime.Now;
            this.txtNombreEnfant.Text = "0";
            this.txtMutuelle.Text = "Inconnu";
            this.txtFonctionFr.ResetText();
            this.txtFonctionAr.ResetText();
            this.txtNomConjoint.Text="Inconnu";
            this.txtFonctionConjoint.Text="Inconnu";
            this.txtVilleConjoint.Text="Inconnu";
            //this.TxtArmoire.ResetText();
            //this.TxtTiroire.ResetText();
            this.dateTimePickerAM.Value = DateTime.Now;
            this.dateTimePickerPremLieuAff.Value = DateTime.Now;
            this.txtNuméroEmplacement.Text = "0";
            this.txtAdresseFr.ResetText();
            this.txtAdresseAr.ResetText();
          this.btnEnrg.Enabled = true;
           // this.btnEnrg.BackColor=this.btnRech.BackColor;
          this.btnAttestation.Enabled = false;
          this.btnFiche.Enabled = false;
          this.btnNService.Enabled = false;
            this.btnRech.Enabled=false;
            this.btnSupp.Enabled = false;
            this.btnMod.Enabled = false;
            this.btnAnnuler.Enabled = true;
         pictureBox1.Image =Image.FromFile(Application.StartupPath.ToString()+"\\Photos\\image_nondispo.png");
        // this.cONGESANNUELSDataTableBindingSource.DataSource = null;
         this.dataGridViewCongeAnuelle.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
             DialogResult confirmer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (confirmer == DialogResult.Yes)
             {
                 ag.Ppr = int.Parse(this.txtPPR.Text.ToString());
                 ag.MAJ("supprimer_agent");
                 MessageBox.Show("bien supprimer");
             }
             else
             {
                 MessageBox.Show("La Suppréssion est annulé");
             }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(Application.StartupPath + @"\Word\AttestationTravailAr.doc");

            //Français:
            string bookmark = "CiviliteNomPrenom";
            string bookmark1 = "PPRFR";
            string bookmark2 = "CINFR";
            string bookmark3 = "GradeFR";
            string bookmark4 = "recrutementFr";
            string bookmark5 = "provisoirefr";
            string bookmark6 = "AFFECTATION";
            string bookmark7 = "FONCTION";
            
            
            
            

          
//Français:
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

        //Arabe:

            
            string bookmark8 = "cin";
            string bookmark9 = "civilite";
            string bookmark10 = "date_recrutement";
            string bookmark11 = "fs";
            string bookmark12 = "grade";
            string bookmark13 = "nom_prenom";
            string bookmark14 = "ppr";
            string bookmark15 = "provisoirear";
            string bookmark16 = "specialite";
            string bookmark17 = "travail";

            Microsoft.Office.Interop.Word.Bookmark bm8 = doc.Bookmarks[bookmark8];
            Microsoft.Office.Interop.Word.Range range8 = bm8.Range;
            Microsoft.Office.Interop.Word.Bookmark bm9 = doc.Bookmarks[bookmark9];
            Microsoft.Office.Interop.Word.Range range9 = bm9.Range;
            Microsoft.Office.Interop.Word.Bookmark bm10 = doc.Bookmarks[bookmark10];
            Microsoft.Office.Interop.Word.Range range10 = bm10.Range;
            Microsoft.Office.Interop.Word.Bookmark bm11 = doc.Bookmarks[bookmark11];
            Microsoft.Office.Interop.Word.Range range11 = bm11.Range;
            Microsoft.Office.Interop.Word.Bookmark bm12 = doc.Bookmarks[bookmark12];
            Microsoft.Office.Interop.Word.Range range12 = bm12.Range;
            Microsoft.Office.Interop.Word.Bookmark bm13 = doc.Bookmarks[bookmark13];
            Microsoft.Office.Interop.Word.Range range13 = bm13.Range;
            Microsoft.Office.Interop.Word.Bookmark bm14 = doc.Bookmarks[bookmark14];
            Microsoft.Office.Interop.Word.Range range14 = bm14.Range;
            Microsoft.Office.Interop.Word.Bookmark bm15 = doc.Bookmarks[bookmark15];
            Microsoft.Office.Interop.Word.Range range15 = bm15.Range;
            Microsoft.Office.Interop.Word.Bookmark bm16 = doc.Bookmarks[bookmark16];
            Microsoft.Office.Interop.Word.Range range16 = bm16.Range;
            Microsoft.Office.Interop.Word.Bookmark bm17 = doc.Bookmarks[bookmark17];
            Microsoft.Office.Interop.Word.Range range17 = bm17.Range;

            //Français:
            if (radioButtonMonsieur.Checked)
            {
                range.Text = this.radioButtonMonsieur.Text + "" + this.txtNomFr.Text + " " + this.txtPrenomFr.Text;
            }
            if (radioButtonMme.Checked)
            {
                range.Text = this.radioButtonMme.Text + "" + this.txtNomFr.Text + " " + this.txtPrenomFr.Text;
            }
            if (radioButtonMlle.Checked)
            {
                range.Text = this.radioButtonMlle.Text + "" + this.txtNomFr.Text + " " + this.txtPrenomFr.Text;
            }
            doc.Bookmarks.Add(bookmark, range);
            range1.Text = "PPR : " + this.txtPPR.Text;
            doc.Bookmarks.Add(bookmark1, range1);
            range2.Text = "CIN : " + this.txtCin.Text;
            doc.Bookmarks.Add(bookmark2, range2);
            range3.Text = "Grade : " + this.comboBoxGrade.Text;
            doc.Bookmarks.Add(bookmark3, range3);
            range4.Text = this.DateRecru.Value.ToString("d");
            doc.Bookmarks.Add(bookmark4, range4);
            if (this.comboBoxFSinitaire.Text != this.comboBoxFSinitaireAffRellFR.Text)
            {
                range5.Text = "provisoire";
                range15.Text = "مؤقت";
            }

            else
            {
                range5.Text = "";
                range15.Text = "";
            }
            doc.Bookmarks.Add(bookmark5, range5);
            doc.Bookmarks.Add(bookmark15, range15);
            if (this.comboBoxAffectation.Text == "Délégation" || this.comboBoxAffectation.Text == "SRES")
            {
                if (this.comboBoxAffectation.Text == "Délégation")
                range6.Text = "la"+" "+this.comboBoxAffectation.Text;
                else if (this.comboBoxAffectation.Text == "SRES")
                    range6.Text =this.comboBoxAffectation.Text;

                range11.Text = this.comboBoxAffectationAR.Text;
                range16.Text = "";
            }

            else
            {
                range6.Text = this.comboBoxFSinitaire.Text;
                range16.Text = this.comboBoxFSinitaireAR.Text;
                range11.Text = "";
            }
            doc.Bookmarks.Add(bookmark6, range6);
         doc.Bookmarks.Add(bookmark11, range11);
            doc.Bookmarks.Add(bookmark16, range16);

            range7.Text = this.txtFonctionFr.Text;
            doc.Bookmarks.Add(bookmark7, range7);

            ////Arabe:

            range8.Text = this.txtCin.Text;
            doc.Bookmarks.Add(bookmark8, range8);

            if (radioButtonMonsieur.Checked)
            {
                range9.Text = "سيد";
            }

            else
            {

                range9.Text = "سيدة";
            }
            doc.Bookmarks.Add(bookmark9, range9);

            range10.Text = this.DateRecru.Value.ToShortDateString(); 
            doc.Bookmarks.Add(bookmark10, range10);

              

            range12.Text = this.comboBoxGradeAR.Text;
            doc.Bookmarks.Add(bookmark12, range12);

            range13.Text = this.txtNomAr.Text + " " + this.txtPrenomAr.Text;
            doc.Bookmarks.Add(bookmark13, range13);

            range14.Text = this.txtPPR.Text;
            doc.Bookmarks.Add(bookmark14, range14);

            range17.Text = "يعمل";
            doc.Bookmarks.Add(bookmark17, range17);

            app.Documents.Open(Application.StartupPath + @"\Word\AttestationTravailAr.doc");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtArmoire_SelectedIndexChanged(object sender, EventArgs e)
        {
            troireDataTableBindingSource.DataSource = MyDataBase.remplircombo("Troire", "Liste_Tiroire", (Convert.ToInt32(this.TxtArmoire.SelectedValue)).ToString(), "@aromoir"); 
        }

        private void ajouterCongéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Congé.Ajouter_Congé congé = new Congé.Ajouter_Congé();
            congé.MdiParent = FormMenu.menu;
            congé.Show();
        }

        private void dataGridViewCongeAnuelle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = this.dataGridViewCongeAnuelle.CurrentRow.Index;
        if(e.ColumnIndex==5)
        {
            Congé.Modifier_Conge mc = new Congé.Modifier_Conge();
            mc.MdiParent = FormMenu.menu;
            mc.Show();
        }
        if (e.ColumnIndex == 6)
        {
            ca = new Congé_annuelle();
            
            DialogResult confirmer = MessageBox.Show("Voulez-vous vraiment supprimer conge ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmer == DialogResult.Yes)
            {
                
                ca.MAJ("delete_conge",null,int.Parse(this.dataGridViewCongeAnuelle.Rows[rowindex].Cells[0].Value.ToString()));
            
               
                    MessageBox.Show("Bien supprimer", "Pour votre information", MessageBoxButtons.OK, MessageBoxIcon.None);
                    afficher(Program.ppr);
            }
        }

        if (e.ColumnIndex == 7)
        {
            Congé.Mise_a_jour_conge majc= new Congé.Mise_a_jour_conge();
            majc.MdiParent = FormMenu.menu;
            majc.Show();
            //Program.conge = Convert.ToInt32(FormMajPers.maj.dataGridViewCongeAnuelle.Rows[rowindex].Cells[0].Value);
            //MessageBox.Show(Program.conge.ToString());
            
        }

        if (e.ColumnIndex == 8)
        {
            //int rowindex = FormMajPers.maj.dataGridViewCongeAnuelle.CurrentRow.Index;
            DialogResult confirmer = MessageBox.Show("Voulez-vous vraiment Reporter cet congé ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmer == DialogResult.Yes)
            {

                ca = new Congé_annuelle();
                ca.Etat_conge = this.dataGridViewCongeAnuelle.Rows[rowindex].Cells[2].Value.ToString() + " " + "jour reporter à " + " " + (Convert.ToInt32(FormMajPers.maj.dataGridViewCongeAnuelle.Rows[rowindex].Cells[1].Value) + 1).ToString();
                if (ca.MAJ("modifier_conger", "R", Convert.ToInt32(FormMajPers.maj.dataGridViewCongeAnuelle.Rows[rowindex].Cells[0].Value))) 
                {
                    MessageBox.Show("Modification Réussi", "Pour votre information", MessageBoxButtons.OK, MessageBoxIcon.None);
                    afficher(Program.ppr);
                }
            }
        }
            if(e.ColumnIndex == 9)
            {
                if (this.dataGridViewCongeAnuelle.Rows[rowindex].Cells[4].Value.ToString() == "Normale")
                {
                    MessageBox.Show("Il faut d'abord reporter ce congé", "Pour votre information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(Application.StartupPath + @"\\Word\\RepportConge.docx");
                    //Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(Application.StartupPath + @"\Word\Repportconge.doc");
                    string bookmark = "AFFECTATION";
                    string bookmark1 = "ANNEE";
                    string bookmark2 = "ANNEE_";
                    string bookmark3 = "ANNEE__";
                    string bookmark4 = "CiviliteNomPrenom";
                    string bookmark5 = "DUREE";

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

                    range.Text = this.comboBoxAffectation.Text;
                    doc.Bookmarks.Add(bookmark, range);

                    range1.Text = this.dataGridViewCongeAnuelle.Rows[rowindex].Cells[1].Value.ToString();
                    doc.Bookmarks.Add(bookmark1, range1);

                    range2.Text = (Convert.ToInt32(this.dataGridViewCongeAnuelle.Rows[rowindex].Cells[1].Value) + 1).ToString();
                    doc.Bookmarks.Add(bookmark2, range2);

                    range3.Text = (Convert.ToInt32(this.dataGridViewCongeAnuelle.Rows[rowindex].Cells[1].Value) + 1).ToString();
                    doc.Bookmarks.Add(bookmark3, range3);
                    if (radioButtonMlle.Checked)
                    {
                        range4.Text = this.radioButtonMlle.Text + "" + this.txtNomFr.Text + " " + this.txtPrenomFr.Text; ;
                    }
                    else if (radioButtonMme.Checked)
                    {
                        range4.Text = this.radioButtonMme.Text + "" + this.txtNomFr.Text + " " + this.txtPrenomFr.Text; ;
                    }
                    else if (radioButtonMonsieur.Checked)
                    {
                        range4.Text = this.radioButtonMonsieur.Text + "" + this.txtNomFr.Text + " " + this.txtPrenomFr.Text; ;
                    }
                    doc.Bookmarks.Add(bookmark4, range4);

                    range5.Text = this.dataGridViewCongeAnuelle.Rows[rowindex].Cells[2].Value.ToString();
                    doc.Bookmarks.Add(bookmark5, range5);



                    app.Documents.Open(Application.StartupPath + @"\Word\Repportconge.docx");
                }
               

            }
        

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NoteService ns = new NoteService();
            ns.MdiParent = FormMenu.menu;
            ns.Show();
        }

        private void txtPPR_OnValueChanged(object sender, EventArgs e)
        {
            this.txtPPR.BorderColorIdle = this.txtNomFr.BorderColorIdle;
        }
        OpenFileDialog fd= new OpenFileDialog();
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
            fd.Filter = "JPG Files(*.jpg)|*.jpg|all files(*.*)|*.*";
            fd.ShowDialog();
            image = fd.FileName.ToString();
            pictureBox1.ImageLocation = image;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.btnEnrg.Enabled = false;
            this.btnAttestation.Enabled = true;
            this.btnFiche.Enabled = true;
            this.btnNService.Enabled = true;
            this.btnRech.Enabled = true;
            this.btnSupp.Enabled = true;
            this.btnMod.Enabled = true;
            this.btnAnnuler.Enabled = false;

            //afficher(Agent.Min_ppr());

        }

        private void txtPPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
              
            }
            
            
               
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewCongeAnuelle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtmodifPPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try{
                if (String.IsNullOrEmpty(this.txtmodifPPR.Text))
                {
                    this.txtmodifPPR.BorderColorIdle = Color.Red;
                    MessageBox.Show("le champ Nouveau PPR est obligatoire");

                }
                else if(String.IsNullOrEmpty(this.txtPPR.Text))
                {
                    this.txtPPR.BorderColorIdle = Color.Red;
                    MessageBox.Show("le champ PPR est obligatoire");
                }
                else
                {
                    DialogResult confirmer = MessageBox.Show("Voulez-vous vraiment modifier ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmer == DialogResult.Yes)
                    {
                        ag.Ppr = Convert.ToInt32(this.txtPPR.Text);
                        ag.Noveauppr = Convert.ToInt32(this.txtmodifPPR.Text);

                        if (ag.MAJ("ModifierPPR"))
                        {
                            MessageBox.Show("Bien Modifier");
                            FormMajPers_Load(sender, e);
                            this.txtmodifPPR.ResetText();
                            this.txtmodifPPR.BorderColorIdle = this.txtCin.BorderColorIdle;
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Modification Annulé");
                    }
                }
            }
                catch(SqlException sqlex)
                {
                    if(sqlex.Number==2627)
                    {
                        MessageBox.Show("PPR déja existe", "Pour Votre Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

