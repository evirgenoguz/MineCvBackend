using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfResumeDal : EfEntityRepositoryBase<Resume, MinecvdbContext>, IResumeDal
    {
      

        public List<ResumeDetailDto> GetResumeDetails()
        {
            using (MinecvdbContext context = new MinecvdbContext())
            {
                var result = from r in context.Resumes
                             join s in context.Skills on r.id equals s.resume_id
                             join l in context.Languages on r.id equals l.resume_id
                             select new ResumeDetailDto
                             {
                                 resume_id = r.id,
                                 user_id = r.user_id,
                                 name = r.name,
                                 surname = r.surname,
                                 adress = r.adress,
                                 skill = s.skill,
                                 language = l.language

                             };
                return result.ToList();
                            
            }
        }
    }
}
