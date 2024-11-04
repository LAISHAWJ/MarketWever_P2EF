﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using MarketWevers_Northwind.Data;
using MarketWevers_Northwind.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MarketWevers_Northwind.Data.Configurations
{
    public partial class ProductSalesFor1997Configuration : IEntityTypeConfiguration<ProductSalesFor1997>
    {
        public void Configure(EntityTypeBuilder<ProductSalesFor1997> entity)
        {
            entity
                .HasNoKey()
                .ToView("Product Sales for 1997");

            entity.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(15);
            entity.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(40);
            entity.Property(e => e.ProductSales).HasColumnType("money");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProductSalesFor1997> entity);
    }
}