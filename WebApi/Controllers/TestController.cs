using System.Collections.Generic;
using System.Web.Http;
using WebApi.Models;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        [Authorize]
        [HttpGet]
        [Route("api/users")]
        public IHttpActionResult GetUsers() // ~/api/users adresine GET isteği ile alabileceğiniz kullanıcı bilgilerini json olarak gönderir
        {
            var x = new UsersRepository();
            List<UsersWithoutPass> users = x.GetUsers();

            return Json(users);
        }
    }
}