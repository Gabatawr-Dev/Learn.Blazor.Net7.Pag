﻿using Learn.Blazor.Net7.Pag.Server.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Learn.Blazor.Net7.Pag.Server.Data.Contexts;

public partial class ApplicationDbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductEntity>().HasData(
            new ProductEntity
            {
                Id = new Guid("00000000-1000-0000-0000-000000000000"),
                Title = "The Great Gatsby",
                Description =
                    "The Great Gatsby is a 1925 novel written by American author F. Scott Fitzgerald that follows a cast of characters living in the fictional town of West Egg on prosperous Long Island in the summer of 1922.",
                ImageUrl =
                    "https://fastly.picsum.photos/id/765/200/300.jpg?hmac=yRNlm1EXdqLX1q3pNM20VW3eARvw3XIoph6gf4qydTk",
                Price = 9.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-2000-0000-0000-000000000000"),
                Title = "The Catcher in the Rye",
                Description =
                    "The Catcher in the Rye is a 1951 novel by J. D. Salinger. A controversial novel originally published for adults, it has since become popular with adolescent readers for its themes of teenage angst and alienation.",
                ImageUrl =
                    "https://fastly.picsum.photos/id/906/200/300.jpg?hmac=7sarKOMVDlgOBTc6eUDUf0M4S-M-4jF0X0uix_sMALU",
                Price = 8.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-3000-0000-0000-000000000000"),
                Title = "The Grapes of Wrath",
                Description =
                    "The Grapes of Wrath is an American realist novel written by John Steinbeck and published in 1939. The book won the National Book Award and Pulitzer Prize for Fiction, and it was cited prominently when Steinbeck was awarded the Nobel Prize in 1962.",
                ImageUrl =
                    "https://fastly.picsum.photos/id/688/200/300.jpg?hmac=6_iDeSdl4f6R2Lre1xFrJ9VaO8OQHMJD_PL5lEypBGI",
                Price = 7.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-4000-0000-0000-000000000000"),
                Title = "The Lord of the Rings",
                Description =
                    "The Lord of the Rings is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. The story began as a sequel to Tolkien's 1937 fantasy novel The Hobbit, but eventually developed into a much larger work.",
                ImageUrl =
                    "https://fastly.picsum.photos/id/448/200/300.jpg?hmac=9a1pqR60H2xWN80jPWfmdVkRII-wEQZceiSHpJSZnE4",
                Price = 6.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-5000-0000-0000-000000000000"),
                Title = "The Adventures of Huckleberry Finn",
                Description =
                    "The Adventures of Huckleberry Finn is a novel by Mark Twain, first published in the United Kingdom in December 1884 and in the United States in February 1885. Commonly named among the Great American Novels, the work is among the first in major American literature to be written throughout in vernacular English, characterized by local color regionalism.",
                ImageUrl =
                    "https://fastly.picsum.photos/id/602/200/300.jpg?hmac=TkzlF12MtJomcmqzsOc-CR43gSl3xnotDQRPBvM7Avw",
                Price = 5.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-6000-0000-0000-000000000000"),
                Title = "The Adventures of Tom Sawyer",
                Description =
                    "The Adventures of Tom Sawyer is a novel by Mark Twain, first published in the United Kingdom in December 1884 and in the United States in February 1885. Commonly named among the Great American Novels, the work is among the first in major American literature to be written throughout in vernacular English, characterized by local color regionalism.",
                ImageUrl =
                    "https://fastly.picsum.photos/id/555/200/300.jpg?hmac=HbW_j1WvVDr5eTwXP2bsohZEiyBe-G6fsPkgAxJe9ps",
                Price = 4.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-7000-0000-0000-000000000000"),
                Title = "The Adventures of Sherlock Holmes",
                Description =
                    "The Adventures of Sherlock Holmes is a collection of twelve stories by Arthur Conan Doyle, featuring his fictional detective Sherlock Holmes. It was first published on 14 October 1892; the individual stories had been serialised in The Strand Magazine between July 1891 and June 1892.",
                ImageUrl =
                    "https://fastly.picsum.photos/id/831/200/300.jpg?hmac=IC6dJVWWVnJ-extXtn0D9QDwKwbQ-tA_M6UD2T9zUbQ",
                Price = 3.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-8000-0000-0000-000000000000"),
                Title = "To Kill a Mockingbird",
                Description =
                    "A Pulitzer Prize-winning novel by Harper Lee set in the Deep South and deals with issues of racism and injustice.",
                ImageUrl = "https://fastly.picsum.photos/id/530/200/300.jpg?hmac=pl2pzOmYOiMa6E_Ddf_SFQVGjDvmZ1xgj-JznVHuUsg",
                Price = 12.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-9000-0000-0000-000000000000"),
                Title = "1984",
                Description =
                    "A dystopian novel by George Orwell that depicts a totalitarian society and explores themes of government surveillance, censorship, and propaganda.",
                ImageUrl = "https://fastly.picsum.photos/id/581/200/300.jpg?hmac=Xsg_aDXsNDPBGUvQPMKuMn2f4XS6zkrgh0vnl2lzljk",
                Price = 8.99m,
            }
            ,
            new ProductEntity
            {
                Id = new Guid("00000000-1000-1000-0000-000000000000"),
                Title = "Pride and Prejudice",
                Description =
                    "A classic novel by Jane Austen that explores themes of love, marriage, and societal expectations.",
                ImageUrl = "https://fastly.picsum.photos/id/381/200/300.jpg?hmac=DHcGsLBoQPJC-_rudxS4AdZuSE9UoOFP2U2v2veUAok",
                Price = 7.99m,
            },
            new ProductEntity
            {
                Id = new Guid("00000000-1000-2000-0000-000000000000"),
                Title = "One Hundred Years of Solitude",
                Description =
                    "A novel by Gabriel Garcia Marquez that tells the story of the Buendia family over seven generations and explores themes of love, magic, and the cyclical nature of time.",
                ImageUrl = "https://fastly.picsum.photos/id/374/200/300.jpg?hmac=O7_6jZztETgk8S2eFcdlCNlqe50qS5u-OW5hs-EoNMo",
                Price = 11.99m,
            }
        );
    }
}