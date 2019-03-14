using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clash.DataBase.Migrations.MemberList
{
    public partial class MemberListCxt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TAG = table.Column<string>(nullable: true),
                    NOME = table.Column<string>(nullable: true),
                    ROLE = table.Column<string>(nullable: true),
                    EXP = table.Column<int>(nullable: false),
                    TROFEUS = table.Column<int>(nullable: false),
                    VERSUS_TROFEUS = table.Column<int>(nullable: false),
                    CLAN_RANK = table.Column<int>(nullable: false),
                    PREVIOUS_CLAN_RANK = table.Column<int>(nullable: false),
                    DONATION = table.Column<int>(nullable: false),
                    DONATION_RECEIVED = table.Column<int>(nullable: false),
                    LeagueId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberList_League_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "League",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberList_LeagueId",
                table: "MemberList",
                column: "LeagueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberList");
        }
    }
}