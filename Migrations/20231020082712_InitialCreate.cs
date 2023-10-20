using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basakitaa.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jeniskelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tanggallahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alamat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
