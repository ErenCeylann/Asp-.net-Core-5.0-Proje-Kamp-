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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _SocialMedia;

        public SocialMediaManager(ISocialMediaDal socialMedia)
        {
            _SocialMedia = socialMedia;
        }

        public List<SocialMedia> GetList()
        {
           return _SocialMedia.GetList();
        }

        public List<SocialMedia> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SocialMedia t)
        {
            _SocialMedia.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _SocialMedia.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
            return _SocialMedia.GetById(id);
        }

        public void TUpdate(SocialMedia t)
        {
            _SocialMedia.Update(t);
        }
    }
}
