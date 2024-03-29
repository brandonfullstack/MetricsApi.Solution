﻿// <auto-generated />
using System;
using MetricsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MetricsApi.Migrations
{
    [DbContext(typeof(MetricsApiContext))]
    partial class MetricsApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MetricsApi.Models.Interaction", b =>
                {
                    b.Property<int>("InteractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("InteractionName")
                        .HasColumnType("longtext");

                    b.HasKey("InteractionId");

                    b.ToTable("Interactions");

                    b.HasData(
                        new
                        {
                            InteractionId = 1,
                            InteractionName = "Calls Made"
                        },
                        new
                        {
                            InteractionId = 2,
                            InteractionName = "Calls Received"
                        },
                        new
                        {
                            InteractionId = 3,
                            InteractionName = "Emails Received"
                        },
                        new
                        {
                            InteractionId = 4,
                            InteractionName = "Emails Sent"
                        },
                        new
                        {
                            InteractionId = 5,
                            InteractionName = "Meetings"
                        });
                });

            modelBuilder.Entity("MetricsApi.Models.Metric", b =>
                {
                    b.Property<int>("MetricId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("InteractionId")
                        .HasColumnType("int");

                    b.Property<int>("PortalId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("MetricId");

                    b.ToTable("Metrics");

                    b.HasData(
                        new
                        {
                            MetricId = 1,
                            Date = new DateTime(2024, 3, 6, 3, 15, 1, 0, DateTimeKind.Unspecified),
                            InteractionId = 1,
                            PortalId = 1,
                            UserId = 1,
                            Value = 2
                        },
                        new
                        {
                            MetricId = 2,
                            Date = new DateTime(2024, 3, 6, 4, 15, 0, 0, DateTimeKind.Unspecified),
                            InteractionId = 2,
                            PortalId = 2,
                            UserId = 2,
                            Value = 7
                        },
                        new
                        {
                            MetricId = 3,
                            Date = new DateTime(2024, 3, 6, 20, 15, 0, 0, DateTimeKind.Unspecified),
                            InteractionId = 3,
                            PortalId = 3,
                            UserId = 3,
                            Value = 9
                        },
                        new
                        {
                            MetricId = 4,
                            Date = new DateTime(2024, 3, 6, 6, 15, 0, 0, DateTimeKind.Unspecified),
                            InteractionId = 4,
                            PortalId = 4,
                            UserId = 4,
                            Value = 23
                        },
                        new
                        {
                            MetricId = 5,
                            Date = new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InteractionId = 5,
                            PortalId = 5,
                            UserId = 5,
                            Value = 15
                        });
                });

            modelBuilder.Entity("MetricsApi.Models.Portal", b =>
                {
                    b.Property<int>("PortalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PortalName")
                        .HasColumnType("longtext");

                    b.HasKey("PortalId");

                    b.ToTable("Portals");

                    b.HasData(
                        new
                        {
                            PortalId = 1,
                            PortalName = "CAREWare"
                        },
                        new
                        {
                            PortalId = 2,
                            PortalName = "AIMS2.0"
                        },
                        new
                        {
                            PortalId = 3,
                            PortalName = "CTLS"
                        },
                        new
                        {
                            PortalId = 4,
                            PortalName = "HIVD2C"
                        },
                        new
                        {
                            PortalId = 5,
                            PortalName = "STARS"
                        });
                });

            modelBuilder.Entity("MetricsApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Brad",
                            LastName = "Ross"
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "John",
                            LastName = "Smith"
                        },
                        new
                        {
                            UserId = 3,
                            FirstName = "Beth",
                            LastName = "Baily"
                        },
                        new
                        {
                            UserId = 4,
                            FirstName = "Steve",
                            LastName = "Nash"
                        },
                        new
                        {
                            UserId = 5,
                            FirstName = "Mark",
                            LastName = "Brown"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
