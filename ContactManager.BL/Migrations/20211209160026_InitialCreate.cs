using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.BL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.EmailAddress);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddresses",
                columns: table => new
                {
                    EmailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddresses", x => x.EmailID);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "men@nerdymail.com", "Michelle", "Nesbitt" },
                    { "mn@nerdymail.com", "Michelle", "Nesbitt" }
                });

            migrationBuilder.InsertData(
                table: "EmailAddresses",
                columns: new[] { "EmailID", "EmailAddress", "EmailType" },
                values: new object[,]
                {
                    { 1, "mn@nerdymail.com", 1 },
                    { 2, "men@nerdymail.com", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EmailAddresses");
        }
    }
}
