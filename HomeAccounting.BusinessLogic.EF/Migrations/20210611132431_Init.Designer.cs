﻿// <auto-generated />
using System;
using HomeAccounting.DataSource.EF.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HomeAccounting.DataSource.EF.Migrations
{
    [DbContext(typeof(DomainContext))]
    [Migration("20210611132431_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("OperationId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.ToTable("Accounts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Account");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BIC")
                        .HasColumnType("text");

                    b.Property<int>("Title")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Operation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("ExecutionDate")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.PropertyPriceChange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Delta")
                        .HasColumnType("numeric");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PriceChanges");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Cash", b =>
                {
                    b.HasBaseType("HomeAccounting.DataSource.EF.Domain.Account");

                    b.Property<int>("Banknots")
                        .HasColumnType("integer");

                    b.Property<int>("Monets")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("Cash");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Deposit", b =>
                {
                    b.HasBaseType("HomeAccounting.DataSource.EF.Domain.Account");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("text");

                    b.Property<int?>("BankId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Persent")
                        .HasColumnType("numeric");

                    b.Property<int>("PersentType")
                        .HasColumnType("integer");

                    b.HasIndex("BankId");

                    b.HasDiscriminator().HasValue("Deposit");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Property", b =>
                {
                    b.HasBaseType("HomeAccounting.DataSource.EF.Domain.Account");

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("PropertyType")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("Property");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Account", b =>
                {
                    b.HasOne("HomeAccounting.DataSource.EF.Domain.Operation", null)
                        .WithMany("Accounts")
                        .HasForeignKey("OperationId");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.PropertyPriceChange", b =>
                {
                    b.HasOne("HomeAccounting.DataSource.EF.Domain.Property", null)
                        .WithMany("PropertyPriceChanges")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Deposit", b =>
                {
                    b.HasOne("HomeAccounting.DataSource.EF.Domain.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Operation", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("HomeAccounting.DataSource.EF.Domain.Property", b =>
                {
                    b.Navigation("PropertyPriceChanges");
                });
#pragma warning restore 612, 618
        }
    }
}
