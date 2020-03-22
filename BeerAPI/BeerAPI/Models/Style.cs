using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerAPI.Models
{
    public class Style
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StyleId { get; set; }

        [Required]
        public string StyleName { get; set; }

        public ICollection<Beer> Beers { get; set; }


    }
}
