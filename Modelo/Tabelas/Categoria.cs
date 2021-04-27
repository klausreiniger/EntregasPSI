using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelo.Cadastros;
using Modelo.Tabelas;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Tabelas
{
    public class Categoria
    {
        public long CategoriaId { get; set; }
        [Display(Name = "Categoria")]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}