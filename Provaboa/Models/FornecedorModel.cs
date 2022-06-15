using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Provaboa.Models
{
    public class FornecedorModel
    {
        [Key]
        public long FornecedorId { get; set; }

        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Email Invalido")]
        public string Email { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public ProdutoModel Produtos { get; set; }
    }
}