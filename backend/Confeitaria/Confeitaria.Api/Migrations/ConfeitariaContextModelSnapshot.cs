﻿// <auto-generated />
using Confeitaria.Api.Infra.ContextDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Confeitaria.Api.Migrations
{
    [DbContext(typeof(ConfeitariaContext))]
    partial class ConfeitariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Confeitaria.Api.Entities.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Ingredientes");
                });
#pragma warning restore 612, 618
        }
    }
}