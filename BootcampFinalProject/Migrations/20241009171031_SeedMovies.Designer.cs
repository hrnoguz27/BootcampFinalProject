﻿// <auto-generated />
using BootcampFinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BootcampFinalProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241009171031_SeedMovies")]
    partial class SeedMovies
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("BootcampFinalProject.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BannerUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RunningTimeInMin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            BannerUrl = "https://w0.peakpx.com/wallpaper/557/513/HD-wallpaper-the-godfather-marlon-brando-vito-corleone.jpg",
                            Director = "Francis Ford Coppola",
                            Genre = "Epic, Gangster, Drama, Crime, Tragedy",
                            Rating = 9.2m,
                            ReleaseYear = 1972,
                            RunningTimeInMin = 175,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BYTJkNGQyZDgtZDQ0NC00MDM0LWEzZWQtYzUzZDEwMDljZWNjXkEyXkFqcGc@._V1_.jpg",
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 4,
                            BannerUrl = "https://c4.wallpaperflare.com/wallpaper/834/280/850/movies-the-shawshank-redemption-wallpaper-preview.jpg",
                            Director = "Frank Darabont",
                            Genre = "Epic, Period Drama, Prison Drama, Tragedy, Drama",
                            Rating = 9.3m,
                            ReleaseYear = 1994,
                            RunningTimeInMin = 142,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BMDAyY2FhYjctNDc5OS00MDNlLThiMGUtY2UxYWVkNGY2ZjljXkEyXkFqcGc@._V1_.jpg",
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 5,
                            BannerUrl = "https://images3.alphacoders.com/131/1315823.jpg",
                            Director = "Francis Ford Coppola",
                            Genre = "Epic, Gangster, Drama, Crime, Tragedy",
                            Rating = 9.0m,
                            ReleaseYear = 1974,
                            RunningTimeInMin = 202,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BNzc1OWY5MjktZDllMi00ZDEzLWEwMGItYjk1YmRhYjBjNTVlXkEyXkFqcGc@._V1_.jpg",
                            Title = "The Godfather Part II"
                        },
                        new
                        {
                            Id = 6,
                            BannerUrl = "https://wallpapercave.com/wp/Q48fR1x.jpg",
                            Director = "Christopher Nolan",
                            Genre = "Action Epic, Adventure Epic, Psychological Thriller, Sci-Fi Epic, Action, Adventure, Sci-Fi, Thriller",
                            Rating = 8.8m,
                            ReleaseYear = 2010,
                            RunningTimeInMin = 148,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                            Title = "Inception"
                        },
                        new
                        {
                            Id = 7,
                            BannerUrl = "https://lumiere-a.akamaihd.net/v1/images/fightclub_mainmenu_ka_3840x2160_98330c30.jpeg",
                            Director = "David Fincher",
                            Genre = "Psychological Drama, Workplace Drama, Drama",
                            Rating = 8.8m,
                            ReleaseYear = 1999,
                            RunningTimeInMin = 139,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_.jpg",
                            Title = "Fight Club"
                        },
                        new
                        {
                            Id = 8,
                            BannerUrl = "https://theconsultingdetectivesblog.com/wp-content/uploads/2014/06/the-dark-knight-original.jpg",
                            Director = "Christopher Nolan",
                            Genre = "Action Epic, Epic, Superhero, Action, Crime, Drama, Thriller",
                            Rating = 9.0m,
                            ReleaseYear = 2008,
                            RunningTimeInMin = 152,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BMTIzMDc4MzA2Ml5BMl5BanBnXkFtZTcwODU0MzA3MQ@@._V1_.jpg",
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = 9,
                            BannerUrl = "https://s1.dmcdn.net/v/VPo1g1bLR9X3RfLPs/x1080",
                            Director = "Sidney Lumet",
                            Genre = "Legal Drama, Psychological Drama, Crime, Drama",
                            Rating = 9.0m,
                            ReleaseYear = 1957,
                            RunningTimeInMin = 96,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BYjE4NzdmOTYtYjc5Yi00YzBiLWEzNDEtNTgxZGQ2MWVkN2NiXkEyXkFqcGc@._V1_.jpg",
                            Title = "12 Angry Men"
                        },
                        new
                        {
                            Id = 10,
                            BannerUrl = "https://m.media-amazon.com/images/S/pv-target-images/2f0e365f033851be687ca2179166fb614c2e2175d4a812b671abb533650b8639.jpg",
                            Director = "Peter Jackson",
                            Genre = "Adventure Epic, Fantasy Epic, Quest, Sword & Sorcery, Action, Adventure, Drama, Fantasy",
                            Rating = 8.9m,
                            ReleaseYear = 2001,
                            RunningTimeInMin = 178,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BZjRlZGYwYjUtYWQwNi00N2JjLTk2NmUtODBkODJkNjNjZTYyXkEyXkFqcGc@._V1_.jpg",
                            Title = "The Lord of the Rings: The Fellowship of the Ring"
                        },
                        new
                        {
                            Id = 11,
                            BannerUrl = "https://static1.colliderimages.com/wordpress/wp-content/uploads/2024/02/the-matrix-code-keanu-reeves.jpg",
                            Director = " Lana Wachowski & Lilly Wachowski",
                            Genre = "Action Epic, Artificial Intelligence, Cyberpunk, Dystopian Sci-Fi, Gun Fu, Martial Arts, Sci-Fi Epic, Action, Sci-Fi",
                            Rating = 8.7m,
                            ReleaseYear = 1999,
                            RunningTimeInMin = 136,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BZjVkOGM1ZTctZGZmOC00MTM0LWFjYjctNjg2MTg1YTM4N2VlXkEyXkFqcGc@._V1_.jpg",
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 12,
                            BannerUrl = "https://indigomusic.com/wp-content/uploads/2024/01/untitled-design-51-min-2-1024x576.png",
                            Director = " David Fincher",
                            Genre = "Cop Drama, Hard-boiled Detective, Legal Drama, Police Procedural, Psychological Thriller, Serial Killer, Crime, Drama, Mystery, Thriller",
                            Rating = 8.6m,
                            ReleaseYear = 1995,
                            RunningTimeInMin = 127,
                            ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BY2IzNzMxZjctZjUxZi00YzAxLTk3ZjMtODFjODdhMDU5NDM1XkEyXkFqcGc@._V1_.jpg",
                            Title = "Se7en"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
