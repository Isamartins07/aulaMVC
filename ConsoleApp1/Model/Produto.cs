using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{

    [Table("Produto")]
    public partial class Produto
    {
        public int Id { get; set; }

        [Column("NomeProduto")]
        public string NomeProduto { get; set; }
        [Required]

        [Column("DescricaoProduto")]
        public string DescricaoProduto { get; set; }
        [Required]

        [Column("ValorProduto")]
        public decimal ValorProduto { get; set; }
    }
}