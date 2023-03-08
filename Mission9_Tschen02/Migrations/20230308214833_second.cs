using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission9_Tschen02.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketLineItem_Donations_DonationId",
                table: "BasketLineItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donations",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_BasketLineItem_DonationId",
                table: "BasketLineItem");

            migrationBuilder.DropColumn(
                name: "DonationId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonationId",
                table: "BasketLineItem");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Donations",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "BasketLineItem",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donations",
                table: "Donations",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketLineItem_PurchaseId",
                table: "BasketLineItem",
                column: "PurchaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketLineItem_Donations_PurchaseId",
                table: "BasketLineItem",
                column: "PurchaseId",
                principalTable: "Donations",
                principalColumn: "PurchaseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketLineItem_Donations_PurchaseId",
                table: "BasketLineItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donations",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_BasketLineItem_PurchaseId",
                table: "BasketLineItem");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "BasketLineItem");

            migrationBuilder.AddColumn<int>(
                name: "DonationId",
                table: "Donations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "DonationId",
                table: "BasketLineItem",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donations",
                table: "Donations",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketLineItem_DonationId",
                table: "BasketLineItem",
                column: "DonationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketLineItem_Donations_DonationId",
                table: "BasketLineItem",
                column: "DonationId",
                principalTable: "Donations",
                principalColumn: "DonationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
