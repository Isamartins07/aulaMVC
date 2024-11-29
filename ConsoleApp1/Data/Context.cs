using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class Context : DbContext
    {

        public Context() : base(@"Server=JUN0675619W10-1\\BDSENAC;Database=BancoVendas;user id=senaclivre;password='senaclivre'")
        {
            // Desabilita a criação automática de tabelas
            // Database.SetInitializer<VendaController>(null);
        }
        //Dbset dentro do context

        public DbSet<ConsoleApp1.Model.Venda> Vendas { get; set; }
    }
}