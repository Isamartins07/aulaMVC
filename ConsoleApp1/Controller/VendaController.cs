using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//controller = pode ficar dentro do context
//

namespace ConsoleApp1.Controller
{
    internal class VendaController
    {
        public VendaController() : base(@"Server=JUN0675619W10-1\\BDSENAC; Database=BancoVendas; user id=senaclivre; password = senaclivre")
        {
            // Desabilita a criação automática de tabelas
            Database.SetInitializer<VendaController>(null);
        }
    }

    public DbSet<Vendas> venda { get; set; }
}
