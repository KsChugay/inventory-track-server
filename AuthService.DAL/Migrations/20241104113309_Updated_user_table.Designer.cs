﻿// <auto-generated />
using System;
using AuthService.DAL.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuthService.DAL.Migrations
{
    [DbContext(typeof(AuthDbContext))]
    [Migration("20241104113309_Updated_user_table")]
    partial class Updated_user_table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthService.Domain.Enities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LegalAddress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("PostalAddress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid>("ResponsibleUserId")
                        .HasColumnType("uuid");

                    b.Property<int>("Unp")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResponsibleUserId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("AuthService.Domain.Enities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b0a4c4d1-180a-4884-952b-3ebf51616af1"),
                            IsDeleted = false,
                            Name = "Resident"
                        },
                        new
                        {
                            Id = new Guid("84299b0e-7ad1-4378-884e-7979c1d56978"),
                            IsDeleted = false,
                            Name = "Department Head"
                        },
                        new
                        {
                            Id = new Guid("c478504c-142b-4fdc-b592-c3ff7273c1b6"),
                            IsDeleted = false,
                            Name = "Warehouse Manager"
                        },
                        new
                        {
                            Id = new Guid("2e3a8e1c-f00b-4f6a-99d0-2d84c150313b"),
                            IsDeleted = false,
                            Name = "Accountant"
                        });
                });

            modelBuilder.Entity("AuthService.Domain.Enities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuthService.Domain.Enities.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("AuthService.Domain.Enities.Company", b =>
                {
                    b.HasOne("AuthService.Domain.Enities.User", null)
                        .WithMany()
                        .HasForeignKey("ResponsibleUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AuthService.Domain.Enities.User", b =>
                {
                    b.HasOne("AuthService.Domain.Enities.Company", null)
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("AuthService.Domain.Enities.UserRole", b =>
                {
                    b.HasOne("AuthService.Domain.Enities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuthService.Domain.Enities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}