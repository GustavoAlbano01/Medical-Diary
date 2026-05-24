using System;
using System.Collections.Generic;
using System.Text;
using MedicalDiary.Infrastructure;
using Microsoft.Data.Sqlite;

namespace MedicalDiary.DAO_SQLite
{
    public class UsuarioDAO
    {
        DatabaseSQLite db = new DatabaseSQLite();

        public bool ValidarLogin(string email, string senha)
        {
            using var conn = db.GetConnection();

            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM Usuario WHERE Email=@e AND Senha=@s";

            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@s", senha);

            int total = Convert.ToInt32(cmd.ExecuteScalar());

            return total > 0;
        }
    }
}
