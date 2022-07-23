using System.Collections.Generic;
using Empresa.Dao;
using Empresa.Poco;

namespace Empresa.Services
{
    public class EmpleadoData : ICrud<Empleado>
    {
        public List<Empleado> empleados{private get; set;}

        public EmpleadoData(){
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