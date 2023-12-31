﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Processor.Data;

#nullable disable

namespace Processor.Migrations
{
    [DbContext(typeof(IncidentsDbContext))]
    partial class IncidentsDbContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Processor.Models.Incident", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Incidents");
                });

            modelBuilder.Entity("SharedClassLibrary.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("IncidentId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("SharedClassLibrary.Models.Event", b =>
                {
                    b.HasOne("Processor.Models.Incident", null)
                        .WithMany("EventsBasedOn")
                        .HasForeignKey("IncidentId");
                });

            modelBuilder.Entity("Processor.Models.Incident", b =>
                {
                    b.Navigation("EventsBasedOn");
                });
#pragma warning restore 612, 618
        }
    }
}
