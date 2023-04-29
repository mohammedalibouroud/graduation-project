using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace PrejetStage_Library
{
    public class Congé_annuelle
    {
        public Congé_annuelle()
        {

        }

        #region "champs"

        private int id_conge_annuel;
        private int annee_conge;
        private int nbre_jours;
        private int ppr;
        private String etat_conge;

        #endregion

        #region "propriétés"

        public int Id_conge_annuel
        {
            get { return id_conge_annuel; }
            set { id_conge_annuel = value; }
        }

        public int Annee_conge
        {
            get { return annee_conge; }
            set { annee_conge = value; }
        }

        public int Nbre_jours
        {
            get { return nbre_jours; }
            set { nbre_jours = value; }
        }

        public int Ppr
        {
            get { return ppr; }
            set { ppr = value; }
        }

        public String Etat_conge
        {
            get { return etat_conge; }
            set { etat_conge = value; }
        }

        #endregion


        public Congé_annuelle(int annee_conge, int nbre_jours, int ppr, string etat_conge)
        {

            this.annee_conge = annee_conge;
            this.nbre_jours = nbre_jours;
            this.ppr = ppr;
            this.etat_conge = etat_conge;


        }

        public bool MAJ(string sql, string filtre = null, int id = 0)
        {

            MyDataBase.connexion();
            SqlCommand cmd = new SqlCommand(sql, MyDataBase.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Id_conge_annuel ",id_conge_annuel);
            if (sql == "modifier_conger" || sql == "AjouterConge")
            {
                cmd.Parameters.AddWithValue("@Annee_conge", annee_conge);
                cmd.Parameters.AddWithValue("@Nbre_jours", nbre_jours);
                cmd.Parameters.AddWithValue("@PPR", ppr);
                cmd.Parameters.AddWithValue("@Etat_conge", etat_conge);
            }
            if (sql == "delete_conge")
            {
                cmd.Parameters.AddWithValue("@Id_conge_annuel", id);
            }
            if (sql == "modifier_conger")
            {
                cmd.Parameters.AddWithValue("@filtre", filtre);
                cmd.Parameters.AddWithValue("@Id_conge_annuel", id);
            }
            cmd.ExecuteNonQuery();

            return true;


        }

        public bool Date(string sql,DateTime date)
        {
             
            MyDataBase.connexion();
            SqlCommand cmd = new SqlCommand(sql, MyDataBase.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Id_conge_annuel ",id_conge_annuel);
            cmd.Parameters.AddWithValue("@date", date);

           SqlDataReader dr=cmd.ExecuteReader();
           if (dr.HasRows)
           {
               return true;
           }
           else
           {
               return false;
           }

          
        }
    }
}
