using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMVCCrawler.Model;

namespace TemplateMVCCrawler.Repository
{
    public interface ILogRoboRepository
    {
        void add(LogRobo log);

        void update(LogRobo log);

        List<LogRobo> GetAll();

    }
}
