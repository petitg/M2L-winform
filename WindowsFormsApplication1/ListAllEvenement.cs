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
    public partial class ListAllEvenement : Form
    {
        public ListAllEvenement()
        {
            InitializeComponent();
        }

        private void ListAllEvenement_Load(object sender, EventArgs e)
        {
            List<evenement> listeevenement = DataBase.recupEvenement();

            foreach(evenement uneven in listeevenement)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = uneven.getId().ToString();;
                laLigne.SubItems.Add(uneven.getNom());
                laLigne.SubItems.Add(uneven.getType());
                laLigne.SubItems.Add(uneven.getdateDebut());
                laLigne.SubItems.Add(uneven.getdateFin());
                laLigne.SubItems.Add(uneven.getadresse());
                laLigne.SubItems.Add(uneven.getidclub().ToString());;
                laLigne.SubItems.Add(uneven.getId().ToString());
                lvevent.Items.Add(laLigne);
            }
        }

        private void lvClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
