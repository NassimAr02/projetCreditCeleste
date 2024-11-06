using System;
using System.Data;
using System.Data.SqlClient;

namespace CreditCeleste
{
    class Connexion
    {
        // Remplace ces valeurs par celles de ta configuration
        string connectionString = "Server=192.168.1.33;Database=creditCelesteARRASS;User Id=creditUSER;Password=creditCeleste;";

        public void OuvrirConnexion()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Ouvrir la connexion
                    conn.Open();
                    Console.WriteLine("Connexion ouverte avec succès.");

                    // Créer une commande SQL
                    string query = "SELECT * FROM NomDeLaTable"; // Remplace par ta requête
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Exécuter la commande et lire les données
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Accéder aux données par le nom de la colonne ou par l'index
                                Console.WriteLine($"Colonne1: {reader["Colonne1"]}, Colonne2: {reader["Colonne2"]}");
                            }
                        }
                    }
                }
                c
