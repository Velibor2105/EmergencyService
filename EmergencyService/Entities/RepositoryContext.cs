using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Comment> Comment { get; set; }
        public DbSet<EmergencySitutation> EmergencySitutation { get; set; }
        public DbSet<Municipality> Municipality { get; set; }
        public DbSet<StateOfVolunteer> StateOfVolunteer { get; set; }
        public DbSet<Territory> Territory { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }
    }
}
