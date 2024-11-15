using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicalTranscriptionSystem.Pages.Manage.Tags
{
    public class AddModel : PageModel
    {
        private static List<Item> _items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1", Price = 10.0M },
            new Item { Id = 2, Name = "Item 2", Price = 20.0M }
        };

        [BindProperty]
        public Item Items { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Index");
        }
        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
