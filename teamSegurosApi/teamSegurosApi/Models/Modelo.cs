using System;

namespace teamSegurosApi.Models
{
    public class Modelo
    {
        public Guid Id { get; set; }
        public Guid MarcaId { get; set; }

        public virtual Marca Marca { get; set; }

        public string Nombre { get; set; }

    }


}
