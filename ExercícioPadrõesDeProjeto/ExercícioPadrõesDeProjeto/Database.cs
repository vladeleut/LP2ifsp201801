using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExercícioPadrõesDeProjeto
{
    class Database
    {
        private static MySqlConnection conn;
        private static Database instance;

        private Database()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = biblioteca; Uid = root; Pwd = admin;";
        }
        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
        public MySqlConnection GetConnection()
        {
            return conn;
        }
        public void ExecuteSQL(string qry)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        
        
        
    }
}
