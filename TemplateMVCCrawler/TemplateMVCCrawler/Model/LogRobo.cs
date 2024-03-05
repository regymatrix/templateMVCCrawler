using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMVCCrawler.Model
{
    public class LogRobo
    {
        public int iDIOG { get; set; }

        public string CodigoRobo { get; set; }

        public string UsuarioRobo { get; set; }

        public DateTime DateLog { get; set; }

        public string Etapa { get; set; }

        public string InformacaoLog { get; set; }

        public int? idProdutoAPI { get; set; }
    }
}
