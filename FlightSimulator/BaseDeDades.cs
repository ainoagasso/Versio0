using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;

namespace FlightSimulator

{
    public class BaseDeDades 
    {
        private SQLiteConnection cnx;

        public void Iniciar()
        {
            string dataSource = "Data Source=usuaris.db";
            cnx = new SQLiteConnection(dataSource);
            cnx.Open();

            string sqlTabla = "CREATE TABLE IF NOT EXISTS usuaris (username varchar PRIMARY KEY, contrasenya VARCHAR);";
            SQLiteCommand cmd = new SQLiteCommand(sqlTabla, cnx);
            int rows = cmd.ExecuteNonQuery();
          
        }

        public int IniciSessio(string username, string contrasenya)
        {

            DataTable dt = new DataTable();
            string sqlselect = "SELECT * FROM usuaris WHERE username = '" + username + "'";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sqlselect, cnx);
            int rows1 = adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string password = Convert.ToString(dt.Rows[0]["contrasenya"]);
                if (password == contrasenya)
                    return 1;
                else
                    return 2;
            }
            else
            {
                string sqlinsert = "INSERT INTO usuaris VALUES ('" + username + "', '" + contrasenya + "')";
                SQLiteCommand command = new SQLiteCommand(sqlinsert, cnx);
                int rows2 = command.ExecuteNonQuery();
                return 0;
            }

        }
         public void Cerrar()
        {
            cnx.Close();
        }


    }
}

