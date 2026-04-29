using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_classeD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("dados da primeira pessoa");
            Console.Write("nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            

            Console.WriteLine("dados da segunda pessoa");
            Console.Write("nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            int diferença;
            if ( p1.idade > p2.idade)
            {
                Console.WriteLine("pessoa mais velha:" + p1.nome);
             diferença =p1.idade- p2.idade;
                Console.Write(" a diferença entre eles e:" + diferença);
            }
            else
            {
                Console.WriteLine("pessoa mais velha:" + p2.nome);
                diferença = p1.idade - p2.idade;
                Console.Write(" a diferença entre eles e:" + diferença);

            }
        }
    }
}
