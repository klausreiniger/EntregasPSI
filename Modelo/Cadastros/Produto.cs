using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelo.Tabelas;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    using System.ComponentModel.DataAnnotations;
    public class Produto
    {
        [StringLength(100, ErrorMessage = "O nome precisa ter no mínimo 10 caracteres", MinimumLength = 10)]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }
        [Display(Name = "Id")]
        public long? ProdutoId { get; set; }
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Insira a data de cadastro")]
        public DateTime? DataCadastro { get; set; }
        [Display(Name = "Categoria")]
        public long? CategoriaId { get; set; }
        [Display(Name = "Fabricante")]
        public long? FabricanteId { get; set; }

        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}