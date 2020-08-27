using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BUYList.API.Migrations
{
    public partial class InitaialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "IsDeleted", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("67d86d59-84c7-4939-a81d-10d59c6fe4f5"), new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy a Toradora volume 8 in Amazon.", true, false, "Toradora", new Guid("dd080e3b-1d46-4c48-bf27-adc079f36732") },
                    { new Guid("99673a66-bb5d-41f7-8a2f-09485afc0ccb"), new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy a Re: Zero volume 13 in Amazon.", true, false, "Re: Zero", new Guid("dd080e3b-1d46-4c48-bf27-adc079f36732") },
                    { new Guid("530b86d0-8ea3-4e11-87a6-5719af3348fa"), new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy a Re: Zero volume 12 in Amazon.", false, true, "Re: Zero", new Guid("dd080e3b-1d46-4c48-bf27-adc079f36732") },
                    { new Guid("de1cc9e3-6c52-46a5-8ce2-173da2015bf4"), new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy a Car in WebMotors.", true, false, "Car", new Guid("95ae172e-1e77-4df6-993c-2b20302c6e02") },
                    { new Guid("4a6807d9-5eb4-4b0e-98e6-5fc661822bb0"), new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy a TV in Amazon.", true, false, "TV", new Guid("95ae172e-1e77-4df6-993c-2b20302c6e02") },
                    { new Guid("48234769-8826-43d0-97ce-5579daf7cb0b"), new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy a Mouse in Razer.", true, false, "Mouse", new Guid("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35") },
                    { new Guid("a1a4793b-874c-43d4-80d4-fd71097aec9d"), new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy a Mousepad in Razer.", true, false, "Mousepad", new Guid("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsDeleted", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("dd080e3b-1d46-4c48-bf27-adc079f36732"), "pedrooctavio@email.com", false, "Pedro Octávio", "pedropassword" },
                    { new Guid("95ae172e-1e77-4df6-993c-2b20302c6e02"), "igorandrade@email.com", false, "Ígor Andrade", "igorpassword" },
                    { new Guid("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35"), "juliasilva@email.com", false, "Júlia da Silva", "juliapassword" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
