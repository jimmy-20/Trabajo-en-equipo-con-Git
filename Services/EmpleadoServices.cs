using System.Collections.Generic;
using Empresa.Dao;
using Empresa.Poco;

namespace Empresa.Services
{
    public class EmpleadoServices : ICrud<Empleado>
    {
        public List<Empleado> empleados{private get; set;}

        public EmpleadoServices(){
            if (empleados ==  null){
                empleados = new List<Empleado>();
            }
        }

        public void Agregar(Empleado t)
        {
            empleados.Add(t);
        }

        public IEnumerable<Empleado> Visualizar()
        {
            return empleados;
        }

        public void Actualizar(Empleado t)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}