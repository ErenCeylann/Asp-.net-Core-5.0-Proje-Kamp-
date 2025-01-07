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
    public class ContactManager:IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public List<Contact> GetList()
        {
           return _contactdal.GetList();
        }

        public List<Contact> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact t)
        {
            _contactdal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactdal.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _contactdal.GetById(id);
        }

        public void TUpdate(Contact t)
        {
            _contactdal.Update(t);
        }
    }
}
