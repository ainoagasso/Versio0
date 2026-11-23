using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite; 

namespace FlightSimulator
{
    public partial class Registre : Form
    {
        BaseDeDades base1 = new BaseDeDades();
        public Registre()
        {
            InitializeComponent();
        }

        private void Registre_Load(object sender, EventArgs e)
        {
            base1.Iniciar();
        }

        private void IniciarSessio_Click(object sender, EventArgs e)
        {
            string username = textBoxUsuari.Text;
            string contrasenya = textBoxContra.Text;

            int resultat = base1.IniciSessio(username, contrasenya);
            if (resultat == 1)
            {
                MessageBox.Show("Inici de sessió correcte.");
                base1.Cerrar();
                            
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            else if (resultat == 2)
            {
                MessageBox.Show("Usuari o contrasenya incorrectes.");
            }
            else if (resultat == 0)
            {
                MessageBox.Show("No estaves registrat. Afegit com a nou usuari.");
                MenuForm form1 = new MenuForm();
                form1.ShowDialog();
                this.Close();
            }
        }
            

        
    }
}
