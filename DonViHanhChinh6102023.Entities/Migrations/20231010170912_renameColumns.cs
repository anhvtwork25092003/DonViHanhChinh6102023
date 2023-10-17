using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonViHanhChinh6102023.Entities.Migrations
{
    /// <inheritdoc />
    public partial class renameColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WardName",
                table: "Ward",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "WardId",
                table: "Ward",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProvinceName",
                table: "Provinces",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "Provinces",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DistrictName",
                table: "District",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DistrictID",
                table: "District",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Ward",
                newName: "WardName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ward",
                newName: "WardId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Provinces",
                newName: "ProvinceName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Provinces",
                newName: "ProvinceId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "District",
                newName: "DistrictName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "District",
                newName: "DistrictID");
        }
    }
}
