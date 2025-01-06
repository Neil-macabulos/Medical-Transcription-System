using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MedicalTranscriptionSystem.Pages.Public
{
    public class PatientSignUpModel : PageModel
    {
        [BindProperty]
        public Patient Patient { get; set; }

        public bool IsSubmitted { get; set; }

        public string FullNameError { get; set; }
        public string EmailError { get; set; }
        public string DateOfBirthError { get; set; }
        public string PhoneNumberError { get; set; }

        public void OnGet()
        {
            Patient = new Patient();
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                // Simulate saving to database or performing business logic.
                IsSubmitted = true;

                // Reset errors
                FullNameError = null;
                EmailError = null;
                DateOfBirthError = null;
                PhoneNumberError = null;
            }
            else
            {
                // Capture validation errors
                FullNameError = "Please enter a valid name.";
                EmailError = "Please enter a valid email.";
                DateOfBirthError = "Please select a valid date of birth.";
                PhoneNumberError = "Please enter a valid phone number.";
            }
        }
    }

    public class Patient
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
