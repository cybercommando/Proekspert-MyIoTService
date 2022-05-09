﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyIoTService.Database;

namespace MyIoTService.Migrations
{
    [DbContext(typeof(IoTServiceDBContext))]
    partial class IoTServiceDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyIoTService.Entities.Device", b =>
                {
                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.Property<bool>("HasOutsideTemperature")
                        .HasColumnType("bit");

                    b.Property<int>("InsideTemperature")
                        .HasColumnType("int");

                    b.Property<bool>("IsOperational")
                        .HasColumnType("bit");

                    b.Property<bool>("MachineIsBroken")
                        .HasColumnType("bit");

                    b.Property<int>("OperationTimeInHour")
                        .HasColumnType("int");

                    b.Property<int>("OperationTimeInSec")
                        .HasColumnType("int");

                    b.Property<int>("OutsideTemperature")
                        .HasColumnType("int");

                    b.Property<bool>("SilentMode")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WaterTemperature")
                        .HasColumnType("int");

                    b.HasKey("SerialNumber");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("MyIoTService.Entities.EndUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EndUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Muhammad",
                            LastName = "Zubair",
                            Password = "admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("MyIoTService.Entities.Device", b =>
                {
                    b.HasOne("MyIoTService.Entities.EndUser", "EndUser")
                        .WithMany("Devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}