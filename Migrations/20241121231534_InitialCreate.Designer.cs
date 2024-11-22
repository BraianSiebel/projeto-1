﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MinhaPrimeiraApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241121231534_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nome")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
