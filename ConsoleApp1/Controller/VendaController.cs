using ConsoleApp1.Data;
using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class VendaController
    {
       readonly Context _context = new Context();
        public VendaController() 
        { 
        }

        public bool CadastroVenda(Venda venda)
        {
                try
                {
                    _context.Vendas.Add(venda);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
        }




    }
}
