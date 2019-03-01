using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Databases.Pages
{
    public class RouteDataParametersModel : PageModel
    {
        //care is needed with the bindmethod

        [BindProperty(SupportsGet = true)]
            public string Message { get; set; }//Message has to be spelt like the parameter in cshtml page




        // public string Mess { get; set; }
        //public void OnGet(string message)
        // {
        // Mess = message;
        //}
    }
}