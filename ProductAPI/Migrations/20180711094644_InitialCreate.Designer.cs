﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Data.Context;

namespace ProductAPI.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20180711094644_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductAPI.Models.Product", b =>
                {
                    b.Property<string>("GuProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Category");

                    b.Property<string>("Code");

                    b.Property<string>("CostPrice");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<string>("Description");

                    b.Property<string>("GuTaxGrpId");

                    b.Property<string>("Image");

                    b.Property<int>("MinStock");

                    b.Property<int>("ProdStatus");

                    b.Property<string>("ProductName");

                    b.Property<int>("Sku");

                    b.Property<int>("Taxable");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitQty");

                    b.HasKey("GuProductId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
