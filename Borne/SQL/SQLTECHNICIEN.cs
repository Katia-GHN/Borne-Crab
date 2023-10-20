using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Borne.Methodes;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Borne.SQL
{
    public class SQLTECHNICIEN
    {
        public static Technicien FindId(int param)
        {
            Technicien resultat = null;

            // connecte à la base de donnée sur localhost
            string connectionString = "Server=localhost;UserId=root;Password=;Database=MaNouvelleBaseMySQL";
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = @"SELECT JSON_OBJECT('Matricule', Matricule, 'Nom', Nom, 'Prenom', Email) 
                                   FROM Technicien
                                   WHERE  Id = @param";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@param", param);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userJson = reader.GetString(0);  // considering the JSON is in the first column
                            TechnicienJsonList
                        }
                    }
                }
            }
            return resultat;
        }
    }
}
// creer connexion base de donnée 
// ouvert connexion
// ecrit notre requete SQL dans le selec 
// préparation à la migration --- formater pour qu'elle soit bien lu par MySQL 