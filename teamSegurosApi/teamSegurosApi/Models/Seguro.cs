using DataAnnotationsExtensions;
using System;

namespace teamSegurosApi.Models
{
    public class Seguro
    {
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public Guid VehiculoId { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public Guid Id { get; set; }


        [Min(1000000)]
        public int Valor { get; set; }
    }
}
