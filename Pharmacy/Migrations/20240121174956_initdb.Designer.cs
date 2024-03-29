﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pharmacy.Data.Models;

#nullable disable

namespace Pharmacy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240121174956_initdb")]
    partial class initdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pharmacy.Data.Model.Medicine", b =>
                {
                    b.Property<string>("med_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("med_expired_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("med_id")
                        .HasColumnType("int");

                    b.Property<string>("med_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("med_price")
                        .HasColumnType("int");

                    b.Property<string>("med_produced_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
