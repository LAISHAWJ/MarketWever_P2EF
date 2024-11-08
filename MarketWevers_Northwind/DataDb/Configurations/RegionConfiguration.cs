﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using MarketWevers_Northwind.DataDb;
using MarketWevers_Northwind.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MarketWevers_Northwind.DataDb.Configurations
{
    public partial class RegionConfiguration : IEntityTypeConfiguration<Models.Region>
    {
        public void Configure(EntityTypeBuilder<Models.Region> entity)
        {
            entity.HasKey(e => e.RegionId).IsClustered(false);

            entity.ToTable("Region");

            entity.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("RegionID");
            entity.Property(e => e.RegionDescription)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Models.Region> entity);
    }
}
