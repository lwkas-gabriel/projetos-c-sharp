/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Produto
    {
        private string _Nome;
        public double Preco { get; private set; }
        public int Quantidade; { get; private set; }

        public Produto(string nome, double preco, int qtd)
        {
            this._Nome = nome;
            this.Preco = preco;
            this.Quantidade = qtd;
        }

        public string Nome
        {
            get {
                return _Nome;

            }
            set {
                if (value != null && value.Length > 1)
                {
                    _Nome = value;
                }

            }
        }

        public void ImprimirDadosProduto()
        {
            Console.WriteLine($"{this._Nome} - Quantidade em Estoque: {this.Quantidade} - Preço: R${this.Preco}");
        }

        public double ValorTotalEmEstoque()
        {
            return this.Quantidade;
        }

        public void AdicionarProdutos(int qtd)
        {
            if (qtd < 0)
            {
                Console.WriteLine("Entrada inválida!");
            }
            else
            {
                this.Quantidade += qtd;
            }
        }

        public void RemoverProdutos(int qtd)
        {
            if (qtd > this.Quantidade)
            {
                Console.WriteLine("A quantidade informada he maior que a quantidade em estoque!");
            }
            else
            {
                this.Quantidade -= qtd;
            }
        }
    }
}*/
