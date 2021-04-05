﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovContainer.Models;

namespace MovContainer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210331194632_fix3103211646")]
    partial class fix3103211646
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovContainer.Models.Container", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContainerCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ContainerStatusId")
                        .HasColumnType("int");

                    b.Property<int>("ContainerTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContainerCategoryId");

                    b.HasIndex("ContainerStatusId");

                    b.HasIndex("ContainerTypeId");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContainerCategories");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContainerStatuses");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContainerTypes");
                });

            modelBuilder.Entity("MovContainer.Models.MovType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MovTypes");
                });

            modelBuilder.Entity("MovContainer.Models.Movimentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContainerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dt_Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dt_Init")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContainerId");

                    b.HasIndex("MovTypeId");

                    b.ToTable("Movimentations");
                });

            modelBuilder.Entity("MovContainer.Models.Container", b =>
                {
                    b.HasOne("MovContainer.Models.ContainerCategory", "Category")
                        .WithMany("Containers")
                        .HasForeignKey("ContainerCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovContainer.Models.ContainerStatus", "Status")
                        .WithMany("Containers")
                        .HasForeignKey("ContainerStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovContainer.Models.ContainerType", "ContainerType")
                        .WithMany("Containers")
                        .HasForeignKey("ContainerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ContainerType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("MovContainer.Models.Movimentation", b =>
                {
                    b.HasOne("MovContainer.Models.Container", "Container")
                        .WithMany("Movimentations")
                        .HasForeignKey("ContainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovContainer.Models.MovType", "MovType")
                        .WithMany("Movimentations")
                        .HasForeignKey("MovTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Container");

                    b.Navigation("MovType");
                });

            modelBuilder.Entity("MovContainer.Models.Container", b =>
                {
                    b.Navigation("Movimentations");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerCategory", b =>
                {
                    b.Navigation("Containers");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerStatus", b =>
                {
                    b.Navigation("Containers");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerType", b =>
                {
                    b.Navigation("Containers");
                });

            modelBuilder.Entity("MovContainer.Models.MovType", b =>
                {
                    b.Navigation("Movimentations");
                });
#pragma warning restore 612, 618
        }
    }
}
