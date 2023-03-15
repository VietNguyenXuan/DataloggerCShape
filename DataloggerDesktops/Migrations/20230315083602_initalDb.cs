using Microsoft.EntityFrameworkCore.Migrations;

namespace DataloggerDesktops.Migrations
{
    public partial class initalDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lines_Factories_FactoryId",
                table: "Lines");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametterLogs_ParametterSensors_ParametterSensorId",
                table: "ParametterLogs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ParametterSensors",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Value",
                table: "ParametterLogs",
                type: "REAL",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParametterSensorId",
                table: "ParametterLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "Lines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lines_Factories_FactoryId",
                table: "Lines",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametterLogs_ParametterSensors_ParametterSensorId",
                table: "ParametterLogs",
                column: "ParametterSensorId",
                principalTable: "ParametterSensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lines_Factories_FactoryId",
                table: "Lines");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametterLogs_ParametterSensors_ParametterSensorId",
                table: "ParametterLogs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ParametterSensors",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<float>(
                name: "Value",
                table: "ParametterLogs",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "ParametterSensorId",
                table: "ParametterLogs",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "Lines",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Lines_Factories_FactoryId",
                table: "Lines",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametterLogs_ParametterSensors_ParametterSensorId",
                table: "ParametterLogs",
                column: "ParametterSensorId",
                principalTable: "ParametterSensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
