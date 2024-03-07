using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterManagement.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2d66ce00-c23f-4168-b3de-515a588df72f"));

            migrationBuilder.DeleteData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: new Guid("2921a84c-441b-402a-858c-6986976d2b28"));

            migrationBuilder.DeleteData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: new Guid("64cce700-c1f0-4c04-9874-637b717ef70f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("272374ff-e089-4d5d-9dee-9ac25826ea33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e6d0741-5f2b-4618-b2fb-4f66e9e81b35"));

            migrationBuilder.RenameColumn(
                name: "UserName_LastName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "UserName_FirstName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "ShelterAddress_Street",
                table: "Shelters",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "ShelterAddress_PostalCode",
                table: "Shelters",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "ShelterAddress_City",
                table: "Shelters",
                newName: "City");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Shelters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shelters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pets",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Pets",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Created", "CreatedBy", "Description", "Details", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Photos", "ShelterId", "StatusId" },
                values: new object[] { new Guid("d9f5efa3-72c6-4af1-8a65-6885e799410d"), 3, new DateTime(2024, 3, 7, 17, 45, 22, 119, DateTimeKind.Local).AddTicks(3824), null, "Good boy.", null, null, null, null, null, "Lupin", null, null, 1 });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Email", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "PhoneNumber", "StatusId" },
                values: new object[] { new Guid("bfaf8b00-157c-4cb4-b032-8a46b03f3b6d"), new DateTime(2024, 3, 7, 17, 45, 22, 119, DateTimeKind.Local).AddTicks(3311), null, "Shelter for abbandon pets in New York.", "shelterNY@mail.com", null, null, null, null, "New York Shelter", "123 456 789", 1 });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "Id", "City", "PostalCode", "Street" },
                values: new object[] { new Guid("e30efb72-d018-4b4e-adab-9ec29cd287d3"), "New York", "61-070", "Street" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Created", "CreatedBy", "Email", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PhoneNumber", "RoleId", "StatusId" },
                values: new object[] { new Guid("14e7b440-b13e-4a1f-97fb-f7769fc4ee27"), "New York", new DateTime(2024, 3, 7, 17, 45, 22, 119, DateTimeKind.Local).AddTicks(2045), null, "mail@example.com", null, null, null, null, "123 456 789", null, 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("aa694fc1-3c33-4d4c-851b-d77b1aad6f39"), "Peter", "Smith" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d9f5efa3-72c6-4af1-8a65-6885e799410d"));

            migrationBuilder.DeleteData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: new Guid("bfaf8b00-157c-4cb4-b032-8a46b03f3b6d"));

            migrationBuilder.DeleteData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: new Guid("e30efb72-d018-4b4e-adab-9ec29cd287d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14e7b440-b13e-4a1f-97fb-f7769fc4ee27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa694fc1-3c33-4d4c-851b-d77b1aad6f39"));

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "UserName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "UserName_FirstName");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Shelters",
                newName: "ShelterAddress_Street");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Shelters",
                newName: "ShelterAddress_PostalCode");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Shelters",
                newName: "ShelterAddress_City");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Created", "CreatedBy", "Description", "Details", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Photos", "ShelterId", "StatusId" },
                values: new object[] { new Guid("2d66ce00-c23f-4168-b3de-515a588df72f"), 3, new DateTime(2024, 3, 6, 17, 15, 51, 275, DateTimeKind.Local).AddTicks(9415), null, "Good boy.", null, null, null, null, null, "Lupin", null, null, 1 });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "Id", "ShelterAddress_City", "ShelterAddress_PostalCode", "ShelterAddress_Street" },
                values: new object[] { new Guid("2921a84c-441b-402a-858c-6986976d2b28"), "New York", "61-070", "Street" });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Email", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "PhoneNumber", "StatusId" },
                values: new object[] { new Guid("64cce700-c1f0-4c04-9874-637b717ef70f"), new DateTime(2024, 3, 6, 17, 15, 51, 275, DateTimeKind.Local).AddTicks(8855), null, "Shelter for abbandon pets in New York.", "shelterNY@mail.com", null, null, null, null, "New York Shelter", "123 456 789", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Created", "CreatedBy", "Email", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PhoneNumber", "RoleId", "StatusId" },
                values: new object[] { new Guid("272374ff-e089-4d5d-9dee-9ac25826ea33"), "New York", new DateTime(2024, 3, 6, 17, 15, 51, 275, DateTimeKind.Local).AddTicks(6935), null, "mail@example.com", null, null, null, null, "123 456 789", null, 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName_FirstName", "UserName_LastName" },
                values: new object[] { new Guid("6e6d0741-5f2b-4618-b2fb-4f66e9e81b35"), "Peter", "Smith" });
        }
    }
}
