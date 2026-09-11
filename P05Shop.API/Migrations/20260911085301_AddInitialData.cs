using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "8", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 585.877247451282m, new DateTime(2026, 8, 15, 6, 7, 3, 148, DateTimeKind.Local).AddTicks(7563), "Fantastic Fresh Gloves" },
                    { 2, "8", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 529.589840147919m, new DateTime(2026, 6, 15, 2, 17, 48, 657, DateTimeKind.Local).AddTicks(9454), "Ergonomic Wooden Cheese" },
                    { 3, "0", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 439.181953936434m, new DateTime(2025, 10, 22, 16, 57, 39, 68, DateTimeKind.Local).AddTicks(3733), "Intelligent Plastic Chicken" },
                    { 4, "8", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 476.239197481535m, new DateTime(2026, 6, 17, 17, 0, 42, 908, DateTimeKind.Local).AddTicks(4315), "Gorgeous Soft Pants" },
                    { 5, "1", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 647.728195340712m, new DateTime(2025, 12, 21, 8, 22, 14, 15, DateTimeKind.Local).AddTicks(415), "Fantastic Granite Ball" },
                    { 6, "7", "The Football Is Good For Training And Recreational Purposes", 477.091525651557m, new DateTime(2025, 9, 17, 15, 28, 51, 440, DateTimeKind.Local).AddTicks(908), "Unbranded Steel Car" },
                    { 7, "4", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 615.480758703072m, new DateTime(2026, 3, 28, 23, 58, 40, 337, DateTimeKind.Local).AddTicks(6053), "Generic Steel Pants" },
                    { 8, "6", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 28.6544425253079m, new DateTime(2026, 2, 5, 7, 42, 56, 4, DateTimeKind.Local).AddTicks(6410), "Intelligent Fresh Salad" },
                    { 9, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 349.030380745898m, new DateTime(2026, 1, 30, 19, 22, 24, 786, DateTimeKind.Local).AddTicks(1612), "Fantastic Wooden Table" },
                    { 10, "7", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 848.389565332043m, new DateTime(2026, 3, 31, 1, 26, 52, 218, DateTimeKind.Local).AddTicks(8520), "Ergonomic Metal Bike" },
                    { 11, "5", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 986.58874038448m, new DateTime(2026, 4, 22, 3, 16, 44, 981, DateTimeKind.Local).AddTicks(7766), "Small Plastic Shirt" },
                    { 12, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 366.218003555302m, new DateTime(2026, 9, 2, 0, 19, 1, 828, DateTimeKind.Local).AddTicks(3523), "Incredible Steel Chicken" },
                    { 13, "0", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 424.228819234403m, new DateTime(2025, 11, 24, 4, 42, 48, 955, DateTimeKind.Local).AddTicks(9184), "Intelligent Soft Car" },
                    { 14, "4", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 570.416535940681m, new DateTime(2026, 6, 30, 15, 37, 1, 47, DateTimeKind.Local).AddTicks(7672), "Handmade Wooden Tuna" },
                    { 15, "0", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 387.912313662894m, new DateTime(2026, 6, 27, 13, 25, 38, 405, DateTimeKind.Local).AddTicks(1929), "Incredible Granite Chair" },
                    { 16, "2", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 960.830080752648m, new DateTime(2025, 10, 24, 11, 20, 11, 500, DateTimeKind.Local).AddTicks(174), "Fantastic Steel Pants" },
                    { 17, "3", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 824.229407654716m, new DateTime(2026, 3, 17, 10, 30, 5, 151, DateTimeKind.Local).AddTicks(978), "Licensed Fresh Soap" },
                    { 18, "7", "The Football Is Good For Training And Recreational Purposes", 212.783163749978m, new DateTime(2026, 3, 14, 3, 14, 57, 263, DateTimeKind.Local).AddTicks(7772), "Refined Steel Soap" },
                    { 19, "4", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 749.219822308617m, new DateTime(2025, 10, 17, 5, 9, 40, 13, DateTimeKind.Local).AddTicks(586), "Generic Soft Keyboard" },
                    { 20, "7", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 653.205129991847m, new DateTime(2026, 8, 21, 17, 27, 51, 549, DateTimeKind.Local).AddTicks(1103), "Gorgeous Concrete Tuna" },
                    { 21, "7", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 421.230083562075m, new DateTime(2025, 9, 23, 19, 16, 47, 888, DateTimeKind.Local).AddTicks(2003), "Incredible Concrete Shoes" },
                    { 22, "2", "The Football Is Good For Training And Recreational Purposes", 136.821059656246m, new DateTime(2026, 2, 24, 18, 59, 38, 837, DateTimeKind.Local).AddTicks(1412), "Refined Rubber Pants" },
                    { 23, "2", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 957.658069013459m, new DateTime(2026, 9, 5, 6, 57, 25, 644, DateTimeKind.Local).AddTicks(6510), "Practical Plastic Hat" },
                    { 24, "1", "The Football Is Good For Training And Recreational Purposes", 142.272277362771m, new DateTime(2026, 7, 26, 3, 57, 43, 459, DateTimeKind.Local).AddTicks(65), "Handmade Soft Pizza" },
                    { 25, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 23.9252489027219m, new DateTime(2026, 5, 16, 18, 0, 0, 165, DateTimeKind.Local).AddTicks(8944), "Practical Wooden Shoes" },
                    { 26, "0", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 191.487272297259m, new DateTime(2025, 11, 24, 19, 37, 14, 355, DateTimeKind.Local).AddTicks(7854), "Handcrafted Fresh Fish" },
                    { 27, "1", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 561.967948376186m, new DateTime(2026, 6, 7, 16, 9, 45, 757, DateTimeKind.Local).AddTicks(453), "Awesome Steel Computer" },
                    { 28, "2", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3.5221822948764m, new DateTime(2025, 9, 29, 22, 19, 35, 420, DateTimeKind.Local).AddTicks(9341), "Fantastic Concrete Fish" },
                    { 29, "9", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 904.469962442513m, new DateTime(2025, 9, 15, 10, 1, 1, 251, DateTimeKind.Local).AddTicks(238), "Gorgeous Soft Cheese" },
                    { 30, "1", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 746.896074790459m, new DateTime(2025, 12, 13, 12, 29, 37, 660, DateTimeKind.Local).AddTicks(6084), "Ergonomic Rubber Chair" },
                    { 31, "0", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 148.38073461474m, new DateTime(2026, 4, 12, 11, 30, 6, 276, DateTimeKind.Local).AddTicks(463), "Sleek Wooden Chicken" },
                    { 32, "9", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 417.814398632298m, new DateTime(2025, 12, 15, 10, 42, 15, 666, DateTimeKind.Local).AddTicks(8398), "Unbranded Cotton Hat" },
                    { 33, "6", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 852.765678265489m, new DateTime(2026, 5, 20, 7, 50, 12, 27, DateTimeKind.Local).AddTicks(7270), "Incredible Plastic Bacon" },
                    { 34, "5", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 804.236928754131m, new DateTime(2025, 11, 17, 8, 8, 28, 207, DateTimeKind.Local).AddTicks(7879), "Gorgeous Rubber Shirt" },
                    { 35, "4", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 26.2404758977892m, new DateTime(2025, 11, 9, 10, 57, 23, 767, DateTimeKind.Local).AddTicks(8314), "Generic Concrete Chicken" },
                    { 36, "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 725.144727047134m, new DateTime(2026, 1, 27, 8, 5, 54, 605, DateTimeKind.Local).AddTicks(8599), "Incredible Soft Chair" },
                    { 37, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 803.266455316109m, new DateTime(2026, 9, 9, 20, 9, 32, 23, DateTimeKind.Local).AddTicks(5884), "Generic Wooden Gloves" },
                    { 38, "1", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 62.5145756315974m, new DateTime(2025, 10, 27, 18, 12, 9, 384, DateTimeKind.Local).AddTicks(6259), "Licensed Frozen Bacon" },
                    { 39, "4", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 237.21610888616m, new DateTime(2025, 12, 3, 9, 17, 41, 336, DateTimeKind.Local).AddTicks(7108), "Awesome Steel Bike" },
                    { 40, "5", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 423.906217697498m, new DateTime(2025, 11, 25, 8, 31, 28, 904, DateTimeKind.Local).AddTicks(4004), "Licensed Cotton Chicken" },
                    { 41, "6", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 348.033573048671m, new DateTime(2026, 1, 12, 18, 59, 32, 481, DateTimeKind.Local).AddTicks(1180), "Licensed Soft Tuna" },
                    { 42, "8", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 923.708887695199m, new DateTime(2026, 4, 4, 17, 55, 38, 702, DateTimeKind.Local).AddTicks(7231), "Intelligent Steel Mouse" },
                    { 43, "0", "The Football Is Good For Training And Recreational Purposes", 399.114577426163m, new DateTime(2026, 5, 4, 7, 25, 42, 320, DateTimeKind.Local).AddTicks(9193), "Rustic Rubber Soap" },
                    { 44, "6", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 567.6642325342m, new DateTime(2025, 11, 23, 13, 39, 16, 81, DateTimeKind.Local).AddTicks(4466), "Generic Wooden Soap" },
                    { 45, "6", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 177.533260105892m, new DateTime(2025, 11, 22, 1, 22, 38, 291, DateTimeKind.Local).AddTicks(8751), "Small Metal Chair" },
                    { 46, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 811.113948725682m, new DateTime(2025, 12, 20, 5, 5, 12, 982, DateTimeKind.Local).AddTicks(355), "Licensed Steel Pizza" },
                    { 47, "2", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 695.593573097882m, new DateTime(2026, 2, 28, 6, 43, 45, 188, DateTimeKind.Local).AddTicks(1591), "Incredible Plastic Mouse" },
                    { 48, "6", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 647.554261952431m, new DateTime(2025, 10, 24, 0, 57, 5, 115, DateTimeKind.Local).AddTicks(593), "Unbranded Frozen Shirt" },
                    { 49, "5", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 434.967351342071m, new DateTime(2025, 10, 28, 8, 15, 31, 429, DateTimeKind.Local).AddTicks(7249), "Generic Cotton Gloves" },
                    { 50, "4", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 757.585922315058m, new DateTime(2026, 6, 7, 7, 12, 45, 323, DateTimeKind.Local).AddTicks(8660), "Incredible Rubber Sausages" },
                    { 51, "7", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 788.283209431583m, new DateTime(2026, 8, 10, 10, 24, 50, 438, DateTimeKind.Local).AddTicks(759), "Intelligent Concrete Chips" },
                    { 52, "5", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 450.797146271354m, new DateTime(2026, 6, 25, 23, 39, 30, 511, DateTimeKind.Local).AddTicks(8940), "Tasty Soft Pants" },
                    { 53, "9", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 470.599800235871m, new DateTime(2025, 9, 25, 8, 22, 28, 732, DateTimeKind.Local).AddTicks(5049), "Unbranded Granite Sausages" },
                    { 54, "7", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 434.606364188067m, new DateTime(2026, 5, 21, 19, 39, 23, 265, DateTimeKind.Local).AddTicks(9671), "Unbranded Frozen Shoes" },
                    { 55, "6", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 493.17411300129m, new DateTime(2026, 3, 12, 3, 8, 32, 524, DateTimeKind.Local).AddTicks(6404), "Rustic Steel Ball" },
                    { 56, "4", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 784.890900582024m, new DateTime(2026, 4, 19, 3, 46, 32, 562, DateTimeKind.Local).AddTicks(3316), "Handmade Soft Salad" },
                    { 57, "0", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 788.656938758985m, new DateTime(2025, 12, 28, 4, 33, 30, 928, DateTimeKind.Local).AddTicks(6259), "Handcrafted Plastic Car" },
                    { 58, "3", "The Football Is Good For Training And Recreational Purposes", 361.786875191511m, new DateTime(2026, 7, 8, 8, 36, 14, 731, DateTimeKind.Local).AddTicks(6048), "Fantastic Cotton Shoes" },
                    { 59, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 998.108976057781m, new DateTime(2026, 5, 5, 22, 41, 43, 447, DateTimeKind.Local).AddTicks(7495), "Practical Granite Car" },
                    { 60, "0", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 971.996800778898m, new DateTime(2026, 5, 24, 16, 50, 50, 661, DateTimeKind.Local).AddTicks(7971), "Unbranded Wooden Gloves" },
                    { 61, "0", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 903.091018867721m, new DateTime(2026, 6, 29, 19, 42, 18, 506, DateTimeKind.Local).AddTicks(1479), "Handcrafted Cotton Hat" },
                    { 62, "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 638.596461951545m, new DateTime(2026, 2, 24, 11, 15, 26, 793, DateTimeKind.Local).AddTicks(8071), "Refined Frozen Pizza" },
                    { 63, "7", "The Football Is Good For Training And Recreational Purposes", 757.721955285278m, new DateTime(2025, 9, 17, 11, 46, 31, 574, DateTimeKind.Local).AddTicks(2855), "Refined Concrete Towels" },
                    { 64, "0", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 743.693539240255m, new DateTime(2026, 1, 9, 9, 27, 34, 480, DateTimeKind.Local).AddTicks(7889), "Practical Frozen Bacon" },
                    { 65, "3", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 643.732897129251m, new DateTime(2025, 12, 23, 4, 40, 18, 325, DateTimeKind.Local).AddTicks(5955), "Generic Plastic Chair" },
                    { 66, "8", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 421.864970457677m, new DateTime(2026, 3, 23, 23, 49, 24, 524, DateTimeKind.Local).AddTicks(9921), "Handmade Steel Salad" },
                    { 67, "6", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 166.650159618654m, new DateTime(2025, 12, 29, 2, 22, 39, 794, DateTimeKind.Local).AddTicks(9826), "Tasty Wooden Ball" },
                    { 68, "2", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 922.382416791461m, new DateTime(2026, 3, 24, 18, 44, 53, 773, DateTimeKind.Local).AddTicks(4901), "Licensed Fresh Pizza" },
                    { 69, "5", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 809.553099705164m, new DateTime(2026, 3, 4, 11, 15, 40, 689, DateTimeKind.Local).AddTicks(9498), "Practical Rubber Shoes" },
                    { 70, "7", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 655.430085775643m, new DateTime(2026, 2, 5, 22, 50, 19, 656, DateTimeKind.Local).AddTicks(1805), "Generic Soft Fish" },
                    { 71, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 514.024618253123m, new DateTime(2026, 7, 20, 8, 27, 17, 299, DateTimeKind.Local).AddTicks(9411), "Intelligent Frozen Car" },
                    { 72, "0", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 962.847247140876m, new DateTime(2025, 11, 19, 3, 36, 44, 351, DateTimeKind.Local).AddTicks(834), "Handmade Steel Mouse" },
                    { 73, "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 342.365613256751m, new DateTime(2026, 1, 25, 12, 31, 41, 424, DateTimeKind.Local).AddTicks(4823), "Practical Granite Ball" },
                    { 74, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 634.955703747904m, new DateTime(2026, 9, 9, 9, 48, 10, 255, DateTimeKind.Local).AddTicks(2486), "Fantastic Concrete Towels" },
                    { 75, "9", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 248.995546445248m, new DateTime(2025, 12, 21, 19, 31, 9, 758, DateTimeKind.Local).AddTicks(9203), "Unbranded Soft Mouse" },
                    { 76, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 701.105381604333m, new DateTime(2026, 2, 1, 4, 19, 9, 612, DateTimeKind.Local).AddTicks(1719), "Gorgeous Rubber Tuna" },
                    { 77, "0", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 245.491691592844m, new DateTime(2026, 9, 2, 13, 52, 18, 488, DateTimeKind.Local).AddTicks(3891), "Practical Cotton Keyboard" },
                    { 78, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 478.180023406716m, new DateTime(2025, 11, 22, 21, 56, 40, 376, DateTimeKind.Local).AddTicks(3621), "Fantastic Frozen Salad" },
                    { 79, "2", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 730.923636926302m, new DateTime(2025, 12, 21, 19, 40, 26, 999, DateTimeKind.Local).AddTicks(5333), "Awesome Rubber Hat" },
                    { 80, "0", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 380.033881022611m, new DateTime(2026, 1, 7, 22, 36, 6, 575, DateTimeKind.Local).AddTicks(5066), "Handmade Plastic Cheese" },
                    { 81, "9", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 321.162595319637m, new DateTime(2026, 7, 25, 13, 39, 29, 676, DateTimeKind.Local).AddTicks(7886), "Sleek Frozen Table" },
                    { 82, "4", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 288.791837182265m, new DateTime(2025, 11, 16, 2, 37, 9, 243, DateTimeKind.Local).AddTicks(2444), "Small Cotton Chips" },
                    { 83, "0", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 664.62972283998m, new DateTime(2026, 9, 5, 17, 24, 38, 255, DateTimeKind.Local).AddTicks(3611), "Gorgeous Cotton Mouse" },
                    { 84, "3", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 852.271434428762m, new DateTime(2025, 10, 8, 18, 56, 11, 629, DateTimeKind.Local).AddTicks(6953), "Handcrafted Granite Mouse" },
                    { 85, "5", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 78.5820450538686m, new DateTime(2025, 11, 12, 20, 43, 48, 306, DateTimeKind.Local).AddTicks(8123), "Tasty Fresh Chair" },
                    { 86, "6", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 902.329506187853m, new DateTime(2025, 11, 13, 22, 0, 39, 340, DateTimeKind.Local).AddTicks(6699), "Generic Rubber Gloves" },
                    { 87, "5", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 467.696303133711m, new DateTime(2026, 6, 19, 19, 52, 56, 65, DateTimeKind.Local).AddTicks(7614), "Tasty Fresh Car" },
                    { 88, "8", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 621.782007443617m, new DateTime(2026, 6, 22, 15, 20, 42, 884, DateTimeKind.Local).AddTicks(9478), "Generic Wooden Hat" },
                    { 89, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 671.673668492899m, new DateTime(2025, 12, 18, 15, 22, 24, 174, DateTimeKind.Local).AddTicks(5659), "Licensed Concrete Towels" },
                    { 90, "9", "The Football Is Good For Training And Recreational Purposes", 266.666077669554m, new DateTime(2026, 6, 2, 12, 51, 35, 709, DateTimeKind.Local).AddTicks(5839), "Incredible Wooden Mouse" },
                    { 91, "9", "The Football Is Good For Training And Recreational Purposes", 479.420829466274m, new DateTime(2026, 3, 24, 13, 37, 7, 311, DateTimeKind.Local).AddTicks(5572), "Handcrafted Granite Chicken" },
                    { 92, "5", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 396.853495480424m, new DateTime(2026, 7, 2, 0, 13, 20, 857, DateTimeKind.Local).AddTicks(9747), "Small Concrete Hat" },
                    { 93, "3", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 428.859090867852m, new DateTime(2026, 8, 31, 23, 7, 12, 676, DateTimeKind.Local).AddTicks(6444), "Small Soft Soap" },
                    { 94, "2", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 227.56040147299m, new DateTime(2025, 12, 31, 14, 40, 57, 695, DateTimeKind.Local).AddTicks(3835), "Licensed Plastic Fish" },
                    { 95, "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 844.347017200825m, new DateTime(2026, 7, 31, 1, 8, 37, 598, DateTimeKind.Local).AddTicks(2777), "Refined Steel Keyboard" },
                    { 96, "2", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 771.981288391622m, new DateTime(2026, 5, 8, 20, 19, 25, 541, DateTimeKind.Local).AddTicks(1555), "Sleek Metal Gloves" },
                    { 97, "6", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 322.036397850158m, new DateTime(2026, 3, 10, 23, 1, 43, 867, DateTimeKind.Local).AddTicks(8648), "Unbranded Steel Ball" },
                    { 98, "6", "The Football Is Good For Training And Recreational Purposes", 74.260098103555m, new DateTime(2025, 12, 2, 5, 54, 7, 785, DateTimeKind.Local).AddTicks(9001), "Fantastic Cotton Chicken" },
                    { 99, "5", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 427.946504512777m, new DateTime(2026, 5, 18, 6, 27, 43, 278, DateTimeKind.Local).AddTicks(9367), "Refined Metal Chicken" },
                    { 100, "9", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 590.502272143263m, new DateTime(2026, 1, 14, 5, 38, 28, 583, DateTimeKind.Local).AddTicks(5603), "Handcrafted Plastic Car" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

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
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);
        }
    }
}
