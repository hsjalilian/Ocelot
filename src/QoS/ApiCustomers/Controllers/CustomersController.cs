using Microsoft.AspNetCore.Mvc;

namespace ApiCustomers.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private static int _count = 0;

        private string[] _names = { "Hossein Jalilian", "Adams Brown", "Jones Abraham" };

        [HttpGet("GetAll")]
        public IEnumerable<string> Get()
        {
            return _names;
        }

        [HttpGet("GetByID/{id:int}")]
        public string Get([FromRoute] int id)
        {
            _count++;
            Console.WriteLine($"call number {_count}");
            if (_count <= 3)
            {
                Thread.Sleep(3000);
            }
            if (id >= _names.Length)
                return "Wrong id!";
            return _names[id];
        }
    }
}
