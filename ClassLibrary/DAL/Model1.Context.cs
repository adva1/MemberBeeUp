﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ClassLibrary.DAL
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class igroup36_prodEntities : DbContext
{
    public igroup36_prodEntities()
        : base("name=igroup36_prodEntities")
    {

        this.Configuration.LazyLoadingEnabled = false;

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Benefit_Type> Benefit_Types { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Category1> Categories1 { get; set; }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Club> Clubs { get; set; }

    public virtual DbSet<Club_Benefit_Type> Club_Benefit_Type { get; set; }

    public virtual DbSet<Club_Customer> Club_Customer { get; set; }

    public virtual DbSet<Club_Required_Fields> Club_Required_Fields { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Customer_subCategory> Customer_subCategory { get; set; }

    public virtual DbSet<Required_Field> Required_Fields { get; set; }

    public virtual DbSet<subCategory> subCategories { get; set; }

    public virtual DbSet<CategoryChoice> CategoryChoices { get; set; }

}

}

