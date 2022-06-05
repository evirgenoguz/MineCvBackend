using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISkillService
    {
        IDataResult<List<Skill>> GetAll();
        IDataResult<Skill> GetById(int id);
        IResult Add(Skill skill);
        IResult Delete(Skill skill);
        IResult Update(Skill skill);
    }
}
