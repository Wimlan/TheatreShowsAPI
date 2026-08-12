using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreShowsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProductionMembersJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionMembers_Shows_ShowId",
                table: "ProductionMembers");

            migrationBuilder.DropIndex(
                name: "IX_ProductionMembers_ShowId",
                table: "ProductionMembers");

            migrationBuilder.DropColumn(
                name: "ShowId",
                table: "ProductionMembers");

            migrationBuilder.CreateTable(
                name: "shows_productionmembers",
                columns: table => new
                {
                    ProductionMembersId = table.Column<int>(type: "integer", nullable: false),
                    ShowsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shows_productionmembers", x => new { x.ProductionMembersId, x.ShowsId });
                    table.ForeignKey(
                        name: "FK_shows_productionmembers_ProductionMembers_ProductionMembers~",
                        column: x => x.ProductionMembersId,
                        principalTable: "ProductionMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shows_productionmembers_Shows_ShowsId",
                        column: x => x.ShowsId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shows_productionmembers_ShowsId",
                table: "shows_productionmembers",
                column: "ShowsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shows_productionmembers");

            migrationBuilder.AddColumn<int>(
                name: "ShowId",
                table: "ProductionMembers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductionMembers_ShowId",
                table: "ProductionMembers",
                column: "ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionMembers_Shows_ShowId",
                table: "ProductionMembers",
                column: "ShowId",
                principalTable: "Shows",
                principalColumn: "Id");
        }
    }
}
