using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clash.DataBase.Migrations.Clan
{
    public partial class ClanCxt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clan",
                columns: table => new
                {
                    ID_CLAN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAN_TAG = table.Column<string>(nullable: true),
                    CLAN_NOME = table.Column<string>(nullable: true),
                    CLAN_TYPE = table.Column<string>(nullable: true),
                    CLAN_DESCRICAO = table.Column<string>(nullable: true),
                    CLAN_LEVEL = table.Column<int>(nullable: false),
                    CLAN_PONTOS = table.Column<long>(nullable: false),
                    CLAN_VERSUS_POINTS = table.Column<long>(nullable: false),
                    CLAN_TROFEUS_NECESSARIOS = table.Column<int>(nullable: false),
                    CLAN_FREQUENCIA_WAR = table.Column<string>(nullable: true),
                    CLAN_WAR_STREAK = table.Column<int>(nullable: false),
                    CLAN_WAR_WINS = table.Column<int>(nullable: false),
                    CLAN_WAR_LOG = table.Column<bool>(nullable: false),
                    CLAN_QNTD_MEMBERS = table.Column<int>(nullable: false),
                    BadgeUrlsId = table.Column<int>(nullable: true),
                    LocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clan", x => x.ID_CLAN);
                    table.ForeignKey(
                        name: "FK_Clan_BadgeUrls_BadgeUrlsId",
                        column: x => x.BadgeUrlsId,
                        principalTable: "BadgeUrls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clan_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clan_BadgeUrlsId",
                table: "Clan",
                column: "BadgeUrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_Clan_LocationId",
                table: "Clan",
                column: "LocationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_League_IconUrlsId",
            //    table: "League",
            //    column: "IconUrlsId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MemberList_ClanId",
            //    table: "MemberList",
            //    column: "ClanId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MemberList_LeagueId",
            //    table: "MemberList",
            //    column: "LeagueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.DropTable(
                name: "Clan");
        }
    }
}