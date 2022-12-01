using BusinessLayer;
using DataLayerAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresentationLayerAPI.Models;

namespace PresentationLayerAPI.Controllers
{
    [ApiController]
    public class MangaController : ControllerBase
    {
        [HttpPost]
        [Route("api/createRegisterMovil")]
        public ResponseMovil moviltoAPI([FromBody]RequestMovil request)
        {
            Business business = new Business(new mangaRebyuDataManga(), new mangaRebyuDataUser());
            ResponseMovil response = new ResponseMovil();
            response.response = business.createRegisterManga(request.username, request.idManga, request.rating, request.coment);
            return response;
        }

        [HttpGet]
        [Route("api/sendDataMovil")]
        public ResponseSendDataMovil APIMovil([FromQuery]RequestSendDataMovil request)
        {
            Business business = new Business(new mangaRebyuDataManga(), new mangaRebyuDataUser());
            ResponseSendDataMovil response = new ResponseSendDataMovil();
            response.data = business.sendDataMovil(request.idManga);
            return response;
        }

        [HttpGet]
        [Route("api/sendDataDesktop")]
        public ResponseSendDataDesktop APIDesktop([FromQuery] RequestSendDataDesktop request)
        {
            Business business = new Business(new mangaRebyuDataManga(), new mangaRebyuDataUser());
            ResponseSendDataDesktop response = new ResponseSendDataDesktop();
            response.info = business.sendDataDesktop();
            return response;
        }
    }
}
