using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DataBase
    {
        public static string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=m2l;" + "UID=root;" + "PASSWORD=;";
        public static MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
        
        // recupere la lise des adherent  + DEfINIr ADHERENT 
        public static List<adherent> recupAdherent()
        {
            List<adherent> TableAdherent = new List<adherent>();

            MySqlCommand maCommande = connection.CreateCommand();
           //
            MySqlDataReader maLigne;
            maCommande.CommandText = "select * from adherent";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[9];
                for (int i=0; i<maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                int id = int.Parse(valeurColonnes[0]);
                string nom = valeurColonnes[1];
                string prenom = valeurColonnes[2];
                char sexe = char.Parse(valeurColonnes[3]);
                string date = valeurColonnes[4];
                string adress = valeurColonnes[5];
                string cp = valeurColonnes[6];
                string ville = valeurColonnes[7];
                int cotisation = int.Parse(valeurColonnes[8]);
                
                // remplacer dès que l'objet adérent est fait
                adherent adhe = new adherent(id, nom, prenom, sexe, date, adress, cp , ville , cotisation);
                TableAdherent.Add(adhe);
            }//
            connection.Close();
            return TableAdherent;
        }

        public static List<club> recupClub()
        {
            List<club> Tableclub = new List<club>();
            MySqlCommand maCommande = connection.CreateCommand();
            //
            MySqlDataReader maLigne;
            maCommande.CommandText = "select * from club";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[7];
                for (int i=0; i<maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                string nom = valeurColonnes[0];
                string site = valeurColonnes[1];
                string adress = valeurColonnes[2];
                string telephone = valeurColonnes[3];
                string mail = valeurColonnes[4];
                string type = valeurColonnes[5];
                int id = int.Parse(valeurColonnes[6]);

                club clu = new club(nom, site, adress, telephone, mail, type, id);
                Tableclub.Add(clu);

            }
            connection.Close();
            return Tableclub;

        }   
        
         public static List<evenement> recupEvenement()
        {
            List<evenement> TableEvenement = new List<evenement>();
             MySqlCommand maCommande = connection.CreateCommand();
            //
            MySqlDataReader maLigne;
            maCommande.CommandText = "select * from evenement";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[7];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                int id = int.Parse(valeurColonnes[0]);
                string nom = valeurColonnes[1];
                string type = valeurColonnes[2];
                string datedebut = valeurColonnes[3];
                string datefin = valeurColonnes[4];
                string adresse = valeurColonnes[5];
                int idclub = int.Parse(valeurColonnes[6]);

                evenement even = new evenement(id, nom, type, datedebut, datefin, adresse, idclub);
                TableEvenement.Add(even);
            }
            connection.Close();
            return TableEvenement;
        }

         public static void ajoutAdherent(adherent unAdherent)
         {
             MySqlCommand maCommande = connection.CreateCommand();
             maCommande.CommandText = "insert into `adherent` (`nom`, `prenom`, `sexe`, `naissance`, `rueAdresse`, `cp`, `ville`, `cotisation`) values ( '" + unAdherent.getNom() + "','" + unAdherent.getPrenom() + "','" + unAdherent.getSexe() + "','" + unAdherent.getDateNaissance() + "','" + unAdherent.getRueAdresse() + "','" + unAdherent.getCp() + "','" + unAdherent.getVille() + "','" + unAdherent.getCotisation() + "')";
             connection.Open();
             maCommande.ExecuteReader();
             connection.Close();
         }

          public static void ajoutClub(club unClub)
          {
             MySqlCommand maCommande = connection.CreateCommand();
             maCommande.CommandText = "insert into 'club' ('nom', 'site', 'adresse', telephone, email, type) values ( '" + unClub.getNom() + "', '" + unClub.getSite() + "','" + unClub.getAdresse() + "','" + unClub.getTelephone() + "','" + unClub.getEmail() + "','" + unClub.getType() + "')";
             connection.Open();
             maCommande.ExecuteReader();
             connection.Close();
          }

          public static void ajoutevenement(evenement unevenement)
          {
              MySqlCommand maCommande = connection.CreateCommand();
              maCommande.CommandText = "insert into 'evenement' ('nom', 'type','dateDebut', 'dateFin', adresse, idClub) values ('" + unevenement.getNom() + "','" + unevenement.getType() + "','" + unevenement.getdateDebut() + "','" + unevenement.getdateFin() + "','" + unevenement.getadresse() + "')";
              connection.Open();
              maCommande.ExecuteReader();
              connection.Close();
          }
             

    }
} 
        
        
        /*
       
        macomande.commandtext = "inset/delee";
        Connectionn.open();
        maCommande.executereader);*/
        

