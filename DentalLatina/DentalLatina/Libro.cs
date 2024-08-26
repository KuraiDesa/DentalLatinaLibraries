using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Libro
    {
        public static int id = 0;
        public string titulo { get; set; }
        public string descripcion {  get; set; }
        public List<Link> links = new List<Link>();


        public Libro(string titulo, string descripcion) {
            this.titulo = titulo;
            this.descripcion= descripcion;
        }


        //ADD SET Y GET

        public void setLinks(List<Link> lista) {  links = lista; }
        public void addLink(Link link) { links.Add(link);}
        public List<Link> getLinks() { return links; }
    }
}
