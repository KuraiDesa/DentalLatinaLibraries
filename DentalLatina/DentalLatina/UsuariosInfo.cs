using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class UsuariosInfo
    {
        public static int id;
        public string nombre {  get; set; }
        public string apellido { get; set;}
        public string mail { get; set;}
        public int idUser { get; set; }

        public UsuariosInfo(string nombre, string apellido, string mail) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            id++;
            this.idUser = id;
        }
        
    }
}
