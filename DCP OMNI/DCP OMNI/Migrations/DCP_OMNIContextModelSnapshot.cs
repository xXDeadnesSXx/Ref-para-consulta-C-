﻿// <auto-generated />
using DCP_OMNI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DCP_OMNI.Migrations
{
    [DbContext(typeof(DCP_OMNIContext))]
    partial class DCP_OMNIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DCP_OMNI.Models.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("DCP_OMNI.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CargoId");

                    b.Property<string>("Cpf");

                    b.Property<string>("Nome");

                    b.Property<int>("Rg");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("DCP_OMNI.Models.Funcionario", b =>
                {
                    b.HasOne("DCP_OMNI.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
