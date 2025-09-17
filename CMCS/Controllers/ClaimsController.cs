using Microsoft.AspNetCore.Mvc;
using CMCS.Models;
using CMCS.ViewModels;
using System;
using System.Collections.Generic;

namespace CMCS.Controllers
{
    public class ClaimsController : Controller
    {
        private static readonly List<Claim> SampleClaims = new()
        {
            new Claim
            {
                Id = 1001,
                LecturerId = "L001",
                LecturerName = "Dr Jack harlow",
                PeriodStart = new DateTime(2025, 8, 1),
                PeriodEnd = new DateTime(2025, 8, 31),
                HoursWorked = 12.5m,
                HourlyRate = 500m,
                Status = ClaimStatus.UnderReview,
                Notes = "Guest lectures and assessment marking."
            },
            new Claim
            {
                Id = 1002,
                LecturerId = "L002",
                LecturerName = "Mr Namjoon RM",
                PeriodStart = new DateTime(2025, 8, 1),
                PeriodEnd = new DateTime(2025, 8, 31),
                HoursWorked = 20m,
                HourlyRate = 450m,
                Status = ClaimStatus.Submitted
            },
            new Claim
            {
                Id = 1003,
                LecturerId = "L003",
                LecturerName = "Dr Taehyung V",
                PeriodStart = new DateTime(2025, 7, 1),
                PeriodEnd = new DateTime(2025, 7, 31),
                HoursWorked = 18m,
                HourlyRate = 500m,
                Status = ClaimStatus.Approved
            }
        };
        [HttpGet]
        public IActionResult Submit()
        {
            var vm = new SubmitClaimVM
            {
                Lecturer = new Lecturer
                {
                    Id = "L001",
                    FullName = "Dr Jack Harlow",
                    Email = "jackharlow@campus.ac.za",
                    Department = "IT"
                },
                Claim = new Claim
                {
                    PeriodStart = DateTime.Today.AddDays(-30),
                    PeriodEnd = DateTime.Today,
                    HoursWorked = 0m,
                    HourlyRate = 500m,
                    Status = ClaimStatus.Draft
                }
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Submit(SubmitClaimVM vm)
        {
            ViewBag.Message = "Prototype: submission is not saved in Part-1.";
            return View(vm);
        }
        [HttpGet]
        public IActionResult Track()
        {
            // Show "my" claims for L001 in the prototype.
            var mine = SampleClaims.FindAll(c => c.LecturerId == "L001");
            return View(mine);
        }
        [HttpGet]
        public IActionResult Verify()
        {
            var vm = new VerifyClaimVM
            {
                PendingClaims = SampleClaims
                    .FindAll(c => c.Status == ClaimStatus.Submitted || c.Status == ClaimStatus.UnderReview)
            };
            return View(vm);
        }
    }
}
