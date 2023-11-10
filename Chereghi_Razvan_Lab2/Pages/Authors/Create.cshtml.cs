﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Chereghi_Razvan_Lab2.Data;
using Chereghi_Razvan_Lab2.Models;

namespace Chereghi_Razvan_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Chereghi_Razvan_Lab2.Data.Chereghi_Razvan_Lab2Context _context;

        public CreateModel(Chereghi_Razvan_Lab2.Data.Chereghi_Razvan_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Author == null || Author == null)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}