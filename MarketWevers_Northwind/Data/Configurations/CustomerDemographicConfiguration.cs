﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using MarketWevers_Northwind.DATA;
using MarketWevers_Northwind.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MarketWevers_Northwind.DATA.Configurations
{
    public partial class CustomerDemographicConfiguration : IEntityTypeConfiguration<CustomerDemographic>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographic> entity)
        {
            entity.HasKey(e => e.CustomerTypeId).IsClustered(false);

            entity.Property(e => e.CustomerTypeId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CustomerTypeID");
            entity.Property(e => e.CustomerDesc).HasColumnType("ntext");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CustomerDemographic> entity);
    }
}
