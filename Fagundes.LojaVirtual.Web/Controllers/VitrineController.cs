using Fagundes.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fagundes.LojaVirtual.Web.Models;

namespace Fagundes.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;
        public ActionResult LitaProdutos(int pagina=1)
        {
            _repositorio = new ProdutosRepositorio();

           



            ProdutosViewModel model = new ProdutosViewModel
            {

                Produtos = _repositorio.Produtos
                .OrderBy(p => p.Nome)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),


            Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _repositorio.Produtos.Count()
                }
            };

           




            return View(model);
        }
    }
}