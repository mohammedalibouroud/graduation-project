using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ProjetStage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static int ppr;
        public static string NomComplet="";
        public static int duree;
        public static DateTime depart;
        public static DateTime fin;
        
        //public static int conge;


        public static string ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();
        public static DataTable dt;
        public static SqlConnection cn;
        public static SqlCommand cmd;

        public static void connexion(String sql, CommandType cmdtype)
        {
            cn = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(sql, cn);
            cmd.CommandType = cmdtype;
            
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        public static void deconnexion()
        {
            cn = new SqlConnection(ConnectionString);
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public static DataTable remplir_combo(CommandType ct, String query)
        {
            dt = new DataTable();
            connexion(query, ct);
            dt.Load(cmd.ExecuteReader());
            return dt;
           
        }

        public static DataTable remplir_combo1(CommandType ct, String query,String var,string value)
        {
            dt = new DataTable();
            connexion(query, ct);
            cmd.Parameters.AddWithValue(var,value);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

      
    }
}
