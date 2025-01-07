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
    public class SkillManager:ISkillService
    {
        ISkillDal _SkillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _SkillDal = skillDal;
        }

        public List<Skill> GetList()
        {
            return _SkillDal.GetList();
        }

        public List<Skill> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Skill t)
        {
            _SkillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _SkillDal.Delete(t);
        }

        public Skill TGetById(int id)
        {
            return _SkillDal.GetById(id);
        }

        public void TUpdate(Skill t)
        {
            _SkillDal.Update(t);
        }
    }
}
