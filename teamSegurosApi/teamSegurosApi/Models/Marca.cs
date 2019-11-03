﻿using System;
using System.ComponentModel.DataAnnotations;

namespace teamSegurosApi.Models
{
    public class Marca
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

    }

}
