using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Practica_2.Data;
using Practica_2.Models;

namespace Practica_2.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Practica_2.Data.TareaDBContext _context;

        public CreateModel(Practica_2.Data.TareaDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tarea Tarea { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tareas.Add(Tarea);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
