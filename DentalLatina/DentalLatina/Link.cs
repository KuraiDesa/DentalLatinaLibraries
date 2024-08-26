using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Link
    {
        public string titulo {  get; set; }
        public string link {  get; set; }

        public Link(string titulo, string link) {
            this.titulo = titulo;
            this.link = link;
        }
    }
}
