using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace audits_.net_react_ramine.Migrations
{
    public partial class CreateAuditsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "audits",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    @event = table.Column<string>(name: "event", type: "text", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    message = table.Column<string>(type: "text", nullable: false),
                    context = table.Column<string>(type: "jsonb", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_audits", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "audits",
                columns: new[] { "id", "context", "created_at", "event", "message", "status", "updated_at", "user_id" },
                values: new object[,]
                {
                    { 1, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 415, DateTimeKind.Utc).AddTicks(1695), "authentication:logout", "Dolores ab magni amet ipsa. Reiciendis quos atque sint illum culpa ab autem incidunt. Est dolorum consectetur est sit quo maiores. Quia est sapiente ullam dolorum nostrum dolorem eos quos. Dolore iusto modi incidunt ex et exercitationem.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 415, DateTimeKind.Utc).AddTicks(1695), 1 },
                    { 2, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 415, DateTimeKind.Utc).AddTicks(6061), "invoice:send", "Et laudantium velit consequatur at sed eius. Voluptatibus nihil debitis libero rem illum alias. Non et eveniet rem inventore porro et. Quia unde sunt deserunt modi. Enim consequatur dolorem nihil velit. Consequatur modi veniam aut est ea perspiciatis et nulla.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 415, DateTimeKind.Utc).AddTicks(6061), 1 },
                    { 3, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 415, DateTimeKind.Utc).AddTicks(9899), "invoice:create", "Nihil tenetur libero dolorem cum. Eum sit blanditiis sint nisi sit qui. Deserunt sunt eligendi ea harum sunt. Amet reprehenderit repellendus omnis. Ut velit repudiandae minima quos magni nemo sed. Vel pariatur officiis amet sed.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 415, DateTimeKind.Utc).AddTicks(9900), 2 },
                    { 4, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 416, DateTimeKind.Utc).AddTicks(3427), "settings:change", "Tempore nisi consequatur quo est perferendis soluta. At architecto sapiente esse asperiores. Laudantium corporis commodi laudantium. Quia voluptatum velit sunt aut velit pariatur dolorem laboriosam et. Est dolorem ipsum libero et sed quae corrupti beatae repellendus. Dolorem reiciendis tenetur nihil ipsum.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 416, DateTimeKind.Utc).AddTicks(3427), 2 },
                    { 5, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 416, DateTimeKind.Utc).AddTicks(6271), "authentication:new", "Sint nesciunt non sit quod ab est reiciendis hic. Voluptate dolor iste molestias fuga est expedita fuga accusamus. Quidem in perferendis expedita assumenda blanditiis aperiam sint et maxime. Saepe soluta magnam magni id aspernatur est. Earum nemo molestias non dolorem qui ullam adipisci.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 416, DateTimeKind.Utc).AddTicks(6271), 1 },
                    { 6, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 416, DateTimeKind.Utc).AddTicks(8141), "authentication:new", "Doloribus autem est beatae velit amet. Quisquam cupiditate dolore deleniti iste minima expedita. Qui et autem impedit facilis fugiat reprehenderit cum.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 416, DateTimeKind.Utc).AddTicks(8141), 1 },
                    { 7, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 417, DateTimeKind.Utc).AddTicks(1071), "invoice:send", "Repudiandae rerum minus delectus. Accusantium voluptates at id. Tempora et quod consequatur ipsum reprehenderit dolorem. Repellendus consequatur nostrum voluptatem illo possimus veritatis voluptas. Nostrum omnis dignissimos provident delectus labore iusto sint doloremque corporis. Itaque praesentium tenetur voluptatem velit aut velit.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 417, DateTimeKind.Utc).AddTicks(1071), 1 },
                    { 8, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 417, DateTimeKind.Utc).AddTicks(3908), "invoice:create", "Nemo architecto est libero laborum est quia minima quam distinctio. Odio non velit eius sint eaque temporibus facere alias. Earum molestias quia perspiciatis. Nostrum quis quia non ad nihil nostrum temporibus incidunt nihil. Voluptate quo corporis occaecati quia omnis. Voluptatem sed ut consequuntur.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 417, DateTimeKind.Utc).AddTicks(3908), 2 },
                    { 9, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 417, DateTimeKind.Utc).AddTicks(5901), "invoice:send", "Vel est earum maxime. Qui quis beatae adipisci accusantium esse officia et quia. Praesentium assumenda nihil in id neque sed.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 417, DateTimeKind.Utc).AddTicks(5901), 1 },
                    { 10, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 417, DateTimeKind.Utc).AddTicks(8670), "invoice:create", "Veniam molestias placeat aut cumque aut. Explicabo earum mollitia quis. Et est dicta autem amet assumenda quasi. Unde veniam ipsa in illum officia qui omnis.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 417, DateTimeKind.Utc).AddTicks(8670), 1 },
                    { 11, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 418, DateTimeKind.Utc).AddTicks(2830), "authentication:logout", "Et non distinctio deleniti unde dolor expedita nam. Consequatur aut corporis est dolor rem distinctio eius est. Eos voluptatem non in aliquid alias et tempora earum dolor. Cupiditate quo adipisci omnis eos et omnis sunt. Consequatur magnam in molestiae.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 418, DateTimeKind.Utc).AddTicks(2830), 2 },
                    { 12, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 418, DateTimeKind.Utc).AddTicks(7251), "authentication:logout", "Nam voluptate omnis molestiae ad sapiente quaerat similique. Minima saepe sed incidunt nesciunt est veritatis. Tempora facere aliquid ex aliquam quidem est possimus quia amet. Sit ipsa optio exercitationem. At id repellat libero numquam nesciunt deserunt beatae. Cupiditate perferendis reiciendis pariatur.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 418, DateTimeKind.Utc).AddTicks(7251), 2 },
                    { 13, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 419, DateTimeKind.Utc).AddTicks(8454), "invoice:send", "Sunt explicabo harum et molestias omnis qui. Pariatur quia officiis culpa ut quia temporibus possimus. Adipisci voluptatem consequuntur et alias. Aut eum ad illum quibusdam. Quis consectetur est ut sed voluptatem pariatur. Iusto perspiciatis omnis eum et sed facilis.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 419, DateTimeKind.Utc).AddTicks(8457), 1 },
                    { 14, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 420, DateTimeKind.Utc).AddTicks(2126), "authentication:logout", "Temporibus ex labore voluptatum qui harum tempora tempora laboriosam sequi. Quod in est animi dolor accusamus quae. Neque eius ut quia. Sit occaecati expedita quam.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 420, DateTimeKind.Utc).AddTicks(2126), 1 },
                    { 15, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 420, DateTimeKind.Utc).AddTicks(6991), "authentication:new", "Rem ut voluptatum fugit consequatur nulla. Nihil consequatur maxime ut ipsum. Eos voluptatum rerum dolorem illum aut molestiae et quisquam. Necessitatibus enim dolorum dolorem alias. Perspiciatis est totam aut numquam aut. Et aut architecto omnis a est accusamus sed ut ad.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 420, DateTimeKind.Utc).AddTicks(6992), 1 },
                    { 16, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 420, DateTimeKind.Utc).AddTicks(9889), "invoice:create", "Natus rerum adipisci eligendi. Voluptate velit doloremque nesciunt eveniet architecto iusto est minus. Ipsum qui voluptate enim provident nihil. Velit et porro labore beatae ratione assumenda.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 420, DateTimeKind.Utc).AddTicks(9889), 1 },
                    { 17, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 421, DateTimeKind.Utc).AddTicks(3765), "authentication:logout", "A veritatis non in eius porro. Porro maiores id cupiditate quia et ut. Id consequuntur et soluta odit. Quidem nostrum molestiae voluptas. Aut voluptatem laborum et quo. Veritatis animi eligendi quis accusamus qui.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 421, DateTimeKind.Utc).AddTicks(3765), 2 },
                    { 18, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 421, DateTimeKind.Utc).AddTicks(7302), "authentication:new", "Eos officiis provident officia aut provident. Nisi nesciunt maxime rerum. Et corporis enim laboriosam voluptas rerum velit modi. Nobis omnis similique quam reprehenderit. Quasi blanditiis ipsa modi sapiente corporis dolor quod.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 421, DateTimeKind.Utc).AddTicks(7303), 1 },
                    { 19, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 422, DateTimeKind.Utc).AddTicks(503), "settings:change", "Quas harum ex distinctio consequatur dolorum amet suscipit alias. Quam veniam ipsa cupiditate ipsum nulla sunt beatae. Iste dolore ratione laudantium consequatur. Neque omnis magnam maiores nobis.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 422, DateTimeKind.Utc).AddTicks(503), 1 },
                    { 20, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 422, DateTimeKind.Utc).AddTicks(3700), "authentication:new", "Inventore ut est quis est ratione facere. Dolores ducimus est culpa ipsum rerum aut optio. Fugiat quisquam autem excepturi labore quo quas incidunt et. Quis modi et molestiae dicta. Rem accusantium libero et repudiandae.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 422, DateTimeKind.Utc).AddTicks(3700), 2 },
                    { 21, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 422, DateTimeKind.Utc).AddTicks(7664), "invoice:create", "Sed ea odio sequi asperiores iste omnis quidem enim. Sit voluptas doloribus dolores quam. Consequatur aut quia doloribus ad similique ipsam. Debitis ipsa quasi et. Facere dolores aut quaerat nobis quia sit. Consequatur tempora laudantium delectus non libero recusandae.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 422, DateTimeKind.Utc).AddTicks(7664), 1 },
                    { 22, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 423, DateTimeKind.Utc).AddTicks(1650), "authentication:logout", "Voluptatem qui voluptate laborum beatae qui at. Dolor ea dolorem non. Qui quia asperiores sed quasi. Ut consectetur sunt ducimus id debitis in nihil vel pariatur. Eos repellat mollitia accusantium ipsum sit voluptatem fuga dolore sunt.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 423, DateTimeKind.Utc).AddTicks(1650), 2 },
                    { 23, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 423, DateTimeKind.Utc).AddTicks(5739), "settings:change", "Voluptates ipsum nisi quaerat. Et autem voluptas adipisci quo quos aut totam sit dolores. Adipisci consequatur necessitatibus laboriosam modi cum iusto esse. Praesentium molestiae natus explicabo. Consequatur omnis omnis inventore aperiam facere ullam et itaque at.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 423, DateTimeKind.Utc).AddTicks(5740), 1 },
                    { 24, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 423, DateTimeKind.Utc).AddTicks(8042), "authentication:logout", "Et quae autem consequatur expedita qui. Beatae dolores quaerat qui exercitationem ea blanditiis ut et dicta. Ipsum ut facere perspiciatis eligendi.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 423, DateTimeKind.Utc).AddTicks(8042), 2 },
                    { 25, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 424, DateTimeKind.Utc).AddTicks(1327), "settings:change", "Ad sint commodi voluptatem fuga minima officiis ut. Voluptatem rerum quasi laborum est incidunt ducimus. Nobis est dolor tempore incidunt quas. Cupiditate quia repudiandae aut voluptas nesciunt et ea perferendis.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 424, DateTimeKind.Utc).AddTicks(1327), 1 },
                    { 26, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 424, DateTimeKind.Utc).AddTicks(4717), "authentication:new", "Iste et ut corrupti quo et. Ut rerum perferendis aut vel architecto aut suscipit non. Possimus et cum iure vel ipsum. Aut ut accusamus consequatur saepe ut quidem eveniet soluta.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 424, DateTimeKind.Utc).AddTicks(4719), 2 },
                    { 27, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 424, DateTimeKind.Utc).AddTicks(8318), "invoice:create", "Qui quae earum praesentium et sunt itaque optio qui quia. Sapiente unde et optio fuga nam. Aut sequi culpa non ut. Ducimus nobis quia aperiam. Ratione magnam sint vel consequuntur commodi quidem laudantium.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 424, DateTimeKind.Utc).AddTicks(8318), 1 },
                    { 28, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 425, DateTimeKind.Utc).AddTicks(4033), "invoice:send", "At doloremque omnis suscipit porro. Sit praesentium architecto non sed et libero. Voluptates et reiciendis harum. Quos ea excepturi voluptatem nihil sit qui et est deserunt. Sunt vitae qui porro et laborum tempore inventore nemo officiis. Voluptatum in consequatur expedita porro et veritatis id rerum et.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 425, DateTimeKind.Utc).AddTicks(4034), 1 },
                    { 29, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 425, DateTimeKind.Utc).AddTicks(7835), "authentication:new", "Error et ut quis enim quia. Architecto repellat inventore facilis provident nihil ullam sapiente incidunt minima. Odit beatae dolor alias quia laudantium quia et et placeat. Dolore non aspernatur itaque reiciendis ut nam.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 425, DateTimeKind.Utc).AddTicks(7836), 2 },
                    { 30, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 426, DateTimeKind.Utc).AddTicks(2343), "invoice:send", "Maiores accusamus et ratione quia blanditiis dolor ratione nulla ad. Autem voluptatem possimus et eveniet ducimus. Reprehenderit id asperiores at magnam minus sed. Doloremque aut natus quasi numquam repellat placeat cumque. Beatae sunt corrupti non doloremque consequuntur asperiores.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 426, DateTimeKind.Utc).AddTicks(2344), 1 },
                    { 31, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 426, DateTimeKind.Utc).AddTicks(7009), "invoice:send", "Fugit iste est esse rem consequatur optio. Tenetur vero cupiditate non amet velit aliquid praesentium magnam ut. Quis quis labore tempore qui corporis alias. Doloribus facere omnis debitis. Veniam tempora non necessitatibus quae quia. Odio facere quo sed.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 426, DateTimeKind.Utc).AddTicks(7010), 1 },
                    { 32, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 427, DateTimeKind.Utc).AddTicks(1185), "authentication:logout", "Dolores qui repudiandae dolor. Dolorem distinctio assumenda ut totam repudiandae sit. Blanditiis sequi temporibus dignissimos sint ducimus et vel. Ut id maiores minima. Sit nobis nulla excepturi aspernatur placeat dolores. Et quia error eligendi doloremque numquam.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 427, DateTimeKind.Utc).AddTicks(1186), 1 },
                    { 33, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 427, DateTimeKind.Utc).AddTicks(5650), "invoice:create", "Ullam soluta corporis odit. Adipisci doloremque nostrum laboriosam eaque quaerat. Sed aliquam et laudantium est iusto. Molestiae rerum amet ut quia qui pariatur quia eum. Consequatur dolorum aperiam maiores et debitis qui inventore. Atque aliquam ex ipsum.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 427, DateTimeKind.Utc).AddTicks(5653), 2 },
                    { 34, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 427, DateTimeKind.Utc).AddTicks(7883), "invoice:send", "Quis repudiandae nesciunt eligendi ipsum soluta. Eum ab sunt fugit iusto dicta ut blanditiis ducimus. Ut odit iste cupiditate aut.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 427, DateTimeKind.Utc).AddTicks(7883), 2 },
                    { 35, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 428, DateTimeKind.Utc).AddTicks(3120), "authentication:new", "Consequatur ipsum aut et et nisi voluptatum. Numquam incidunt aut qui ullam numquam corporis quod est esse. Aut dolorem enim voluptatem sunt et sequi est. Consectetur eum qui expedita sunt voluptatem. Non impedit beatae libero. Veritatis fuga omnis recusandae dolor expedita et quibusdam soluta.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 428, DateTimeKind.Utc).AddTicks(3120), 1 },
                    { 36, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 428, DateTimeKind.Utc).AddTicks(6639), "settings:change", "Voluptates itaque quidem enim magni. Veniam provident consequatur omnis est. Vel qui voluptates et alias quos perferendis. Ex reprehenderit suscipit vel. Molestiae dolores sequi enim porro ad quis debitis.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 428, DateTimeKind.Utc).AddTicks(6639), 1 },
                    { 37, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 429, DateTimeKind.Utc).AddTicks(2260), "invoice:create", "Rem enim magni fuga ratione. Quibusdam molestiae ut quia enim blanditiis qui tenetur. Autem fuga a dolorum labore repellendus ratione magnam rerum. Animi fuga eius dolorem voluptatem quia illum distinctio corporis unde. Ex voluptas minima ea et mollitia. Culpa quibusdam illum ut et non nemo nemo rerum.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 429, DateTimeKind.Utc).AddTicks(2261), 1 },
                    { 38, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 429, DateTimeKind.Utc).AddTicks(8120), "invoice:send", "Amet possimus cumque rerum soluta omnis magnam ut magni rerum. Quia expedita officia nostrum minus cumque nemo deserunt eius. Nam sit voluptatem quis consequatur nesciunt eius molestiae ut dolores. Consequatur quod debitis suscipit qui quae earum magnam quam. Recusandae voluptas consequatur exercitationem provident porro. Et ea qui accusamus neque temporibus.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 429, DateTimeKind.Utc).AddTicks(8120), 1 },
                    { 39, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 430, DateTimeKind.Utc).AddTicks(2554), "invoice:create", "Consequatur autem officia exercitationem. Occaecati expedita quod modi est commodi. Qui a quis hic sed perferendis est alias aliquam quidem. Est rerum ut aut libero eius. Nobis tempore maxime corrupti. Ut doloribus repudiandae eaque fugiat excepturi recusandae.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 430, DateTimeKind.Utc).AddTicks(2554), 1 },
                    { 40, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 430, DateTimeKind.Utc).AddTicks(6661), "invoice:send", "Quasi dolorem non repudiandae saepe vitae ipsa architecto. Impedit explicabo reprehenderit iure voluptate. Aut voluptatem qui tempore sunt vitae aliquam minima. Cupiditate sint placeat eos voluptatum nam. Dolorem minima repudiandae voluptatibus doloribus aliquam est corrupti animi.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 430, DateTimeKind.Utc).AddTicks(6662), 2 },
                    { 41, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 431, DateTimeKind.Utc).AddTicks(323), "invoice:create", "Quae vel ut laborum. Autem dicta consectetur sit sit ipsam saepe cum. Est dolor nihil molestiae sit sint quis quia minus. Excepturi distinctio enim ipsam recusandae vitae quae itaque. Temporibus voluptas nihil iure.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 431, DateTimeKind.Utc).AddTicks(324), 1 },
                    { 42, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 431, DateTimeKind.Utc).AddTicks(4316), "authentication:new", "Consequatur quia voluptatem et eos. Ipsa necessitatibus quisquam harum aliquid quia. Et harum labore fugit vel doloribus consequatur esse tempora omnis. Distinctio est est ratione autem sit tempora. Sint beatae quis quaerat qui consequuntur dolor.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 431, DateTimeKind.Utc).AddTicks(4317), 2 },
                    { 43, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 431, DateTimeKind.Utc).AddTicks(7014), "invoice:create", "Voluptatem ratione aperiam quidem quia aspernatur aut. Expedita consectetur aut repellat eveniet sed. Non soluta perspiciatis quos inventore nemo pariatur est autem deleniti.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 431, DateTimeKind.Utc).AddTicks(7015), 2 },
                    { 44, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 432, DateTimeKind.Utc).AddTicks(1002), "authentication:logout", "Error nihil ipsam animi magni. Qui voluptas officia facere sint quia vel quam. Repudiandae quis aut sunt quo ratione et possimus minima. Quo error dolores sint. Nulla dolor aut illum at error quos est possimus.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 432, DateTimeKind.Utc).AddTicks(1003), 2 },
                    { 45, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 432, DateTimeKind.Utc).AddTicks(4236), "settings:change", "Voluptatibus quo ut quia deserunt ea sit dignissimos quasi. Tempore molestias magni quo atque fuga perferendis placeat eum voluptatem. Molestiae molestiae tempore ullam. Consectetur necessitatibus et dolore aperiam.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 432, DateTimeKind.Utc).AddTicks(4237), 2 },
                    { 46, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 432, DateTimeKind.Utc).AddTicks(7844), "invoice:create", "Excepturi reiciendis et aut maxime. Eaque minus ipsam suscipit. Ut aperiam et nemo. Odio repudiandae ducimus inventore cumque minus expedita nemo. Ea nobis aliquid distinctio facilis tenetur. Eos ut eum ipsum consequuntur.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 432, DateTimeKind.Utc).AddTicks(7844), 1 },
                    { 47, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 433, DateTimeKind.Utc).AddTicks(1881), "invoice:send", "Voluptatem a quidem temporibus quos ducimus voluptatem sed. Et officiis sed animi. Alias tempora quo repellendus voluptates. Odit sint veritatis ea qui culpa repellendus. Aliquam rem expedita molestiae aut accusantium. Repellat cumque voluptatibus a quia veniam.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 433, DateTimeKind.Utc).AddTicks(1882), 2 },
                    { 48, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 433, DateTimeKind.Utc).AddTicks(5322), "authentication:new", "Ipsa praesentium facilis non consequatur et nihil alias. Sapiente voluptates numquam numquam. Perspiciatis eum ut autem. Quia cupiditate saepe veniam ipsa repellat numquam omnis voluptatem.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 433, DateTimeKind.Utc).AddTicks(5323), 1 },
                    { 49, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 433, DateTimeKind.Utc).AddTicks(8352), "invoice:create", "Consectetur harum a odio optio non dolor similique cupiditate. Ullam veniam suscipit repellendus omnis repellat recusandae voluptas. Quod odio perspiciatis perferendis quos nemo accusantium.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 433, DateTimeKind.Utc).AddTicks(8353), 1 },
                    { 50, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 434, DateTimeKind.Utc).AddTicks(1539), "authentication:new", "Rerum dolores modi voluptatum dicta dolor. Possimus id inventore nulla quis est beatae laudantium consequatur. Unde culpa autem ea accusantium id qui. Necessitatibus sunt ea rerum possimus magni.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 434, DateTimeKind.Utc).AddTicks(1540), 2 },
                    { 51, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 434, DateTimeKind.Utc).AddTicks(3375), "invoice:create", "Ea praesentium quos veritatis quia. Atque vel odit ea sit. Voluptates ullam iste distinctio cum totam.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 434, DateTimeKind.Utc).AddTicks(3375), 2 },
                    { 52, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 434, DateTimeKind.Utc).AddTicks(7324), "invoice:send", "Sequi sint perspiciatis cupiditate. Totam sunt delectus quis enim. Illum quia quae iste placeat aut eos dolor. Et provident tempora cum adipisci ut tempora. Sit quia incidunt saepe quidem natus. Quas accusamus omnis minima consectetur.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 434, DateTimeKind.Utc).AddTicks(7324), 1 },
                    { 53, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 435, DateTimeKind.Utc).AddTicks(1056), "authentication:logout", "Sit qui ea iusto. Ullam debitis voluptatem vitae eos cumque corporis. Voluptatem impedit quidem quas porro deleniti. Et eius eveniet necessitatibus eum beatae non repellat. Animi temporibus et doloremque similique magnam ex vel.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 435, DateTimeKind.Utc).AddTicks(1057), 2 },
                    { 54, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 435, DateTimeKind.Utc).AddTicks(7234), "authentication:logout", "Libero voluptatibus culpa velit eaque suscipit. Sunt eos facere perferendis dolores accusantium omnis excepturi aut. Voluptate ratione impedit qui et provident aut incidunt iste. Placeat quo iure quaerat quia quae est deserunt tempore. Saepe et quia est qui non nemo. Eos repellat voluptatem cumque nobis aut molestiae eum.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 435, DateTimeKind.Utc).AddTicks(7235), 1 },
                    { 55, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 436, DateTimeKind.Utc).AddTicks(697), "authentication:new", "Molestias veritatis non ex perspiciatis aperiam rerum consequatur rerum. Doloremque dolores ea cum libero molestiae at. Voluptatem dolores blanditiis velit ex consequatur quis laudantium.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 436, DateTimeKind.Utc).AddTicks(698), 1 },
                    { 56, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 436, DateTimeKind.Utc).AddTicks(5319), "authentication:new", "Quae sint quam iste. Optio incidunt est atque quaerat amet doloribus. Deserunt aut pariatur qui expedita voluptates. Et voluptatem tempora necessitatibus nisi sint quam qui. Numquam soluta ut quia perspiciatis. Quidem harum asperiores voluptas quod quia ut.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 436, DateTimeKind.Utc).AddTicks(5320), 2 },
                    { 57, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 436, DateTimeKind.Utc).AddTicks(8210), "authentication:logout", "Eos incidunt numquam enim alias. Deleniti id ducimus sit quisquam voluptatem ratione. Error sed qui officiis cupiditate tempora molestias distinctio voluptas. Eos numquam repudiandae aut.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 436, DateTimeKind.Utc).AddTicks(8210), 1 },
                    { 58, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 437, DateTimeKind.Utc).AddTicks(3143), "authentication:new", "Qui distinctio est impedit totam eum eveniet. Maiores consequuntur sunt velit neque ipsam eaque id iure. Minima ratione numquam exercitationem aut quae aut. Atque vel vitae qui maiores temporibus. Consequatur dolore consectetur voluptatem qui dignissimos vel. Ipsum odio labore optio eveniet impedit voluptas.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 437, DateTimeKind.Utc).AddTicks(3143), 2 },
                    { 59, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 437, DateTimeKind.Utc).AddTicks(6460), "authentication:logout", "Hic nam dolor atque aut sed beatae expedita optio. Cum iste fuga est. Non sed maiores quidem qui mollitia iusto voluptatem. Quaerat sint magni vero perferendis eius aut.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 437, DateTimeKind.Utc).AddTicks(6461), 1 },
                    { 60, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 437, DateTimeKind.Utc).AddTicks(9359), "invoice:send", "Omnis ut rerum est. Quo quam fugiat cupiditate voluptatem iure aut fugiat repellat asperiores. Fuga tempore id eligendi assumenda. Debitis consequatur modi officia corrupti quo accusantium.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 437, DateTimeKind.Utc).AddTicks(9359), 2 },
                    { 61, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 438, DateTimeKind.Utc).AddTicks(1985), "settings:change", "Harum facilis delectus nam optio. Modi veniam voluptatibus sunt quisquam voluptatem nemo velit mollitia at. Accusantium rem error exercitationem distinctio voluptatem quo illum.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 438, DateTimeKind.Utc).AddTicks(1986), 1 },
                    { 62, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 438, DateTimeKind.Utc).AddTicks(4623), "invoice:create", "Nulla quo quaerat id. Doloremque neque ut dignissimos in et ullam rerum. Voluptas et aliquam corporis non qui. Eligendi quaerat magnam dolore.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 438, DateTimeKind.Utc).AddTicks(4623), 2 },
                    { 63, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 438, DateTimeKind.Utc).AddTicks(6966), "invoice:send", "Recusandae autem nemo quis laboriosam repellendus omnis labore aut voluptas. Placeat reprehenderit molestiae similique eligendi tempora nobis. In vitae voluptatem rem.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 438, DateTimeKind.Utc).AddTicks(6966), 1 },
                    { 64, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 438, DateTimeKind.Utc).AddTicks(9750), "authentication:logout", "Maxime suscipit aut sed repellat ea. Molestiae neque cupiditate quia voluptas aut consequatur ut. Nostrum voluptas perspiciatis similique distinctio quia odio. Sint molestias non voluptas.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 438, DateTimeKind.Utc).AddTicks(9751), 1 },
                    { 65, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 439, DateTimeKind.Utc).AddTicks(2187), "authentication:logout", "Qui enim illum non accusamus sit non. Eum suscipit omnis modi consequatur saepe et necessitatibus dicta. Ex dicta expedita quis consectetur.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 439, DateTimeKind.Utc).AddTicks(2188), 1 },
                    { 66, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 439, DateTimeKind.Utc).AddTicks(4436), "authentication:new", "Eos sit non ipsa provident. Exercitationem cum quos impedit vel qui qui doloremque. Animi repellendus unde non ea.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 439, DateTimeKind.Utc).AddTicks(4437), 2 },
                    { 67, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 439, DateTimeKind.Utc).AddTicks(6825), "settings:change", "Perspiciatis quo excepturi cupiditate possimus ducimus modi et exercitationem. Libero ut consequatur autem. Sed libero qui qui voluptas ipsum qui velit.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 439, DateTimeKind.Utc).AddTicks(6826), 2 },
                    { 68, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(963), "settings:change", "Et consequatur dolor distinctio velit illo aspernatur est. Amet quibusdam qui at dolorem. Sint eos maiores necessitatibus. Dolorem sunt at perferendis eos eaque tempore perspiciatis quis. Enim optio ipsam exercitationem consequatur optio sit quia voluptatem est. Consequatur distinctio id est.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(964), 1 },
                    { 69, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(3504), "settings:change", "Maiores voluptas ab quisquam voluptatibus ad. Dolores rem eligendi quia voluptas cum hic. Adipisci perspiciatis dolorum vitae nostrum quo. Occaecati reiciendis corporis nobis perferendis quam sit consequuntur. Qui et nemo odio ut impedit. Consequatur facilis accusamus id quaerat fugit quia.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(3504), 2 },
                    { 70, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(4821), "authentication:logout", "Nihil laborum ipsum eius. Suscipit eos eos est odio ratione asperiores. Unde deserunt et vel dignissimos delectus commodi a numquam amet.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(4821), 2 },
                    { 71, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(6269), "invoice:create", "Ab cupiditate deleniti sed pariatur porro in. Voluptas assumenda voluptatem molestias suscipit molestiae veritatis dolorem. Temporibus optio commodi omnis porro dolorem ut rerum.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(6269), 2 },
                    { 72, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(8977), "authentication:logout", "Cumque iusto asperiores in aut aut aspernatur. Similique qui vitae et facere aut aperiam occaecati quia. Dolorem architecto est et blanditiis quos nihil. Quo dolor est voluptas dolorem aut quo hic quisquam cum. Ut dicta at omnis est magnam omnis.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 440, DateTimeKind.Utc).AddTicks(8977), 2 },
                    { 73, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 441, DateTimeKind.Utc).AddTicks(1926), "authentication:new", "Numquam quod laborum enim. Officia et recusandae eos debitis qui provident delectus. Quae rerum non aliquid quia. Numquam commodi ex nam magnam assumenda ex commodi laboriosam.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 441, DateTimeKind.Utc).AddTicks(1926), 2 },
                    { 74, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 441, DateTimeKind.Utc).AddTicks(4659), "authentication:logout", "Et veniam voluptatem dignissimos autem debitis fugiat eaque. Tempore magni qui mollitia libero odit sit. Odit quaerat suscipit quo.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 441, DateTimeKind.Utc).AddTicks(4659), 2 },
                    { 75, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 441, DateTimeKind.Utc).AddTicks(7289), "authentication:new", "In reiciendis saepe saepe fuga repudiandae. Libero quidem incidunt suscipit ipsam. Soluta error quos animi saepe alias illo.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 441, DateTimeKind.Utc).AddTicks(7289), 2 },
                    { 76, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 442, DateTimeKind.Utc).AddTicks(450), "invoice:create", "Minus dolorum consectetur a voluptatem. Praesentium eum velit earum eos iure. Non repellendus non sint dicta quidem et. Exercitationem voluptas sed ut omnis.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 442, DateTimeKind.Utc).AddTicks(450), 2 },
                    { 77, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 442, DateTimeKind.Utc).AddTicks(5902), "invoice:send", "Ut eos aut perspiciatis recusandae fugiat. Iste dignissimos consequatur praesentium dolore aperiam consectetur. Aspernatur in blanditiis eos ut quibusdam. Officiis quo velit corporis quia facilis aliquam. Tempora doloribus non ut beatae.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 442, DateTimeKind.Utc).AddTicks(5904), 1 },
                    { 78, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 442, DateTimeKind.Utc).AddTicks(9318), "authentication:logout", "Est molestias explicabo et omnis sequi sunt sapiente qui. Facere et iusto tempora consequatur iure. Omnis provident facere facere. Tempore numquam ut quas tenetur. Ea iusto molestias culpa natus.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 442, DateTimeKind.Utc).AddTicks(9319), 1 },
                    { 79, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 443, DateTimeKind.Utc).AddTicks(2190), "invoice:create", "Aut in mollitia aut possimus suscipit voluptate voluptas. Inventore eligendi quod est sed error totam. Voluptatem exercitationem architecto iusto deserunt delectus aliquam incidunt et culpa.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 443, DateTimeKind.Utc).AddTicks(2190), 2 },
                    { 80, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 443, DateTimeKind.Utc).AddTicks(5574), "authentication:new", "In eum magnam voluptates autem sint. Veritatis omnis voluptatem asperiores est quas et. Placeat quia sint dignissimos vel enim ea. Ullam ab molestias soluta dolores ut aspernatur debitis odio voluptatem.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 443, DateTimeKind.Utc).AddTicks(5575), 1 },
                    { 81, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 443, DateTimeKind.Utc).AddTicks(9085), "settings:change", "Sint eveniet eligendi quia quia. Ut explicabo sed aut maiores. Ipsam veniam voluptatem labore nihil architecto. Nesciunt incidunt labore inventore porro ad temporibus pariatur expedita numquam. Natus maxime qui est sunt illum at minus et. Similique modi non exercitationem numquam nostrum architecto possimus ducimus.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 443, DateTimeKind.Utc).AddTicks(9086), 1 },
                    { 82, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 444, DateTimeKind.Utc).AddTicks(1352), "authentication:logout", "Aut adipisci atque ut. Eveniet perspiciatis ab tempore esse ad. Harum eum earum sapiente soluta quo ut eaque. Suscipit ullam quas officiis commodi vel autem corporis. Repellat voluptatem quis aut aliquid et pariatur vero quia quod.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 444, DateTimeKind.Utc).AddTicks(1353), 1 },
                    { 83, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 444, DateTimeKind.Utc).AddTicks(3832), "invoice:send", "Cumque et et qui porro eaque aut facere rerum explicabo. Aliquam quod fugiat incidunt iusto culpa quo delectus sed rerum. Et quo aut ex ipsum. Ut maxime perspiciatis accusamus fugit suscipit necessitatibus facere optio optio. Tempore nobis quis doloremque.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 444, DateTimeKind.Utc).AddTicks(3833), 1 },
                    { 84, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 444, DateTimeKind.Utc).AddTicks(8660), "settings:change", "Illo sed eligendi occaecati commodi. Asperiores at rem dolor libero in explicabo non. Laudantium ducimus et reiciendis iste delectus corporis amet. Ad temporibus repellendus maiores maiores excepturi fuga deleniti. Voluptatem et cumque ut aut voluptate natus et libero.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 444, DateTimeKind.Utc).AddTicks(8661), 1 },
                    { 85, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 445, DateTimeKind.Utc).AddTicks(2629), "invoice:create", "Natus voluptate aliquid et officia beatae molestias et. Rerum libero quibusdam assumenda sunt eos est architecto vel. Eum voluptatem et illo consequuntur dicta consequatur. Qui est sed aspernatur. Sint quia repudiandae quasi nihil non et.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 445, DateTimeKind.Utc).AddTicks(2629), 2 },
                    { 86, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 445, DateTimeKind.Utc).AddTicks(6346), "invoice:create", "Aut et non quod. Quo deleniti unde autem voluptates eos enim non. Est qui fugiat cumque. Quod quia ut impedit modi saepe blanditiis. Quisquam molestias voluptas est.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 445, DateTimeKind.Utc).AddTicks(6347), 2 },
                    { 87, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 446, DateTimeKind.Utc).AddTicks(2189), "invoice:send", "Sed debitis perferendis laudantium. Qui odio aspernatur quia aut totam et adipisci. Voluptatibus ex velit aut adipisci impedit sint molestiae ut ullam. Et qui ad sunt numquam quis voluptatem doloremque aperiam. Dignissimos est unde veniam rerum. Rerum sed est similique consequatur suscipit.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 446, DateTimeKind.Utc).AddTicks(2190), 2 },
                    { 88, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 446, DateTimeKind.Utc).AddTicks(4844), "authentication:logout", "Et et saepe expedita. Itaque velit explicabo recusandae itaque hic fugiat et. Voluptatem ex sint fugiat sequi aut. Saepe in explicabo voluptatem ea.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 446, DateTimeKind.Utc).AddTicks(4844), 2 },
                    { 89, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 446, DateTimeKind.Utc).AddTicks(8027), "authentication:logout", "Eveniet id nesciunt iste repellat rerum autem doloremque. Qui velit voluptatem aut dolorum animi voluptas minus aut. Assumenda quisquam in non quo ad voluptatem quo quam aperiam.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 446, DateTimeKind.Utc).AddTicks(8028), 2 },
                    { 90, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 447, DateTimeKind.Utc).AddTicks(630), "settings:change", "Quo officiis consectetur tempora. Ut totam sint consequuntur iure alias qui est. Architecto temporibus consequuntur blanditiis aspernatur. Nostrum ipsam sapiente voluptatem enim. Delectus aut consequatur consequatur consequatur suscipit id.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 447, DateTimeKind.Utc).AddTicks(630), 1 },
                    { 91, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 447, DateTimeKind.Utc).AddTicks(3025), "authentication:logout", "Laudantium ea dolor molestias. Quidem quo quia aut tenetur ducimus non. Maxime asperiores qui reprehenderit consequatur dolor. Doloremque quo aut veritatis saepe eligendi. Est nam dolore deserunt neque ut sed voluptatem autem necessitatibus. Assumenda quae sed quidem corrupti.", "finished", new DateTime(2022, 10, 9, 5, 54, 24, 447, DateTimeKind.Utc).AddTicks(3026), 2 },
                    { 92, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 447, DateTimeKind.Utc).AddTicks(4198), "authentication:new", "Ex voluptatem non animi. Consequatur ad deleniti explicabo quas suscipit aliquam. Quidem quam dicta et nisi voluptatem.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 447, DateTimeKind.Utc).AddTicks(4199), 1 },
                    { 93, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 447, DateTimeKind.Utc).AddTicks(8064), "authentication:new", "Unde quisquam est et dignissimos qui quae ipsa at molestiae. Numquam voluptatem non velit porro aperiam hic sit. Doloremque nostrum natus ut ratione aut illo et aliquam et. Quo aspernatur quam vitae iste enim.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 447, DateTimeKind.Utc).AddTicks(8064), 2 },
                    { 94, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(1134), "invoice:send", "Voluptate assumenda quia dolorem sint. Nihil voluptatum vero itaque et. Minima illum rerum temporibus et odit quidem aliquam. Et eaque cum eligendi cumque iste ducimus ipsa cum.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(1134), 2 },
                    { 95, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(3485), "invoice:create", "Itaque et non ea. Accusantium aut enim voluptatum et omnis unde beatae. Nihil quod aut et. Beatae tempore consequatur qui.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(3485), 2 },
                    { 96, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(5325), "invoice:create", "Corrupti sit magnam ut. Voluptatem rem dolorum dolor aut labore officiis eos. Consectetur velit qui omnis.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(5325), 2 },
                    { 97, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(7884), "invoice:create", "Nihil quisquam occaecati corporis est. Dolorum officia sit officiis nam adipisci omnis recusandae ut. Cupiditate et laboriosam sint labore. Veniam molestias incidunt distinctio officiis explicabo perferendis facere. Rerum magnam animi est provident nisi excepturi et omnis.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(7884), 1 },
                    { 98, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(9213), "invoice:create", "Veniam unde dolor sed consectetur. Atque nam omnis omnis aut ut nam. In inventore ipsa magnam ut corrupti libero soluta rerum.", "error", new DateTime(2022, 10, 9, 5, 54, 24, 448, DateTimeKind.Utc).AddTicks(9213), 1 },
                    { 99, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 449, DateTimeKind.Utc).AddTicks(1997), "authentication:logout", "Nobis debitis et et cumque est fugiat quo. Qui odit et delectus. Culpa voluptatibus quod possimus eos dicta sequi est dolor suscipit. Labore aut quia ea voluptate. Ad et in quia et ab et qui id aut. Accusantium sed ut beatae ut et.", "started", new DateTime(2022, 10, 9, 5, 54, 24, 449, DateTimeKind.Utc).AddTicks(1997), 2 },
                    { 100, "{}", new DateTime(2022, 10, 9, 5, 54, 24, 449, DateTimeKind.Utc).AddTicks(5741), "authentication:logout", "Molestiae quae et est sunt ipsa saepe. Est qui iure quod impedit modi. Fugiat hic eos explicabo. Cumque ipsa assumenda non sit ad modi. Et dignissimos nesciunt inventore.", "in progress", new DateTime(2022, 10, 9, 5, 54, 24, 449, DateTimeKind.Utc).AddTicks(5742), 2 }
                });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 412, DateTimeKind.Utc).AddTicks(758), "Et cumque autem et. Recusandae atque labore a non laudantium sit voluptas. Pariatur architecto quibusdam natus repudiandae sapiente earum itaque eaque dicta. Consequatur ab cumque soluta reiciendis. Laborum voluptate voluptate ut aut cupiditate quasi. Quam veniam consequuntur est adipisci qui aut.", "Self-enabling human-resource process improvement", new DateTime(2022, 10, 9, 5, 54, 24, 412, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 412, DateTimeKind.Utc).AddTicks(5223), "Qui odio sit expedita quae. Ad et fuga ullam quos aut quisquam illum temporibus quis. Doloribus odio vel dignissimos debitis illum sed sunt. Voluptatem quasi quod ipsa adipisci occaecati nostrum. Velit ex enim laborum libero voluptas ut qui aut maxime. Voluptatum et veniam quas et.", "Virtual disintermediate projection", new DateTime(2022, 10, 9, 5, 54, 24, 412, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 412, DateTimeKind.Utc).AddTicks(9083), "Voluptas consectetur molestiae et adipisci quaerat aut nobis maiores voluptatem. Omnis odio quas minus magni maiores iste quia id saepe. Est et vel sapiente officiis adipisci maiores qui a. Placeat quos aut quos sunt.", "Focused impactful superstructure", new DateTime(2022, 10, 9, 5, 54, 24, 412, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(1259), "Iste quisquam unde laboriosam unde ratione. Incidunt tempore possimus aut. Aliquam laborum voluptatem asperiores magnam sit et quis fuga.", "Profound systematic adapter", new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(4609), "Voluptas sit ab praesentium maxime fugit accusantium natus quos architecto. Dolorem magni doloribus error minus eligendi doloremque quae. Assumenda ab nemo dolor rerum commodi eum. Aut blanditiis corrupti soluta vero repellendus ut. Rerum itaque distinctio ad ab sed aspernatur.", "Profit-focused clear-thinking archive", new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(5718), "Doloribus qui quo quos. Distinctio aperiam non debitis. Expedita hic reprehenderit aut ullam voluptatem numquam.", "Quality-focused motivating solution", new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(7984), "Ducimus repellat laborum aspernatur qui quae aperiam. Repellat non aliquam inventore quasi excepturi impedit nihil inventore nihil. Facilis quia ut non. Perferendis et quam est aut voluptatem ea sed. Temporibus rerum minus ut quo.", "Assimilated scalable product", new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(9458), "Blanditiis ut rerum voluptatum amet dolorem quia et aut. Voluptas mollitia sed sit voluptatem exercitationem ut est. Rerum amet nisi neque.", "Focused directional conglomeration", new DateTime(2022, 10, 9, 5, 54, 24, 413, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "description", "owner_id", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 414, DateTimeKind.Utc).AddTicks(3250), "Consequatur voluptatem iste deleniti omnis pariatur dolorum officia. Id eum et eos deleniti totam aliquam. Eos quasi molestiae quos natus ad aliquam quis nostrum. Velit ducimus minima totam corrupti omnis perferendis quam tempore et. Porro neque aut impedit rerum.", 1, "Networked executive flexibility", new DateTime(2022, 10, 9, 5, 54, 24, 414, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "owner_id", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 414, DateTimeKind.Utc).AddTicks(7589), "Necessitatibus corporis et autem nostrum ducimus quia. Amet deleniti dolorem non omnis eos ducimus nihil. Non quod non molestiae eaque illo et in. Aspernatur fuga nostrum accusantium libero. Sit atque perspiciatis quis omnis eos voluptatem ut et aperiam.", 1, "Programmable 6th generation matrices", new DateTime(2022, 10, 9, 5, 54, 24, 414, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 411, DateTimeKind.Utc).AddTicks(6713), new DateTime(2022, 10, 9, 5, 54, 24, 411, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 5, 54, 24, 411, DateTimeKind.Utc).AddTicks(6758), new DateTime(2022, 10, 9, 5, 54, 24, 411, DateTimeKind.Utc).AddTicks(6758) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "audits");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporis sit ratione quia minima. Quasi voluptatum tempora temporibus et atque quis nesciunt. Voluptas similique est eum id numquam ducimus quis. Eum laborum maxime aut aperiam velit. Doloremque vero sed velit libero.", "Right-sized reciprocal adapter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia vel rerum consequatur. Aliquam qui sed fugiat et nostrum. Labore explicabo consequatur reiciendis laboriosam optio sint facilis. Illum qui quod eos. Excepturi provident aut aut numquam voluptatibus.", "Down-sized national open system", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alias a rerum quasi voluptates. Repellat excepturi quasi amet dolore amet veritatis facere et. Dolor ullam rem non accusantium necessitatibus dolores alias.", "Compatible 24 hour migration", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic soluta eum commodi qui autem quae et. Et consectetur odit minus. Odit corrupti in nihil harum aliquam omnis. Sed et sint officiis autem voluptatem sequi. Enim enim fugit ab molestiae id hic.", "Customizable incremental strategy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et rerum assumenda veritatis qui qui et nostrum delectus nihil. Dolor rerum quaerat neque. Est quae maxime accusamus maiores quia expedita ab fugit odit. Eius iure dolorem minus sunt. Quod ipsum omnis itaque ratione officiis ut ea ad ea.", "Networked human-resource firmware", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic aliquid et molestiae et. Dolorum ipsum magnam eius maiores. Qui voluptatum cumque ad fugiat itaque aliquam. Tenetur qui eveniet voluptatibus quam reiciendis eligendi. Quos voluptatem exercitationem quam sunt inventore earum tempore placeat ut. Suscipit assumenda veritatis ex sunt et.", "Pre-emptive discrete open system", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut eos est in voluptatem eos natus quia. Et quo distinctio impedit molestias libero suscipit eveniet neque. Eum numquam perspiciatis omnis ex alias est et. Sit praesentium laborum atque nobis nihil voluptatem odio rerum. Qui voluptas cum tenetur omnis at explicabo velit dolores.", "Horizontal methodical knowledge user", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur veritatis doloremque molestiae officiis omnis et. Fugiat doloremque molestiae eum qui et consequatur aut sunt consectetur. At soluta odio debitis ut amet recusandae nulla voluptas placeat. Blanditiis itaque quo quibusdam sapiente ut quae.", "Optimized real-time knowledge base", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "description", "owner_id", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum distinctio et odio veniam. Earum est omnis voluptatem. Mollitia aut eos rerum totam alias autem fugiat. Ullam in ab enim.", 2, "Open-source modular help-desk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "owner_id", "title", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem distinctio delectus numquam. Culpa aut provident voluptatem repellat sunt tempora. Odio quia quisquam et quam quisquam nulla esse. Molestiae ullam velit qui accusantium a vero non. Accusamus distinctio assumenda occaecati non saepe provident omnis ut aspernatur.", 2, "Reactive static concept", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
