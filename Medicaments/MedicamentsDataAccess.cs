using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Medicaments
{
    internal class MedicamentsDataAccess
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable GetMedicamentListFromDB()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_med AS ID, libelle_med AS Libelle FROM medicament;";
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
        public void CreateMedicament(string libelle )
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO medicament (id_med, libelle_med) VALUES (NULL, @libelle_med); ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_med", libelle);
                    
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void UpdateMedicamentInfo(int id, string libelle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medicament SET libelle_med = @libelle, WHERE id_med = @id;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", libelle);

                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void FillComboBox(ComboBox comboBox)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_med FROM medicament ORDER BY libelle_med ASC;";
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
    }
}

