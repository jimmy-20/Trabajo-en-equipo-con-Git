using System.Collections.Generic;

namespace Empresa.Dao
{
    public interface ICrud<T>
    {
        void Agregar(T t);
        IEnumerable<T> Visualizar();
        void Actualizar(T t);
        bool Eliminar(int id);
    }
}