
namespace SalesCommon.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int ProductoId { get; set; }

        [Required]
       // [StringLength(50)]
        public string Descripcion { get; set; }

        //[DataType(DataType.MultilineText)]

        public string Notas { get; set; }

        //[Display(Name ="Image")]
        public string ImagePath { get; set; }

        //[DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public Decimal Precio { get; set; }

        //[Display(Name = "Is Available")]
        //[DataType(DataType.Date)]
        public bool Disponible { get; set; }

       // [Display(Name = "Publish On")]
        public DateTime Fecha { get; set; }
    }
}
