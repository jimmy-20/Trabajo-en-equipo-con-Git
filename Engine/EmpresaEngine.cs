using System;
using System.Collections.Generic;
using System.Linq;
using Empresa.Poco;
using Empresa.Printer;

namespace Empresa.Engine
{
    class EmpresaEngine
    {
        private List<Empleado> Empleados{get;set;}
        public EmpresaEngine(){
            Inicializar();
        }

        private void Inicializar() => Empleados = loadEmpleados();

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
    }
}