using System;
namespace Empresa.Poco
{
    public class ActivoFijo
    {
        public string IdActivoFijo{get;}
        public string? Nombre {get;set;}
        public string? TipoActivoFijo{get;set;}
        public double? Monto{get; set;}
        public double? ValorResidual{get;set;}

        public ActivoFijo() => IdActivoFijo = Guid.NewGuid().ToString();
    }
}