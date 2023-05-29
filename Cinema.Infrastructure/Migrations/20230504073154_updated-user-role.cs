using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateduserrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("060caa16-b9b9-4ee2-bced-e16d4f05f465"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2f9cc257-5d1a-48e1-9039-4d5477a705a3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3ec96e8c-5bb1-48e2-842e-8ebb6a796c28"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("40b2bde8-a92c-4682-8cee-5a72958ccbd4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("53156ffe-43df-4c69-96b3-6fcfd69798e8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("58c3cbb3-8414-4dec-a5b4-1ba1072a5aad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6b2ca5de-821d-46fe-853b-45dbd6d286c6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dadfe048-b099-45dd-a536-a0f0f909c12e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fa1e6696-6eda-45dc-9609-5bf69d52fd0c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fb87061f-47b9-44c6-931a-f5d3689bed94"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("008fff3a-7e56-46f4-ac8e-3e0e24b036dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06b523da-8b2c-4ffe-916a-c8cef2a13852"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bbce79f-34ff-4c37-9329-afac041b0b38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c6c533c-9e76-42fe-8ff2-69fb5ffc8f58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d93828a-2749-4987-8af2-fb6120ee7e1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12d2cc15-e541-4e87-82c7-689bc70058e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1489f23f-f43c-44f1-9bcd-adcc90857561"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b260092-b839-4af4-bf2d-c890f72f4cc0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c698f6b-4113-42ce-9824-23f0595f7f6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1edb3481-53ac-47b0-ad61-2dfdd0f3ebee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2838156a-4c03-46d7-9bf4-c53dc88d7ca6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28ae218f-33ac-48b9-bac3-5abfdb63adee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29980ddc-306e-403e-ae4e-e256bec51f3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29cf1a2e-69e2-4427-960d-accff89410ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d923753-2bc7-4500-9afe-e0631dee7b42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ef43a70-10ae-4552-93d7-370739549405"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32c1d7be-6308-4e7b-9812-175dedb4e475"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("344f5389-9ad1-4263-bc94-9d4f817bdc49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bc2cb13-a8fb-41c5-96de-17543bcb0d34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43289697-328b-4813-83f3-14f1b8cafb83"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bad0608-1ad4-46b1-b149-059af9c2f9aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c771428-8c46-4488-9d0e-44c5449d31aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d261c96-37e8-40dd-b839-7c97c0b12f9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4eb22f65-f27d-474d-b730-b078c9325123"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ed8236b-7f6e-425d-a086-811f9f74988d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4eedfac3-ae89-464a-aa19-cffc9e415b55"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f2fc8b4-2420-493e-ad8f-fa4609a71e40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5091a5a2-9cb2-46a3-b4df-d0829b5447a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("577e69a1-5f95-4935-9989-969e332b4ba3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("590529de-8796-43f3-acee-677ee0a17647"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f3a62c5-8bbc-43a5-8d7e-e2479f29c57e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("617666fc-665f-4dc0-9823-489ee30af9a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63b4300b-de9e-4387-9ef9-971d37f8bdf4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67102368-eb71-45cf-89c2-fbe19925a024"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("68c9573f-5faa-4e6e-b5ac-399920f2682a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("694911e8-fedd-4fcc-8849-356de507bb60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e89278b-cc0b-4118-add8-bf3e534e09c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ef38fea-d183-42f1-8ffc-8e491e4a517e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("701f825f-2e11-4552-8c06-e7ae689507f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70822888-bfdd-4e88-b1e5-6aca2acabfe6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75daeea1-1a58-4aed-a197-c04fc8b70fce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("79481498-4e02-42e1-936a-d8302f1fd589"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("79d8d9b6-de6f-42bc-8f78-45fd8b753f21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ea419a4-514d-455c-9185-c573d80b8d83"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ef16765-f64b-4239-bb86-62c76d901d20"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8654f800-ffb4-4a7b-8c93-922b252271bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86cd0644-7a31-416e-be36-a6fcd16bb145"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87037a7f-1931-461b-95b8-3ba5768c9583"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91743dc7-2e37-471a-804d-9cb281d18e4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9391c7a9-8ef3-4703-9479-24acb8dc0390"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95affaaf-c6d0-4c84-a6ce-6bab45c11412"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9de26b11-a5aa-48d0-82dc-1512ba4bb0d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0bd1f3c-d90b-4dec-95be-35e6ceb6a47c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5a4c612-ad5f-4404-8ec7-433961d2aa4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a71bea01-b162-4f49-94a0-81f992de062b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a79b2288-d9f3-486c-8628-34d0ccaeab77"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b156397e-e43d-4117-9bc5-f8531777c59e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b38d3722-46c0-46e5-97d8-208e5ed25193"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd3e46dd-2113-44a8-b8eb-aae69ab3dbf3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bdd8c227-3711-4d26-bfc0-59ed8a8e124a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c250a63f-0147-447a-9163-458985a3f4e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2ce6a5c-82b3-471f-9c1f-b7352139cfe5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c62d6b3a-8eea-4f01-801b-a5fe1430f60e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6e31a31-d49c-4a2a-bc15-f7d6cae94f5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c743aace-d294-49ae-af0f-912ebe4c9489"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7e61f9f-a9da-4dd8-8e4a-15da83f5ad51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd75cdd8-9c57-4f74-afbd-b72a38d23116"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd7a01bc-7bf9-4448-a006-045ab49fb2b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d436461b-7053-4656-b100-923bb76e9214"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7e4a90f-47d8-4c4a-9c83-11a6c5371420"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ddd77d54-f1ea-4927-8017-40280b74656c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f290ad18-8c30-4b32-b5c8-5b526461b6f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f54d69c1-0eee-4d9a-b75a-4b6973cd72e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd034ecd-7593-4f6c-ae44-71fbb6f83f04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d281af2-7dd7-43bd-9f9a-50960fb58ca8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fedd2cb-0162-4887-be0f-eff982219543"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b68b7d49-6003-4e3e-85dd-80ecad45034b"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("2a057a61-3f07-4f18-a79c-00610ce2eb9f"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("3e2bd12b-2786-4cc2-89dd-d6a76916c919"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("594c373b-632e-4934-a71a-72c5e02137fd"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("6c4a93e1-9939-461b-8f47-2cca413f3bdc"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("9c9b0b0b-993b-425e-ad47-8b043b48a603"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("b67c86f7-5c77-49a3-9ab3-b2d42d2375d8"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("b97e8940-22f0-4b20-a1a4-11f3d674684b"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("c0504a93-bbff-4ad4-9a67-5b033a8667d5"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("d9e7cee5-d18d-4f99-881e-d433a510ab2c"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("e554c302-f451-4957-b7b1-d6b112fa5691"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("058ae6f4-6a62-475b-9910-f27a21b228fe"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0b59191c-acbf-47bb-92e1-a97b39a75736"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0c1b7792-9a14-449e-9da3-6daf2a508f88"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0d25935e-8d59-45c8-a8d5-1fc526a01276"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0f63d46f-a3d5-4dc1-9336-3384244a87e1"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("10843b40-fa7b-4192-9ffa-dfa2e4908faa"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("10a6a4a3-548f-4db3-9b4d-1968947958f6"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("10b608e3-db1b-431d-8b1b-5abfe55ee70d"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("11f64bb1-a56a-4a6c-89eb-ad87cb460fea"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("152416e9-59d2-4299-8946-26d4b2745c9b"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("19baada4-fcc9-49e1-a4ac-26443a104ed3"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1d6de834-cef3-42ab-a01d-5ad8d286cc2e"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("21201ea7-3db4-45f0-b68d-e4411af00935"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("26de8d6b-7741-48d3-8bd7-2f697e79b0d7"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("284aadff-a76b-4077-b9fc-94c7fe73c7fb"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2c06b23d-7c3c-4a0d-a145-74949f0fa786"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("39035796-ef6a-4323-86d8-4aa85fbd5d8a"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("398e30fd-4ad3-493e-92db-2557e9527071"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3b9bb2c9-5b87-4b6f-add7-fc24807f3ec5"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3cee491d-83a3-4f6c-b844-040e0efaacb4"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3d5e8072-008a-4571-830a-c4133ff91c85"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3f51710e-8d15-4f00-ac41-451618bb434a"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("40792ee1-591e-4b0b-a02d-25bbc0f1744b"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("42d9b6c8-6e81-4be2-92b9-8b9180d8d2a6"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("44e95760-f479-4477-9cfd-a2dda9d5929d"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4a0c557d-4d86-4258-9279-f2df42f862a8"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4d0ae1e6-ffc7-4aaf-95b5-466b33da796a"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("509a800b-3a5f-413e-b462-70c21e032252"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("54a925d9-b39c-4471-b47d-4c9b3288ad1d"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("55080752-064b-40b1-89c3-dc410aaedff1"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5f8ae3cc-6e27-48d6-a717-b9b318201d45"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6041decf-aee5-4fc0-b6ec-9c37d53f1530"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("645b856c-dab9-440c-8ec7-88a8c582eb1d"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("669ce83b-a1fe-45b6-a090-9e07dd35a971"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6765808a-4a1a-4373-9d7e-3712311bddb6"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6f0324fe-7278-4fe1-9c51-77c2bb7de550"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("76cd73fc-6ffd-426f-92e5-692d98af942a"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("77caaff1-be81-4653-9f3f-69cdbcf38704"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7f933d1d-93e0-4921-8e50-e310dd5a1bf0"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("80f7c0db-37bf-4cc4-9224-41d7355830b3"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("819d012c-f826-431e-aa80-b369088be4e3"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8306e611-db47-47dd-a42c-775d966227c9"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8706b11e-3778-4ec3-a3f7-b7b798856ae4"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8b99209b-022f-44ed-826a-3b273a5534d1"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8e02e60d-f9a7-49f2-9ee5-224e655b7ad9"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("936ec55d-a8c7-4119-a9d8-9c05fe4f566a"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("98893bd9-1ea1-4684-a377-5949d5e6d9f0"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9d4aaf96-97c2-463f-a49c-69a3885d4eb9"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a9a7c446-3ffe-475b-84be-50ff3f8f155a"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ab6495ea-ef74-48fd-810c-db17df2dfd1e"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b2e883d7-b617-4cbe-8457-41efd0e0be94"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b4436eb5-3bc7-4112-9bd9-fbc2e254f10c"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("b47cc357-e86f-4945-8f88-e48825d497e4"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b714b465-368e-417e-b2e3-498427a942a0"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b8004b91-a75d-4cb4-8b59-b9ac19121896"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("b8577f75-8215-474e-8404-c94efc9a3153"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("be298b3c-4daf-4726-b14d-f362356a2fc4"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c0912596-32bc-43b2-adc1-ccb38896d3e9"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c1da79b3-27c5-4eb3-8f0a-a23bf93b48e2"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c343f12a-3685-402c-8ebc-21c170141fdb"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c5aca5a9-3935-4f17-bc82-bd5e00906097"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c7a82656-0f3f-42de-9222-788869950075"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("caefa80a-faa3-404a-bceb-8ee935559914"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ccfb6f76-1b64-4d39-9463-ce95e09bc452"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d030476b-6f46-40e1-b6ad-564ee44dbd90"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d7b4fdcb-48c5-4c02-b7a1-bc7b4bdd7770"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("e99aa29c-d770-43c0-bf0f-a71fb49b34d1"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ec11b695-bfbf-49a3-af39-120139b153eb"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("ed352746-dd2c-4d2d-a942-020687f61640"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ee77a4c1-1363-4ae7-8fbe-6ba586dddc65"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f2628e0b-2b01-4b40-a304-a2a733b11dda"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fa48f5b9-9536-4f0d-b1e8-749eb5d69b0c"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("fb4bd6ff-c2e7-4b35-8507-9f02f564f09f"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("fb5690bb-ed5d-471a-9ae6-61d61324699b"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3533ee98-6ac9-439c-9873-2aea37676f13"), new DateTime(2023, 5, 4, 9, 31, 54, 665, DateTimeKind.Local).AddTicks(5814), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" },
                    { new Guid("774ec70c-4101-43ef-8b7c-07e88bd9d0c4"), new DateTime(2023, 5, 4, 9, 31, 54, 665, DateTimeKind.Local).AddTicks(5510), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" },
                    { new Guid("776a3ec6-b7a2-47f9-af9e-c79f408f4698"), new DateTime(2023, 5, 4, 9, 31, 54, 665, DateTimeKind.Local).AddTicks(5919), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2a057a61-3f07-4f18-a79c-00610ce2eb9f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3e2bd12b-2786-4cc2-89dd-d6a76916c919"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("594c373b-632e-4934-a71a-72c5e02137fd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6c4a93e1-9939-461b-8f47-2cca413f3bdc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9c9b0b0b-993b-425e-ad47-8b043b48a603"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b67c86f7-5c77-49a3-9ab3-b2d42d2375d8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b97e8940-22f0-4b20-a1a4-11f3d674684b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c0504a93-bbff-4ad4-9a67-5b033a8667d5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d9e7cee5-d18d-4f99-881e-d433a510ab2c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e554c302-f451-4957-b7b1-d6b112fa5691"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("058ae6f4-6a62-475b-9910-f27a21b228fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b59191c-acbf-47bb-92e1-a97b39a75736"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c1b7792-9a14-449e-9da3-6daf2a508f88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d25935e-8d59-45c8-a8d5-1fc526a01276"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f63d46f-a3d5-4dc1-9336-3384244a87e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10843b40-fa7b-4192-9ffa-dfa2e4908faa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10a6a4a3-548f-4db3-9b4d-1968947958f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10b608e3-db1b-431d-8b1b-5abfe55ee70d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11f64bb1-a56a-4a6c-89eb-ad87cb460fea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("152416e9-59d2-4299-8946-26d4b2745c9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19baada4-fcc9-49e1-a4ac-26443a104ed3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1d6de834-cef3-42ab-a01d-5ad8d286cc2e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21201ea7-3db4-45f0-b68d-e4411af00935"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26de8d6b-7741-48d3-8bd7-2f697e79b0d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("284aadff-a76b-4077-b9fc-94c7fe73c7fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c06b23d-7c3c-4a0d-a145-74949f0fa786"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39035796-ef6a-4323-86d8-4aa85fbd5d8a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("398e30fd-4ad3-493e-92db-2557e9527071"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b9bb2c9-5b87-4b6f-add7-fc24807f3ec5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3cee491d-83a3-4f6c-b844-040e0efaacb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d5e8072-008a-4571-830a-c4133ff91c85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f51710e-8d15-4f00-ac41-451618bb434a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40792ee1-591e-4b0b-a02d-25bbc0f1744b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42d9b6c8-6e81-4be2-92b9-8b9180d8d2a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44e95760-f479-4477-9cfd-a2dda9d5929d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a0c557d-4d86-4258-9279-f2df42f862a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d0ae1e6-ffc7-4aaf-95b5-466b33da796a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("509a800b-3a5f-413e-b462-70c21e032252"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54a925d9-b39c-4471-b47d-4c9b3288ad1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55080752-064b-40b1-89c3-dc410aaedff1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f8ae3cc-6e27-48d6-a717-b9b318201d45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6041decf-aee5-4fc0-b6ec-9c37d53f1530"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("645b856c-dab9-440c-8ec7-88a8c582eb1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("669ce83b-a1fe-45b6-a090-9e07dd35a971"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6765808a-4a1a-4373-9d7e-3712311bddb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f0324fe-7278-4fe1-9c51-77c2bb7de550"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76cd73fc-6ffd-426f-92e5-692d98af942a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77caaff1-be81-4653-9f3f-69cdbcf38704"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f933d1d-93e0-4921-8e50-e310dd5a1bf0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80f7c0db-37bf-4cc4-9224-41d7355830b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("819d012c-f826-431e-aa80-b369088be4e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8306e611-db47-47dd-a42c-775d966227c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8706b11e-3778-4ec3-a3f7-b7b798856ae4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b99209b-022f-44ed-826a-3b273a5534d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e02e60d-f9a7-49f2-9ee5-224e655b7ad9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("936ec55d-a8c7-4119-a9d8-9c05fe4f566a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98893bd9-1ea1-4684-a377-5949d5e6d9f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d4aaf96-97c2-463f-a49c-69a3885d4eb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9a7c446-3ffe-475b-84be-50ff3f8f155a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab6495ea-ef74-48fd-810c-db17df2dfd1e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2e883d7-b617-4cbe-8457-41efd0e0be94"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4436eb5-3bc7-4112-9bd9-fbc2e254f10c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b47cc357-e86f-4945-8f88-e48825d497e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b714b465-368e-417e-b2e3-498427a942a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8004b91-a75d-4cb4-8b59-b9ac19121896"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8577f75-8215-474e-8404-c94efc9a3153"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be298b3c-4daf-4726-b14d-f362356a2fc4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0912596-32bc-43b2-adc1-ccb38896d3e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1da79b3-27c5-4eb3-8f0a-a23bf93b48e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c343f12a-3685-402c-8ebc-21c170141fdb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5aca5a9-3935-4f17-bc82-bd5e00906097"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7a82656-0f3f-42de-9222-788869950075"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("caefa80a-faa3-404a-bceb-8ee935559914"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ccfb6f76-1b64-4d39-9463-ce95e09bc452"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d030476b-6f46-40e1-b6ad-564ee44dbd90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7b4fdcb-48c5-4c02-b7a1-bc7b4bdd7770"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e99aa29c-d770-43c0-bf0f-a71fb49b34d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec11b695-bfbf-49a3-af39-120139b153eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed352746-dd2c-4d2d-a942-020687f61640"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee77a4c1-1363-4ae7-8fbe-6ba586dddc65"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2628e0b-2b01-4b40-a304-a2a733b11dda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa48f5b9-9536-4f0d-b1e8-749eb5d69b0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb4bd6ff-c2e7-4b35-8507-9f02f564f09f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb5690bb-ed5d-471a-9ae6-61d61324699b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3533ee98-6ac9-439c-9873-2aea37676f13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("774ec70c-4101-43ef-8b7c-07e88bd9d0c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("776a3ec6-b7a2-47f9-af9e-c79f408f4698"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("060caa16-b9b9-4ee2-bced-e16d4f05f465"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("2f9cc257-5d1a-48e1-9039-4d5477a705a3"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("3ec96e8c-5bb1-48e2-842e-8ebb6a796c28"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("40b2bde8-a92c-4682-8cee-5a72958ccbd4"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("53156ffe-43df-4c69-96b3-6fcfd69798e8"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("58c3cbb3-8414-4dec-a5b4-1ba1072a5aad"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("6b2ca5de-821d-46fe-853b-45dbd6d286c6"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("dadfe048-b099-45dd-a536-a0f0f909c12e"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("fa1e6696-6eda-45dc-9609-5bf69d52fd0c"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("fb87061f-47b9-44c6-931a-f5d3689bed94"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("008fff3a-7e56-46f4-ac8e-3e0e24b036dd"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("06b523da-8b2c-4ffe-916a-c8cef2a13852"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0bbce79f-34ff-4c37-9329-afac041b0b38"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("0c6c533c-9e76-42fe-8ff2-69fb5ffc8f58"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0d93828a-2749-4987-8af2-fb6120ee7e1f"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("12d2cc15-e541-4e87-82c7-689bc70058e4"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1489f23f-f43c-44f1-9bcd-adcc90857561"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1b260092-b839-4af4-bf2d-c890f72f4cc0"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("1c698f6b-4113-42ce-9824-23f0595f7f6e"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1edb3481-53ac-47b0-ad61-2dfdd0f3ebee"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2838156a-4c03-46d7-9bf4-c53dc88d7ca6"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("28ae218f-33ac-48b9-bac3-5abfdb63adee"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("29980ddc-306e-403e-ae4e-e256bec51f3d"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("29cf1a2e-69e2-4427-960d-accff89410ca"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2d923753-2bc7-4500-9afe-e0631dee7b42"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2ef43a70-10ae-4552-93d7-370739549405"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("32c1d7be-6308-4e7b-9812-175dedb4e475"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("344f5389-9ad1-4263-bc94-9d4f817bdc49"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("3bc2cb13-a8fb-41c5-96de-17543bcb0d34"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("43289697-328b-4813-83f3-14f1b8cafb83"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4bad0608-1ad4-46b1-b149-059af9c2f9aa"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4c771428-8c46-4488-9d0e-44c5449d31aa"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4d261c96-37e8-40dd-b839-7c97c0b12f9f"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4eb22f65-f27d-474d-b730-b078c9325123"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("4ed8236b-7f6e-425d-a086-811f9f74988d"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("4eedfac3-ae89-464a-aa19-cffc9e415b55"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("4f2fc8b4-2420-493e-ad8f-fa4609a71e40"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5091a5a2-9cb2-46a3-b4df-d0829b5447a9"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("577e69a1-5f95-4935-9989-969e332b4ba3"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("590529de-8796-43f3-acee-677ee0a17647"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("5f3a62c5-8bbc-43a5-8d7e-e2479f29c57e"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("617666fc-665f-4dc0-9823-489ee30af9a7"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("63b4300b-de9e-4387-9ef9-971d37f8bdf4"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("67102368-eb71-45cf-89c2-fbe19925a024"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("68c9573f-5faa-4e6e-b5ac-399920f2682a"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("694911e8-fedd-4fcc-8849-356de507bb60"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6e89278b-cc0b-4118-add8-bf3e534e09c0"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6ef38fea-d183-42f1-8ffc-8e491e4a517e"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("701f825f-2e11-4552-8c06-e7ae689507f9"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("70822888-bfdd-4e88-b1e5-6aca2acabfe6"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("75daeea1-1a58-4aed-a197-c04fc8b70fce"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("79481498-4e02-42e1-936a-d8302f1fd589"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("79d8d9b6-de6f-42bc-8f78-45fd8b753f21"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7ea419a4-514d-455c-9185-c573d80b8d83"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7ef16765-f64b-4239-bb86-62c76d901d20"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8654f800-ffb4-4a7b-8c93-922b252271bb"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("86cd0644-7a31-416e-be36-a6fcd16bb145"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("87037a7f-1931-461b-95b8-3ba5768c9583"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("91743dc7-2e37-471a-804d-9cb281d18e4f"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9391c7a9-8ef3-4703-9479-24acb8dc0390"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("95affaaf-c6d0-4c84-a6ce-6bab45c11412"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9de26b11-a5aa-48d0-82dc-1512ba4bb0d5"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a0bd1f3c-d90b-4dec-95be-35e6ceb6a47c"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a5a4c612-ad5f-4404-8ec7-433961d2aa4c"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("a71bea01-b162-4f49-94a0-81f992de062b"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("a79b2288-d9f3-486c-8628-34d0ccaeab77"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b156397e-e43d-4117-9bc5-f8531777c59e"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b38d3722-46c0-46e5-97d8-208e5ed25193"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("bd3e46dd-2113-44a8-b8eb-aae69ab3dbf3"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("bdd8c227-3711-4d26-bfc0-59ed8a8e124a"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c250a63f-0147-447a-9163-458985a3f4e5"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("c2ce6a5c-82b3-471f-9c1f-b7352139cfe5"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c62d6b3a-8eea-4f01-801b-a5fe1430f60e"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("c6e31a31-d49c-4a2a-bc15-f7d6cae94f5a"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c743aace-d294-49ae-af0f-912ebe4c9489"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c7e61f9f-a9da-4dd8-8e4a-15da83f5ad51"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("cd75cdd8-9c57-4f74-afbd-b72a38d23116"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("cd7a01bc-7bf9-4448-a006-045ab49fb2b5"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d436461b-7053-4656-b100-923bb76e9214"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d7e4a90f-47d8-4c4a-9c83-11a6c5371420"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ddd77d54-f1ea-4927-8017-40280b74656c"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f290ad18-8c30-4b32-b5c8-5b526461b6f3"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("f54d69c1-0eee-4d9a-b75a-4b6973cd72e5"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("fd034ecd-7593-4f6c-ae44-71fbb6f83f04"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("4d281af2-7dd7-43bd-9f9a-50960fb58ca8"), new DateTime(2023, 4, 27, 12, 45, 33, 827, DateTimeKind.Local).AddTicks(2909), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("9fedd2cb-0162-4887-be0f-eff982219543"), new DateTime(2023, 4, 27, 12, 45, 33, 827, DateTimeKind.Local).AddTicks(3052), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("b68b7d49-6003-4e3e-85dd-80ecad45034b"), new DateTime(2023, 4, 27, 12, 45, 33, 827, DateTimeKind.Local).AddTicks(3067), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" }
                });
        }
    }
}
