using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabajoEnEquipo.Models;

    public class BDContext : DbContext
    {
        public BDContext (DbContextOptions<BDContext> options)
            : base(options)
        {
        }

        public DbSet<TrabajoEnEquipo.Models.Car> Car { get; set; }

        public DbSet<TrabajoEnEquipo.Models.Student> Student { get; set; }

        public DbSet<TrabajoEnEquipo.Models.Edificio> Edificio { get; set; }
    }
