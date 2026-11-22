using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FlightSimulator

{
    public class BaseDeDades 
    {
        private SQLiteConnection cnx; //"connexió"

        public void Iniciar()
        {
            string dataSource = "Data Source=usuaris.db"; //arxiu on es guardaran les dades
            cnx = new SQLiteConnection(dataSource); //connectem amb l'arxiu
            cnx.Open(); //obrim connexió

            // PRIMARY KEY és la clau primària, no pot haver-hi dos usuaris amb el mateix nom
            string sqlTabla = "CREATE TABLE IF NOT EXISTS usuaris (username varchar PRIMARY KEY, contrasenya VARCHAR);";
            SQLiteCommand cmd = new SQLiteCommand(sqlTabla, cnx);
            int rows = cmd.ExecuteNonQuery();
          
        }

        public int IniciSessio(string username, string contrasenya)
        {

            DataTable dt = new DataTable(); //creem una taula temporal per guardar el resultat
            string sqlselect = "SELECT * FROM usuaris WHERE username = '" + username + "'"; //busquem si ja existeix un usuari amb aquest nom el "'" del final només pq es string
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sqlselect, cnx);
            int rows1 = adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string password = Convert.ToString(dt.Rows[0]["contrasenya"]); //agafem la contrasenya per mirar si coincideix
                if (password == contrasenya)
                    return 1;
                else
                    return 2;
            }
            else //si no hem trobat cap fila, es usuari nou
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


//coses rares de BLO4

//SELECT count(*) FROM clientes;
//SELECT* FROM clientes WHERE edad>18 ORDER BY edad ASC;
//SELECT* FROM clientes WHERE edad>18 ORDER BY edad DESC;
//SELECT* FROM clientes WHERE edad>18 AND edad <30;
//SELECT* FROM clientes WHERE DNI=’1111111111H’;
//SELECT* FROM clientes WHERE nombre LIKE ‘j%’;
//SELECT* FROM clients WHERE DNI LIKE ‘%H’;
//SELECT max(edad) FROM clientes;
//INSERT INTO clientes VALUES (‘22222222T’, ‘enric’,25);
//UPDATE clientes SET nombre=’pep’ WHERE DNI=‘22222222T’;
//UPDATE clientes SET edad=edad+1 WHERE DNI=‘22222222T’;
//DELETE FROM clientes WHERE DNI=‘22222222T’ and edad<18;
//DELETE FROM clientes WHERE DNI=‘22222222T’;
