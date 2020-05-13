
namespace SalesCommon.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int ProductoId { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public Decimal Precio { get; set; }

        public bool Disponible { get; set; }

        public DateTime Fecha { get; set; }
    }
}
