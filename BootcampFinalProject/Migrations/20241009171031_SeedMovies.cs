using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootcampFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "BannerUrl", "Director", "Genre", "Rating", "ReleaseYear", "RunningTimeInMin", "ThumbnailUrl", "Title" },
                values: new object[,]
                {
                    { "7e9d6875-fccd-454c-b462-bc22afb0bc10.jpg", "Francis Ford Coppola", "Epic, Gangster, Drama, Crime, Tragedy", 9.2m, 1972, 175, "3b98ba65-fedc-4be6-9c65-99b98bf3f926.jpg", "The Godfather" },
                    { "93c20918-51dc-4046-b12c-11c54808763c.jpg", "Frank Darabont", "Epic, Period Drama, Prison Drama, Tragedy, Drama", 9.3m, 1994, 142, "5711c6f1-3f60-409d-b13a-8c0a3ad016d0.jpg", "The Shawshank Redemption" },
                    { "6b686f0c-7c9e-40c5-95b9-130f8a3bd6e2.jpg", "Francis Ford Coppola", "Epic, Gangster, Drama, Crime, Tragedy", 9.0m, 1974, 202, "fc559522-8dd4-474f-9ea1-f98cae007cf4.jpg", "The Godfather Part II" },
                    { "220bbc2b-48ee-4765-9eb2-f13e3ff4b2ff.jpg", "Christopher Nolan", "Action Epic, Adventure Epic, Psychological Thriller, Sci-Fi Epic, Action, Adventure, Sci-Fi, Thriller", 8.8m, 2010, 148, "956e35b2-e684-4095-a437-2c22b7c7f4e7.jpg", "Inception" },
                    { "a744ef00-2db0-43ad-b83b-1587d48d348d.jpg", "David Fincher", "Psychological Drama, Workplace Drama, Drama", 8.8m, 1999, 139, "1109391a-e96e-40ac-8932-8d0283f056f5.jpg", "Fight Club" },
                    { "987a3215-cdd2-4193-becb-a084b7863bd9.jpg", "Christopher Nolan", "Action Epic, Epic, Superhero, Action, Crime, Drama, Thriller", 9.0m, 2008, 152, "7fb187ae-bb68-4f47-9a8d-b815119db2d4.jpg", "The Dark Knight" },
                    { "163c5647-3eeb-44dc-80e6-04418bfc13a0.jpg", "Sidney Lumet", "Legal Drama, Psychological Drama, Crime, Drama", 9.0m, 1957, 96, "00c3bf93-5856-4696-95b2-0c14687b8923.jpg", "12 Angry Men" },
                    { "21ba7840-7b0a-4c16-b4eb-f77c24131518.jpg", "Peter Jackson", "Adventure Epic, Fantasy Epic, Quest, Sword & Sorcery, Action, Adventure, Drama, Fantasy", 8.9m, 2001, 178, "7cb3bcdc-79eb-42d4-ac1c-3233c23ff18f.jpg", "The Lord of the Rings: The Fellowship of the Ring" },
                    { "878a437a-ce65-4033-97fd-a7c57800b4bf.jpg", " Lana Wachowski & Lilly Wachowski", "Action Epic, Artificial Intelligence, Cyberpunk, Dystopian Sci-Fi, Gun Fu, Martial Arts, Sci-Fi Epic, Action, Sci-Fi", 8.7m, 1999, 136, "85170eab-36c5-45d5-b393-f924f75ff904.jpg", "The Matrix" },
                    { "07944830-465d-4eb7-86ae-ac97dbb0fcc8.jpg", " David Fincher", "Cop Drama, Hard-boiled Detective, Legal Drama, Police Procedural, Psychological Thriller, Serial Killer, Crime, Drama, Mystery, Thriller", 8.6m, 1995, 127, "c895e1fe-0bb4-4888-9f91-6a0fdae6dd55.jpg", "Se7en" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
