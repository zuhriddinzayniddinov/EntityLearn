using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityLearn.Migrations
{
    /// <inheritdoc />
    public partial class Testererte3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Adress_AdressId",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adress",
                table: "Adress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Adress",
                newName: "adress");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "persons");

            migrationBuilder.RenameIndex(
                name: "IX_Person_AdressId",
                table: "persons",
                newName: "IX_persons_AdressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_adress",
                table: "adress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_persons",
                table: "persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_adress_AdressId",
                table: "persons",
                column: "AdressId",
                principalTable: "adress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persons_adress_AdressId",
                table: "persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_adress",
                table: "adress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_persons",
                table: "persons");

            migrationBuilder.RenameTable(
                name: "adress",
                newName: "Adress");

            migrationBuilder.RenameTable(
                name: "persons",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_persons_AdressId",
                table: "Person",
                newName: "IX_Person_AdressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adress",
                table: "Adress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Adress_AdressId",
                table: "Person",
                column: "AdressId",
                principalTable: "Adress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
