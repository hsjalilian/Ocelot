using Microsoft.AspNetCore.Mvc;

namespace ApiUsers.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private string[] _names = { "Hossein Jalilian", "Adams Brown", "Jones Abraham" };

        [HttpGet("GetByID/{id:int}")]
        public string Get([FromRoute] int id)
        {
            if (id >= _names.Length)
                return "Wrong id!";
            return _names[id];
        }
    }
}
