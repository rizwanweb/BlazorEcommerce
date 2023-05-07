using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<ProductVariant> ProductVariants { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ProductVariant>().HasKey(x => new { x.ProductId, x.ProductTypeId});

			modelBuilder.Entity<ProductType>().HasData(
				new ProductType { Id = 1, Name = "Default"},
				new ProductType { Id = 2, Name = "Paperback" },
				new ProductType { Id = 3, Name = "E-Book" },
				new ProductType { Id = 4, Name = "Audiobook" },
				new ProductType { Id = 5, Name = "Stream" },
				new ProductType { Id = 6, Name = "Blu-Ray" },
				new ProductType { Id = 7, Name = "VHS" },
				new ProductType { Id = 8, Name = "PC" },
				new ProductType { Id = 9, Name = "PlayStation" },
				new ProductType { Id = 10, Name = "XBox" }
				);
			modelBuilder.Entity<ProductVariant>().HasData(
				new ProductVariant
				{
					ProductId = 1,
					ProductTypeId = 2,
					Price = 9.99m,
					OriginalPrice = 19.99m
				},
				new ProductVariant
				{
					ProductId = 1,
					ProductTypeId = 3,
					Price = 7.99m
				},
				new ProductVariant
				{
					ProductId = 1,
					ProductTypeId = 4,
					Price = 19.99m,
					OriginalPrice = 29.99m
				},
				new ProductVariant
				{
					ProductId = 2,
					ProductTypeId = 2,
					Price = 7.99m,
					OriginalPrice = 14.99m
				},
				new ProductVariant
				{
					ProductId = 3,
					ProductTypeId = 2,
					Price = 6.99m
				},
				new ProductVariant
				{
					ProductId = 4,
					ProductTypeId = 5,
					Price = 3.99m
				},
				new ProductVariant
				{
					ProductId = 4,
					ProductTypeId = 6,
					Price = 9.99m
				},
				new ProductVariant
				{
					ProductId = 4,
					ProductTypeId = 7,
					Price = 19.99m
				},
				new ProductVariant
				{
					ProductId = 5,
					ProductTypeId = 5,
					Price = 3.99m,
				},
				new ProductVariant
				{
					ProductId = 6,
					ProductTypeId = 5,
					Price = 2.99m
				},
				new ProductVariant
				{
					ProductId = 7,
					ProductTypeId = 8,
					Price = 19.99m,
					OriginalPrice = 29.99m
				},
				new ProductVariant
				{
					ProductId = 7,
					ProductTypeId = 9,
					Price = 69.99m
				},
				new ProductVariant
				{
					ProductId = 7,
					ProductTypeId = 10,
					Price = 49.99m,
					OriginalPrice = 59.99m
				}
			);

			modelBuilder.Entity<Category>().HasData(

				new Category
				{
					Id = 1,
					Name = "Books",
					Url = "books"
				},
				new Category
				{
					Id = 2,
					Name = "Movies",
					Url = "movies"
				},
				new Category
				{
					Id = 3,
					Name = "Video Games",
					Url = "video-games"
				}
				) ;

			modelBuilder.Entity<Product>().HasData(

				new Product
				{
					Id = 1,
					Title = "The Hitchhiker's Guide to the Galaxy From COntroller",
					Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
					
					CategoryId = 1
					
				},
				new Product
				{
					Id = 2,
					Title = "Ready Player One",
					Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
					
					CategoryId = 1
				},
				new Product
				{
					Id = 3,
					Title = "Nineteen Eighty-Four",
					Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the authoritarian state in the novel on Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
					
					CategoryId = 1
				},
				new Product
				{
					Id = 4,
					Title = "Silent Hill",
					Description = "Silent Hill[a] is a 1999 survival horror game developed by Team Silent and published by Konami. The first installment in the video game series Silent Hill, the game was released from February to July, originally for the PlayStation. Silent Hill uses a third-person view, with real-time rendering of 3D environments. To mitigate limitations of the console hardware, developers liberally used fog and darkness to muddle the graphics. Unlike earlier survival horror games that focused on protagonists with combat training, the player character of Silent Hill is an everyman",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/96/Silent_Hill_video_game_cover.png",
					CategoryId = 3
				},
				new Product
				{
					Id = 5,
					Title = "Zeus: Master of Olympus",
					Description = "Zeus: Master of Olympus is a single-player strategy game developed by Impressions Games and published by Sierra Studios.[2] It is considered to be an additional installment in the City Building series of games.[3] Like previous titles in the series, Zeus focuses on the building and development of a city in ancient times. The game features a number of changes from previous titles in the series, including being set in Ancient Greece as well as changes to certain gameplay mechanics; however, it is considered to be in most aspects very similar to its predecessor",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8e/Master_of_Olympus_-_Zeus_Coverart.png",
					
					CategoryId = 3
				},
				new Product
				{
					Id = 15,
					Title = "Thor",
					Description = "Thor is a 2011 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,[a] it is the fourth film in the Marvel Cinematic Universe (MCU). It was directed by Kenneth Branagh, written by the writing team of Ashley Edward Miller and Zack Stentz along with Don Payne, and stars Chris Hemsworth as the title character alongside Natalie Portman, Tom Hiddleston, Stellan Skarsgård, Kat Dennings, Clark Gregg, Colm Feore, Ray Stevenson, Idris Elba, Jaimie Alexander, Rene Russo, and Anthony Hopkins. After reigniting a dormant war, Thor is banished from Asgard to Earth, stripped of his powers and his hammer Mjölnir. As his brother Loki (Hiddleston) plots to take the Asgardian throne, Thor must prove himself worthy.",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/95/Thor_%28film%29_poster.jpg",
					
					CategoryId = 2
				},
				new Product
				{
					Id = 6,
					Title = "Lovelace",
					Description = "Lovelace is a 2013 American biographical drama film centered on porn actress Linda Lovelace, star of Deep Throat, a landmark 1972 film at the forefront of the Golden Age of Porn. Lovelace covers her life from age 21 to 32.",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0f/Lovelace_%282013%29.png",					
					CategoryId = 2
				},
				new Product
				{
					Id = 7,
					Title = "Empire Earth",
					Description = "Empire Earth is a real-time strategy video game developed by Stainless Steel Studios and released on November 13, 2001.[1] It is the first game in the Empire Earth series.",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/1f/Empire_Earth.jpg",
					CategoryId = 3
				}
			);
		}
    }
}
