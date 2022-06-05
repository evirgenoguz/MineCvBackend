using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IResumeService
    {
        IDataResult<List<Resume>> GetAll();

        IDataResult<Resume> GetById(int id);

        IResult Add(Resume resume);

        IResult Delete(Resume resume);

        IResult Update(Resume resume);

        IDataResult<List<ResumeDetailDto>> GetResumeDetails();
    }
}
