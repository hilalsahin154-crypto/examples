using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = new
            {
                Id = id,
                Title = "Örnek Kitap"
            };

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] BookRequestDto request)
        {
            return Ok(request);
        }
    }
}
