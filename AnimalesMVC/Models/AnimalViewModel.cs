using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalesMVC.Models
{
    public class AnimalViewModel
    {
        public List<Animal> Animales { get; set; }

        public string SearchString { get; set; }
    }
}