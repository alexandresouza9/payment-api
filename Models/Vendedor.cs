using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

         [Required]
        [MaxLength(14)]
        [Column(TypeName = "varchar(14)")]
        public string Cpf { get; set; }

         [Required]
        [MaxLength(500)]
        public string Email { get; set; }

         [Required]
        [MaxLength(13)]
        [Column(TypeName = "varchar(13)")]
        public string Telefone { get; set; }
    }
}