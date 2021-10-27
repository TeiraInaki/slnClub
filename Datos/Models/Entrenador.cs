using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseModels;


namespace Datos.Models
{
    public class Entrenador : Persona
    {
        public Entrenador() { }
        public Entrenador(int Id, string Nombre, string Apellido, string Domicilio, string Telefono, string Titulo) : base(Id, Nombre, Apellido)
        {
            this.Domicilio = Domicilio;
            this.Telefono = Telefono;
            this.Titulo = Titulo;
        }

        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Titulo { get; set; }
    }
}
