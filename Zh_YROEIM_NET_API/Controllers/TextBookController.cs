using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Zh_YROEIM_NET_API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TextBookController : ControllerBase
    {
        Models.ContextTextbook context = new Models.ContextTextbook();


        [HttpGet]
        [Route("textbook/osszes")]
        public IActionResult osszes() 
        {
            var konyvek = from x in context.Textbooks
                          select x;

            return Ok(konyvek);
        }

        [HttpGet]
        [Route("textbook/{textbookid}")]
        public IActionResult egydb(int textbookid)
        {
            var konyv = from x in context.Textbooks
                        where x.TextbookId == textbookid
                        select x;

            return Ok(konyv);
        }
    }
}
