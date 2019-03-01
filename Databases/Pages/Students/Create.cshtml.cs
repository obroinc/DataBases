using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Databases.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Databases.Pages.Students
{
    public class CreateModel : PageModel
    {

          
        private readonly CollegeContext _db;

        public CreateModel(CollegeContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();

        public void OnGet()
        {

                


        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(Student);
                await _db.SaveChangesAsync();
                return RedirectToPage("ListStudents");
            }
            else
            {
                return Page();
            }
        }
    }
}