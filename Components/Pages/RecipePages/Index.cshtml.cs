using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ratatouille.Data;
using Ratatouille.Models;

namespace Ratatouille.Components.Pages.RecipePages
{
    public class IndexModel : PageModel
    {
        private readonly Ratatouille.Data.RatatouilleContext _context;

        public IndexModel(Ratatouille.Data.RatatouilleContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe.ToListAsync();
        }
    }
}
