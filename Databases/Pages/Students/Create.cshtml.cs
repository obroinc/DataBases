﻿using System;
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


        [BindProperty]

        public Student Student { get; set; } = new Student();

        public void OnGet()
        {

        }
    }
}