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
    public class TestimonialManager:IGenericService<Testimonial>
    {
        ITestimonialDal _testimonialdal;

        public TestimonialManager(ITestimonialDal testimonialdal)
        {
            _testimonialdal = testimonialdal;
        }

        public List<Testimonial> GetList()
        {
            return _testimonialdal.GetList();
        }

        public List<Testimonial> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonial t)
        {
            _testimonialdal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialdal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialdal.GetById(id);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialdal.Update(t);
        }
    }
}
