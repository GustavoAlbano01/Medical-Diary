using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDiary.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }
    }
}
