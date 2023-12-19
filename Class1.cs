using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nogometna_akademija
{
    public class DatabaseHelper
    {
        private string GetConnectionString()
        {
            string connString = "Server=localhost;Database=nogometna_akademija;Uid=root;Pwd=root;";


            return connString;

        }
    }
    public bool AutorizirajKorisnika(string username, string pwd)
    {
        bool postoji = false;




        var connection = new MySqlConnection(GetConnectionString());
        connection.Open();


        var command = new MySqlCommand("SELECT ime,prezime FROM korisnik " +
            "WHERE korisnicko_ime ='" + username + "' AND lozinka= '" +
            pwd + "'", connection);

        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            postoji = reader.HasRows;
        }

        return postoji;

    }
}
