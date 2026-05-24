using MedicalDiary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDiary.Controllers
{
    public class UsuarioController
    {
        UsuarioService service = new UsuarioService();

        public bool Login(string email, string senha)
        {
            return service.Login(email, senha);
        }
    }
}
