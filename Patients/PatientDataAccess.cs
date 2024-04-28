using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace GeStionB.Patients
{
    internal class PatientDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable GetPatientListFromDB()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_p As ID, nom_p As Nom, prenom_p As Prenom, sexe As Sexe, birthday_p AS 'Date de naissance' FROM patient";
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
        public void UpdatePatientInfo(int id, string nom, string prenom, string sexe, string birthday)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE patient SET nom_p = @nom , prenom_p = @prenom, sexe = @sexe, birthday_p = @birthday WHERE patient.id_p = @id; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@sexe", sexe);
                    command.Parameters.AddWithValue("@birthday_p", birthday);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                conn.Close() ;
            }
        }
        public void CreatePatient(string nom, string prenom, string sexe, string birthday) {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO patient (id_p, nom_p, prenom_p, sexe, birthday_p) VALUES (NULL, @nom, @prenom, @sexe, @birthday); ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@sexe", sexe);
                    command.Parameters.AddWithValue("@birthday", birthday);
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
                string query = "SELECT CONCAT(nom_p, ' ', prenom_p) AS nom_complet FROM patient ORDER BY nom_complet ASC;";
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

