using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PensionMicroService.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banktype",
                columns: table => new
                {
                    BankDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<double>(type: "float", nullable: false),
                    BankType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banktype", x => x.BankDetailId);
                });

            migrationBuilder.CreateTable(
                name: "Pensioner",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aadhaarcard = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salaryearned = table.Column<int>(type: "int", nullable: false),
                    Allowances = table.Column<int>(type: "int", nullable: false),
                    Pensiontype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pensioner", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pensioner_Banktype_BankDetailId",
                        column: x => x.BankDetailId,
                        principalTable: "Banktype",
                        principalColumn: "BankDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pensioner_BankDetailId",
                table: "Pensioner",
                column: "BankDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pensioner");

            migrationBuilder.DropTable(
                name: "Banktype");
        }
    }
}
