using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMVCCrawler.Model;

namespace TemplateMVCCrawler.Repository
{
    public class LogoRoboRepository : ILogRoboRepository
    {
        Context _conexao; //simular conexão

        public LogoRoboRepository(Context db)
        {
            _conexao = db;

        }

        public void add(LogRobo log)
        {
            throw new NotImplementedException();
        }

        public List<LogRobo> GetAll()
        {
            throw new NotImplementedException();
        }

        public void update(LogRobo log)
        {
            throw new NotImplementedException();
        }
    }
}
