using System.Collections.Generic;
using CMCS.Models;

namespace CMCS.ViewModels
{
    public class VerifyClaimVM
    {
        public List<Claim> PendingClaims { get; set; } = new();
        public string PrototypeNote =>
            "Prototype only: Approve/Reject are disabled in Part-1.";
    }
}
