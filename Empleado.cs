using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_recursos_Humanos
{
    public class Empleado
    {
        static string[] Cedula = new string[10];
        static string[] Nombre = new string[10];
        static string[] Telefono = new string[10];
        static float[] Salario = new float[10];
        static int contador = 0; 

        public static void InicializaArreglo()
        {
            for (int i = 0; i < Cedula.Length; i++)
            {
                Cedula[i] = " ";
                Nombre[i] = " ";
                Telefono[i] = " ";
                Salario[i] = 0; 
            }
        }

        public static void ListarEmpleadosOrdenadosPorNombre()
        {
            
            string[] nombresOrdenados = new string[contador];
            for (int i = 0; i < contador; i++)
            {
                nombresOrdenados[i] = Nombre[i];
            }
            Array.Sort(nombresOrdenados);

            Console.WriteLine("Empleados ordenados por nombre:");
            foreach (string nombre in nombresOrdenados)
            {
                int index = Array.IndexOf(Nombre, nombre);
                Console.WriteLine($"Cedula: {Cedula[index]}, Nombre: {Nombre[index]}, Telefono: {Telefono[index]}, Salario: {Salario[index]}");
            }
        }
        public static void ReporteCalculoPromedio()
        {
            float promedioSalario = 0;
            for (int i = 0; i < contador; i++)
            {
                promedioSalario += Salario[i];
            }
            if (contador > 0)
            {
                promedioSalario /= contador;
            }
            Console.WriteLine($"El promedio del salario es: {promedioSalario}");
        }

        public static void AgregarEmpleado(string cedula, string nombre, string telefono, float salario)
        {
            if (contador < Cedula.Length)
            {
                Cedula[contador] = cedula;
                Nombre[contador] = nombre;
                Telefono[contador] = telefono;
                Salario[contador] = salario;
                contador++;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más empleados.");
            }
        }

        public static void ConsultarEmpleados()
        {
            Console.WriteLine("Lista de empleados:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Cedula: {Cedula[i]}, Nombre: {Nombre[i]}, Telefono: {Telefono[i]}, Salario: {Salario[i]}");
            }
        }

        public static void ModificarEmpleado(string cedula, string nuevoNombre, string nuevoTelefono, float nuevoSalario)
        {
            for (int i = 0; i < contador; i++)
            {
                if (Cedula[i] == cedula)
                {
                    Nombre[i] = nuevoNombre;
                    Telefono[i] = nuevoTelefono;
                    Salario[i] = nuevoSalario;
                    Console.WriteLine("Empleado modificado con éxito.");
                    return;
                }
            }
            Console.WriteLine("Empleado no encontrado.");
        }

        public static void BorrarEmpleado(string cedula)
        {
            for (int i = 0; i < contador; i++)
            {
                if (Cedula[i] == cedula)
                {
                   
                    for (int j = i; j < contador - 1; j++)
                    {
                        Cedula[j] = Cedula[j + 1];
                        Nombre[j] = Nombre[j + 1];
                        Telefono[j] = Telefono[j + 1];
                        Salario[j] = Salario[j + 1];
                    }
                    Cedula[contador - 1] = " ";
                    Nombre[contador - 1] = " ";
                    Telefono[contador - 1] = " ";
                    Salario[contador - 1] = 0;
                    contador--;
                    Console.WriteLine("Empleado borrado con éxito.");
                    return;
                }
            }
            Console.WriteLine("Empleado no encontrado.");
        }



    }
}
