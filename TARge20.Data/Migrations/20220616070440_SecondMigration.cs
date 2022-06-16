using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ClosingDate = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthCheckup",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DoctorsAppointment = table.Column<DateTime>(nullable: false),
                    AppointmentTimeArrangement = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCheckup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hints",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Advice = table.Column<string>(nullable: true),
                    Evaluation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemLending",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Keyboard = table.Column<string>(nullable: true),
                    Mouse = table.Column<string>(nullable: true),
                    Laptop = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemLending", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ServerManagement = table.Column<string>(nullable: true),
                    Programming = table.Column<string>(nullable: true),
                    SecurityManagement = table.Column<string>(nullable: true),
                    SoftwarePlanning = table.Column<string>(nullable: true),
                    Secretary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailBox",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderRow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RowNumber = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceDynamics",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MinimumAmount = table.Column<int>(nullable: false),
                    MaximumAmount = table.Column<int>(nullable: false),
                    Begin = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceDynamics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Recommendations = table.Column<string>(nullable: true),
                    Vacations = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesContract",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Begins = table.Column<DateTime>(nullable: false),
                    Ends = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Frequency = table.Column<string>(nullable: true),
                    AutomaticExtension = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesContract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SickLeave",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Symptoms = table.Column<string>(nullable: true),
                    Illness = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SickLeave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Begin = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ClosingDate = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    AreaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Region_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderNumber = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    OrderRowId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_OrderRow_OrderRowId",
                        column: x => x.OrderRowId,
                        principalTable: "OrderRow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseContract",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ContractNumber = table.Column<int>(nullable: false),
                    ContractDate = table.Column<DateTime>(nullable: false),
                    ContractStart = table.Column<DateTime>(nullable: false),
                    ContractEnd = table.Column<DateTime>(nullable: false),
                    PurchaseFrequency = table.Column<string>(nullable: true),
                    ContractBreak = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    PriceDynamicsId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseContract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseContract_PriceDynamics_PriceDynamicsId",
                        column: x => x.PriceDynamicsId,
                        principalTable: "PriceDynamics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Check",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CheckNumber = table.Column<int>(nullable: false),
                    CheckDate = table.Column<DateTime>(nullable: false),
                    CheckDeadline = table.Column<DateTime>(nullable: false),
                    SalesContractId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Check_SalesContract_SalesContractId",
                        column: x => x.SalesContractId,
                        principalTable: "SalesContract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RegistryNumber = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    EMail = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    OrderId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    List = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Experience = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true),
                    CheckId = table.Column<Guid>(nullable: true),
                    ChildrenId = table.Column<Guid>(nullable: true),
                    HealthCheckupId = table.Column<Guid>(nullable: true),
                    ItemLendingId = table.Column<Guid>(nullable: true),
                    JobId = table.Column<Guid>(nullable: true),
                    PurchaseContractId = table.Column<Guid>(nullable: true),
                    RequestsId = table.Column<Guid>(nullable: true),
                    SalesContractId = table.Column<Guid>(nullable: true),
                    SickLeaveId = table.Column<Guid>(nullable: true),
                    VacationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Check_CheckId",
                        column: x => x.CheckId,
                        principalTable: "Check",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Children_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_HealthCheckup_HealthCheckupId",
                        column: x => x.HealthCheckupId,
                        principalTable: "HealthCheckup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_ItemLending_ItemLendingId",
                        column: x => x.ItemLendingId,
                        principalTable: "ItemLending",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_PurchaseContract_PurchaseContractId",
                        column: x => x.PurchaseContractId,
                        principalTable: "PurchaseContract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Request_RequestsId",
                        column: x => x.RequestsId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_SalesContract_SalesContractId",
                        column: x => x.SalesContractId,
                        principalTable: "SalesContract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_SickLeave_SickLeaveId",
                        column: x => x.SickLeaveId,
                        principalTable: "SickLeave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Vacation_VacationId",
                        column: x => x.VacationId,
                        principalTable: "Vacation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Access",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ServerAccess = table.Column<bool>(nullable: false),
                    ComputerAccess = table.Column<bool>(nullable: false),
                    SoftwareAccess = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Access_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BranchOffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Employees = table.Column<string>(nullable: true),
                    Office = table.Column<string>(nullable: true),
                    Computers = table.Column<string>(nullable: true),
                    CompanyId = table.Column<Guid>(nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    HintsId = table.Column<Guid>(nullable: true),
                    MailBoxId = table.Column<Guid>(nullable: true),
                    RegionId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchOffice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchOffice_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchOffice_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchOffice_Hints_HintsId",
                        column: x => x.HintsId,
                        principalTable: "Hints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchOffice_MailBox_MailBoxId",
                        column: x => x.MailBoxId,
                        principalTable: "MailBox",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchOffice_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Access_EmployeeId",
                table: "Access",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffice_CompanyId",
                table: "BranchOffice",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffice_EmployeeId",
                table: "BranchOffice",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffice_HintsId",
                table: "BranchOffice",
                column: "HintsId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffice_MailBoxId",
                table: "BranchOffice",
                column: "MailBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffice_RegionId",
                table: "BranchOffice",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_SalesContractId",
                table: "Check",
                column: "SalesContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_OrderId",
                table: "Company",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CheckId",
                table: "Employee",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ChildrenId",
                table: "Employee",
                column: "ChildrenId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_HealthCheckupId",
                table: "Employee",
                column: "HealthCheckupId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ItemLendingId",
                table: "Employee",
                column: "ItemLendingId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobId",
                table: "Employee",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PurchaseContractId",
                table: "Employee",
                column: "PurchaseContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RequestsId",
                table: "Employee",
                column: "RequestsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SalesContractId",
                table: "Employee",
                column: "SalesContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SickLeaveId",
                table: "Employee",
                column: "SickLeaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_VacationId",
                table: "Employee",
                column: "VacationId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderRowId",
                table: "Order",
                column: "OrderRowId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseContract_PriceDynamicsId",
                table: "PurchaseContract",
                column: "PriceDynamicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Region_AreaId",
                table: "Region",
                column: "AreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Access");

            migrationBuilder.DropTable(
                name: "BranchOffice");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Hints");

            migrationBuilder.DropTable(
                name: "MailBox");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Check");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "HealthCheckup");

            migrationBuilder.DropTable(
                name: "ItemLending");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "PurchaseContract");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "SickLeave");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "OrderRow");

            migrationBuilder.DropTable(
                name: "SalesContract");

            migrationBuilder.DropTable(
                name: "PriceDynamics");
        }
    }
}
