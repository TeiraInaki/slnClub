using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseModels;

namespace Datos.Models
{
    public class Jugador : Persona
    {
        public Jugador()
        {
        }

        public Jugador(int Id, string Nombre, string Apellido, DateTime FechaNacimiento, string Puesto) : base(Id, Nombre, Apellido)
        {
            this.FechaNacimiento = FechaNacimiento;
            this.Puesto = Puesto;
        }

        public DateTime FechaNacimiento { get; set; }
        public string Puesto { get; set; }
    }
}
