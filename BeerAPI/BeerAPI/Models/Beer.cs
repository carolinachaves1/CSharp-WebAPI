using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
        public Guid BreweryId { get; set; }


        public Style StyleName { get; set; }
        public Guid StyleId { get; set; }





    }
}
