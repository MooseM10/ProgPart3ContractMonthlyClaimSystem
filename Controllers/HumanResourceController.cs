using ContractMonthlyClaimSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class HumanResourceController : Controller
    {
        public IActionResult Index()
        {
            var claims = LocalStorage.GetClaims().Where(c => c.Status == "Approved by AM").ToList();
            return View(claims);
        }
    }
}
