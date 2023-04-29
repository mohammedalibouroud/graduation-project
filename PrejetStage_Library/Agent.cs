using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace PrejetStage_Library
{
   public class Agent
   {
       #region "champs"
       private int noveauppr;

       public int Noveauppr
       {
           get { return noveauppr; }
           set { noveauppr = value; }
       }

        private int ppr;

        private string nomfr;
        
        private string prenomfr;

        private string nomAr;
       
        private string prenomAr;
        
        private string cin;
      
        private string adresseFR;
      
        private string adresseAR;
       
        private string fonctionFR;
   
        private string fonctionAR;
      
        private string sexe;
       
        private string civilite;
      
        private int grade;

        private int cadre;

        public int Cadre
        {
            get { return cadre; }
            set { cadre = value; }
        }
       // private String grade1;

        //public String Grade1
        //{
        //    get { return grade1; }
        //    set { grade1 = value; }
        //}

        private int specialite;
        //private String specialite1;

        //public String Specialite1
        //{
        //    get { return specialite1; }
        //    set { specialite1 = value; }
        //}

        private DateTime dn;
        
        private DateTime dr;
        
        private DateTime da;
        
        private int affectation_ministerielle;
        //private String affectation_ministerielle1;

        //public String Affectation_ministerielle1
        //{
        //    get { return affectation_ministerielle1; }
        //    set { affectation_ministerielle1 = value; }
        //}

        private string situantion_familiale;
      
        private int nombre_enfants;
       
        private string telephone;
      
        private int tiroire;
        //private String tiroire1;

        //public String Tiroire1
        //{
        //    get { return tiroire1; }
        //    set { tiroire1 = value; }
        //}
       
        private int numeroDossier;
        
        private DateTime datePremierLieu;
       
        private DateTime datePosteActuel;
       
        private int premierLieuAffectation;
       //private string premierLieuAffectation1;

//public string PremierLieuAffectation1
//{
//  get { return premierLieuAffectation1; }
//  set { premierLieuAffectation1 = value; }
//}
       
        private int affectation_relle;
//        private string affectation_relle1;

//public string Affectation_relle1
//{
//  get { return affectation_relle1; }
//  set { affectation_relle1 = value; }
//}
       
        private string numMutuelle;
      
        private int position;
//       private string position1;

//public string Position1
//{
//  get { return position1; }
//  set { position1 = value; }
//}
      
        private string conjoint;
     
        private string fonctionConj;
        
        private string villeAffectConjoint;

        private byte[] photo;

     
       
        private string syndicat;
       
        private Boolean supprimer;

        private int entite;

        public int Entite
        {
            get { return entite; }
            set { entite = value; }
        }

        private int affectation;

        public int Affectation
        {
            get { return affectation; }
            set { affectation = value; }
        }

        private int entite1;

        public int Entite1
        {
            get { return entite1; }
            set { entite1 = value; }
        }
        private int affectation1;

        public int Affectation1
        {
            get { return affectation1; }
            set { affectation1 = value; }
        }
        private int entite2;

        public int Entite2
        {
            get { return entite2; }
            set { entite2 = value; }
        }
        private int affectation2;

        public int Affectation2
        {
            get { return affectation2; }
            set { affectation2 = value; }
        }

        private int armoire;

        public int Armoire
        {
            get { return armoire; }
            set { armoire = value; }
        }


       #endregion


       #region "propriétés"

        public int Ppr
   {
       get { return ppr; }
       set { ppr = value; }
   }

   public string Nomfr
   {
       get { return nomfr; }
       set { nomfr = value; }
   }

   public string Prenomfr
   {
       get { return prenomfr; }
       set { prenomfr = value; }
   }

   public string NomAr
   {
       get { return nomAr; }
       set { nomAr = value; }
   }

   public string PrenomAr
   {
       get { return prenomAr; }
       set { prenomAr = value; }
   }

   public string Cin
   {
       get { return cin; }
       set { cin = value; }
   }

   public string AdresseFR
   {
       get { return adresseFR; }
       set { adresseFR = value; }
   }

   public string AdresseAR
   {
       get { return adresseAR; }
       set { adresseAR = value; }
   }

   public string FonctionFR
   {
       get { return fonctionFR; }
       set { fonctionFR = value; }
   }

   public string FonctionAR
   {
       get { return fonctionAR; }
       set { fonctionAR = value; }
   }

   public string Sexe
   {
       get { return sexe; }
       set { sexe = value; }
   }

   public string Civilite
   {
       get { return civilite; }
       set { civilite = value; }
   }

   public int Grade
   {
       get { return grade; }
       set { grade = value; }
   }

   public int Specialite
   {
       get { return specialite; }
       set { specialite = value; }
   }

   public DateTime Dn
   {
       get { return dn; }
       set { dn = value; }
   }

   public DateTime Dr
   {
       get { return dr; }
       set { dr = value; }
   }

   public DateTime Da
   {
       get { return da; }
       set { da = value; }
   }

   public int Affectation_ministerielle
   {
       get { return affectation_ministerielle; }
       set { affectation_ministerielle = value; }
   }

   public string Situantion_familiale
   {
       get { return situantion_familiale; }
       set { situantion_familiale = value; }
   }

   public int Nombre_enfants
   {
       get { return nombre_enfants; }
       set { nombre_enfants = value; }
   }

   public string Telephone
   {
       get { return telephone; }
       set { telephone = value; }
   }

   public int Tiroire
   {
       get { return tiroire; }
       set { tiroire = value; }
   }

   public int NumeroDossier
   {
       get { return numeroDossier; }
       set { numeroDossier = value; }
   }

   public DateTime DatePremierLieu
   {
       get { return datePremierLieu; }
       set { datePremierLieu = value; }
   }

   public DateTime DatePosteActuel
   {
       get { return datePosteActuel; }
       set { datePosteActuel = value; }
   }

   public int PremierLieuAffectation
   {
       get { return premierLieuAffectation; }
       set { premierLieuAffectation = value; }
   }

   public int Affectation_relle
   {
       get { return affectation_relle; }
       set { affectation_relle = value; }
   }

   public string NumMutuelle
   {
       get { return numMutuelle; }
       set { numMutuelle = value; }
   }

   public int Position
   {
       get { return position; }
       set { position = value; }
   }

   public string Conjoint
   {
       get { return conjoint; }
       set { conjoint = value; }
   }

   public string FonctionConj
   {
       get { return fonctionConj; }
       set { fonctionConj = value; }
   }

   public string VilleAffectConjoint
   {
       get { return villeAffectConjoint; }
       set { villeAffectConjoint = value; }
   }

   public byte[] Photo
   {
       get { return photo; }
       set { photo = value; }
   }

   public string Syndicat
   {
       get { return syndicat; }
       set { syndicat = value; }
   }

   public Boolean Supprimer
   {
       get { return supprimer; }
       set { supprimer = value; }
   }
   #endregion

   public Agent()
   {

   }



   public Agent(int ppr,String sql)
        {
            DataTable dt = new DataTable();
            MyDataBase.connexion();
            SqlCommand cmd = new SqlCommand(sql,MyDataBase.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ppr", ppr);
            dt.Load(cmd.ExecuteReader());
            this.ppr = Convert.ToInt32(dt.Rows[0][0]);
            nomfr = dt.Rows[0][1].ToString();
            prenomfr = dt.Rows[0][2].ToString();
            NomAr=dt.Rows[0][3].ToString();
prenomAr=dt.Rows[0][4].ToString();
cin=dt.Rows[0][5].ToString();
adresseFR=dt.Rows[0][6].ToString();
adresseAR=dt.Rows[0][7].ToString();
fonctionFR = dt.Rows[0][8].ToString(); 

fonctionAR = dt.Rows[0][9].ToString(); 

sexe = dt.Rows[0][10].ToString(); 

civilite = dt.Rows[0][11].ToString();

grade =int.Parse(dt.Rows[0][12].ToString());

specialite = int.Parse(dt.Rows[0][13].ToString());

dn = Convert.ToDateTime(dt.Rows[0][14]); 

dr = Convert.ToDateTime(dt.Rows[0][15]); 

da = Convert.ToDateTime(dt.Rows[0][16]); 

affectation_ministerielle =int.Parse( dt.Rows[0][17].ToString()); 

situantion_familiale = dt.Rows[0][18].ToString(); 

nombre_enfants = Convert.ToInt32(dt.Rows[0][19]); 

telephone = dt.Rows[0][20].ToString();

tiroire = int.Parse(dt.Rows[0][21].ToString()); 

numeroDossier = Convert.ToInt32(dt.Rows[0][22]); 

datePremierLieu = Convert.ToDateTime(dt.Rows[0][23]); 

datePosteActuel = Convert.ToDateTime(dt.Rows[0][24]); 

premierLieuAffectation =int.Parse(dt.Rows[0][25].ToString());

affectation_relle = int.Parse(dt.Rows[0][26].ToString()); 

numMutuelle = dt.Rows[0][27].ToString(); 

position =int.Parse(dt.Rows[0][28].ToString()); 

conjoint = dt.Rows[0][29].ToString(); 

fonctionConj = dt.Rows[0][30].ToString(); 

villeAffectConjoint = dt.Rows[0][31].ToString();

//photo = Encoding.ASCII.GetBytes(dt.Rows[0][32].ToString());

photo = (byte[])dt.Rows[0][32];

syndicat = dt.Rows[0][33].ToString(); 

supprimer = Convert.ToBoolean(dt.Rows[0][34]); 
       cmd.Dispose();
      
       cmd = new SqlCommand("RecupererCadre", MyDataBase.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("grade", grade);
            DataTable dt2 = new DataTable();
            dt2.Load(cmd.ExecuteReader());
            cadre =int.Parse(dt2.Rows[0][0].ToString());

           
           SqlCommand cmd2 = new SqlCommand("RecupererAffectationEntite", MyDataBase.cn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("fs",affectation_ministerielle);
            DataTable dt3 = new DataTable();
            dt3.Load(cmd2.ExecuteReader());
            affectation = int.Parse(dt3.Rows[0][0].ToString());
            entite = int.Parse(dt3.Rows[0][1].ToString());

            SqlCommand cmd3 = new SqlCommand("RecupererAffectationEntite", MyDataBase.cn);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("fs", affectation_relle);
            DataTable dt4 = new DataTable();
            dt4.Load(cmd3.ExecuteReader());
            affectation1 = int.Parse(dt4.Rows[0][0].ToString());
            entite1 = int.Parse(dt4.Rows[0][1].ToString());

            SqlCommand cmd4 = new SqlCommand("RecupererAffectationEntite", MyDataBase.cn);
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.Parameters.AddWithValue("fs", premierLieuAffectation);
            DataTable dt5 = new DataTable();
            dt5.Load(cmd4.ExecuteReader());
            affectation2 = int.Parse(dt5.Rows[0][0].ToString());
            entite2 = int.Parse(dt5.Rows[0][1].ToString());

            SqlCommand cmd5 = new SqlCommand("recuperer_aramoir ", MyDataBase.cn);
            cmd5.CommandType = CommandType.StoredProcedure;
            cmd5.Parameters.AddWithValue("@tiroire", tiroire);
            DataTable dt6 = new DataTable();
            dt6.Load(cmd5.ExecuteReader());
            armoire = int.Parse(dt6.Rows[0][0].ToString());
            //entite2 = int.Parse(dt6.Rows[0][1].ToString());

                   MyDataBase.deconnexion();
            
        }

  

   public bool MAJ(string sql)
   {
       
       MyDataBase.connexion();
       SqlCommand cmd = new SqlCommand(sql, MyDataBase.cn);
       cmd.CommandType = CommandType.StoredProcedure;
       if (sql != "ModifierPPR")
       {
           cmd.Parameters.AddWithValue("@PPR", ppr);

           if (sql == "Modifier_Agent" || sql == "Ajouter_Agent")
           {
               cmd.Parameters.AddWithValue("@NOMFR", nomfr);
               cmd.Parameters.AddWithValue("@PRENOMFR", prenomfr);
               cmd.Parameters.AddWithValue("@NomAr", nomAr);
               cmd.Parameters.AddWithValue("@PrenomAr", prenomAr);
               cmd.Parameters.AddWithValue("@Cin", cin);
               cmd.Parameters.AddWithValue("@ADRESSEFR", adresseFR);
               cmd.Parameters.AddWithValue("@AdresseAR", adresseAR);
               cmd.Parameters.AddWithValue("@FONCTIONFR", fonctionFR);
               cmd.Parameters.AddWithValue("@FonctionAR", fonctionAR);
               cmd.Parameters.AddWithValue("@SEXE", sexe);
               cmd.Parameters.AddWithValue("@CIVILITE", civilite);
               cmd.Parameters.AddWithValue("@GRADE", grade);
               cmd.Parameters.AddWithValue("@SPECIALITE", specialite);
               cmd.Parameters.AddWithValue("@DN", dn);
               cmd.Parameters.AddWithValue("@DR", dr);
               cmd.Parameters.AddWithValue("@DA", da);
               cmd.Parameters.AddWithValue("@Affectation_Ministerielle", affectation_ministerielle);
               cmd.Parameters.AddWithValue("@SITUATION_FAMILIALE", situantion_familiale);
               cmd.Parameters.AddWithValue("@NOMBRE_ENFANTS", nombre_enfants);
               cmd.Parameters.AddWithValue("@TELEPHONE", telephone);
               cmd.Parameters.AddWithValue("@Tiroire", tiroire);
               cmd.Parameters.AddWithValue("@NumeroDossier", numeroDossier);
               cmd.Parameters.AddWithValue("@DatePremierLieu", datePremierLieu);
               cmd.Parameters.AddWithValue("@DatePosteActuel", datePosteActuel);
               cmd.Parameters.AddWithValue("@PremierLieuAffectation", premierLieuAffectation);
               cmd.Parameters.AddWithValue("@Affectation_relle", affectation_relle);
               cmd.Parameters.AddWithValue("@NumMutuelle", numMutuelle);
               cmd.Parameters.AddWithValue("@Position", position);
               cmd.Parameters.AddWithValue("@Conjoint", conjoint);
               cmd.Parameters.AddWithValue("@FonctionConj", fonctionConj);
               cmd.Parameters.AddWithValue("@VilleAffectConjoint", villeAffectConjoint);
               cmd.Parameters.AddWithValue("@Photo", photo);
           }
       }
       if (sql=="ModifierPPR")
       {
           cmd.Parameters.AddWithValue("@APPR", ppr);
           cmd.Parameters.AddWithValue("@NPPR",noveauppr);
       }
       

       cmd.ExecuteNonQuery();

       return true;       
   }

   public DataTable rechercher(string sql)
   {
       DataTable dt_recherche = new DataTable();
       MyDataBase.connexion();
       SqlCommand cmd = new SqlCommand(sql, MyDataBase.cn);
       cmd.CommandType = CommandType.StoredProcedure;
       string p;
       if (ppr == 0)
           p = null;
       else
           p = ppr.ToString();

       if (nomfr == "")
           nomfr = null;
       if (prenomfr == "")
           prenomfr = null;
       if (nomAr == "")
           nomAr = null;
       if (prenomAr == "")
           prenomAr = null;

       cmd.Parameters.AddWithValue("@ppr", p);
       cmd.Parameters.AddWithValue("@nomfr", nomfr);
       cmd.Parameters.AddWithValue("@prenomfr ", prenomfr);
       cmd.Parameters.AddWithValue("@nomar", nomAr);
       cmd.Parameters.AddWithValue("@prenomar", prenomAr);
       
       dt_recherche.Load(cmd.ExecuteReader());
       return dt_recherche;
   }

   public static int Min_ppr()
   {
       DataTable dt_ppr = new DataTable();
       
       MyDataBase.connexion();
       SqlCommand cmd = new SqlCommand("Min_ppr", MyDataBase.cn);
       cmd.CommandType = CommandType.StoredProcedure;

       SqlParameter minppr = new SqlParameter();
       minppr.ParameterName = "@ppr";
       minppr.SqlDbType = SqlDbType.Int;
       minppr.Direction = ParameterDirection.Output;


       cmd.Parameters.Add(minppr);

      
       cmd.ExecuteScalar();

     int min= int.Parse(cmd.Parameters["@ppr"].Value.ToString());
     MyDataBase.deconnexion();
       return min;
   }

            
   }
}
