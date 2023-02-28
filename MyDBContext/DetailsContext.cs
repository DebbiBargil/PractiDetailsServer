using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PractiDetails.Models;

namespace PractiDetails.Repositories;

public partial class DetailsContext : DbContext,IContext
{
    public DetailsContext()
    {
    }

    public DetailsContext(DbContextOptions<DetailsContext> options)
        : base(options)
    {
    }

    public  DbSet<Child> children { get; set; }
 
    public  DbSet<Parent> parents { get; set; }
 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=sqlsrv;Initial Catalog=proDebbi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>()
            .Property(b => b.IdNumber)
            .IsRequired();
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
