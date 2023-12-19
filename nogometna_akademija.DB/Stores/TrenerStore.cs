using MySqlConnector;
using System;
using nogometna_akademija.Abstract.Models;
using System.Data.SqlClient;

namespace nogometna_akademija.DB.Stores
{
    public class TrenerStore
    {
        public Trener Autoriziraj(string ime, string lozinka)
        {
            var connectionManager = new SqlConnectionFactory();
            Trener trener = new Trener();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT id, ime, prezime FROM Trener " +
                        "WHERE ime = '{0}' AND lozinka = '{1}'", ime, lozinka);

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                trener.ime = reader.GetString("ime");
                                trener.prezime = reader.GetString("prezime");
                                trener.aktivan = reader.GetBoolean("aktivan");
                            }
                        }
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
            return trener;
        }

    }
}
