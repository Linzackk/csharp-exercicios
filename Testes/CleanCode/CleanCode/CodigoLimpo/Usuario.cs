using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
