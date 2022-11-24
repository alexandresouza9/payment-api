using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Models
{
    public class Item
    {
         public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string NomeProduto { get; set; }
    }
}