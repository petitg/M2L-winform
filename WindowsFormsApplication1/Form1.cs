using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=m2l;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            MySqlCommand maCommande = connection.CreateCommand();
           /* MySqlDataReader maLigne;
            maCommande.CommandText = "REQUETE";
            connecion.open();
            maLigne = maCommande.ExecuteReader);
            while(maLigne.read))
                                     * string[] valeurColonnes = new string[5];
                                     * for(int i =0; i< maLigne.ielCon;i++) valeuColonnes[i] = aLigne.getValue(i).ToString();
                                     * string nom = valeurColonnes[X]
                                     * connection.close();                         
                               */
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listAllAdherent maFenetre = new listAllAdherent();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void clubToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listAllClub maFenetre = new listAllClub();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListAllEvenement maFenetre = new ListAllEvenement();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void ajouterAdherentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutAdherent maFenetre = new AjoutAdherent();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

    }
}
