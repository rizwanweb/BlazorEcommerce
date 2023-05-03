using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 3, "Silent Hill[a] is a 1999 survival horror game developed by Team Silent and published by Konami. The first installment in the video game series Silent Hill, the game was released from February to July, originally for the PlayStation. Silent Hill uses a third-person view, with real-time rendering of 3D environments. To mitigate limitations of the console hardware, developers liberally used fog and darkness to muddle the graphics. Unlike earlier survival horror games that focused on protagonists with combat training, the player character of Silent Hill is an everyman", "https://upload.wikimedia.org/wikipedia/en/9/96/Silent_Hill_video_game_cover.png", 25.0, "Silent Hill" },
                    { 5, 3, "Zeus: Master of Olympus is a single-player strategy game developed by Impressions Games and published by Sierra Studios.[2] It is considered to be an additional installment in the City Building series of games.[3] Like previous titles in the series, Zeus focuses on the building and development of a city in ancient times. The game features a number of changes from previous titles in the series, including being set in Ancient Greece as well as changes to certain gameplay mechanics; however, it is considered to be in most aspects very similar to its predecessor", "https://upload.wikimedia.org/wikipedia/en/8/8e/Master_of_Olympus_-_Zeus_Coverart.png", 35.0, "Zeus: Master of Olympus" },
                    { 6, 2, "Lovelace is a 2013 American biographical drama film centered on porn actress Linda Lovelace, star of Deep Throat, a landmark 1972 film at the forefront of the Golden Age of Porn. Lovelace covers her life from age 21 to 32.", "https://upload.wikimedia.org/wikipedia/en/0/0f/Lovelace_%282013%29.png", 89.0, "Lovelace" },
                    { 7, 3, "Empire Earth is a real-time strategy video game developed by Stainless Steel Studios and released on November 13, 2001.[1] It is the first game in the Empire Earth series.", "https://upload.wikimedia.org/wikipedia/en/1/1f/Empire_Earth.jpg", 14.0, "Empire Earth" },
                    { 15, 2, "Thor is a 2011 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,[a] it is the fourth film in the Marvel Cinematic Universe (MCU). It was directed by Kenneth Branagh, written by the writing team of Ashley Edward Miller and Zack Stentz along with Don Payne, and stars Chris Hemsworth as the title character alongside Natalie Portman, Tom Hiddleston, Stellan Skarsgård, Kat Dennings, Clark Gregg, Colm Feore, Ray Stevenson, Idris Elba, Jaimie Alexander, Rene Russo, and Anthony Hopkins. After reigniting a dormant war, Thor is banished from Asgard to Earth, stripped of his powers and his hammer Mjölnir. As his brother Loki (Hiddleston) plots to take the Asgardian throne, Thor must prove himself worthy.", "https://upload.wikimedia.org/wikipedia/en/9/95/Thor_%28film%29_poster.jpg", 58.0, "Thor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
