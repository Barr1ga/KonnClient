#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KonnClient.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workspaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workspaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workspaces_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkspaceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Workspaces_WorkspaceId",
                        column: x => x.WorkspaceId,
                        principalTable: "Workspaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkspaceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pronounciation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFavorite = table.Column<bool>(type: "bit", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    IsEmergency = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastOpenedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Workspaces_WorkspaceId",
                        column: x => x.WorkspaceId,
                        principalTable: "Workspaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactCategories_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Image", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5686), "john.doe@example.com", "", false, "John Doe", new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.InsertData(
                table: "Workspaces",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the first workspace.", "https://example.com/image1.jpg", false, "Workspace Alpha", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the second workspace.", "https://example.com/image2.jpg", false, "Workspace Beta", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the third workspace.", "https://example.com/image3.jpg", true, "Workspace Gamma", new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the fourth workspace.", "https://example.com/image4.jpg", false, "Workspace Delta", new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the fifth workspace.", "https://example.com/image5.jpg", false, "Workspace Epsilon", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Color", "CreatedAt", "Description", "IsDeleted", "Name", "UpdatedAt", "WorkspaceId" },
                values: new object[] { 1, "#60abe3", new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5872), "My own personal important contacts", false, "Important", new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5872), 1 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedAt", "Email", "Image", "IsBlocked", "IsDeleted", "IsEmergency", "IsFavorite", "LastOpenedAt", "Name", "Notes", "Phone", "Pronounciation", "Telephone", "UpdatedAt", "WorkspaceId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5893), "john.doe@example.com", "", false, false, false, true, null, "John Doe", "Important contact", "123-456-7890", "John Doe", "123-456-7890", new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5893), 1 },
                    { 2, new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5897), "ben.affleck@example.com", "", false, false, false, true, null, "Ben Affleck", "Important contact", "123-456-7890", "Ben Affleck", "123-456-7890", new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5898), 1 },
                    { 3, new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5901), "hosea@example.com", "", false, false, false, true, null, "Hosea Mendez Barriga", "Important contact", "123-456-7890", "Hosea Mendez Barriga", "123-456-7890", new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5902), 1 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ContactId", "CreatedAt", "FullName", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5924), "University of San Carlos Talamban, Cebu", true, null },
                    { 2, 1, new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5926), "Liloan, Cebu", true, null },
                    { 3, 1, new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5928), "Villa Marina, Lapu-Lapu City", true, null },
                    { 4, 2, new DateTime(2024, 7, 30, 18, 7, 48, 614, DateTimeKind.Local).AddTicks(5929), "Guinacot, Danao, Cebu", true, null }
                });

            migrationBuilder.InsertData(
                table: "ContactCategories",
                columns: new[] { "Id", "CategoryId", "ContactId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactId",
                table: "Addresses",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_WorkspaceId",
                table: "Categories",
                column: "WorkspaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactCategories_CategoryId",
                table: "ContactCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactCategories_ContactId",
                table: "ContactCategories",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_WorkspaceId",
                table: "Contacts",
                column: "WorkspaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Workspaces_UserId",
                table: "Workspaces",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "ContactCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Workspaces");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
