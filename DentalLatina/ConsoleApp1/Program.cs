using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DentalLatina;
namespace DentalLatina
{
    public class Program
    {

        public static void tutu()
        {
            Sistema instancia = Sistema.instancia;
            Random rnd = new Random();
            string Cat = instancia.getCategoria()[rnd.Next(0, 2)];
            Producto producto2 = new Producto("Banana", "nada", Cat, "fruta", "Lo comes", 400);
            instancia.agregarProducto(producto2);


            List<Producto> prods = instancia.getProductos();
            for (int i = 0; i < prods.Count; i++)
            {
                Console.WriteLine(prods[i].nombre);
            }

        }
        public static void Main(string[] args) {
            Sistema instancias = new Sistema();
            Sistema instancia = Sistema.instancia;
            Random rnd = new Random();
            string Cat = instancia.getCategoria()[rnd.Next(0, 2)];
            Producto producto = new Producto("Arroz", "nada", Cat, "fruta", "Lo comes", 200);
            instancia.agregarProducto(producto);
            tutu();
        }

        
    }
}
