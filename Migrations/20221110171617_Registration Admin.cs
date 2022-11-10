using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupProject.Migrations
{
    public partial class RegistrationAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "UserModel",
                columns: new[] { "UserId", "Address", "City", "Email", "FirstName", "LastName", "Password", "Phone", "State", "Zip" },
                values: new object[] { 1, "8800 O Street", "Lincoln", "admin@admin.com", "Admin", "Artist", "Admin1", "4025555555", "NE", "68504" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserModel");
        }
    }
}
