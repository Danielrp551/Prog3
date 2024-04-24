using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgDBManager
{
    public class DBManager
    {
        private MySqlConnection con;

        private static DBManager dbManager;
        private string url = "server="+ "db-prog3-softprog.cdvpmwunv4cu.us-east-1.rds.amazonaws.com;";
        private string user = "user=danielrp551;";
        private string password = "password=26deJULIO;";
        private string puerto = "port=3306;";
        private string database = "database=prog3_softprog;";

        public static DBManager Instance
        {
            get {
                if (dbManager == null)
                    createInstance();
                return dbManager;
            }
        }

        public static void createInstance()
        {
            if(dbManager == null)
                dbManager = new DBManager();
        }

        public MySqlConnection Connection
        {
            get
            {
                string cadena = url + user + password + puerto + database;
                con = new MySqlConnection(cadena);
                return con;
            }
        }
    }
}
