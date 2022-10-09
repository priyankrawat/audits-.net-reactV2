using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace audits_.net_react_ramine.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_projects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "text", nullable: false),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    daily_email_updates = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "created_at", "description", "owner_id", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporis sit ratione quia minima. Quasi voluptatum tempora temporibus et atque quis nesciunt. Voluptas similique est eum id numquam ducimus quis. Eum laborum maxime aut aperiam velit. Doloremque vero sed velit libero.", 1, "Right-sized reciprocal adapter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia vel rerum consequatur. Aliquam qui sed fugiat et nostrum. Labore explicabo consequatur reiciendis laboriosam optio sint facilis. Illum qui quod eos. Excepturi provident aut aut numquam voluptatibus.", 2, "Down-sized national open system", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alias a rerum quasi voluptates. Repellat excepturi quasi amet dolore amet veritatis facere et. Dolor ullam rem non accusantium necessitatibus dolores alias.", 1, "Compatible 24 hour migration", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic soluta eum commodi qui autem quae et. Et consectetur odit minus. Odit corrupti in nihil harum aliquam omnis. Sed et sint officiis autem voluptatem sequi. Enim enim fugit ab molestiae id hic.", 1, "Customizable incremental strategy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et rerum assumenda veritatis qui qui et nostrum delectus nihil. Dolor rerum quaerat neque. Est quae maxime accusamus maiores quia expedita ab fugit odit. Eius iure dolorem minus sunt. Quod ipsum omnis itaque ratione officiis ut ea ad ea.", 1, "Networked human-resource firmware", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic aliquid et molestiae et. Dolorum ipsum magnam eius maiores. Qui voluptatum cumque ad fugiat itaque aliquam. Tenetur qui eveniet voluptatibus quam reiciendis eligendi. Quos voluptatem exercitationem quam sunt inventore earum tempore placeat ut. Suscipit assumenda veritatis ex sunt et.", 1, "Pre-emptive discrete open system", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut eos est in voluptatem eos natus quia. Et quo distinctio impedit molestias libero suscipit eveniet neque. Eum numquam perspiciatis omnis ex alias est et. Sit praesentium laborum atque nobis nihil voluptatem odio rerum. Qui voluptas cum tenetur omnis at explicabo velit dolores.", 2, "Horizontal methodical knowledge user", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur veritatis doloremque molestiae officiis omnis et. Fugiat doloremque molestiae eum qui et consequatur aut sunt consectetur. At soluta odio debitis ut amet recusandae nulla voluptas placeat. Blanditiis itaque quo quibusdam sapiente ut quae.", 1, "Optimized real-time knowledge base", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum distinctio et odio veniam. Earum est omnis voluptatem. Mollitia aut eos rerum totam alias autem fugiat. Ullam in ab enim.", 2, "Open-source modular help-desk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem distinctio delectus numquam. Culpa aut provident voluptatem repellat sunt tempora. Odio quia quisquam et quam quisquam nulla esse. Molestiae ullam velit qui accusantium a vero non. Accusamus distinctio assumenda occaecati non saepe provident omnis ut aspernatur.", 2, "Reactive static concept", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "daily_email_updates", "email", "first_name", "last_name", "password", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "test@example.com", "User", "Test", "password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "test2@example.com", "User", "Test 2", "password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
