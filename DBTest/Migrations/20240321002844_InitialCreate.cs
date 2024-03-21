using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DBTest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SampleType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sample",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SampleTypeId = table.Column<int>(type: "integer", nullable: false),
                    Barcode = table.Column<string>(type: "character varying(48)", maxLength: 48, nullable: false),
                    PatientName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sample_SampleType_SampleTypeId",
                        column: x => x.SampleTypeId,
                        principalTable: "SampleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SampleType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 0, "Vizelet" },
                    { 1, "Ellenörző folyadék" },
                    { 2, "Test folyadék" }
                });

            migrationBuilder.InsertData(
                table: "Sample",
                columns: new[] { "Id", "Barcode", "PatientName", "SampleTypeId" },
                values: new object[,]
                {
                    { 1, "T001", "Kis Pista", 0 },
                    { 2, "T002", "Tóth János", 0 },
                    { 3, "T003", "Teller Ede", 2 },
                    { 4, "T004", "Tóth Rita", 0 },
                    { 5, "T005", "Volly Zoli", 2 },
                    { 6, "T006", "-", 1 },
                    { 7, "T007", "Győri Dorottya", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sample_SampleTypeId",
                table: "Sample",
                column: "SampleTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sample");

            migrationBuilder.DropTable(
                name: "SampleType");
        }
    }
}
