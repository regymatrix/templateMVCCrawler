using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMVCCrawler.Model;

namespace TemplateMVCCrawler.Controller
{
    public class BenchMarkingBusinessController
    {
        public List<Produto> getProdutoNovo(List<Produto> produtosRetornadosAPI, List<LogRobo> registrosLog)
        {
            //usando o LINQ
            //var produtosNaoRegistrados = produtosRetornadosAPI
            //                             .Where(produto => !registrosLog.Any(log => log.idProdutoAPI == produto.id))
            //                             .ToList();

            //return produtosNaoRegistrados.First();


            //SEM LINQ
            List<Produto> produtoNaoRegistrado = new List<Produto>();
            foreach (var pro in produtosRetornadosAPI)
            {
                foreach (var log in registrosLog)
                {
                    if (log.idProdutoAPI == pro.id)
                    {
                        produtoNaoRegistrado.Add(pro);
                        break;
                    }
                }
            }
            return produtoNaoRegistrado;
            

        }


        public Produto compararPreco(Produto pMercado, Produto pMagazine)
        {
            //para ficar escalavel podemos receber uma lista de produtos
            if (Convert.ToDouble(pMercado.preco) >= Convert.ToDouble(pMagazine.preco))
            {
                return pMercado;
            }
            else
            {
                return pMagazine;
            }
        }
    }
}
