using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicalTranscriptionSystem.Pages.Manage.Treatments
{
    public class IndexModel : PageModel
    {
        public class ViewModel
        {
            public Guid? Id { get; set; }
            public string? Name { get; set; }
            public string? IsActive { get; set; }

        }
    }
}
