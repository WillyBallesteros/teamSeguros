using System;
using System.ComponentModel.DataAnnotations;

namespace teamSegurosApi.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        public Guid TipoDocumentoId { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        [Required]
        [StringLength(50)]
        public int NumeroDocumento { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public Guid CiudadId { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public Guid RolId { get; set; }
        public virtual Rol Rol { get; set; }

    }
}
