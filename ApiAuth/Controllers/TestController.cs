using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("Anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet("Authenticated")]
        [Authorize]
        public string Authenticated() => $"Autenticado - {User.Identity.Name}";

        [HttpGet("Employee")]
        [Authorize(Roles = "Employee")]
        public string Employee() => "Funcionário";

        [HttpGet("Manager")]
        [Authorize(Roles = "Manager")]
        public string Manager() => "Gerente";
    }
}
