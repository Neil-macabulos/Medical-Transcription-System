using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicalTranscriptionSystem.Pages.Manage.Users
{
    public class IndexModel : PageModel
    {
        public class ViewModel
        {
            public Guid? Id { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? EmailAddress { get; set; }
            public string? Role { get; set; }
            public string? IsActive { get; set; }
        }
    }
}
