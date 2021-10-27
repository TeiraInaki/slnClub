using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Puesto
    {
        public Puesto()
        {
        }

        public Puesto(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }
    }
}
