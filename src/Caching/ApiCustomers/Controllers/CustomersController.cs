using Microsoft.AspNetCore.Mvc;

namespace ApiCustomers.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private string[] _names = { "Hossein Jalilian", "Adams Brown", "Jones Abraham" };

        [HttpGet("GetAll")]
        public IEnumerable<string> Get()
        {
            return _names.Append(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
        }

        [HttpGet("GetByID/{id:int}")]
        public string Get([FromRoute] int id)
        {
            if (id >= _names.Length)
                return "Wrong id!";
            return $"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}, {_names[id]}" ;
        }
    }
}
