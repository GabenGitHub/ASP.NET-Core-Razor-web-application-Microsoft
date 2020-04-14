using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppPractice.Model;

namespace MSWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        private ILogger<CreateModel> _log;
        
        public CreateModel(ApplicationDbContext db, ILogger<CreateModel> log)
        {
            _db = db;
            _log = log;
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _db.Customers.Add(Customer);
            await _db.SaveChangesAsync();
            var msg = $"Customer {Customer.Name} added!";
            Message = msg;
            _log.LogCritical(msg);
            return RedirectToPage("/Index");
        }
    }
}
