using ConsoleApp1.Controller;
using ConsoleApp1.Data;
using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{

    //metodos -- CRUD
    public class VendaView
    {
        //adiciona venda

        public bool CadastroVenda()
        {
            //instanciando model venda
            Venda venda = new Venda();

            Console.WriteLine("Produto: ");
            venda.Produto = Console.ReadLine();
            Console.WriteLine("Descrição: ");
            venda.Descricao = Console.ReadLine();
            Console.WriteLine("Data: ");
            venda.DataVenda = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Valor: ");
            venda.ValorProduto = Decimal.Parse(Console.ReadLine());

            //chamando controller Venda isso é uma instancia de classe...
            //poder usar a classe e seus metodos dentro de outra...

            VendaController vendaController = new VendaController();
            return vendaController.CadastroVenda(venda);
        }



        //mostra todas vendas
        //alterar venda
        //remover venda






    }
}
