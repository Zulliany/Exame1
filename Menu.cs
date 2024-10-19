using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistama_de_recursos_Humanos
{
    using System;
    using global::Sistema_de_recursos_Humanos;

    namespace Sistema_de_recursos_Humanos
    {
        public class Menu
        {
            static int opcion = 0;
            public static void MostrarMenu()
            {
                Empleado.InicializaArreglo();

                do
                {
                    Console.WriteLine("\n--- Sistema de Recursos Humanos ---");
                    Console.WriteLine("1. Agregar Empleado");
                    Console.WriteLine("2. Consultar Empleados");
                    Console.WriteLine("3. Modificar Empleado");
                    Console.WriteLine("4. Borrar Empleado");
                    Console.WriteLine("5. Listar Empleados Ordenados por Nombre");
                    Console.WriteLine("6. Reporte de Promedio de Salario");
                    Console.WriteLine("0. Salir");
                    Console.Write("Seleccione una opción: ");

                    switch (opcion)
                    {
                        case 1:
                            AgregarEmpleado();
                            break;
                        case 2:
                            Empleado.ConsultarEmpleados();
                            break;
                        case 3:
                            ModificarEmpleado();
                            break;
                        case 4:
                            BorrarEmpleado();
                            break;
                        case 5:
                            Empleado.ListarEmpleadosOrdenadosPorNombre();
                            break;
                        case 6:
                            Empleado.ReporteCalculoPromedio();
                            break;
                        case 0:
                            Console.WriteLine("Saliendo del sistema...");
                            break;
                    }
                } while (opcion != 0);

            }
            private static void AgregarEmpleado()
            {
                Console.Write("Ingrese cédula: ");
                string cedula = Console.ReadLine();
                Console.Write("Ingrese nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese teléfono: ");
                string telefono = Console.ReadLine();
                Console.Write("Ingrese salario: ");
                float salario;
                while (!float.TryParse(Console.ReadLine(), out salario))
                {
                    Console.Write("Por favor, ingrese un salario válido: ");
                }

                Empleado.AgregarEmpleado(cedula, nombre, telefono, salario);
            }

            private static void ModificarEmpleado()
            {
                Console.Write("Ingrese la cédula del empleado a modificar: ");
                string cedula = Console.ReadLine();
                Console.Write("Ingrese el nuevo nombre: ");
                string nuevoNombre = Console.ReadLine();
                Console.Write("Ingrese el nuevo teléfono: ");
                string nuevoTelefono = Console.ReadLine();
                Console.Write("Ingrese el nuevo salario: ");
                float nuevoSalario;
                while (!float.TryParse(Console.ReadLine(), out nuevoSalario))
                {
                    Console.Write("Por favor, ingrese un salario válido: ");
                }

                Empleado.ModificarEmpleado(cedula, nuevoNombre, nuevoTelefono, nuevoSalario);
            }

            private static void BorrarEmpleado()
            {
                Console.Write("Ingrese la cédula del empleado a borrar: ");
                string cedula = Console.ReadLine();
                Empleado.BorrarEmpleado(cedula);
            }


        }
    }
    
}