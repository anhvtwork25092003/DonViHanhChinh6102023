﻿// <auto-generated />
using DonViHanhChinh6102023.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DonViHanhChinh6102023.Entities.Migrations
{
    [DbContext(typeof(DBHanhChinhContext))]
    [Migration("20231010134350_oke")]
    partial class oke
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DonViHanhChinh6102023.Entities.Entities.District", b =>
                {
                    b.Property<int>("DistrictID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("DistrictID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DistrictID"));

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("DistrictName");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("integer");

                    b.HasKey("DistrictID");

                    b.HasIndex("ProvinceId");

                    b.ToTable("District");
                });

            modelBuilder.Entity("DonViHanhChinh6102023.Entities.Entities.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ProvinceId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProvinceId"));

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("ProvinceName");

                    b.HasKey("ProvinceId");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("DonViHanhChinh6102023.Entities.Entities.Ward", b =>
                {
                    b.Property<int>("WardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("WardId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WardId"));

                    b.Property<int>("DistrictID")
                        .HasColumnType("integer");

                    b.Property<string>("WardName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("WardName");

                    b.HasKey("WardId");

                    b.HasIndex("DistrictID");

                    b.ToTable("Ward");
                });

            modelBuilder.Entity("DonViHanhChinh6102023.Entities.Entities.District", b =>
                {
                    b.HasOne("DonViHanhChinh6102023.Entities.Entities.Province", "Province")
                        .WithMany("districts")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("DonViHanhChinh6102023.Entities.Entities.Ward", b =>
                {
                    b.HasOne("DonViHanhChinh6102023.Entities.Entities.District", "District")
                        .WithMany("Wards")
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("DonViHanhChinh6102023.Entities.Entities.District", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("DonViHanhChinh6102023.Entities.Entities.Province", b =>
                {
                    b.Navigation("districts");
                });
#pragma warning restore 612, 618
        }
    }
}
