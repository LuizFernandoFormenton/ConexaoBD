using System;
using System.Collections.Generic;
using System.Data;

namespace ConexaoBD
{
    class Produto
    {
        public int id {get; set;}

        public string nome {get; set;}

        public float preco {get; set;}
        
        public DateTime registro { get; set; }

        Conexao conexao { get; set; }

        public Produto()
        {
            conexao = new Conexao();
        }

        public void Insere()
        {
            string query = $" INSERT INTO produtos (nome, preco) VALUES ( '{nome}', {preco.ToString().Replace(",",".")} ); ";
            conexao.ExecutaComando(query);
            Console.WriteLine(" Produto inserido com sucesso! ");
        }

        public List<Produto> BuscaTodos()
        {
            DataTable dt = conexao.ExecutaSelect("SELECT * FROM produtos;");

            List<Produto> lista = new List<Produto>();

            foreach (DataRow Linha in dt.Rows)
            {
                Produto produto = new Produto();

                produto.id = int.Parse(Linha["ID"].ToString());
                produto.nome = Linha["Nome"].ToString();
                produto.preco = float.Parse(Linha["preco"].ToString());
                produto.registro = DateTime.Parse(Linha["registro"].ToString());

                lista.Add(produto);
            }

            return lista;
        }


    }
}