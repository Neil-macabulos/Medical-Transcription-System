using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicalTranscriptionSystem.Pages.Provider.Consultations
{
    public class AddPatientModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        private static List<Patient> _patients = new List<Patient>();

        [BindProperty]
        public Patient Patient { get; set; }

        public AddPatientModel(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Patient.ProfilePictureFile != null)
            {
                var fileExtension = Path.GetExtension(Patient.ProfilePictureFile.FileName);

                var fileName = $"{Guid.NewGuid()}{fileExtension}";

                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await Patient.ProfilePictureFile.CopyToAsync(fileStream);
                }

                Patient.ProfilePicture = $"/uploads/{fileName}";
            }

            Patient.Id = _patients.Any() ? _patients.Max(p => p.Id) + 1 : 1;
            _patients.Add(Patient);

            return RedirectToPage("/Index");
        }
    }
}
