using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Producto
    {
        public static int id = 0;
        public int prodId { get; set; }
        public string nombre { get; set; }
        public string photoUrl { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public string subcategoria { get; set; }
        public int precio { get; set; }
        

        public Producto(string nombre, string photoUrl, string categoria, string subcategoria, string descripcion, int precio)
        {
            this.nombre = nombre;
            this.photoUrl = photoUrl;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.subcategoria = subcategoria;
            //haccer un IValidate
            try
            {
                this.precio = precio;
            }
            catch (FormatException)
            {
                //Hay que ver que hacer aca
            }
            catch (Exception ex)
            {

            }
            id++;
            prodId = id;

        }
    }
}
