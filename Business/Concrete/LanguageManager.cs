using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LanguageManager: ILanguageService
    {
        ILanguageDal _languageDal;

        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public IResult Add(Language language)
        {
            _languageDal.Add(language);
            return new SuccessResult();
        }

        public IResult Delete(Language language)
        {
            _languageDal.Delete(language);
            return new SuccessResult();
        }

        public IDataResult<List<Language>> GetAll()
        {
            return new SuccessDataResult<List<Language>>(_languageDal.GetAll(), "Diller Listelendi ");
        }

        public IDataResult<Language> GetById(int id)
        {
            return new SuccessDataResult<Language>(_languageDal.Get(r => r.id == id));
        }

        public IResult Update(Language language)
        {
            _languageDal.Update(language);
            return new SuccessResult();
        }

    }
}
