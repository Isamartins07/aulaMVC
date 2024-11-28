using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    internal class Context
    {

        public Context() : base(@"Server=JUN0675619W10-1\BDSENAC; Database=LojaProdutos; user id=senaclivre; password = senaclivre")
        {
            // Desabilita a criação automática de tabelas
            Database.SetInitializer<Context>(null);
        }
      
    }

    public DbSet<Produto> produto { get; set; }
}
