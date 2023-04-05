using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01.model
{
    public class Produto
    {
        private string? _nome;
        private static decimal _valorMaior;
        private decimal _preco;
        private string? _produtoMaisCaro;




        public Produto(decimal preco)
        {
            
            
            _preco = preco;

        }
        public Produto(decimal preco, string nome)
        {
            _preco = preco;
            _nome = nome;
            if (preco > _valorMaior)
            {
                _valorMaior = preco;
                _produtoMaisCaro = _nome;


            }
        }
        public decimal Preço
        {
            get => _preco;
            private set => _preco = value;
        }
        public decimal ValorMaior
        {
            get => _valorMaior;
            private set => _valorMaior = value;
        }
        public string Nome
        {
            get => _nome;
            private set => _nome = value;
        }
        public string ProdutoMaisCaro
        {
            get => _produtoMaisCaro;
            private set => _produtoMaisCaro = value;
        }
        public Cliente Dados { get; set; }
        public bool Comprar(decimal valorSaldo)
        {
            if (_preco <= valorSaldo)
            {
                throw new ArgumentException("O cliente conseguiu comprar");
                
            }
            throw new ArgumentException("Compra negada"); ;
        }


    }
}
