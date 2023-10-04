using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDENTREGISTRATIONFORM.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentFirstName = table.Column<string>(name: "Student First Name ", type: "nvarchar(max)", nullable: false),
                    StudentLastName = table.Column<string>(name: "Student Last Name ", type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdmissionYear = table.Column<string>(name: "Admission Year", type: "nvarchar(max)", nullable: false),
                    AdmissionCategory = table.Column<string>(name: "Admission Category", type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentDateofBirth = table.Column<DateTime>(name: "Student Date of Birth ", type: "datetime2", nullable: false),
                    SecondLanguage = table.Column<string>(name: "Second Language", type: "nvarchar(max)", nullable: false),
                    ThirdLanguage = table.Column<string>(name: "Third Language", type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WouldyoulikeCampusTour = table.Column<string>(name: "Would you like Campus Tour", type: "nvarchar(max)", nullable: false),
                    Howdidyouhearaboutus = table.Column<string>(name: "How did you hear about us", type: "nvarchar(max)", nullable: false),
                    AdditionalInformation = table.Column<string>(name: "Additional Information", type: "nvarchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
