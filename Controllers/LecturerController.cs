using ContractMonthlyClaimSystem.Data;
using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Models;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Index()
        {
            var lecturerId = "lecturer1"; // Example, replace with logged-in lecturer's ID
            var claims = LocalStorage.GetClaims().Where(c => c.LecturerId == lecturerId).ToList();
            return View(claims);
        }

        [HttpPost]
        public IActionResult SubmitClaim(decimal hoursWorked, decimal hourlyRate)
        {
            var claim = new Claim
            {
                Id = LocalStorage.GetClaims().Count + 1,
                LecturerId = "lecturer1",
                LecturerName = "John Doe",
                HoursWorked = hoursWorked,
                HourlyRate = hourlyRate,
                Status = "Pending PC Approval",
                SubmissionDate = DateTime.Now
            };

            LocalStorage.AddClaim(claim);
            return RedirectToAction("Index");
        }
    }
}
