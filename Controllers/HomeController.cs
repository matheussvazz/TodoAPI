using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    [ApiController]
    [Route("home")]   // localhost:port/home
    public class HomeController : ControllerBase
    {
        [HttpGet("/")] 
        public string Get() 
        {
            return "Em construção";
        }
    }
}