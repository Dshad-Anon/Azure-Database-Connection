using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure2soln.Models;

namespace Azure2soln.Data
{
    public class Azure2solnContext : DbContext
    {
        public Azure2solnContext (DbContextOptions<Azure2solnContext> options)
            : base(options)
        {
        }

        public DbSet<Azure2soln.Models.ToDo> ToDo { get; set; } = default!;
    }
}
