using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Provaboa.Models
{
    public class ProdutoModel
    {
        [Key]
        public long ProdutoId { get; set; }

        [Required(ErrorMessage = "Digite um nome de produto")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<FornecedorModel> Fornecedores { get; set; }
    }
}