using Microsoft.AspNetCore.Mvc;

namespace ApiRoles.Controllers
{
    [Route("api/[controller]")]
    public class RolesController : Controller
    {
        private Dictionary<int, List<string>> _roles =
            new()
            {
                { 0,new List<string>{"Admin","Support" } },
                { 1,new List<string>{"Manager", } },
                { 2,new List<string>{"Support","Manager","Technical" } }
            };

        [HttpGet("GetByID/{id:int}")]
        public List<string> Get([FromRoute] int id)
        {
            return _roles.FirstOrDefault(x=>x.Key.Equals(id)).Value;
        }
    }
}
