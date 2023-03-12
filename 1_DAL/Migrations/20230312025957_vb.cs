using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class vb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "SanPhamChiTiet",
                newName: "SoLuongTon");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaNhap",
                table: "SanPhamChiTiet",
                type: "decimal(18,2)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaBan",
                table: "SanPhamChiTiet",
                type: "decimal(18,2)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "SanPhamChiTiet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "KhuyenMai",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "HoaDonChiTiet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "HoaDon",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ma",
                table: "SanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "KhuyenMai");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "HoaDon");

            migrationBuilder.RenameColumn(
                name: "SoLuongTon",
                table: "SanPhamChiTiet",
                newName: "SoLuong");

            migrationBuilder.AlterColumn<string>(
                name: "GiaNhap",
                table: "SanPhamChiTiet",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "GiaBan",
                table: "SanPhamChiTiet",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 64);
        }
    }
}
