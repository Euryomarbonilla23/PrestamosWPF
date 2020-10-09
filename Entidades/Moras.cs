using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrestamosWPF.Entidades
{
    public class Moras
    {
        [Key]
        public int MoraId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}