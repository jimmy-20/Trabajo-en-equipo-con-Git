using System.Collections;
using System.Collections.Generic;
using Empresa.Poco;
using static System.Console;
namespace Empresa.Printer
{
    static class Sistema
    {

        public static void MenuPrincipal(){
            WriteLine("1. Empleados");
            WriteLine("2. ActivoFijos");
            WriteLine("3. Salida");
        }

        public static void MenuActivoFijo(){
            WriteLine("1. Agregar Activo Fijo");
            WriteLine("2. Visualizar");
            WriteLine("3. Actualizar Activo");
            WriteLine("4. Borrar");
            WriteLine("5. Salir");
        }
        public static void MenuEmpleado(){
            WriteLine("1. Agregar empleado");
            WriteLine("2. Visualizar");
            WriteLine("3. Actualizar Empleado");
            WriteLine("4. Borrar");
            WriteLine("5. Salir");
        }

        public static void Titulo(string cad, int opcion){
            switch (opcion)
            {
                case 1:
                WriteLine("             "+ cad);
                break;

                case 2:
                WriteLine("===== "+cad+" =====");
                break;

                case 3:
                WriteLine(">>"+cad);
                break;
            }
        }

        public static void Imprimir(IEnumerable<ActivoFijo> lista){

        }

        public static void Imprimir(IEnumerable<Empleado> lista){
            WriteLine("IdEmpleado\tNombre\tApellido\tRol\tEmpleado");
            WriteLine("======================================================");
            foreach (Empleado e in lista)
            {
                WriteLine($"Id: {e.IdEmpleado} \nNombre: {e.Nombre} \nApellido: {e.Apellido} \nRol: {e.Rol}");
                WriteLine("");
            }
        }
    }
}