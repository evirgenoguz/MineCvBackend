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

        IResumeService _resumeService;

        public ResumesController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {   
            var result = _resumeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _resumeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Resume resume)
        {
            var result = _resumeService.Add(resume);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Resume resume)
        {
            var result = _resumeService.Delete(resume);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(Resume resume)
        {
            var result = _resumeService.Update(resume);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        




    }
}
