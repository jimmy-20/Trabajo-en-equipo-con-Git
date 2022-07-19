using System;
using Empresa.Engine;
using Empresa.Printer;

namespace Empresa
{
    public class Program
    {
        static void Main()
        {
            EmpresaEngine engine = new EmpresaEngine();
            bool flag = true;
            int opcion = 0;

            Console.WriteLine("Bienvenido!");
            do
            {
                Sistema.Titulo("MENU", 1);
                Sistema.MenuPrincipal();
                Sistema.Titulo("Seleccione una opción", 3);
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) //Menu principal
                {
                    case 1:
                        switch (opcion) //  Menu de Activos Fijos
                        {
                            case 1:
                                break;

                            case 2:
                                break;

                            case 3:
                                break;

                            case 4:
                                break;

                            case 5:
                                flag = false;
                                break;
                        }
                        break;

                    case 2: // Menu de Empleados
                        switch (opcion)
                        {
                            case 1:
                                break;

                            case 2:
                                break;

                            case 3:
                                break;

                            case 4:
                                break;

                            case 5:
                                flag = false;
                                break;
                        }
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("Menu no existente");
                        break;

                }


            } while (flag);
        }
    }
}