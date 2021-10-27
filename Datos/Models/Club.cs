using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Club
    {
        public Club()
        {
        }

        public Club(int id, string nombre, string domicilio, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Domicilio = domicilio;
            Telefono = telefono;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
    }
}
