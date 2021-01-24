using Microsoft.AspNetCore.Antiforgery;
using FMS.Controllers;

namespace FMS.Web.Host.Controllers
{
    public class AntiForgeryController : FMSControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
