using System;

namespace CMCS.Models
{
    public class Claim
    {
        public int Id { get; set; }                  
        public string LecturerId { get; set; } = "";
        public string LecturerName { get; set; } = "";
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string? Notes { get; set; }
        public ClaimStatus Status { get; set; } = ClaimStatus.Draft;

        
        public decimal TotalAmount => Math.Round(HoursWorked * HourlyRate, 2);

        
        public List<SupportingDocument> Documents { get; set; } = new();
    }
}
