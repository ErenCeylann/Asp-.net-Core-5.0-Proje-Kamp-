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
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;

        public MessageManager(IMessageDal messagedal)
        {
            _messagedal = messagedal;
        }

        public List<Message> GetList()
        {
            return _messagedal.GetList();
        }

        public List<Message> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Message t)
        {
            _messagedal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messagedal.Delete(t);
        }

        public Message TGetById(int id)
        {
           return _messagedal.GetById(id);
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
