using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnimalesMVC.Models
{
    [MetadataType(typeof(AnimalMetadata))]
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public string Tamaño { get; set; }     
        public TipoAnimal TipoAnimal  { get; set; }
        public DateTime FechaNacimiento { get; set; }
 

    }
}