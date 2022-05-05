using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeapYears.Models;

namespace LeapYears.Data
{
    /*public class ContextDB : IdentityDbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options): base(options) { }
    
        public DbSet<YearUser> User { get; set; }
        public DbSet<HistoryUser> History { get; set; }
    }*/



    // ---- Stary context ----

    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options) { }
        public DbSet<YearUser> User { get; set; }
        public DbSet<HistoryUser> History { get; set; }
    }




}
