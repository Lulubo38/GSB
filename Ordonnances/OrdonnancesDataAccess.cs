using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Ordonnances
{
    internal class OrdonnancesDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        public DataTable GetOrdonnancesListFromDB()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ordonnance.id_o AS ID, ordonnance.posologie AS Posologie, ordonnance.date AS \"Date de création\", ordonnance.duree_traitement AS \"Durée du traitement (jours)\", ordonnance.instruction_specifique AS \"Instructions\", (SELECT medecin.nom_m FROM medecin WHERE medecin.id_m = ordonnance.id_m) AS Medecin, (SELECT CONCAT(nom_p, ' ', prenom_p) FROM patient WHERE patient.id_p = ordonnance.id_p) AS Patient, (SELECT medicament.libelle_med FROM medicament WHERE medicament.id_med = ordonnance.id_med) AS \"Medicament Prescrit\" FROM ordonnance";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                conn.Close();
            }
            return dataTable;
        }
        public void CreateOrdonnance(string posologie, int duree, string instructions, string nom_m, string nom_prenom_p, string libelle_med)
        {
            List<string> listeAllergies = GetAllergieListFromDB(nom_prenom_p);
            List<string> listeAntecedents = GetAntecedentListFromDB(nom_prenom_p);
            List<Incompatibilite> listeIncompatibilites = GetIncompatibiliteFromDB(libelle_med);
            bool isIncompatible = false;
            foreach (string allergie in listeAllergies)
            {
                if (listeIncompatibilites.Any(incompatibilite => incompatibilite.Id_al == allergie || incompatibilite.Id_a == allergie))
                {
                    isIncompatible = true;
                    MessageBox.Show("Le médicament est incompatible avec une allergie du patient ");
                    return;
                }
            }
            foreach (string antecedent in listeAntecedents)
            {
                if (listeIncompatibilites.Any(incompatibilite => incompatibilite.Id_al == antecedent || incompatibilite.Id_a == antecedent))
                {
                    isIncompatible = true;
                    MessageBox.Show("Le médicament est incompatible avec un antécédent du patient ");
                    return;
                }
            }
            if (!isIncompatible)
            { 
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO ordonnance (id_o, posologie, date, duree_traitement, instruction_specifique, id_m, id_p, id_med) VALUES (NULL, @posologie, @date, @duree, @instructions,(SELECT id_m FROM medecin WHERE medecin.nom_m = @nom_m), (SELECT id_p FROM patient WHERE CONCAT(patient.nom_p, ' ', patient.prenom_p) = @nom_prenom_p), (SELECT id_med FROM medicament WHERE medicament.libelle_med = @libelle_med)); ";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {

                        command.Parameters.AddWithValue("@posologie", posologie);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@duree", duree);
                        command.Parameters.AddWithValue("@instructions", instructions);
                        command.Parameters.AddWithValue("@nom_m", nom_m);
                        command.Parameters.AddWithValue("@nom_prenom_p", nom_prenom_p);
                        command.Parameters.AddWithValue("@libelle_med", libelle_med);
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Ordonnance crée");
            }

            

        }
        public List<string> GetAntecedentListFromDB(string nom_prenom_p)
        {
            List<string> list = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_a FROM a_eu WHERE id_p = (SELECT id_p FROM patient WHERE CONCAT(patient.nom_p, ' ', patient.prenom_p) = @nom_prenom_p);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom_prenom_p", nom_prenom_p);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int libelle = reader.GetInt32(0);
                            list.Add(libelle.ToString());
                        }
                    }
                }
            }

            return list;
        }

        public List<string> GetAllergieListFromDB(string nom_prenom_p)
        {
            List<string> list = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_al FROM est WHERE id_p = (SELECT id_p FROM patient WHERE CONCAT(patient.nom_p, ' ', patient.prenom_p) = @nom_prenom_p);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom_prenom_p", nom_prenom_p);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id_al = reader.GetInt32(0);
                            list.Add(id_al.ToString());
                        }
                    }
                }
            }

            return list;
        }

        public class Incompatibilite
        {
            public string Id_a { get; set; }
            public string Id_al { get; set; }
        }

        public List<Incompatibilite> GetIncompatibiliteFromDB(string libelle_med)
        {
            List<Incompatibilite> list = new List<Incompatibilite>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_al, id_a FROM incompatible WHERE id_med = (SELECT id_med FROM medicament WHERE medicament.libelle_med = @libelle_med)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_med", libelle_med);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id_al = reader.GetInt32("id_al");
                            int id_a = reader.GetInt32("id_a");

                            Incompatibilite incompatibilite = new Incompatibilite
                            {
                                Id_al = id_al.ToString(),
                                Id_a = id_a.ToString()
                            };

                            list.Add(incompatibilite);
                        }
                    }
                }
            }

            return list;
        }
        public void RemoveOrdonnance(int id_o)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM ordonnance WHERE `ordonnance`.`id_o` = @id_o";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_o", id_o);
                    command.ExecuteNonQuery();
                    
                }
                conn.Close();
            }
        }
    } 
}
