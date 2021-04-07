using Aula2TrilhaDotNet.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Context {
    public class LocalDbContext: DbContext {

        public LocalDbContext(DbContextOptions<LocalDbContext> opt) : base(opt) {

        }

        public  DbSet<SerraCircular> serra_circular { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

        }
    }
}
