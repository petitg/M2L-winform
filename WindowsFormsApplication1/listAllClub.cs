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
    public partial class listAllClub : Form
    {
        public listAllClub()
        {
            InitializeComponent();
        }

        private void listAllClub_Load(object sender, EventArgs e)
        {
            List<club> listeclub = DataBase.recupClub();

            foreach (club unclub in listeclub)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unclub.getNom();
                laLigne.SubItems.Add(unclub.getSite());
                laLigne.SubItems.Add(unclub.getAdresse());
                laLigne.SubItems.Add(unclub.getTelephone());
                laLigne.SubItems.Add(unclub.getEmail());
                laLigne.SubItems.Add(unclub.getType());
                laLigne.SubItems.Add(unclub.getId().ToString());
                lvClub.Items.Add(laLigne);
            }
        }

        private void lvClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
