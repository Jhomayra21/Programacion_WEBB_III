using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Practica_2.Data;
using Practica_2.Models;

namespace Practica_2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Practica_2.Data.TareaDBContext _context;

        public IndexModel(Practica_2.Data.TareaDBContext context)
        {
            _context = context;
        }

        public IList<Tarea> Tarea { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tarea = await _context.Tareas.ToListAsync();
        }
    }
}
