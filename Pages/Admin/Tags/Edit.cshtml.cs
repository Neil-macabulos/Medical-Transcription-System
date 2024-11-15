using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicalTranscriptionSystem.Pages.Manage.Tags
{
    public class EditModel : PageModel
    {
        private static List<Item> _items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1", Price = 10.0M },
            new Item { Id = 2, Name = "Item 2", Price = 20.0M }
        };

        [BindProperty]
        public Item Items { get; set; }

        public IActionResult OnGet(int id)
        {
            Items = _items.FirstOrDefault(i => i.Id == id);

            if (Items == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var existingItem = _items.FirstOrDefault(i => i.Id == Items.Id);
            if (existingItem != null)
            {
                existingItem.Name = Items.Name;
                existingItem.Price = Items.Price;
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
