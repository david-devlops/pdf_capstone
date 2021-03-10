﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AudioContext))]
    [Migration("20210309165826_InitialMigrationScript")]
    partial class InitialMigrationScript
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("WebApplication1.Models.AudioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Audios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Carrot Cake"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lemon Tart"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
