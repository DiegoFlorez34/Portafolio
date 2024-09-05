using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnimalesMVC.Models
{
    public class AnimalMetadata
    {
        [Key]
        public int AnimalId { get; set; }
        [Required, RegularExpression("(^[a-zA-ZÑÁÉÍÓÚ]+$)", ErrorMessage = "Sólo Letras"), StringLength(15)]
        public string Nombre { get; set; }
        [Required, RegularExpression("(^[a-zA-ZÑÁÉÍÓÚ]+$)", ErrorMessage = "Sólo Letras"), StringLength(15)]
        public string Raza { get; set; }
        [Required, RegularExpression("(^[a-zA-ZÑÁÉÍÓÚ]+$)", ErrorMessage = "Sólo Letras"), StringLength(15)]
        public string Color { get; set; }

        [Required, RegularExpression("(^[a-zA-ZÑÁÉÍÓÚ]+$)", ErrorMessage = "Sólo Letras"), StringLength(15)]
        public string Tamaño { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Seleccione una opcion")]
        public TipoAnimal TipoAnimal { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]

        public DateTime FechaNacimiento { get; set; }
    }
}


