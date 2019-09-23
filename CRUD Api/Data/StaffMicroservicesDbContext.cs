using CRUD_Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_Api.Data
{
    public class StaffMicroservicesDbContext
    {
        public DbSet<StaffMicroservices> staffmicroservices { get; set; }
    }


//protected override void OnModelCreating(DbModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<StaffMicroservicesDB>().ToTable("StaffMicroservicesDB");
//    }
}