﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAngularApp.Domain;

namespace MyAngularApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181109155246_AddStatus")]
    partial class AddStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyAngularApp.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("MyAngularApp.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MyAngularApp.Domain.Operation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("MyAngularApp.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId");

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime>("DatePlaced");

                    b.Property<string>("Location");

                    b.Property<string>("Notes");

                    b.Property<int?>("OperationId");

                    b.Property<int>("Status");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OperationId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyAngularApp.Domain.Order", b =>
                {
                    b.HasOne("MyAngularApp.Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("MyAngularApp.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("MyAngularApp.Domain.Operation", "Operation")
                        .WithMany()
                        .HasForeignKey("OperationId");
                });
#pragma warning restore 612, 618
        }
    }
}
