﻿// <auto-generated />
using CRUD_DotNetTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_DotNetTest.Migrations
{
    [DbContext(typeof(CRUD_DotNetTestContext))]
    partial class CRUD_DotNetTestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRUD_DotNetTest.Model.Produk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Harga")
                        .HasColumnType("int");

                    b.Property<string>("Nama_Barang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Produk");
                });
#pragma warning restore 612, 618
        }
    }
}
