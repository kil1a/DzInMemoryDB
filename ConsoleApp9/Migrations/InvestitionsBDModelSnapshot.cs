﻿// <auto-generated />
using DzInvestFondInM.IMInvestFondBd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DzInvestFondInM.Migrations
{
    [DbContext(typeof(InvestitionsBD))]
    partial class InvestitionsBDModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ConsoleApp9.IMInvestItionsBd.ClassTable.RateStocks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StockId")
                        .HasColumnType("INTEGER");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("RateSet");
                });

            modelBuilder.Entity("DzInvestFondInM.IMInvestFondBd.ClassTable.StockWallet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsItOpen")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StockId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("WalletSet");
                });

            modelBuilder.Entity("DzInvestFondInM.IMInvestFondBd.ClassTable.Stocks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("StockSet");
                });
#pragma warning restore 612, 618
        }
    }
}
