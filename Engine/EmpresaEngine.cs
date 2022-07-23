using System;
using System.Collections.Generic;
using System.Linq;
using Empresa.Poco;
using Empresa.Services;

namespace Empresa.Engine
{
    class EmpresaEngine
    {
        public EmpleadoServices empleadoServices;
        public ActivoFijoServices  activoFijoServices;
        public EmpresaEngine() => Inicializar();

        private void Inicializar() {
            empleadoServices = new EmpleadoServices();
            empleadoServices.Data.empleados = loadEmpleados();

            activoFijoServices = new ActivoFijoServices();
            activoFijoServices.Data.activoFijos = loadActivosFijos();
        }

        public List<Empleado> loadEmpleados(){
            string[] nombres = {"Pablo","Pedro","Enrique","Jose"};
            string[] apellidos = {"Cabrera","López","Pereira","Rosales"};
            string[] roles = {"Contador","Vendedor","Cajero","Bódega"};

            var listaEmpleados = 
            from n1 in nombres
            from a1 in apellidos
            from r1 in roles
            select new Empleado{Nombre = n1,Apellido = a1, Rol = r1};

            List<Empleado> subLista = new List<Empleado>();
            for (int i = 0; i < 3; i++)
            {
                int random = Random.Shared.Next(10);
                subLista.Add(listaEmpleados.Distinct().ToArray()[random]);
            }


            return subLista;
        }

        public List<ActivoFijo> loadActivosFijos(){
            string[] nombres = {"Computadora de escritorio","Silla de oficina","Escritorio","Camión","Camioneta","Servidor"};
            double[] montos = {2000,3000,4500,5300,400};
            double[] VResidual = {0,50,100,300};

            var listaActivosFijos =
            from n1 in nombres
            from m1 in montos
            from vr in VResidual
            select new ActivoFijo{Nombre = n1, Monto = m1, ValorResidual = vr};

            List<ActivoFijo> subLista = new List<ActivoFijo>();
            for (int i = 0; i < 5; i++)
            {
                int random = Random.Shared.Next(10);
                subLista.Add(listaActivosFijos.Distinct().ToArray()[random]);
            }


            return subLista;
        }
        
    }
}