using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fagundes.LojaVirtual.Dominio.Entidades;

namespace Fagundes.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {

        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }




    }
}