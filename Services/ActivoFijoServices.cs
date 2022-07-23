using System.Collections.Generic;
using Empresa.Dao;
using Empresa.Poco;

namespace Empresa.Services
{
    public class ActivoFijoServices : ICrud<ActivoFijo>
    {
        public List<ActivoFijo> activoFijos {private get;set;}

        public ActivoFijoServices(){
            if (activoFijos == null){
                activoFijos = new List<ActivoFijo>();
            }
        }

        public void Agregar(ActivoFijo t)
        {
            activoFijos.Add(t);
        }

        public IEnumerable<ActivoFijo> Visualizar()
        {
            throw new System.NotImplementedException();
        }

        public void Actualizar(ActivoFijo t)
        {
            throw new System.NotImplementedException();
        } 

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

     
    }
}