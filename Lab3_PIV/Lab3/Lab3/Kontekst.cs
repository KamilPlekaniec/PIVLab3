using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Kontekst : DbContext
    {
        //pierwszy sposob
        public DbSet<Zajecia> Zajecias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        //drugi sposob fluent 
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder
        //        .Entity<Zajecia>()
        //        .Property(x => x.Nazwa)
        //        .HasMaxLength(255)
        //        .IsRequired()
        //        .HasColumnName("NazwaFluent");

        //}
    }
}
