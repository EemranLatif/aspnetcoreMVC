using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreMVC.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {

        public IActionResult ManageUsers()
        {
            return View();
        }
    }
}
