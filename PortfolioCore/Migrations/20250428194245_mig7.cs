using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCore.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobTitle",
                table: "Features",
                newName: "JobTitle3");

            migrationBuilder.RenameColumn(
                name: "FeatureTitle",
                table: "Features",
                newName: "JobTitle2");

            migrationBuilder.RenameColumn(
                name: "FeatureNameSurName",
                table: "Features",
                newName: "JobTitle1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobTitle3",
                table: "Features",
                newName: "JobTitle");

            migrationBuilder.RenameColumn(
                name: "JobTitle2",
                table: "Features",
                newName: "FeatureTitle");

            migrationBuilder.RenameColumn(
                name: "JobTitle1",
                table: "Features",
                newName: "FeatureNameSurName");
        }
    }
}
