﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SampleApp.Data_Access_Layer.EPIServiceDAL;
using System;

namespace SampleApp.Migrations
{
    [DbContext(typeof(EPIServices))]
    [Migration("20171215130221_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleApp.Data_Access_Layer.DatModels.Customer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CustomField1")
                        .HasMaxLength(50);

                    b.Property<string>("CustomField2")
                        .HasMaxLength(50);

                    b.Property<string>("CustomField3")
                        .HasMaxLength(50);

                    b.Property<string>("CustomField4")
                        .HasMaxLength(50);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ShippingAddress")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
