﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPO_Solutions
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BPOContext : DbContext
    {
        public BPOContext()
            : base("name=BPOContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Allowances> Allowances { get; set; }
        public virtual DbSet<Diabetic_Patients> Diabetic_Patients { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Equipments> Equipments { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Salaries> Salaries { get; set; }
    }
}
