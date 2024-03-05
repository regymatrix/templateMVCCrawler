using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMVCCrawler.Model;
using TemplateMVCCrawler.Repository;

namespace TemplateMVCCrawler.Controller
{
    public class RegistarLogController
    {
        LogoRoboRepository _repository = new LogoRoboRepository(new Context());

        public bool insertLog(LogRobo log)
        {
            //recebe os dados do log e salva no banco de dados
            try
            {
                _repository.add(log);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


        public List<LogRobo> getLogs(string pUsuarioRobo, string pCodigoRobo)
        {
            //recebe os dados do log e salva no banco de dados
            try
            {
               return  _repository.GetAll().Where(x => x.UsuarioRobo == pUsuarioRobo && x.CodigoRobo == pCodigoRobo).ToList();
                
            }
            catch (Exception)
            {

                return null;
            }

        }

    }
}
