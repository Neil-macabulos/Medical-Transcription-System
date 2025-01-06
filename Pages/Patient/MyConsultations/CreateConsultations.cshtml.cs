using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PatientConsultationsDemo.Pages;

namespace CreateConsultationDemo.Pages
{
    public class CreateConsultationModel : PageModel
    {
        [BindProperty]
        public Consultation NewConsultation { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Simulate storing the consultation (e.g., to a database)
                // For simplicity, we just log it in the console for now.
                Console.WriteLine($"Consultation Created: {NewConsultation.PatientName}, {NewConsultation.Date}, {NewConsultation.Findings}");

                // Redirect to a list of consultations after creation
                return RedirectToPage("/ConsultationsList");
            }

            return Page(); // If validation fails, return to the same page
        }
    }

    public class Consultation
    {
        public string PatientName { get; set; }
        public DateTime Date { get; set; }
        public string Findings { get; set; }
        public string Recommended { get; set; }
        public string Treatments { get; set; }
    }