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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessage _writerMessage;

        public WriterMessageManager(IWriterMessage writerMessage)
        {
            _writerMessage = writerMessage;
        }

        public List<WriterMessage> GetList()
        {
           return _writerMessage.GetList();   
        }


        public List<WriterMessage> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessage.GetbyFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessage.GetbyFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
           _writerMessage.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writerMessage.Delete(t);
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessage.GetById(id);
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
