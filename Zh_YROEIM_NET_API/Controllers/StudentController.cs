using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Zh_YROEIM_NET_API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        Models.ContextTextbook context = new Models.ContextTextbook();

        [HttpGet]
        [Route("student/osszes")]
        public IActionResult osszes() 
        {
            var students = from x in context.Students
                           select x;

            return Ok(students);
        }

        [HttpGet]
        [Route("student/{studentid}")]
        public IActionResult egydb(int studentid)
        {
            var student = from x in context.Students
                          where x.StudentId == studentid
                          select x;

            return Ok(student);
        }
    }
}
