using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PatientConsultationsDemo.Pages
{
    public class PatientConsultationsModel : PageModel
    {
        [BindProperty]
        public Patient Patient { get; set; }
        public List<Consultation> Consultations { get; set; }

        public void OnGet()
        {
            // Simulate loading patient data
            Patient = new Patient
            {
                Name = "John Doe",
                Email = "johndoe@example.com",
                DateOfBirth = new DateTime(1985, 5, 15)
            };

            // Simulate loading consultations for the patient
            Consultations = new List<Consultation>
            {
                new Consultation { Id = 1, Date = DateTime.Now.AddDays(-5), Findings = "Blood Pressure Elevated", Recommended = "Reduce Salt Intake", Treatments = "Prescribed Blood Pressure Medication" },
                new Consultation { Id = 2, Date = DateTime.Now.AddDays(-3), Findings = "Normal", Recommended = "Continue Healthy Diet", Treatments = "No Treatment" }
            };
        }
    }

    public class Patient
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class Consultation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Findings { get; set; }
        public string Recommended { get; set; }
        public string Treatments { get; set; }
    }
}
