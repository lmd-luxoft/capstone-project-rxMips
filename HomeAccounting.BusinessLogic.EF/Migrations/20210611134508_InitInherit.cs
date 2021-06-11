using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HomeAccounting.DataSource.EF.Migrations
{
    public partial class InitInherit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Banks_BankId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceChanges_Accounts_PropertyId",
                table: "PriceChanges");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_BankId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Banknots",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Monets",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Persent",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PersentType",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "Accounts");

            migrationBuilder.CreateTable(
                name: "Cashes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Banknots = table.Column<int>(type: "integer", nullable: false),
                    Monets = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cashes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cashes_Accounts_Id",
                        column: x => x.Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccountNumber = table.Column<string>(type: "text", nullable: true),
                    Persent = table.Column<decimal>(type: "numeric", nullable: false),
                    PersentType = table.Column<int>(type: "integer", nullable: false),
                    BankId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposits_Accounts_Id",
                        column: x => x.Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deposits_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BasePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    PropertyType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Accounts_Id",
                        column: x => x.Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_BankId",
                table: "Deposits",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceChanges_Properties_PropertyId",
                table: "PriceChanges",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceChanges_Properties_PropertyId",
                table: "PriceChanges");

            migrationBuilder.DropTable(
                name: "Cashes");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "Accounts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "Accounts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Banknots",
                table: "Accounts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BasePrice",
                table: "Accounts",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Accounts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Accounts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Monets",
                table: "Accounts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Persent",
                table: "Accounts",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersentType",
                table: "Accounts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyType",
                table: "Accounts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BankId",
                table: "Accounts",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Banks_BankId",
                table: "Accounts",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceChanges_Accounts_PropertyId",
                table: "PriceChanges",
                column: "PropertyId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
