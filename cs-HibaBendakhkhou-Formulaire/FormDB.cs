using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace TpCalculette
{
    internal class FormDB
    {
        private MySqlConnection connection;

        public FormDB()
        {
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString);
        }

        private void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        private void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

       public int AddElement(string nom, string prenom, int age)
{
    try
    {
        connection.Open();

        MySqlCommand command = new MySqlCommand("INSERT INTO utilisateurs (nom, prenom, age) VALUES (@nom, @prenom, @age)", connection);
        command.Parameters.AddWithValue("@nom", nom);
        command.Parameters.AddWithValue("@prenom", prenom);
        command.Parameters.AddWithValue("@age", age);

        if (command.ExecuteNonQuery() != 0)
        {
            MessageBox.Show("Personne ajoutée avec succès !");
            return 1;
        } //erreur stupide
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur : " + ex.Message);
    }
    finally
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }

    return 0;
}


        public void ListElements(ComboBox c)
        {
            try
            {
                OpenConnection();

                MySqlCommand rqt = new MySqlCommand("SELECT id, nom, prenom, age FROM utilisateurs", connection);
                MySqlDataReader reader = rqt.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string age = reader["age"].ToString();

                    c.Items.Add($"{id}|{nom}|{prenom}|{age}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public int UpdateElement(string nom, string prenom, int age, int selectedIndex,ComboBox c)
        {
            try
            {
                OpenConnection();

                MySqlCommand rqt = new MySqlCommand("UPDATE utilisateurs SET age = @age, nom = @nom, prenom = @prenom WHERE id = @id", connection);

                string[] selectedData = c.SelectedItem.ToString().Split('|');
                int id = int.Parse(selectedData[0]);

                rqt.Parameters.AddWithValue("@id", id);
                rqt.Parameters.AddWithValue("@nom", nom);
                rqt.Parameters.AddWithValue("@prenom", prenom);
                rqt.Parameters.AddWithValue("@age", age);

                return rqt.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int DeleteElement(int selectedIndex, ComboBox c)
        {
            try
            {
                OpenConnection();

                MySqlCommand rqt = new MySqlCommand("DELETE FROM utilisateurs WHERE id=@id", connection);

                string[] selectedData = c.SelectedItem.ToString().Split('|');
                int id = int.Parse(selectedData[0]);

                rqt.Parameters.AddWithValue("@id", id);

                return rqt.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
