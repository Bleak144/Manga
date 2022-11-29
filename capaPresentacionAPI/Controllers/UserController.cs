using capaPresentacionAPI.Models;
using DataLayerAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using PresentationLayerAPI.Models;

namespace capaPresentacionAPI.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("api/crearRegistro")]
        public ResponseSignUp SignUp([FromBody] RequestSignUp request)
        {
            ResponseSignUp response = new ResponseSignUp();
            response.result = mangaRebyuDataUser.createRegister(request.userName, request.password);
            return response;
        }

        [HttpGet]
        [Route("api/consultarIngreso")]
        public ResponseLogin Login([FromQuery]RequestLogin request)
        {
            ResponseLogin response = new ResponseLogin();
            response.result = mangaRebyuDataUser.searchIncome(request.userName,request.password);
            return response;
        }
    }
}
