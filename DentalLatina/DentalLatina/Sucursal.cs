using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Sucursal
    {
        public static int id = 0;
        public string nombre { get; set; }
        public string direccion {  get; set; }
        public int sucId { get; set; }


        public Sucursal(string nombre, string direccion) { 
            this.nombre = nombre;
            this.direccion = direccion;
            id++;
            sucId = id;
        }
    }
}
