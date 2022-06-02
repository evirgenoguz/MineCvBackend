using Core.Utilities.Results;
using Entities.Concrete;
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

        IResult Add(Resume resume);

        IResult Delete(Resume resume);

        IResult Update(Resume resume);
    }
}
