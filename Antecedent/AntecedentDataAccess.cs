using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Antecedent
{
    internal class AntecedentDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public void FillComboBox(ComboBox comboBox)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_a FROM antecedent;";
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
        public void CreateAntecedent(string libelle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO antecedent (id_a, libelle_a) VALUES (NULL, @libelle_a); ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle_a", libelle);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public DataTable GetAntecedentListFromDB(int id_p)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM antecedent WHERE id_a IN (SELECT id_a FROM a_eu WHERE id_p = @id_patient);";
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
        public void AttributeAntecedent(int id_p, string libelle_a)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO a_eu (id_a, id_p) VALUES ((SELECT id_a FROM antecedent WHERE antecedent.libelle_a = @libelle_a), @id_p)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_p", id_p);
                    command.Parameters.AddWithValue("@libelle_a", libelle_a);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

    }
}
