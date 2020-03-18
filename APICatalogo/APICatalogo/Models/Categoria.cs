using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//DataAnnotations -> Definições da table no DB
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Models
{
    [Table("Categorias")] //DataAnnotations.Schema, mas não é necessário
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        [Key]
        public int CategoriaId { get; set; }

        [Required] //atributo da DataAnnotations
        [MaxLength(80)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(300)]
        public string ImagemUrl { get; set; }

        //propriedade de naveção
        public ICollection<Produto> Produtos { get; set;  }

    }
}
