﻿// <auto-generated />
using System;
using Learn.Blazor.Net6.Pag.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Learn.Blazor.Net6.Pag.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230425084954_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Learn.Blazor.Net6.Pag.Models.Product.ProductDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("920b4e00-383c-4e6a-8071-5802f45b8208"),
                            Description = "The Great Gatsby is a 1925 novel written by American author F. Scott Fitzgerald that follows a cast of characters living in the fictional town of West Egg on prosperous Long Island in the summer of 1922.",
                            ImageUrl = "https://fastly.picsum.photos/id/765/200/300.jpg?hmac=yRNlm1EXdqLX1q3pNM20VW3eARvw3XIoph6gf4qydTk",
                            Price = 9.99m,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = new Guid("c4f27d3e-1913-4b44-b9c2-a200bae8e1bd"),
                            Description = "The Catcher in the Rye is a 1951 novel by J. D. Salinger. A controversial novel originally published for adults, it has since become popular with adolescent readers for its themes of teenage angst and alienation.",
                            ImageUrl = "https://fastly.picsum.photos/id/906/200/300.jpg?hmac=7sarKOMVDlgOBTc6eUDUf0M4S-M-4jF0X0uix_sMALU",
                            Price = 7.99m,
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            Id = new Guid("54ee66a7-78cb-430f-94a9-7fcb325df3ee"),
                            Description = "The Grapes of Wrath is an American realist novel written by John Steinbeck and published in 1939. The book won the National Book Award and Pulitzer Prize for Fiction, and it was cited prominently when Steinbeck was awarded the Nobel Prize in 1962.",
                            ImageUrl = "https://fastly.picsum.photos/id/688/200/300.jpg?hmac=6_iDeSdl4f6R2Lre1xFrJ9VaO8OQHMJD_PL5lEypBGI",
                            Price = 5.99m,
                            Title = "The Grapes of Wrath"
                        },
                        new
                        {
                            Id = new Guid("76125730-eefa-4086-882f-40b148c64496"),
                            Description = "The Lord of the Rings is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. The story began as a sequel to Tolkien's 1937 fantasy novel The Hobbit, but eventually developed into a much larger work.",
                            ImageUrl = "https://fastly.picsum.photos/id/448/200/300.jpg?hmac=9a1pqR60H2xWN80jPWfmdVkRII-wEQZceiSHpJSZnE4",
                            Price = 3.99m,
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = new Guid("5cff8fb2-28aa-4843-8bac-9e692fb4b771"),
                            Description = "The Adventures of Huckleberry Finn is a novel by Mark Twain, first published in the United Kingdom in December 1884 and in the United States in February 1885. Commonly named among the Great American Novels, the work is among the first in major American literature to be written throughout in vernacular English, characterized by local color regionalism.",
                            ImageUrl = "https://fastly.picsum.photos/id/602/200/300.jpg?hmac=TkzlF12MtJomcmqzsOc-CR43gSl3xnotDQRPBvM7Avw",
                            Price = 1.99m,
                            Title = "The Adventures of Huckleberry Finn"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}