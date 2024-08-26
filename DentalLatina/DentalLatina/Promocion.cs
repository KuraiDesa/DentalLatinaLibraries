using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Promocion
    {
        public static int id = 0;
        public string titulo {  get; set; }
        public string descripcion { get; set;}
        public int promoId { get; set; }

        public Promocion(string titulo, string descripcion)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            id++;
            this.promoId = id;
        }
    }
}
