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
    public partial class listAllAdherent : Form
    {
        public listAllAdherent()
        {
            InitializeComponent();
        }

        private void listAllAdherent_Load(object sender, EventArgs e)
        {
            List<adherent> listeAdherent = DataBase.recupAdherent();
           
            foreach(adherent unAdh in listeAdherent)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unAdh.getNom();
                laLigne.SubItems.Add(unAdh.getPrenom());
                laLigne.SubItems.Add(unAdh.getSexe().ToString());
                laLigne.SubItems.Add(unAdh.getDateNaissance());
                laLigne.SubItems.Add(unAdh.getRueAdresse());
                laLigne.SubItems.Add(unAdh.getVille());
                laLigne.SubItems.Add(unAdh.getCp());
                laLigne.SubItems.Add(unAdh.getCotisation().ToString());
                lvAdherent.Items.Add(laLigne);

            } 

        }
    }
}
