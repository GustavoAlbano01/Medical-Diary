using MedicalDiary.DAO_SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDiary.Services
{
    public class UsuarioService
    {
        UsuarioDAO dao = new UsuarioDAO();

        public bool Login(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Digite o email");

            if (string.IsNullOrWhiteSpace(senha))
                throw new Exception("Digite a senha");

            return dao.ValidarLogin(email, senha);
        }
    }
}
