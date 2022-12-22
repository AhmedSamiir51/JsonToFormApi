using ConvertJsonToForm.DAL.Module;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertJsonToForm.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Forms> Forms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
