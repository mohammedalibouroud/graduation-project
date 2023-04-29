using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PrejetStage_Library
{
    public class MyDataBase
    {
        public MyDataBase()
        {

        }

        
     static   DataTable dt;
   public static SqlConnection cn;
     static SqlCommand cmd;
       
        public static void connexion()
     {
             
            string ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            cn = new SqlConnection(ConnectionString);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        public static void deconnexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public static DataTable remplircombo(string table, string sql,string champ = null, string var = null)
        {
            DataSet ds=new DsProjet();
            dt = ds.Tables[table];
            connexion();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;
            if (champ != null && var != null)
            {
                cmd.Parameters.AddWithValue(var, champ); 
            }
           
            dt.Load(cmd.ExecuteReader());
            return dt;
            
        }

        public static DataTable remplirGrade(int idCadre)
        {
            DataSet ds = new DsProjet();
            dt = ds.Tables["Grade"];
            connexion();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "liste_grade";
            cmd.Parameters.AddWithValue("@cadre",idCadre);
            dt.Load(cmd.ExecuteReader());
            return dt;

        }

        public static DataTable remplirSpecialte(int idCadre)
        {
            DataSet ds = new DsProjet();
            dt = ds.Tables["Specialite"];
            connexion();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "liste_specialite";
            cmd.Parameters.AddWithValue("@cadre", idCadre);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public static DataTable fiche_renseignement(int ppr)
        {
            connexion();
            DataSet ds = new DataSetRensein();
            DataTable dt = ds.Tables["Fiche_Renseignement"];
            cmd = new SqlCommand("Fiche_Renseignement", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ppr", ppr);
            //dt = ds.Tables["Fiche_Renseignement"];
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, ds.Tables["Fiche_Renseignement"].TableName);
           // dt = ds.Tables["Fiche_Renseignement"];
            
            return dt;
        }

        public static DataTable Conge_Annuelle(string sql,int ppr)
        {
            DataTable dt_conge = new DataTable();
            MyDataBase.connexion();
            SqlCommand cmd = new SqlCommand(sql, MyDataBase.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ppr", ppr);
            dt_conge.Load(cmd.ExecuteReader());

            return dt_conge;
        }

        public static bool Log_In(string sql,string login,string password)
        {

            MyDataBase.connexion();
            SqlCommand cmd = new SqlCommand(sql, MyDataBase.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader dr = cmd.ExecuteReader();
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
