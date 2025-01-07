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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _AnnouncementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _AnnouncementDal = announcementDal;
        }

        public List<Announcement> GetList()
        {
            return _AnnouncementDal.GetList();
        }

        public List<Announcement> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Announcement t)
        {
            _AnnouncementDal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _AnnouncementDal.Delete(t);
        }

        public Announcement TGetById(int id)
        {
            return _AnnouncementDal.GetById(id);
        }

        public void TUpdate(Announcement t)
        {
            _AnnouncementDal.Update(t);
        }
    }
}
