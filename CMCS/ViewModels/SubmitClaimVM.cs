using CMCS.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace CMCS.ViewModels
{
    public class SubmitClaimVM
    {
        public Lecturer Lecturer { get; set; } = new();
        public Claim Claim { get; set; } = new();
        // Not used in prototype; shows intended API surface.
        public List<IFormFile>? Files { get; set; }
        public string PrototypeNote =>
            "Prototype only: this form does not persist or upload yet.";
    }
}
