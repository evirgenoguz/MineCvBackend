using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MinecvdbContext: DbContext
    {

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer(@"Server = DESKTOP-PAPTNUR;Database = Minecvdb;Trusted_Connection=true");
    }
}
