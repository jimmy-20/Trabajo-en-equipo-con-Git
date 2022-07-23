using System;
using System.Collections.Generic;
using System.Linq;
using Empresa.Poco;
using Empresa.Printer;
using Empresa.Services;

namespace Empresa.Engine
{
    class EmpresaEngine
    {
        private EmpleadoServices empleadoServices;
        private ActivoFijoServices  activoFijoServices;
        public EmpresaEngine(){
            Inicializar();
        }

        private void Inicializar() {

        }

        public List<Empleado> loadEmpleados(){
            string[] nombres = {"Pablo,Pedro,Enrique"};
            string[] apellidos = {"Cabrera,López,Pereira"};
            string[] roles = {"Contador","Vendedor","Cajero,Bódega"};

            var listaEmpleados = 
            from n1 in nombres
            from a1 in apellidos
            from r1 in roles
            select new Empleado{Nombre = $"{n1} {a1} ", Rol = r1};

            return listaEmpleados.OrderBy(e => e.IdEmpleado).Take(5).ToList();
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

            return listaActivosFijos.OrderBy(a => a.IdActivoFijo).Take(4).ToList();
        }

        
    }
}