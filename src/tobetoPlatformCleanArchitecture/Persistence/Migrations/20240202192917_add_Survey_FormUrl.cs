﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_Survey_FormUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormUrl",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 128, 62, 232, 223, 22, 130, 115, 219, 47, 155, 194, 119, 88, 92, 196, 75, 112, 121, 192, 18, 165, 204, 116, 235, 239, 49, 18, 88, 45, 233, 131, 134, 204, 11, 227, 80, 226, 118, 34, 162, 130, 92, 166, 83, 205, 64, 0, 246, 152, 25, 116, 106, 150, 250, 240, 39, 27, 89, 71, 75, 15, 85, 204, 255 }, new byte[] { 67, 186, 20, 103, 75, 246, 113, 145, 13, 147, 51, 89, 66, 20, 19, 23, 240, 126, 136, 10, 81, 178, 17, 244, 54, 167, 124, 102, 251, 147, 158, 199, 94, 99, 245, 146, 127, 19, 144, 63, 231, 182, 150, 155, 205, 113, 224, 242, 253, 221, 92, 238, 140, 211, 156, 164, 33, 71, 81, 238, 121, 64, 195, 132, 197, 36, 35, 76, 238, 72, 227, 109, 76, 173, 109, 50, 232, 141, 127, 102, 17, 75, 151, 184, 38, 51, 215, 162, 155, 107, 71, 10, 79, 78, 60, 241, 62, 131, 237, 61, 50, 38, 214, 92, 41, 66, 50, 189, 78, 119, 174, 151, 219, 53, 82, 137, 45, 53, 107, 119, 218, 215, 139, 139, 97, 221, 42, 66 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormUrl",
                table: "Surveys");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 115, 228, 230, 74, 90, 91, 140, 214, 5, 133, 100, 55, 37, 155, 59, 107, 204, 118, 248, 51, 144, 94, 165, 43, 144, 7, 18, 224, 143, 169, 162, 251, 220, 83, 173, 115, 167, 112, 221, 200, 97, 166, 171, 134, 15, 220, 233, 62, 80, 212, 136, 176, 2, 177, 70, 29, 250, 1, 113, 87, 92, 242, 186, 52 }, new byte[] { 143, 157, 160, 16, 252, 186, 33, 77, 220, 198, 26, 112, 84, 95, 141, 44, 75, 3, 83, 228, 142, 46, 161, 2, 220, 105, 15, 81, 216, 181, 150, 77, 142, 201, 189, 198, 51, 79, 64, 151, 15, 235, 61, 160, 65, 97, 88, 88, 24, 156, 77, 177, 36, 185, 173, 175, 189, 210, 24, 244, 177, 119, 241, 241, 149, 117, 58, 33, 57, 1, 56, 119, 217, 243, 238, 1, 212, 202, 136, 168, 190, 4, 47, 65, 93, 45, 209, 159, 48, 29, 236, 150, 78, 13, 98, 121, 220, 227, 129, 177, 181, 111, 39, 157, 215, 165, 203, 45, 79, 136, 53, 122, 140, 69, 23, 224, 246, 248, 175, 241, 126, 129, 51, 229, 104, 174, 192, 238 } });
        }
    }
}
