using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisInstitucion
{
    public class Usuario
    {
        public int  Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public Usuario(int codigo, string nombre, string apellido, string user, string password)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            User = user;
            Password = password;
        }
    }
}
