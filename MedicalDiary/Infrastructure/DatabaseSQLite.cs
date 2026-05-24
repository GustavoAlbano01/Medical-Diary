using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.Sqlite;

namespace MedicalDiary.Infrastructure
{
    public class DatabaseSQLite
    {
        private string caminho = Path.Combine(FileSystem.AppDataDirectory, "agenda.db");

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection($"Data Source={caminho}");
        }

        public void InicializarBanco()
        {
            using var conn = GetConnection();

            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Usuario (
                    IdUsuario INTEGER PRIMARY KEY AUTOINCREMENT,
                    Email TEXT NOT NULL UNIQUE,
                    Senha TEXT NOT NULL
                );
            ";

            cmd.ExecuteNonQuery();

            cmd.CommandText = @"
                INSERT INTO Usuario (Email,Senha)
                SELECT 'admin@admin.com', '123'
                WHERE NOT EXISTS (
                    SELECT 1 FROM Usuario
                    WHERE Email='admin@admin.com'
                );
            ";

            cmd.ExecuteNonQuery();
        }
    }
}
