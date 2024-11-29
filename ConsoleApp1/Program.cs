using ConsoleApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opc = "";
            VendaView  vendaView = new VendaView();

            Console.WriteLine("Digite 1 para Cadastrar Venda");
            opc = Console.ReadLine();

            if (int.Parse(opc) == 1)
            {
               var resp =  vendaView.CadastroVenda();
                if (resp)
                {
                    Console.WriteLine("Dados Cadastrados com sucesso!!!\nObrigado.");
                }
                else
                {
                    Console.WriteLine("Erros aconteceram :| entre em contato com o Sr. do Sistema!!!\nObrigado.");
                }
            }

            Console.ReadKey();
        }
    }
}
