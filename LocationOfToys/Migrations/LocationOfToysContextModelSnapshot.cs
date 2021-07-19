﻿// <auto-generated />
using System;
using LocationOfToys.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocationOfToys.Migrations
{
    [DbContext(typeof(LocationOfToysContext))]
    partial class LocationOfToysContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocationOfToys.Models.Box", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoxColour");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Box");
                });

            modelBuilder.Entity("LocationOfToys.Models.Toy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BoxId");

                    b.Property<string>("Name");

                    b.Property<int>("ToyCategory");

                    b.HasKey("Id");

                    b.HasIndex("BoxId");

                    b.ToTable("Toy");
                });

            modelBuilder.Entity("LocationOfToys.Models.Toy", b =>
                {
                    b.HasOne("LocationOfToys.Models.Box")
                        .WithMany("Toys")
                        .HasForeignKey("BoxId");
                });
#pragma warning restore 612, 618
        }
    }
}
