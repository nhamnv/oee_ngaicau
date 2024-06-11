using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class OEEMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Data_Error",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ErrorCode = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MachineGroupID = table.Column<int>(type: "int", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MachineGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorNameNested = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L = table.Column<int>(type: "int", nullable: false),
                    ChildPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SearchPattern = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data_Error", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Data_Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsShowMenu = table.Column<bool>(type: "bit", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParentMenuMenuID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data_Menu", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Data_Menu_Data_Menu_ParentMenuMenuID",
                        column: x => x.ParentMenuMenuID,
                        principalTable: "Data_Menu",
                        principalColumn: "MenuID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Data_Menu_ParentMenuMenuID",
                table: "Data_Menu",
                column: "ParentMenuMenuID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Data_Error");

            migrationBuilder.DropTable(
                name: "Data_Menu");
        }
    }
}
