﻿// <auto-generated />
using G_Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace G_Store.Migrations
{
    [DbContext(typeof(GS_Dbcontext))]
    [Migration("20231114143241_CreateSupplierTable")]
    partial class CreateSupplierTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("G_Store.Customer", b =>
                {
                    b.Property<int>("cus_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cus_id"));

                    b.Property<string>("cus_add")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cus_contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("due")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cus_id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("G_Store.Supplier", b =>
                {
                    b.Property<int>("sup_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sup_id"));

                    b.Property<string>("sup_com")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sup_contact")
                        .HasColumnType("int");

                    b.Property<string>("sup_location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sup_id");

                    b.ToTable("Suppliers");
                });
#pragma warning restore 612, 618
        }
    }
}
