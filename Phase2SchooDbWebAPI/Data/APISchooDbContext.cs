using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phase2SchooDbWebAPI.Models;
using Phase2SchoolDbWebAPI.Models;

namespace Phase2SchooDbWebAPI.Data
{
    public class APISchooDbContext : DbContext
    {
        public APISchooDbContext (DbContextOptions<APISchooDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phase2SchooDbWebAPI.Models.Students> Students { get; set; } = default!;

        public DbSet<Phase2SchoolDbWebAPI.Models.Subject>? Subject { get; set; }
    }
}
