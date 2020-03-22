using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAPI.Models
{
    public class Beer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BeerId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public float BitternessUnits { get; set; }

        public float AlcoholVolume { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }

        public Brewery Brewery { get; set; }
        public int BreweryId { get; set; }


        public Style StyleName { get; set; }
        public int StyleId { get; set; }





    }
}
