using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; } // Lecturer, ProgramCoordinator, AcademicManager, HumanResource
    }
}
