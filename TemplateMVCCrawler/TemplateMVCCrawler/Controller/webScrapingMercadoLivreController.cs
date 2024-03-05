using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMVCCrawler.Model;

namespace TemplateMVCCrawler.Controller
{
    public class webScrapingMercadoLivreController
    {

        public Produto startRaspagem(Produto produto)
        {
            //implementar toda logica de raspagem do mercado livre, ao final retorna o produto encontrado

            string url = "https://lista.mercadolivre.com.br/notebook-hp";

            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response =  client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    string htmlContent = response.Content.ReadAsStringAsync().Result;

                    //fazer raspagem aqui
                    Console.WriteLine(htmlContent);
                }

            }


                return new Produto();
        }
    }
}
