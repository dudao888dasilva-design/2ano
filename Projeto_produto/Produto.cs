using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAI01
{
    internal class Produto
    {
        public string nome;
        public double preço;
        public int quantidade;

//comentario aqui
        public double ValorTotalemEstoque()
        {
            return preço * quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            quantidade -= quantidade;
        }
        public override string ToString()
        {
            return nome
            + ", $ "
            + preço.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + quantidade
            + "Unidade, Total: $ "
            + ValorTotalemEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
