using Microsoft.AspNetCore.Antiforgery;
using TeknoLabs.Habit.Controllers;

namespace TeknoLabs.Habit.Web.Host.Controllers
{
    public class AntiForgeryController : HabitControllerBase
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
