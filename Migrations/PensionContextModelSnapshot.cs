﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PensionMicroService.Models;

#nullable disable

namespace PensionMicroService.Migrations
{
    [DbContext(typeof(PensionContext))]
    partial class PensionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PensionMicroService.Models.BankDetails", b =>
                {
                    b.Property<int>("BankDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankDetailId"), 1L, 1);

                    b.Property<double>("AccountNumber")
                        .HasColumnType("float");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankDetailId");

                    b.ToTable("Banktype");
                });

            modelBuilder.Entity("PensionMicroService.Models.PensionModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Aadhaarcard")
                        .HasColumnType("int");

                    b.Property<int>("Allowances")
                        .HasColumnType("int");

                    b.Property<int>("BankDetailId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pensiontype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salaryearned")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("BankDetailId");

                    b.ToTable("Pensioner");
                });

            modelBuilder.Entity("PensionMicroService.Models.PensionModel", b =>
                {
                    b.HasOne("PensionMicroService.Models.BankDetails", "BankDetails")
                        .WithMany()
                        .HasForeignKey("BankDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankDetails");
                });
#pragma warning restore 612, 618
        }
    }
}