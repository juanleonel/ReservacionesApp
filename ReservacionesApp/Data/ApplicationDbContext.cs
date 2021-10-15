using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using ReservacionesApp.Entities;

namespace ReservacionesApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Motociclista> Motociclista { get; set; }
        public DbSet<Servicio> Servicio { get; set; }

        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=ReservacionesDB;Trusted_Connection=True;");                
            }
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            // configures one-to-many relationship 

            //builder.Entity<Motociclista>()
            //    .HasOne(x => x.servicio)
            //    .WithMany(y => y.Motociclistas)
            //    .HasForeignKey(x => x.ServicioId)
            //    .HasPrincipalKey(x => x.ServicioId)
            //    .IsRequired();
        }
         
    }
}
