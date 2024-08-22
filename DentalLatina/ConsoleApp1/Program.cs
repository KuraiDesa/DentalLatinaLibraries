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
            Sistema instancia = Sistema.instancia();
            Random rnd = new Random();
            string Cat = instancia.getCategoria()[rnd.Next(0, 2)];
            Producto producto2 = new Producto("Banana", "nada", Cat, "fruta", "Lo comes", 400);
            instancia.addProducto(producto2);


            List<Producto> prods = instancia.getProductos();
            for (int i = 0; i < prods.Count; i++)
            {
                Console.WriteLine(prods[i].nombre);
            }
            UsuariosInfo user1 = new UsuariosInfo("santiago", "soto", "santiago@gmail.com");
            UsuariosInfo user2 = new UsuariosInfo("rafa", "riv", "santiago@gmail.com");
            UsuariosInfo user3 = new UsuariosInfo("santiago", "guzman", "santiago@gmail.com");
            instancia.addUsuario(user1);
            instancia.addUsuario(user2);
            instancia.addUsuario(user3);
            for (int i = 0;i < instancia.getUsuarios().Count;i++) {
                Console.WriteLine(instancia.getUsuarios()[i].getId());
            }

        }
        public static void Main(string[] args) {
            Sistema instancias = new Sistema();
            Sistema instancia = Sistema.instancia();
            Random rnd = new Random();
            string Cat = instancia.getCategoria()[rnd.Next(0, 2)];
            Producto producto = new Producto("Arroz", "nada", Cat, "fruta", "Lo comes", 200);
            instancia.addProducto(producto);
            tutu();
        }

        
    }
}
