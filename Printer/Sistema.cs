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

        }
        public static void MenuEmpleado(){
            WriteLine("1. Agregar empleado");
            WriteLine("2. Editar empleado");
            WriteLine("3. Actualizar");
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
    }
}