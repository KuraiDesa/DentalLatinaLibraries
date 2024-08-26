using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Evento
    {
        public string nombreEvento {  get; set; }
        public string descripcion { get; set; }
        public DateTime eventoFecha { get; set; }

        public Evento(string nombre, string descripcion, DateTime fecha) {
            this.nombreEvento = nombre;
            this.descripcion = descripcion;
            this.eventoFecha = fecha;
        }


    }
}
