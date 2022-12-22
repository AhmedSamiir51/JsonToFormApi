using Microsoft.EntityFrameworkCore.Migrations;

namespace ConvertJsonToForm.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TexTarea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Radio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckBox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DropdownList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toggle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
