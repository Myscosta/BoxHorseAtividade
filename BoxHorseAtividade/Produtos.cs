using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHorseAtividade
{
  public  class Produtos
    {
     public string Produto { get; set; } 
     public int Quantidade { get; set;}
     public double Valor { get; set; }

        public Produtos(string nomeProduto, int qntProduto, double valorProduto )
        {
            Produto = nomeProduto;
            Quantidade = qntProduto;
            Valor = valorProduto;

        }
   }
  
}
