﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using basakitaa.Data;
using basakitaa.Models;

namespace basakitaa.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly basakitaa.Data.basakitaaContext _context;

        public IndexModel(basakitaa.Data.basakitaaContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
