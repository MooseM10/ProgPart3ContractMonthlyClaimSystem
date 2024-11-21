using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public string LecturerName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalAmount => HoursWorked * HourlyRate;
        public string Status { get; set; } // Pending PC Approval, Pending AM Approval, Approved by AM, Rejected
        public DateTime SubmissionDate { get; set; }
    }
  
}
