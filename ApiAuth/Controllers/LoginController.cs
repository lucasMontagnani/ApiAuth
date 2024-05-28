using ApiAuth.Models;
using ApiAuth.Repositories;
using ApiAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost("Login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User usuario)
        {
            var user = UserRepository.Get(usuario.Username, usuario.Password);

            if (user == null)
            {
                return NotFound(new { message = "Nome de usuário ou senha inválidos" });
            }

            var token = TokenService.GenerateToken(user);

            return token;
        }
    }
}
