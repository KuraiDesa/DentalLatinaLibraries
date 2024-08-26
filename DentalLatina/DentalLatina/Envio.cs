using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Envio
    {
        public static int id = 0;
        public Producto producto { get; set; }
        public UsuariosInfo comprador { get; set; }
        public string descripcion { get; set; }
        public int envioId  { get; set; }
        public string ubicacion {  get; set; }
        public string direccion { get; set; }
        public int codigoZip { get; set; }


        public Envio(Producto producto, UsuariosInfo comprador, string descripcion, string ubicacion, string direccion, int codigoZip) {
            this.producto = producto;
            this.comprador = comprador;
            this.descripcion = descripcion;
            this.ubicacion = ubicacion;
            this.direccion = direccion;
            try
            {
                this.codigoZip = codigoZip;
            }
            catch (FormatException)
            {
                //Hay que ver que hacer aca
            }
            catch (Exception ex)
            {

            }
            id++;
            envioId = id;
        }



    }
}
