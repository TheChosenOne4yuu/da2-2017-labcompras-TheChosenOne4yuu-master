using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class Despesa
    {
        public string NomeDespesa;
        public int Quantidade;
        public double Valor;
        public string Categoria;
        public bool Pago;

        public string nomedespesas
        {
            get { return NomeDespesa; }
            set { NomeDespesa = value; }
        }

        public int quantidade
        {
            get { return Quantidade; }
            set { Quantidade = value; }

        }

        public double valor
        {
            get { return Valor; }
            set { Valor = value; }
        }

        public string categoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }

        public bool pago
        {
            get { return Pago; }
            set { Pago = value; }
        }
        
    }
}
