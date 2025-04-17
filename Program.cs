using System;
using System.Collections.Generic;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p2 = new Produto();
            p2.nome = "Mochila Azul";
            p2.preco = 109.99f;
            p2.Insere();

            Produto produto = new Produto();
            List<Produto> lista = produto.BuscaTodos();

            foreach (Produto p in lista)
            {
                Console.WriteLine(" ID " + p.id + " Nome " + p.nome);
            }


        }
    }

}
