using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AnimalesMVC.Models
{
    public class AnimalContext : DbContext
    {
        public AnimalContext()
        {

        }

        public System.Data.Entity.DbSet<AnimalesMVC.Models.Animal> Animals { get; set; }
    }
}