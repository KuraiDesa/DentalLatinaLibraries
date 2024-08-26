using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Oportunidad
    {
        public static int id = 0;
        public int opId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Oportunidad(string nombre, string descripcion) {
            this.nombre = nombre;
            this.descripcion = descripcion;
            id++;
            this.opId = id;
        }
    }
}
