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
                    { "https://w0.peakpx.com/wallpaper/557/513/HD-wallpaper-the-godfather-marlon-brando-vito-corleone.jpg", "Francis Ford Coppola", "Epic, Gangster, Drama, Crime, Tragedy", 9.2m, 1972, 175, "https://m.media-amazon.com/images/M/MV5BYTJkNGQyZDgtZDQ0NC00MDM0LWEzZWQtYzUzZDEwMDljZWNjXkEyXkFqcGc@._V1_.jpg", "The Godfather" },
                    { "https://c4.wallpaperflare.com/wallpaper/834/280/850/movies-the-shawshank-redemption-wallpaper-preview.jpg", "Frank Darabont", "Epic, Period Drama, Prison Drama, Tragedy, Drama", 9.3m, 1994, 142, "https://m.media-amazon.com/images/M/MV5BMDAyY2FhYjctNDc5OS00MDNlLThiMGUtY2UxYWVkNGY2ZjljXkEyXkFqcGc@._V1_.jpg", "The Shawshank Redemption" },
                    { "https://images3.alphacoders.com/131/1315823.jpg", "Francis Ford Coppola", "Epic, Gangster, Drama, Crime, Tragedy", 9.0m, 1974, 202, "https://m.media-amazon.com/images/M/MV5BNzc1OWY5MjktZDllMi00ZDEzLWEwMGItYjk1YmRhYjBjNTVlXkEyXkFqcGc@._V1_.jpg", "The Godfather Part II" },
                    { "https://wallpapercave.com/wp/Q48fR1x.jpg", "Christopher Nolan", "Action Epic, Adventure Epic, Psychological Thriller, Sci-Fi Epic, Action, Adventure, Sci-Fi, Thriller", 8.8m, 2010, 148, "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg", "Inception" },
                    { "https://lumiere-a.akamaihd.net/v1/images/fightclub_mainmenu_ka_3840x2160_98330c30.jpeg", "David Fincher", "Psychological Drama, Workplace Drama, Drama", 8.8m, 1999, 139, "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_.jpg", "Fight Club" },
                    { "https://theconsultingdetectivesblog.com/wp-content/uploads/2014/06/the-dark-knight-original.jpg", "Christopher Nolan", "Action Epic, Epic, Superhero, Action, Crime, Drama, Thriller", 9.0m, 2008, 152, "https://m.media-amazon.com/images/M/MV5BMTIzMDc4MzA2Ml5BMl5BanBnXkFtZTcwODU0MzA3MQ@@._V1_.jpg", "The Dark Knight" },
                    { "https://s1.dmcdn.net/v/VPo1g1bLR9X3RfLPs/x1080", "Sidney Lumet", "Legal Drama, Psychological Drama, Crime, Drama", 9.0m, 1957, 96, "https://m.media-amazon.com/images/M/MV5BYjE4NzdmOTYtYjc5Yi00YzBiLWEzNDEtNTgxZGQ2MWVkN2NiXkEyXkFqcGc@._V1_.jpg", "12 Angry Men" },
                    { "https://m.media-amazon.com/images/S/pv-target-images/2f0e365f033851be687ca2179166fb614c2e2175d4a812b671abb533650b8639.jpg", "Peter Jackson", "Adventure Epic, Fantasy Epic, Quest, Sword & Sorcery, Action, Adventure, Drama, Fantasy", 8.9m, 2001, 178, "https://m.media-amazon.com/images/M/MV5BZjRlZGYwYjUtYWQwNi00N2JjLTk2NmUtODBkODJkNjNjZTYyXkEyXkFqcGc@._V1_.jpg", "The Lord of the Rings: The Fellowship of the Ring" },
                    { "https://static1.colliderimages.com/wordpress/wp-content/uploads/2024/02/the-matrix-code-keanu-reeves.jpg", " Lana Wachowski & Lilly Wachowski", "Action Epic, Artificial Intelligence, Cyberpunk, Dystopian Sci-Fi, Gun Fu, Martial Arts, Sci-Fi Epic, Action, Sci-Fi", 8.7m, 1999, 136, "https://m.media-amazon.com/images/M/MV5BZjVkOGM1ZTctZGZmOC00MTM0LWFjYjctNjg2MTg1YTM4N2VlXkEyXkFqcGc@._V1_.jpg", "The Matrix" },
                    { "https://indigomusic.com/wp-content/uploads/2024/01/untitled-design-51-min-2-1024x576.png", " David Fincher", "Cop Drama, Hard-boiled Detective, Legal Drama, Police Procedural, Psychological Thriller, Serial Killer, Crime, Drama, Mystery, Thriller", 8.6m, 1995, 127, "https://m.media-amazon.com/images/M/MV5BY2IzNzMxZjctZjUxZi00YzAxLTk3ZjMtODFjODdhMDU5NDM1XkEyXkFqcGc@._V1_.jpg", "Se7en" }
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
