using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupProject.Migrations
{
    public partial class OrderDetailsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersModel",
                table: "OrdersModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsModel",
                table: "ItemsModel");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OrdersModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrdersModel");

            migrationBuilder.RenameTable(
                name: "OrdersModel",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "ItemsModel",
                newName: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserModel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemID");

            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    OrderDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetails", x => new { x.OrderID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_ItemID",
                table: "OrdersDetails",
                column: "ItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "OrdersModel");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "ItemsModel");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "OrdersModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "OrdersModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersModel",
                table: "OrdersModel",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsModel",
                table: "ItemsModel",
                column: "ItemID");
        }
    }
}
