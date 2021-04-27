using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Fabricante
    {
        public long FabricanteId { get; set; }
        [Display(Name = "Fabricante")]
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}