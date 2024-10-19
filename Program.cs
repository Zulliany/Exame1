using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistama_de_recursos_Humanos.Sistema_de_recursos_Humanos;
using Sistema_de_recursos_Humanos;

namespace Sistama_de_recursos_Humanos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Empleado.InicializaArreglo();
            Menu.MostrarMenu(); 
        }
    }

}
