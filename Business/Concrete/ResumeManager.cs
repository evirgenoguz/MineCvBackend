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
    public class ResumeManager : IResumeService
    {

        IResumeDal _resumeDal;

        public ResumeManager(IResumeDal resumeDal)
        {
            _resumeDal = resumeDal;
        }

        public IResult Add(Resume resume)
        {
            _resumeDal.Add(resume);
            return new SuccessResult(Messages.ResumeAdded);
        }

        public IResult Delete(Resume resume)
        {
            _resumeDal.Delete(resume);
            return new SuccessResult();
        }

        public IDataResult<List<Resume>> GetAll()
        {
            return new SuccessDataResult<List<Resume>>(_resumeDal.GetAll(), Messages.ResumesListed);
        }

        public IDataResult<Resume> GetById(int id)
        {
            return new SuccessDataResult<Resume>(_resumeDal.Get(r => r.id == id));
        }

        public IResult Update(Resume resume)
        {
            _resumeDal.Update(resume);
            return new SuccessResult();
        }
    }
}
