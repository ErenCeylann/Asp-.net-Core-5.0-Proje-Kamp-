using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfoliodal;

        public PortfolioManager(IPortfolioDal portfoliodal)
        {
            _portfoliodal = portfoliodal;
        }

        public List<Porfolio> GetList()
        {
           return _portfoliodal.GetList();
        }

        public List<Porfolio> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Porfolio t)
        {
            _portfoliodal.Insert(t);
        }

        public void TDelete(Porfolio t)
        {
            _portfoliodal.Delete(t);
        }

        public Porfolio TGetById(int id)
        {
            return _portfoliodal.GetById(id);
        }

        public void TUpdate(Porfolio t)
        {
            _portfoliodal.Update(t);
        }
    }
}
