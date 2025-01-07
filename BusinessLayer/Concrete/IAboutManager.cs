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
    public class IAboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public IAboutManager(IAboutDal aboutDal)//IAboutmanager e ctrl . Yapınca Generate deyince oluyor
        {
            _aboutDal = aboutDal;
        }

        public List<About> GetList()
        {
           return _aboutDal.GetList();
        }

        public List<About> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);

        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
