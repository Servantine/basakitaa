using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using basakitaa.Models;

namespace basakitaa.Data
{
    public class basakitaaContext : DbContext
    {
        public basakitaaContext (DbContextOptions<basakitaaContext> options)
            : base(options)
        {
        }

        public DbSet<basakitaa.Models.User> User { get; set; } = default!;
    }
}
