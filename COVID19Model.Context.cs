﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COVID19_ContactTracing
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class COVID19Entities : DbContext
    {
        public COVID19Entities()
            : base("name=COVID19Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ContactTracing> ContactTracings { get; set; }
        public virtual DbSet<FTE> FTEs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
    }
}