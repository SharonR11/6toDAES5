using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6toDAES5
{
    internal class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaContratacion { get; set; }

        public Empleado(int idEmpleado, string apellidos, string nombre, string cargo,
                        DateTime fechaContratacion )
        {
            IdEmpleado = idEmpleado;
            Apellidos = apellidos;
            Nombre = nombre;
            Cargo = cargo;
            FechaContratacion = fechaContratacion;
        }
    }
}

