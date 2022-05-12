﻿// <auto-generated />
using FriendOrganizer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FriendOrganizer.DataAccess.Migrations
{
    [DbContext(typeof(FriendOrganizerDbContext))]
    [Migration("20220512063549_AddDataSeed")]
    partial class AddDataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FriendOrganizer.Model.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Friends");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "thomasa@testfriendapp.com",
                            FirstName = "Thomas",
                            LastName = "Anderson"
                        },
                        new
                        {
                            Id = 2,
                            Email = "chuckn@testfriendapp.com",
                            FirstName = "Chuck",
                            LastName = "Norris"
                        },
                        new
                        {
                            Id = 3,
                            Email = "brucel@testfriendapp.com",
                            FirstName = "Bruce",
                            LastName = "Lee"
                        },
                        new
                        {
                            Id = 4,
                            Email = "jackiec@testfriendapp.com",
                            FirstName = "Jackie",
                            LastName = "Chan"
                        },
                        new
                        {
                            Id = 5,
                            Email = "jetl@testfriendapp.com",
                            FirstName = "Jet",
                            LastName = "Li"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
