using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrestamosWPF.Entidades
{
    public class MorasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int MoraId { get; set; }
        public int PrestamoId  { get; set; }
        public decimal Valor { get; set; }
        

    }
}