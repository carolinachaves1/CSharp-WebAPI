using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAPI.Models
{
    public class Brewery 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BreweryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Country { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
