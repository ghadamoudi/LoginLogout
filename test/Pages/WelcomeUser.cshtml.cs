using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace test.Pages
{
    public class WelcomeUserModel : PageModel
    {
        public string Username { get; set; }

        public void OnGet()
        {
            Username = HttpContext.Session.GetString("username");
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToPage("Index");
        }
    }
}