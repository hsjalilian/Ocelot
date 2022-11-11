using Microsoft.AspNetCore.Mvc;

namespace ApiService.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet("GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Apple Pencil", "HP DeskJet" , "SanDisk 128GB", "Apple Lightning to USB Cable" };
        }
    }
}
