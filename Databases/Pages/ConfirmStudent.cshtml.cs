using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Databases.Pages
{
    public class ConfirmStudentModel : PageModel
    {
        public string StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void OnGet()
        {

        }
    }
}