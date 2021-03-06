﻿// <auto-generated />
using Clash.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clash.DataBase.Migrations
{
    [DbContext(typeof(BadgeUrlsContext))]
    [Migration("20190213191448_BadgeCxt")]
    partial class BadgeCxt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clash.Domain.Entities.API.BadgeUrls", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Large")
                        .HasColumnName("LARGE");

                    b.Property<string>("Medium")
                        .HasColumnName("MEDIUM");

                    b.Property<string>("Small")
                        .HasColumnName("SMALL");

                    b.HasKey("Id");

                    b.ToTable("BadgeUrls");
                });
#pragma warning restore 612, 618
        }
    }
}
