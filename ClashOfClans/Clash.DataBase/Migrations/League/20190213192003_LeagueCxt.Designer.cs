﻿// <auto-generated />
using System;
using Clash.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clash.DataBase.Migrations.League
{
    [DbContext(typeof(LeagueContext))]
    [Migration("20190213192003_LeagueCxt")]
    partial class LeagueCxt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clash.Domain.Entities.API.IconUrls", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Medium");

                    b.Property<string>("Small");

                    b.Property<string>("Tiny");

                    b.HasKey("Id");

                    b.ToTable("IconUrls");
                });

            modelBuilder.Entity("Clash.Domain.Entities.API.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IconUrlsId");

                    b.Property<string>("Name")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.HasIndex("IconUrlsId");

                    b.ToTable("League");
                });

            modelBuilder.Entity("Clash.Domain.Entities.API.League", b =>
                {
                    b.HasOne("Clash.Domain.Entities.API.IconUrls", "IconUrls")
                        .WithMany()
                        .HasForeignKey("IconUrlsId");
                });
#pragma warning restore 612, 618
        }
    }
}