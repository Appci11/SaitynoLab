﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaitynoLab.Server.Data;

#nullable disable

namespace SaitynoLab.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SaitynoLab.Shared.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<bool>("ToAssemble")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Furniture");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Stalas1",
                            OrderId = 1,
                            ToAssemble = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Stalas2",
                            OrderId = 1,
                            ToAssemble = true
                        });
                });

            modelBuilder.Entity("SaitynoLab.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuyerId = 1,
                            DateCreated = new DateTime(2022, 10, 2, 15, 21, 3, 314, DateTimeKind.Local).AddTicks(3449),
                            Email = "Pvz.pastas@kazkas.com",
                            IsCompleted = false,
                            PhoneNumber = "867864264"
                        },
                        new
                        {
                            Id = 2,
                            BuyerId = 1,
                            DateCreated = new DateTime(2022, 10, 2, 15, 21, 3, 314, DateTimeKind.Local).AddTicks(3453),
                            Email = "Pvz.pastas@kazkas.com",
                            IsCompleted = false,
                            PhoneNumber = "867864264"
                        });
                });

            modelBuilder.Entity("SaitynoLab.Shared.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<int>("FurnitureId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = 5,
                            FurnitureId = 1,
                            Name = "Stalo koja V1",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            Color = 5,
                            FurnitureId = 1,
                            Name = "Stalo koja V1",
                            Price = 9.9900000000000002
                        });
                });

            modelBuilder.Entity("SaitynoLab.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2022, 10, 2, 15, 21, 3, 314, DateTimeKind.Local).AddTicks(3345),
                            Username = "User1",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2022, 10, 2, 15, 21, 3, 314, DateTimeKind.Local).AddTicks(3374),
                            Username = "User2",
                            isDeleted = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
