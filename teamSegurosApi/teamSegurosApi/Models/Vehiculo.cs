using DataAnnotationsExtensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace teamSegurosApi.Models
{
    public class Vehiculo
    {
        public Guid Id { get; set; }
        public Guid MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
        public Guid ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }
        [Min(2000)]
        public int Año { get; set; }
        [Required]
        [StringLength(6)]
        public string Placa { get; set; }



    }
}
