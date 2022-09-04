﻿// <auto-generated />
using System;
using FinanceManagerAPI.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FinanceManagerAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220629183018_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FinanceManagerAPI.Database.Models.Pots", b =>
                {
                    b.Property<string>("PotName")
                        .HasColumnType("text")
                        .HasColumnName("potName");

                    b.Property<long>("AmountAllocated")
                        .HasColumnType("bigint")
                        .HasColumnName("amountAllocated");

                    b.HasKey("PotName");

                    b.ToTable("Pots");
                });

            modelBuilder.Entity("FinanceManagerAPI.Database.Models.Transactions", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imgUrl");

                    b.Property<string>("MerchantName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("merchantName");

                    b.Property<string>("PotType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("potType");

                    b.Property<bool>("Processed")
                        .HasColumnType("boolean")
                        .HasColumnName("processed");

                    b.Property<long>("TransactionAmount")
                        .HasColumnType("bigint")
                        .HasColumnName("transactionAmount");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("transactionDate");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}