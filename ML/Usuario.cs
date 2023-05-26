using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Foto { get; set; }
        public List<Object> Usuarios { get; set; }
    }
}
