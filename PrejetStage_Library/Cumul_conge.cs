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
   public class Cumul_conge
    {
        private int id_cumul;

        public int Id_cumul
        {
            get { return id_cumul; }
            set { id_cumul = value; }
        }
        private DateTime date_depart;

        public DateTime Date_depart
        {
            get { return date_depart; }
            set { date_depart = value; }
        }

        private int duree;

        public int Duree
        {
            get { return duree; }
            set { duree = value; }
        }


        private DateTime date_retour;

        public DateTime Date_retour
        {
            get { return date_retour; }
            set { date_retour = value; }
        }

        private string disponibilite;

        public string Disponibilite
        {
            get { return disponibilite; }
            set { disponibilite = value; }
        }
        private string observation;

        public string Observation
        {
            get { return observation; }
            set { observation = value; }
        }
        private int conge;

        public int Conge
        {
            get { return conge; }
            set { conge = value; }
        }
        private int numDecision;

        public int NumDecision
        {
            get { return numDecision; }
            set { numDecision = value; }
        }
        private DateTime dateDecision;

        public DateTime DateDecision
        {
            get { return dateDecision; }
            set { dateDecision = value; }
        }
        private DateTime dateCessationSvc;

        public DateTime DateCessationSvc
        {
            get { return dateCessationSvc; }
            set { dateCessationSvc = value; }
        }
        private DateTime dateRepriseSvc;

        public DateTime DateRepriseSvc
        {
            get { return dateRepriseSvc; }
            set { dateRepriseSvc = value; }
        }
        private bool congeEtranger;

        public bool CongeEtranger
        {
            get { return congeEtranger; }
            set { congeEtranger = value; }
        }

        public Cumul_conge()
        {

        }

        public bool MAJ(string sql)
        {

            MyDataBase.connexion();
            SqlCommand cmd = new SqlCommand(sql, MyDataBase.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (sql != "delete_cumul" && sql != "Modifier_cumuls")
            {
                cmd.Parameters.AddWithValue("@Date_depart", date_depart);
                cmd.Parameters.AddWithValue("@Duree", duree);
                cmd.Parameters.AddWithValue("@Date_retour", date_retour);
                cmd.Parameters.AddWithValue("@Disponibilite", disponibilite);
                cmd.Parameters.AddWithValue("@Observation", observation);
                cmd.Parameters.AddWithValue("@Conge", conge);
                cmd.Parameters.AddWithValue("@CongeEtranger", congeEtranger);
            }
            if (sql == "Modifier_cumuls")
            {
                cmd.Parameters.AddWithValue("@NumDecision", numDecision);
                cmd.Parameters.AddWithValue("@DateDecision", dateDecision);
                cmd.Parameters.AddWithValue("@DateCessationSvc", dateCessationSvc);
                cmd.Parameters.AddWithValue("@DateRepriseSvc", dateRepriseSvc);
                cmd.Parameters.AddWithValue("@Id_cumul", id_cumul);

            }

            if (sql == "delete_cumul")
            {
                cmd.Parameters.AddWithValue("@Id_cumul",id_cumul);
        }
            cmd.ExecuteNonQuery();

            return true;
        }

        public DataTable cumul(string sql)
        {
            DataTable dt_cumul = new DataTable();
            MyDataBase.connexion();
            SqlCommand cmd = new SqlCommand(sql, MyDataBase.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@conge", conge);
            dt_cumul.Load(cmd.ExecuteReader());

            return dt_cumul;
        }

    }
}
