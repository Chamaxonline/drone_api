using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Context
{
    public class DroneDbContext : DbContext
    {
        public DroneDbContext(DbContextOptions<DroneDbContext> options) : base(options)
        { }

        public DbSet<Drone> Drone { get; set; }
        
        public DbSet<Medication> Medication { get; set; }

    }
}
