using System;
using System.Web.Mvc;
using Fagundes.LojaVirtual.Web.HtmlHelpers;
using Fagundes.LojaVirtual.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fagundes.LojaVirtual.WebTests.HtmlHelpers
{
    [TestClass()]
    public class PaginacaoHelpersTests
    {

        [TestMethod]
        public void TestarSeAPaginacaoEstaSendoGeradaCorretamente()
        {
            //Arrange

            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };
            Func<int, string> paginaUrl = i => "Pagina" + i;
            //Act
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);
            //Assert
            Assert.AreEqual(

                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()

            );
        }
    }
}