﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalShop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopEntities : DbContext
    {
        public ShopEntities()
            : base("name=ShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Branduri> Branduris { get; set; }
        public virtual DbSet<CategoriiProduse> CategoriiProduses { get; set; }
        public virtual DbSet<Cumparare> Cumparares { get; set; }
        public virtual DbSet<CumparareItem> CumparareItems { get; set; }
        public virtual DbSet<Produse> Produses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vanzatori> Vanzatoris { get; set; }
    }
}