using curso.api.Filters;
using curso.api.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace curso.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo.
        /// </summary>
        /// <param name="_loginViewModelInput"></param>
        /// <returns>Retorna status ok,dados do usuario e o token em caso de sucesso</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar",Type = typeof(LoginViewModelInPut))]
        [SwaggerResponse(statusCode:400, description:"Campos Obrigatorios",Type =typeof(ValidaCampoViewModel))]
        [SwaggerResponse(statusCode:500, description:"Erro Interno",Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        [ValidacaoModelStateFilterCustomizado]
        public IActionResult Logar(LoginViewModelInPut _loginViewModelInput)
        {
           
            return Ok(_loginViewModelInput);
        }
        /// <summary>
        /// Este serviço permite registrar um usuário
        /// </summary>
        /// <param name="_registroViewModelInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelStateFilterCustomizado]
        public IActionResult Registrar(RegistroViewModelInput _registroViewModelInput)
        {
            return Created("", _registroViewModelInput);
        }
    }
}
