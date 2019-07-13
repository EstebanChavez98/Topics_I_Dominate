using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICrudCeuta.Object
{
    public class Usuario
    {
        public int id { get; set; }
        public String Nombre { get; set; }
        public String Departamento { get; set; }
        public String Persona { get; set; }
        public String IP { get; set; }
        public String InicialFecha { get; set; }
        public String InicialHora { get; set; }
        public String FinalFecha { get; set; }
        public String FinalHora { get; set; }
    }
}
