using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tech_test_payment_api.Models
{
  public class Venda
    {
        public int Id { get; set; }

        [Required]
        public DateTime Data {get; set;} = new DateTime();

        [Required]
        public Vendedor VendedorVenda {get; set;} = new Vendedor();

        [Required]
        public List<Item> Itens {get; set;} = new List<Item>();

        [Required]
        public EnumStatusVenda Status {get; set;} = new EnumStatusVenda();

    }
}