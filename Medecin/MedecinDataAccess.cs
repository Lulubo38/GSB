using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Medecin

{
    internal class MedecinDataAccess{
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        public string GetHashForAuthentification(string login_m)
        {
            string hash = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT password_m FROM medecin WHERE login_m = @login_m;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login_m", login_m);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hash = reader.GetString("password_m");
                        }
                    }
                }
                conn.Close();
            }
            return hash;
        }

        public void AddMedecin(string nom_m, string prenom_m, string birthday_m, string login_m, string password_m)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO medecin (nom_m, prenom_m, birthday_m, login_m, password_m) VALUES (@nom_m, @prenom_m, @birthday_m, @login_m, @password_m);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom_m", nom_m);
                    command.Parameters.AddWithValue("@prenom_m", prenom_m);
                    command.Parameters.AddWithValue("@birthday_m", birthday_m);
                    command.Parameters.AddWithValue("@login_m", login_m);
                    command.Parameters.AddWithValue("@password_m", password_m);
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
                string query = "SELECT nom_m FROM medecin;";
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
        public string GetNameOfMedecin(string login_m)
        {
            string nom_m = "";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT nom_m FROM medecin WHERE login_m = @login_m;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login_m", login_m);
                    command.ExecuteNonQuery();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nom_m = reader.GetString(0);
                        }
                    }
                }
                conn.Close();
            }
            return nom_m;
        }
    }
}
