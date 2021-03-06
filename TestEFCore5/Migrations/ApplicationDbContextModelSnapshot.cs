﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MitGymnastik.Server.Data;

namespace TestEFCore5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FloorRoutineGymnastGroup", b =>
                {
                    b.Property<Guid>("FloorRoutinesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GymnastGroupsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FloorRoutinesId", "GymnastGroupsId");

                    b.HasIndex("GymnastGroupsId");

                    b.ToTable("FloorRoutineGymnastGroup");
                });

            modelBuilder.Entity("TestEFCore5.Models.FloorRoutine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("FloorRoutines");
                });

            modelBuilder.Entity("TestEFCore5.Models.GymnastGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("GymnastGroups");
                });

            modelBuilder.Entity("TestEFCore5.Models.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FloorRoutineGymnastGroup", b =>
                {
                    b.HasOne("TestEFCore5.Models.FloorRoutine", null)
                        .WithMany()
                        .HasForeignKey("FloorRoutinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestEFCore5.Models.GymnastGroup", null)
                        .WithMany()
                        .HasForeignKey("GymnastGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestEFCore5.Models.FloorRoutine", b =>
                {
                    b.HasOne("TestEFCore5.Models.Team", "Team")
                        .WithMany("FloorRoutines")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("TestEFCore5.Models.GymnastGroup", b =>
                {
                    b.HasOne("TestEFCore5.Models.Team", "Team")
                        .WithMany("GymnastGroups")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("TestEFCore5.Models.Team", b =>
                {
                    b.Navigation("FloorRoutines");

                    b.Navigation("GymnastGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
