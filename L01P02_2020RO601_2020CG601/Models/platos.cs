﻿using System.ComponentModel.DataAnnotations;
namespace L01P02_2020RO601_2020CG601.Models
{
    public class platos 
    {
        [Key]

        public int platoId { get; set; }
        public string nombrePlato { get; set; }
        public decimal precio { get; set; }
    }
}
