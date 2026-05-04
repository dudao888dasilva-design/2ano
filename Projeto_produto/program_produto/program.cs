using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            Console.WriteLine(" entre com os dados do produto ");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("preço: ");
            p.preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("quantidade no estoque: ");
            p.quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("dados do Produto: " + p);



            Console.Write("digite o numero de produtos a ser adicionado do estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("Dados Atualizados: " + p);


            Console.WriteLine("Digite o numero de produtos a ser removido do estoque");
                qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine("Dados Atualizados: " + p);


        }
    }
}
