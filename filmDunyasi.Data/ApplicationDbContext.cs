using System;
using System.Collections.Generic;
using System.Text;
using filmDunyasi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace filmDunyasi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Native> Native { get; set; }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Country> Country { get; set; }

        public DbSet<Director> Director { get; set; }

        public DbSet<Film> Film { get; set; }

        public DbSet<FilmActor> FilmActor { get; set; }

        public DbSet<Salon> Salon { get; set; }

        public DbSet<Screening> Screening { get; set; }

        public DbSet<Ticket> Ticket { get; set; }

        public DbSet<Town> Town { get; set; }

    }
}
