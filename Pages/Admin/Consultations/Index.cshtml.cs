using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace MedicalTranscriptionSystem.Pages.Admin.Consultations
{
    public class IndexModel : PageModel
    {
        private static List<Patient> _patients = new List<Patient>();

        [BindProperty]
        public Patient NewPatient { get; set; }

        public List<Patient> Patients { get; set; }

        public void OnGet()
        {
            Patients = _patients;
        }

        public IActionResult OnPostCreate()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NewPatient.Id = _patients.Any() ? _patients.Max(p => p.Id) + 1 : 1;

            _patients.Add(NewPatient);

            return RedirectToPage();
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage();
        }
    }
}
