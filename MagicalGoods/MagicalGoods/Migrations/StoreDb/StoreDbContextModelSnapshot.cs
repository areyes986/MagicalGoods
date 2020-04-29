﻿// <auto-generated />
using MagicalGoods.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MagicalGoods.Migrations.StoreDb
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MagicalGoods.Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("MagicalGoods.Models.CartProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("MagicalGoods.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "A feather taken from an empty hippogryff nest that belonged to a young hippogriff!",
                            Image = "https://pm1.narvii.com/6511/68a4998e3c775db2e30db7aca026aadf997d34ca_hq.jpg",
                            Name = "Baby Hippogriff Feather",
                            Price = 100.00m
                        },
                        new
                        {
                            ID = 2,
                            Description = "A 2018 Cumulo 1000 broomstick, top speed 27mph!",
                            Image = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/7/152/1000/1000/636284717908019789.jpeg",
                            Name = "Used Flying Broomstick",
                            Price = 1200.00m
                        },
                        new
                        {
                            ID = 3,
                            Description = "No, really, EVERY flavor!",
                            Image = "https://vignette.wikia.nocookie.net/harrypotter/images/6/60/Bertie_Botts_EFB.png/revision/latest?cb=20161128010133",
                            Name = "Every Flavor Jellybeans",
                            Price = 2.00m
                        },
                        new
                        {
                            ID = 4,
                            Description = "Chocolate Frog that really hops and has the card of a witch or wizard!",
                            Image = "https://images-na.ssl-images-amazon.com/images/I/91rOTxaOA3L._AC_SL1500_.jpg",
                            Name = "Chocolate Frog",
                            Price = 1.50m
                        },
                        new
                        {
                            ID = 5,
                            Description = "Touch it to any question, and it will write the answer!",
                            Image = "https://img1.wikia.nocookie.net/__cb20121112222214/harrypotter/images/d/d0/Quill-lrg.png",
                            Name = "Auto-answer Quill",
                            Price = 500.00m
                        },
                        new
                        {
                            ID = 6,
                            Description = "A bag with considerably more space inside than it appears at first glance. Holds up to 500lbs, but only ever weighs 15!",
                            Image = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/7/120/1000/1000/636284708068284913.jpeg",
                            Name = "Bag of Holding",
                            Price = 400.00m
                        },
                        new
                        {
                            ID = 7,
                            Description = "Just press a button, and this rod will fix itself in place. Defy gravity!",
                            Image = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/7/261/1000/1000/636284741670235041.jpeg",
                            Name = "Immovable Rod",
                            Price = 50.00m
                        },
                        new
                        {
                            ID = 8,
                            Description = "Magically transform into anyone with just a small piece of their hair!",
                            Image = "https://i.stack.imgur.com/LerE3.jpg",
                            Name = "Polyjuice Potion",
                            Price = 150.00m
                        },
                        new
                        {
                            ID = 9,
                            Description = "Put on these slippers, and walk on any surface!",
                            Image = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/7/402/1000/1000/636284767446806965.jpeg",
                            Name = "Slippers of Spider Climb",
                            Price = 250.00m
                        },
                        new
                        {
                            ID = 10,
                            Description = "A powerful wand with a core made from the feather of a pheonix",
                            Name = "Pheonix-core Wand",
                            Price = 1000.00m
                        });
                });

            modelBuilder.Entity("MagicalGoods.Models.CartProduct", b =>
                {
                    b.HasOne("MagicalGoods.Models.Cart", "Cart")
                        .WithMany("CartProducts")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagicalGoods.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
