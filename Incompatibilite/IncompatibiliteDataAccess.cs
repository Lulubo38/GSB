using MySqlConnector;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Incompatibilite
{
    internal class IncompatibiliteDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public void CreateIncompatibilite(string id_a, int id_med, string id_al, string libelle_med)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                
                string deleteQuery = "DELETE FROM incompatible WHERE id_med = @id_med;";
                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn))
                {
                    deleteCommand.Parameters.AddWithValue("@id_med", id_med);
                    deleteCommand.ExecuteNonQuery();
                }

                
                string insertQuery = "INSERT INTO incompatible (id, id_a, id_med, id_al, id_med_Medicament) VALUES (NULL, (SELECT id_a FROM antecedent WHERE antecedent.libelle_a = @libelle_a), @id_med,(SELECT id_al FROM allergie WHERE allergie.libelle_al = @libelle_al),(SELECT id_med FROM medicament WHERE medicament.libelle_med = @libelle_med));";
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@libelle_a", id_a);
                    insertCommand.Parameters.AddWithValue("@id_med", id_med);
                    insertCommand.Parameters.AddWithValue("@libelle_al", id_al);
                    insertCommand.Parameters.AddWithValue("@libelle_med", libelle_med);
                    insertCommand.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
        public string FillDefaultValueComboxBoxMedicaments(int id_med)
        {
            string medicament = "";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_med FROM medicament WHERE medicament.id_med = " +
                    "(SELECT id_med_Medicament FROM incompatible WHERE incompatible.id_med = @id_med);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_med", id_med);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            medicament = reader.GetString(0);
                        }
                    }
                }
                conn.Close();
            }
            return medicament;
        }
        public string FillDefaultValueComboxBoxAllergies(int id_med)
        {
            string allergie = "";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT libelle_al FROM allergie WHERE allergie.id_al = (SELECT id_al FROM incompatible WHERE incompatible.id_med = @id_med); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_med", id_med);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            allergie = reader.GetString(0);
                        }
                    }
                }

                conn.Close();
            }
            return allergie;
        }
        public string FillDefaultValueComboxBoxAntecedents(int id_med)
        {
            string antecedent = "";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT libelle_a FROM antecedent WHERE antecedent.id_a = (SELECT id_a FROM incompatible WHERE incompatible.id_med = @id_med); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_med", id_med);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            antecedent = reader.GetString(0);
                        }
                    }
                }

                conn.Close();
            }
            return antecedent;
        }
    }
}
