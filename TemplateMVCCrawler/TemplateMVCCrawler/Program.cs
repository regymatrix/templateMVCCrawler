using System;
using TemplateMVCCrawler.Model;
using System.Linq;
using System.Collections.Generic;
using TemplateMVCCrawler.Controller;

namespace TempateMVCCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o Projeto");

            //Inicializando servicos
            APICrawlerController appAPIProtudo = new APICrawlerController();
            webScrapingMercadoLivreController appMercadoLivre = new webScrapingMercadoLivreController();
            webScrapingMagazineController appMagazine = new webScrapingMagazineController();
            RegistarLogController appLog = new RegistarLogController();
            EmailServiceController appEmail = new EmailServiceController();
            ZapServiceController appZap = new ZapServiceController();
            BenchMarkingBusinessController appBench = new BenchMarkingBusinessController();


            //Inicio do Ciclo [há cada 5 min
            var produtosAPI = appAPIProtudo.getServiceAPIProdutos();
            var produtosParaExecutar = appBench.getProdutoNovo(produtosAPI, appLog.getLogs("regymatrix", "1"));

            foreach (var item in produtosParaExecutar)
            {
                //um ciclo pode pegar mais de um produto que ainda não foi executado. 
                //Para cada produto executar (MercadoLivre, Magazine, ComparaçãoBenchmarking, EnvioEmail e Enviozap
                var produtoMercadoLivreEncontrado = appMercadoLivre.startRaspagem(item);
                var produtoMagazineEncontrado = appMagazine.startRaspagem(item);
                var produtoMelhorCompra = appBench.compararPreco(produtoMercadoLivreEncontrado, produtoMagazineEncontrado);
                appEmail.enviarEmail(new List<Produto> { produtoMercadoLivreEncontrado, produtoMagazineEncontrado, produtoMelhorCompra });
                appZap.enviarZap(new List<Produto> { produtoMercadoLivreEncontrado, produtoMagazineEncontrado, produtoMelhorCompra });

            }


        }
    }
}