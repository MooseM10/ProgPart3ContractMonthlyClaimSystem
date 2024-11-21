using ContractMonthlyClaimSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class AcademicManagerController : Controller
    {
        public IActionResult Index()
        {
            var claims = LocalStorage.GetClaims().Where(c => c.Status == "Pending AC Approval").ToList();
            return View(claims);
        }

        [HttpPost]
        public IActionResult Approve(int claimId)
        {
            var claim = LocalStorage.GetClaims().FirstOrDefault(c => c.Id == claimId);
            if (claim != null)
            {
                claim.Status = "Approved";
                LocalStorage.UpdateClaim(claim);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Reject(int claimId)
        {
            var claim = LocalStorage.GetClaims().FirstOrDefault(c => c.Id == claimId);
            if (claim != null)
            {
                claim.Status = "Rejected by AC";
                LocalStorage.UpdateClaim(claim);
            }
            return RedirectToAction("Index");
        }
    }
}
