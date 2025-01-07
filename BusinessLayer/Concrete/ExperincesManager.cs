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
    public class ExperincesManager:IGenericService<Experince>
    {
        IExperinceDal _experincedal;

        public ExperincesManager(IExperinceDal experincedal)
        {
            _experincedal = experincedal;
        }

        public List<Experince> GetList()
        {
           return _experincedal.GetList();
        }

        public List<Experince> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Experince t)
        {
            _experincedal.Insert(t);
        }

        public void TDelete(Experince t)
        {
           _experincedal.Delete(t);
        }

        public Experince TGetById(int id)
        {
            return _experincedal.GetById(id);
        }

        public void TUpdate(Experince t)
        {
            _experincedal.Update(t);
        }
    }
}
