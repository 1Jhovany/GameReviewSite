﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using album_collection;

namespace album_collection.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20211118170203_readdedImageUrls2")]
    partial class readdedImageUrls2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("artistId")
                        .HasColumnType("int");

                    b.Property<string>("recordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("artistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "/images/prince.webp",
                            Title = "Paisley Park",
                            artistId = 1,
                            recordLabel = "Atlantic Records"
                        },
                        new
                        {
                            Id = 2,
                            Image = "/images/acdc.jpeg",
                            Title = "Highway to Hell",
                            artistId = 2,
                            recordLabel = "Atlantic Records"
                        },
                        new
                        {
                            Id = 3,
                            Image = "/images.kevingates.jpeg",
                            Title = "Isaiah",
                            artistId = 3,
                            recordLabel = "Atlantic Records"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Hometown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 50,
                            Hometown = "Akron",
                            Name = "Prince",
                            imageUrl = "",
                            recordLabel = "Atlantic Records"
                        },
                        new
                        {
                            Id = 2,
                            Age = 50,
                            Hometown = "Akron",
                            Name = "AC/DC",
                            imageUrl = "",
                            recordLabel = "Atlantic Records"
                        },
                        new
                        {
                            Id = 3,
                            Age = 50,
                            Hometown = "Akron",
                            Name = "Kevin Gates",
                            imageUrl = "",
                            recordLabel = "Atlantic Records"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Content = "Nunc aliquet bibendum enim facilisis. Tellus orci ac auctor augue mauris augue neque. Massa ultricies mi quis hendrerit do",
                            Name = "Joe Blow"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 2,
                            Content = "Nunc aliquet bibendum enim facilisis. Tellus orci ac auctor augue mauris augue neque. Massa ultricies mi quis hendrerit do",
                            Name = "Seymour Butts"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 3,
                            Content = "Nunc aliquet bibendum enim facilisis. Tellus orci ac auctor augue mauris augue neque. Massa ultricies mi quis hendrerit do",
                            Name = "Joseph Maninng"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("albumId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("albumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Paisley Park",
                            albumId = 1
                        },
                        new
                        {
                            Id = 2,
                            Title = "Highway to Hell",
                            albumId = 2
                        },
                        new
                        {
                            Id = 3,
                            Title = "Time for That",
                            albumId = 3
                        });
                });

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.HasOne("album_collection.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("artistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("album_collection.Models.Review", b =>
                {
                    b.HasOne("album_collection.Models.Album", "Album")
                        .WithMany("reviews")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("album_collection.Models.Song", b =>
                {
                    b.HasOne("album_collection.Models.Album", "Album")
                        .WithMany("songs")
                        .HasForeignKey("albumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.Navigation("reviews");

                    b.Navigation("songs");
                });

            modelBuilder.Entity("album_collection.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
