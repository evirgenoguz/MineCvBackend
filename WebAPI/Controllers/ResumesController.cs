using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumesController : ControllerBase
    {
        [HttpGet]
        public List<Resume> Get()
        {
            IResumeService resumeService = new ResumeManager(new EfResumeDal());
            var result = resumeService.GetAll();
            return result.Data;
        }


    }
}
