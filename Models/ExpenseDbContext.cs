using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackIt.Models
{
    public class ExpenseDbContext:DbContext
    {
        public virtual DbSet<ExpenseReport> ExpenseReport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=HOPE-NDUDIM\\SQLEXPRESS;Database=TrackItDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}
