using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConeccionMySql.Clases
{
    internal class CConexion
    {
        MySqlConnection connex = new MySqlConnection();
        static string servidor = "localhost";
        static string db = "bdmysql";
        static string usuario = "root";
        static string password = " ";
        static string port = "3306";


        string cadenaConexion = "server =" + servidor + ";" + "port=" + port + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + db + ";";
        public MySqlConnection mysqlconnexion()
        {
            try {
                connex.ConnectionString = cadenaConexion;
                connex.Open();
                MessageBox.Show("Se conectó a la Data base...");

            
            }
            catch (MySqlException e){
                MessageBox.Show("Imposible conectar a la Base de datos... Error:"+e.ToString());
            }
            return connex;

        }

    }
}
