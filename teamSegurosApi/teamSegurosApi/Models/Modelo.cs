using System;

namespace teamSegurosApi.Models
{
    public class Modelo
    {
        public Guid Id { get; set; }
        public Guid MarcaId { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }

        public string Nombre { get; set; }
    }
}
