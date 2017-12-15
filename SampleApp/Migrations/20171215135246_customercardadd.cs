using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SampleApp.Migrations
{
    public partial class customercardadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerCard",
                columns: table => new
                {
                    CustomerCardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CardToken = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ExpMonth = table.Column<string>(maxLength: 4, nullable: false),
                    Expyear = table.Column<string>(maxLength: 4, nullable: false),
                    ID = table.Column<long>(nullable: true),
                    Insertedon = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Modifiedon = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCard", x => x.CustomerCardID);
                    table.ForeignKey(
                        name: "FK_CustomerCard_Customers_ID",
                        column: x => x.ID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCard_ID",
                table: "CustomerCard",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCard");
        }
    }
}
