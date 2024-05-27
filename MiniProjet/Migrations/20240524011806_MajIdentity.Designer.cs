﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniProjet.Models;

#nullable disable

namespace MiniProjet.Migrations
{
    [DbContext(typeof(ArticleContext))]
    [Migration("20240524011806_MajIdentity")]
    partial class MajIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiniProjet.Models.Article", b =>
                {
                    b.Property<int>("articleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("articleId"));

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Prix")
                        .HasColumnType("real");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("articleId");

                    b.HasIndex("CategorieId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("MiniProjet.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategorieId"));

                    b.Property<string>("Namecategorie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MiniProjet.Models.PanierArt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("PanierArts");
                });

            modelBuilder.Entity("MiniProjet.Models.Article", b =>
                {
                    b.HasOne("MiniProjet.Models.Categorie", "categorie")
                        .WithMany("articles")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorie");
                });

            modelBuilder.Entity("MiniProjet.Models.PanierArt", b =>
                {
                    b.HasOne("MiniProjet.Models.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("MiniProjet.Models.Categorie", b =>
                {
                    b.Navigation("articles");
                });
#pragma warning restore 612, 618
        }
    }
}
