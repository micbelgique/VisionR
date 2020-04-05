﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisionR.Model;

namespace VisionR.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191030123820_thirdMigration")]
    partial class thirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VisionR.Model.Adult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AdultScore")
                        .HasColumnType("float");

                    b.Property<bool>("IsAdultContent")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRacyContent")
                        .HasColumnType("bit");

                    b.Property<double>("RacyScore")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Adult");
                });

            modelBuilder.Entity("VisionR.Model.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Confidence")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RectangleId")
                        .HasColumnType("int");

                    b.Property<int?>("VisionResultId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RectangleId");

                    b.HasIndex("VisionResultId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("VisionR.Model.Caption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Confidence")
                        .HasColumnType("float");

                    b.Property<int?>("DescriptionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.ToTable("Caption");
                });

            modelBuilder.Entity("VisionR.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<int?>("VisionResultId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisionResultId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("VisionR.Model.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccentColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DominantColorBackground")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DominantColorForeground")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBwImg")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("VisionR.Model.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("VisionR.Model.Face", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("FaceRectangleId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VisionResultId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FaceRectangleId");

                    b.HasIndex("VisionResultId");

                    b.ToTable("Face");
                });

            modelBuilder.Entity("VisionR.Model.FaceRectangle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("Left")
                        .HasColumnType("float");

                    b.Property<double>("Top")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("FaceRectangle");
                });

            modelBuilder.Entity("VisionR.Model.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VisionResultId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisionResultId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("VisionR.Model.ImageType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClipArtType")
                        .HasColumnType("int");

                    b.Property<int>("LineDrawingType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ImageType");
                });

            modelBuilder.Entity("VisionR.Model.Metadata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Metadata");
                });

            modelBuilder.Entity("VisionR.Model.Rectangle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("H")
                        .HasColumnType("int");

                    b.Property<int>("W")
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rectangle");
                });

            modelBuilder.Entity("VisionR.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Confidence")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VisionResultId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisionResultId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("VisionR.Model.Thing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Confidence")
                        .HasColumnType("float");

                    b.Property<string>("Object")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RectangleId")
                        .HasColumnType("int");

                    b.Property<int?>("VisionResultId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RectangleId");

                    b.HasIndex("VisionResultId");

                    b.ToTable("Thing");
                });

            modelBuilder.Entity("VisionR.Model.VisionResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdultId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("DescriptionId")
                        .HasColumnType("int");

                    b.Property<int?>("ImageTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("MetadataId")
                        .HasColumnType("int");

                    b.Property<string>("RequestId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdultId");

                    b.HasIndex("ColorId");

                    b.HasIndex("DescriptionId");

                    b.HasIndex("ImageTypeId");

                    b.HasIndex("MetadataId");

                    b.ToTable("VisionResult");
                });

            modelBuilder.Entity("VisionR.Model.Brand", b =>
                {
                    b.HasOne("VisionR.Model.Rectangle", "Rectangle")
                        .WithMany()
                        .HasForeignKey("RectangleId");

                    b.HasOne("VisionR.Model.VisionResult", null)
                        .WithMany("Brands")
                        .HasForeignKey("VisionResultId");
                });

            modelBuilder.Entity("VisionR.Model.Caption", b =>
                {
                    b.HasOne("VisionR.Model.Description", null)
                        .WithMany("Captions")
                        .HasForeignKey("DescriptionId");
                });

            modelBuilder.Entity("VisionR.Model.Category", b =>
                {
                    b.HasOne("VisionR.Model.VisionResult", null)
                        .WithMany("Categories")
                        .HasForeignKey("VisionResultId");
                });

            modelBuilder.Entity("VisionR.Model.Face", b =>
                {
                    b.HasOne("VisionR.Model.FaceRectangle", "FaceRectangle")
                        .WithMany()
                        .HasForeignKey("FaceRectangleId");

                    b.HasOne("VisionR.Model.VisionResult", null)
                        .WithMany("Faces")
                        .HasForeignKey("VisionResultId");
                });

            modelBuilder.Entity("VisionR.Model.Image", b =>
                {
                    b.HasOne("VisionR.Model.VisionResult", "VisionResult")
                        .WithMany()
                        .HasForeignKey("VisionResultId");
                });

            modelBuilder.Entity("VisionR.Model.Tag", b =>
                {
                    b.HasOne("VisionR.Model.VisionResult", null)
                        .WithMany("Tags")
                        .HasForeignKey("VisionResultId");
                });

            modelBuilder.Entity("VisionR.Model.Thing", b =>
                {
                    b.HasOne("VisionR.Model.Rectangle", "Rectangle")
                        .WithMany()
                        .HasForeignKey("RectangleId");

                    b.HasOne("VisionR.Model.VisionResult", null)
                        .WithMany("Objects")
                        .HasForeignKey("VisionResultId");
                });

            modelBuilder.Entity("VisionR.Model.VisionResult", b =>
                {
                    b.HasOne("VisionR.Model.Adult", "Adult")
                        .WithMany()
                        .HasForeignKey("AdultId");

                    b.HasOne("VisionR.Model.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("VisionR.Model.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId");

                    b.HasOne("VisionR.Model.ImageType", "ImageType")
                        .WithMany()
                        .HasForeignKey("ImageTypeId");

                    b.HasOne("VisionR.Model.Metadata", "Metadata")
                        .WithMany()
                        .HasForeignKey("MetadataId");
                });
#pragma warning restore 612, 618
        }
    }
}