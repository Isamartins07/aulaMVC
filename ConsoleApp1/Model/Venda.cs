using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//model representa uma entidade = tabela,
//model reprenta todas as informações para representar as tabelas 
//informações que serão manipuladas //

namespace ConsoleApp1.Model
{

    [Table("Vendas")]
    public partial class Venda
    {
        public int Id { get; set; }

        [Column("Produto")]
        public string Produto { get; set; }
        
        [Required]
        [Column("Descricao")]
        public string Descricao{ get; set; }
        
        [Required]
        [Column("DataVenda")]
        public DateTime DataVenda { get; set; }
        
        [Required]
        [Column("ValorProduto")]
        public decimal ValorProduto { get; set; }
    }
}
