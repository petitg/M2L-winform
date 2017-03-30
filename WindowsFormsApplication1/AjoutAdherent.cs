using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AjoutAdherent : Form
    {
        public AjoutAdherent()
        {
            InitializeComponent();
        }

        private void AjoutAdherent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = tb_nom.Text;
            string prenom = tb_prenom.Text;
            char sexe;
                if(rb_femme.Checked)
                    sexe = char.Parse("F");
                else
                    sexe = char.Parse("M");
            string naissance = dtp_naissance.Text;
            string rueAdresse = tb_adresse.Text;
            string cp = tb_CP.Text;
            string ville = tb_ville.Text;
            int cotisation = int.Parse(tb_cotisation.Text);
            adherent unAdherent = new adherent(nom, prenom, sexe, naissance, rueAdresse, cp, ville, cotisation);
            DataBase.ajoutAdherent(unAdherent);
        }

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
            string nom = tb_nom.Text;
            string prenom = tb_prenom.Text;
            char sexe;
            if (rb_femme.Checked)
                sexe = char.Parse("F");
            else
                sexe = char.Parse("M");
            string naissance = dtp_naissance.Text;
            string rueAdresse = tb_adresse.Text;
            string cp = tb_CP.Text;
            string ville = tb_ville.Text;
            int cotisation = int.Parse(tb_cotisation.Text);
            adherent unAdherent = new adherent(nom, prenom, sexe, naissance, rueAdresse, cp, ville, cotisation);
            DataBase.ajoutAdherent(unAdherent);
        }


    }
}
