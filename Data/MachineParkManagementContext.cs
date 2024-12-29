using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MachineParkManagement.Models;

    public class MachineParkManagementContext : DbContext
    {
        public MachineParkManagementContext (DbContextOptions<MachineParkManagementContext> options)
            : base(options)
        {
        }

        public DbSet<MachineParkManagement.Models.Machine> Machine { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Machine>().HasData(
                new Machine
                {
                    Id = Guid.NewGuid(), // Generate string ID
                    Name = "Machine 1",
                    Status = "Online",
                    LastData = "Temp: 72C"
                },
                new Machine
                {
                    Id = Guid.NewGuid(), // Generate string ID
                    Name = "Machine 2",
                    Status = "Offline",
                    LastData = "Temp: 68C"
                }
            );
        }
    }
