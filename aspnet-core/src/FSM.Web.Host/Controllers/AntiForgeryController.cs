using Microsoft.AspNetCore.Antiforgery;
using FSM.Controllers;

namespace FSM.Web.Host.Controllers
{
    public class AntiForgeryController : FSMControllerBase
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
