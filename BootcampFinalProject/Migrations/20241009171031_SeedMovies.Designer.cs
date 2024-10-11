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
                            BannerUrl = "7e9d6875-fccd-454c-b462-bc22afb0bc10.jpg",
                            Director = "Francis Ford Coppola",
                            Genre = "Epic, Gangster, Drama, Crime, Tragedy",
                            Rating = 9.2m,
                            ReleaseYear = 1972,
                            RunningTimeInMin = 175,
                            ThumbnailUrl = "3b98ba65-fedc-4be6-9c65-99b98bf3f926.jpg",
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 4,
                            BannerUrl = "93c20918-51dc-4046-b12c-11c54808763c.jpg",
                            Director = "Frank Darabont",
                            Genre = "Epic, Period Drama, Prison Drama, Tragedy, Drama",
                            Rating = 9.3m,
                            ReleaseYear = 1994,
                            RunningTimeInMin = 142,
                            ThumbnailUrl = "5711c6f1-3f60-409d-b13a-8c0a3ad016d0.jpg",
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 5,
                            BannerUrl = "6b686f0c-7c9e-40c5-95b9-130f8a3bd6e2.jpg",
                            Director = "Francis Ford Coppola",
                            Genre = "Epic, Gangster, Drama, Crime, Tragedy",
                            Rating = 9.0m,
                            ReleaseYear = 1974,
                            RunningTimeInMin = 202,
                            ThumbnailUrl = "fc559522-8dd4-474f-9ea1-f98cae007cf4.jpg",
                            Title = "The Godfather Part II"
                        },
                        new
                        {
                            Id = 6,
                            BannerUrl = "220bbc2b-48ee-4765-9eb2-f13e3ff4b2ff.jpg",
                            Director = "Christopher Nolan",
                            Genre = "Action Epic, Adventure Epic, Psychological Thriller, Sci-Fi Epic, Action, Adventure, Sci-Fi, Thriller",
                            Rating = 8.8m,
                            ReleaseYear = 2010,
                            RunningTimeInMin = 148,
                            ThumbnailUrl = "956e35b2-e684-4095-a437-2c22b7c7f4e7.jpg",
                            Title = "Inception"
                        },
                        new
                        {
                            Id = 7,
                            BannerUrl = "a744ef00-2db0-43ad-b83b-1587d48d348d.jpg",
                            Director = "David Fincher",
                            Genre = "Psychological Drama, Workplace Drama, Drama",
                            Rating = 8.8m,
                            ReleaseYear = 1999,
                            RunningTimeInMin = 139,
                            ThumbnailUrl = "1109391a-e96e-40ac-8932-8d0283f056f5.jpg",
                            Title = "Fight Club"
                        },
                        new
                        {
                            Id = 8,
                            BannerUrl = "987a3215-cdd2-4193-becb-a084b7863bd9.jpg",
                            Director = "Christopher Nolan",
                            Genre = "Action Epic, Epic, Superhero, Action, Crime, Drama, Thriller",
                            Rating = 9.0m,
                            ReleaseYear = 2008,
                            RunningTimeInMin = 152,
                            ThumbnailUrl = "7fb187ae-bb68-4f47-9a8d-b815119db2d4.jpg",
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = 9,
                            BannerUrl = "163c5647-3eeb-44dc-80e6-04418bfc13a0.jpg",
                            Director = "Sidney Lumet",
                            Genre = "Legal Drama, Psychological Drama, Crime, Drama",
                            Rating = 9.0m,
                            ReleaseYear = 1957,
                            RunningTimeInMin = 96,
                            ThumbnailUrl = "00c3bf93-5856-4696-95b2-0c14687b8923.jpg",
                            Title = "12 Angry Men"
                        },
                        new
                        {
                            Id = 10,
                            BannerUrl = "21ba7840-7b0a-4c16-b4eb-f77c24131518.jpg",
                            Director = "Peter Jackson",
                            Genre = "Adventure Epic, Fantasy Epic, Quest, Sword & Sorcery, Action, Adventure, Drama, Fantasy",
                            Rating = 8.9m,
                            ReleaseYear = 2001,
                            RunningTimeInMin = 178,
                            ThumbnailUrl = "7cb3bcdc-79eb-42d4-ac1c-3233c23ff18f.jpg",
                            Title = "The Lord of the Rings: The Fellowship of the Ring"
                        },
                        new
                        {
                            Id = 11,
                            BannerUrl = "878a437a-ce65-4033-97fd-a7c57800b4bf.jpg",
                            Director = " Lana Wachowski & Lilly Wachowski",
                            Genre = "Action Epic, Artificial Intelligence, Cyberpunk, Dystopian Sci-Fi, Gun Fu, Martial Arts, Sci-Fi Epic, Action, Sci-Fi",
                            Rating = 8.7m,
                            ReleaseYear = 1999,
                            RunningTimeInMin = 136,
                            ThumbnailUrl = "85170eab-36c5-45d5-b393-f924f75ff904.jpg",
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 12,
                            BannerUrl = "07944830-465d-4eb7-86ae-ac97dbb0fcc8.jpg",
                            Director = " David Fincher",
                            Genre = "Cop Drama, Hard-boiled Detective, Legal Drama, Police Procedural, Psychological Thriller, Serial Killer, Crime, Drama, Mystery, Thriller",
                            Rating = 8.6m,
                            ReleaseYear = 1995,
                            RunningTimeInMin = 127,
                            ThumbnailUrl = "c895e1fe-0bb4-4888-9f91-6a0fdae6dd55.jpg",
                            Title = "Se7en"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
