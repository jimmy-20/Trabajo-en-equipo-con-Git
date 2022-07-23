namespace Empresa.Services
{
    public class EmpleadoServices
    {
        public EmpleadoData Data{get;set;}
        public EmpleadoServices() => Data = new EmpleadoData();

        public void Agregar(){

        }

        public void Editar(){

        }

        public void Visualizar(){
            Printer.Sistema.Imprimir(Data.Visualizar());
        }

        public void Eliminar(){

        }
    }
}