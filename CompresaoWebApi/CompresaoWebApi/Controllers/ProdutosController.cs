using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompresaoWebApi.Controllers
{
    public class ProdutosController : ApiController
    {
        
        public HttpResponseMessage GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            Produto produto;
            for (int i = 1; i <= 100; i++)
            {
                produto = new Produto();
                produto.Codigo = i.ToString("0000");
                produto.Nome = string.Format("Produto {0:0000}", i);
                produto.Preco = i / 10.0;

                produtos.Add(produto);

            }
            //return produtos;
            return Request.CreateResponse(HttpStatusCode.OK, produtos);

        }

    }
}
