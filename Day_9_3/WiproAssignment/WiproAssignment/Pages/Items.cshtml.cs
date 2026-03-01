using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WiproAssignment.Pages
{
    public class ItemsModel : PageModel
    {
        private static List<string> _items = new List<string>();

        public List<string> Items => _items;

        [BindProperty]
        public string NewItem { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(NewItem))
            {
                _items.Add(NewItem);
            }

            return Page();
        }
    }
}
