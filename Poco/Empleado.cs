using System;

namespace Empresa.Poco
{
    public class Empleado
    {
        public string IdEmpleado {get;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string Rol {get;set;}
        public Empleado? Supervisor {get;set;}
        
        public Empleado() => IdEmpleado = Guid.NewGuid().ToString();
    }
}