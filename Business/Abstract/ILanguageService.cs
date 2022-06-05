using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILanguageService
    {
        IDataResult<List<Language>> GetAll();
        IDataResult<Language> GetById(int id);
        IResult Add(Language language);
        IResult Delete(Language language);
        IResult Update(Language language);
    }
}
