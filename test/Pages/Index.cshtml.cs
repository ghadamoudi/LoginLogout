using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly test.Data.UserContext _context;

        public IndexModel(test.Data.UserContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var tempUser = _context.User.FirstOrDefault(u => u.Name == Username && u.Password == Password);
            if (tempUser != null)
            {
                HttpContext.Session.SetString("username", Username);
                return RedirectToPage("WelcomeUser");
            }
            else
            {
                Msg = "Invalid username or password!";
                return Page();
            }
        }
    }
}