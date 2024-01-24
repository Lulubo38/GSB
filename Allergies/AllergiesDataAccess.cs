using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Allergies
{
    internal class AllergiesDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public void FillComboBox(ComboBox comboBox)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_al FROM allergie;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                            comboBox.Items.Add(value);
                        }
                    }
                }
                conn.Close();
            }


        }
        public void CreateAllergie(string libelle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO allergie (id_al, libelle_al) VALUES (NULL, @libelle_al); ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_al", libelle);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public DataTable GetAllergieListFromDB(int id_p)
        {
           
            DataTable dataTable = new DataTable();

          
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
               
                conn.Open();
               
                string query = "SELECT * FROM allergie WHERE id_al IN (SELECT id_al FROM est WHERE id_p = @id_patient);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                   
                    command.Parameters.AddWithValue("@id_patient", id_p);
                    
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
               
                conn.Close();
            }
            
            return dataTable;
        }
        public void AttributeAllergie(int id_p, string libelle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO `est` (`id_al`, `id_p`) VALUES((SELECT id_al FROM allergie WHERE allergie.libelle_al = @libelle_al), @id_p)";
                
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_p", id_p);
                    command.Parameters.AddWithValue("@libelle_al", libelle);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
