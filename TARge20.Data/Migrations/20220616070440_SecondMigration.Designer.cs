﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    [Migration("20220616070440_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.Access", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ComputerAccess")
                        .HasColumnType("bit");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ServerAccess")
                        .HasColumnType("bit");

                    b.Property<bool>("SoftwareAccess")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Access");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Area", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("TARge20.Core.Domain.BranchOffice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Computers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Employees")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HintsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MailBoxId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("HintsId");

                    b.HasIndex("MailBoxId");

                    b.HasIndex("RegionId");

                    b.ToTable("BranchOffice");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Check", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckDeadline")
                        .HasColumnType("datetime2");

                    b.Property<int>("CheckNumber")
                        .HasColumnType("int");

                    b.Property<Guid?>("SalesContractId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SalesContractId");

                    b.ToTable("Check");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Children", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("RegistryNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid?>("CheckId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChildrenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HealthCheckupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ItemLendingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("List")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PurchaseContractId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RequestsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SalesContractId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SickLeaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VacationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CheckId");

                    b.HasIndex("ChildrenId");

                    b.HasIndex("HealthCheckupId");

                    b.HasIndex("ItemLendingId");

                    b.HasIndex("JobId");

                    b.HasIndex("PurchaseContractId");

                    b.HasIndex("RequestsId");

                    b.HasIndex("SalesContractId");

                    b.HasIndex("SickLeaveId");

                    b.HasIndex("VacationId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.HealthCheckup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AppointmentTimeArrangement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoctorsAppointment")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HealthCheckup");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Hints", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Advice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Evaluation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hints");
                });

            modelBuilder.Entity("TARge20.Core.Domain.ItemLending", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Keyboard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Laptop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mouse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemLending");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Programming")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secretary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityManagement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerManagement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoftwarePlanning")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("TARge20.Core.Domain.MailBox", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MailBox");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<Guid?>("OrderRowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderRowId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("TARge20.Core.Domain.OrderRow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderRow");
                });

            modelBuilder.Entity("TARge20.Core.Domain.PriceDynamics", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Begin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaximumAmount")
                        .HasColumnType("int");

                    b.Property<int>("MinimumAmount")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("PriceDynamics");
                });

            modelBuilder.Entity("TARge20.Core.Domain.PurchaseContract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContractBreak")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ContractEnd")
                        .HasColumnType("datetime2");

                    b.Property<int>("ContractNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractStart")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PriceDynamicsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PurchaseFrequency")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PriceDynamicsId");

                    b.ToTable("PurchaseContract");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AreaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Requests", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Recommendations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacations")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("TARge20.Core.Domain.SalesContract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AutomaticExtension")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Begins")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ends")
                        .HasColumnType("datetime2");

                    b.Property<string>("Frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SalesContract");
                });

            modelBuilder.Entity("TARge20.Core.Domain.SickLeave", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Illness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symptoms")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SickLeave");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Begin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vacation");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Access", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", null)
                        .WithMany("AccessId")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.BranchOffice", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Company", null)
                        .WithMany("BranchOfficeId")
                        .HasForeignKey("CompanyId");

                    b.HasOne("TARge20.Core.Domain.Employee", null)
                        .WithMany("BranchOfficeId")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TARge20.Core.Domain.Hints", null)
                        .WithMany("BranchOfficeId")
                        .HasForeignKey("HintsId");

                    b.HasOne("TARge20.Core.Domain.MailBox", null)
                        .WithMany("BranchOfficeId")
                        .HasForeignKey("MailBoxId");

                    b.HasOne("TARge20.Core.Domain.Region", null)
                        .WithMany("BranchOfficeId")
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Check", b =>
                {
                    b.HasOne("TARge20.Core.Domain.SalesContract", null)
                        .WithMany("CheckId")
                        .HasForeignKey("SalesContractId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Company", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Order", null)
                        .WithMany("CompanyId")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Check", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("CheckId");

                    b.HasOne("TARge20.Core.Domain.Children", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("ChildrenId");

                    b.HasOne("TARge20.Core.Domain.HealthCheckup", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("HealthCheckupId");

                    b.HasOne("TARge20.Core.Domain.ItemLending", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("ItemLendingId");

                    b.HasOne("TARge20.Core.Domain.Job", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("JobId");

                    b.HasOne("TARge20.Core.Domain.PurchaseContract", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("PurchaseContractId");

                    b.HasOne("TARge20.Core.Domain.Requests", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("RequestsId");

                    b.HasOne("TARge20.Core.Domain.SalesContract", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("SalesContractId");

                    b.HasOne("TARge20.Core.Domain.SickLeave", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("SickLeaveId");

                    b.HasOne("TARge20.Core.Domain.Vacation", null)
                        .WithMany("EmployeeId")
                        .HasForeignKey("VacationId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Order", b =>
                {
                    b.HasOne("TARge20.Core.Domain.OrderRow", null)
                        .WithMany("OrderId")
                        .HasForeignKey("OrderRowId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.PurchaseContract", b =>
                {
                    b.HasOne("TARge20.Core.Domain.PriceDynamics", null)
                        .WithMany("PurchaseContractId")
                        .HasForeignKey("PriceDynamicsId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Region", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Area", null)
                        .WithMany("RegionId")
                        .HasForeignKey("AreaId");
                });
#pragma warning restore 612, 618
        }
    }
}
