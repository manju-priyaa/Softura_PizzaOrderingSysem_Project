﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaOrderingSystem.Models;

namespace PizzaOrderingSystem.Migrations
{
    [DbContext(typeof(PizzaContext))]
    partial class PizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaOrderingSystem.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("crust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("custpizzaprice")
                        .HasColumnType("float");

                    b.Property<string>("pizzaname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("toppings")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("PizzaOrderingSystem.Models.Crusts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Crusts");

                    b.HasData(
                        new
                        {
                            id = 1,
                            name = "Flat Bread"
                        },
                        new
                        {
                            id = 2,
                            name = "Thin Crust"
                        },
                        new
                        {
                            id = 3,
                            name = "Double Dough"
                        },
                        new
                        {
                            id = 4,
                            name = "Stuffed Crust"
                        },
                        new
                        {
                            id = 5,
                            name = "Vegan Friendly"
                        },
                        new
                        {
                            id = 6,
                            name = "Pizza Bagels"
                        },
                        new
                        {
                            id = 7,
                            name = "Silican Style"
                        },
                        new
                        {
                            id = 8,
                            name = "Chicago Deep Dish"
                        },
                        new
                        {
                            id = 9,
                            name = "NY Style Pizza"
                        },
                        new
                        {
                            id = 10,
                            name = "Neapolitan Pizza"
                        });
                });

            modelBuilder.Entity("PizzaOrderingSystem.Models.CustPizza", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<string>("crust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("perPizzaAmount")
                        .HasColumnType("float");

                    b.Property<int>("pizzaId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("toppings")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CustPizzas");
                });

            modelBuilder.Entity("PizzaOrderingSystem.Models.Orders", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<string>("customerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaOrderingSystem.Models.Pizza", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isVeg")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            id = 1,
                            amount = 499.99000000000001,
                            description = "Speacially made with Paneer and then grilled to make extra tasty!!!",
                            isVeg = true,
                            name = "Paneer Grilled Pizza"
                        },
                        new
                        {
                            id = 2,
                            amount = 599.99000000000001,
                            description = "Speacially made with Mushroom  to make extra tasty!!!",
                            isVeg = true,
                            name = "Mushroom Tandoori Pizza"
                        },
                        new
                        {
                            id = 3,
                            amount = 799.99000000000001,
                            description = "Speacially made with Chicken and then grilled to make extra tasty!!!",
                            isVeg = false,
                            name = "Chicken Grilled Pizza"
                        },
                        new
                        {
                            id = 4,
                            amount = 699.99000000000001,
                            description = "Speacially made with Bacon Sausage and then grilled to make extra tasty!!!",
                            isVeg = false,
                            name = "Bacon Grilled Pizza"
                        },
                        new
                        {
                            id = 5,
                            amount = 499.99000000000001,
                            description = "Speacially made with BabyCorn and then grilled to make extra tasty!!!",
                            isVeg = true,
                            name = "Baby Corn Grilled"
                        },
                        new
                        {
                            id = 6,
                            amount = 599.99000000000001,
                            description = "Speacially made with pepper Chicken and onions  to make extra tasty!!!",
                            isVeg = false,
                            name = "Pepper Barbecure & Onion"
                        },
                        new
                        {
                            id = 7,
                            amount = 799.99000000000001,
                            description = "Speacially made with Meal Makers to make extra tasty!!!",
                            isVeg = true,
                            name = "Soya Golden Light"
                        },
                        new
                        {
                            id = 8,
                            amount = 899.99000000000001,
                            description = "Speacially made with Barbeque Chicken and golden corn to make extra tasty!!!",
                            isVeg = false,
                            name = "Chicken Golden Light"
                        });
                });

            modelBuilder.Entity("PizzaOrderingSystem.Models.Toppings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            id = 1,
                            amount = 30.0,
                            name = "Pepperoni(+30 Rs)"
                        },
                        new
                        {
                            id = 2,
                            amount = 40.0,
                            name = "Mushroom(+40 Rs)"
                        },
                        new
                        {
                            id = 3,
                            amount = 50.0,
                            name = "Onions(+50 Rs)"
                        },
                        new
                        {
                            id = 4,
                            amount = 70.0,
                            name = "Bacon(+70 Rs)"
                        },
                        new
                        {
                            id = 5,
                            amount = 80.0,
                            name = "Extra Cheese(+80 Rs)"
                        },
                        new
                        {
                            id = 6,
                            amount = 90.0,
                            name = "Black Olives(+90 Rs)"
                        },
                        new
                        {
                            id = 7,
                            amount = 100.0,
                            name = "Green Peppers(+100 Rs)"
                        },
                        new
                        {
                            id = 8,
                            amount = 150.0,
                            name = "Sausage(+150 Rs)"
                        },
                        new
                        {
                            id = 9,
                            amount = 80.0,
                            name = "Spinach(+80 Rs)"
                        },
                        new
                        {
                            id = 10,
                            amount = 90.0,
                            name = "Pineapple(+90 Rs)"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
