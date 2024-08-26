using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLatina
{
    public class Estudiante : Usuario
    {
        public Estudiante(string nombre, string apellido, string mail) : base(nombre, apellido, mail){ 
        
        }
    }
}
