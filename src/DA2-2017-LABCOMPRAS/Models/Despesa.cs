using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class Despesa
    {
        public string NomeDespesa { get; set; }
        [Required(ErrorMessage = "Por favor insira o nome da despesa")]
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        [Required(ErrorMessage = "Por favor insira o valor da despesa")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Por favor insira a categoria da despesa")]
        public bool Pago { get; set; }



    }
}
