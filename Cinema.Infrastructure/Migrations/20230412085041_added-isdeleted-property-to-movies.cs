using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedisdeletedpropertytomovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("33cf3b01-7973-47e8-b25e-c0be69847ce1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4eed25bf-7789-43ea-b287-fe9b84aa483c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5d0f09d7-7b6f-4a0f-960c-6c5dfc1c2a1f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6af34b78-8c4b-4857-96f9-889bd42b5d67"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7d8b1720-fead-413f-8b34-76e43a5be371"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("95897f6f-cd28-497a-b51f-6c19620f1f59"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9aa95237-a381-4f56-b203-cf47fe97c37f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b712390b-22fd-468d-aaa9-69264018efd7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d90b3bd8-b9a6-4045-904b-35f4b873b4f4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ee82ab82-c685-4763-a814-cfaaf7bb7296"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0238626f-050d-4454-8eee-ced851332d6d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0379743d-0c71-48d3-a276-8083eda4aade"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b05b7b2-a1a5-4695-8305-6889e2c1ba1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("105a4411-d5d7-48ed-a64e-84f6c7faa73c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1998440b-f279-49b7-87f0-2f79239ca2b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1abfe456-464b-4b43-a367-56389f7f22bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c81c093-d04b-41f8-b83e-3ba66b1af6da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1d27bca8-085b-4d77-b92c-c8ed985a4c7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26b834b4-368d-4abe-a747-f741f5ece3be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ff4a78d-334a-4d9a-8db9-1e34f1f6f90c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3034f66b-9703-435a-9a82-2e45d74cb928"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3191ab41-18d9-4ae0-b4f0-da3419ab03db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3932a524-1fd6-4dd2-bae5-a124f343da3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3dc1abf1-8bf3-4428-aa4a-10819deaaf0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ebeb5f1-a686-495d-840b-789c5a591625"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3fe00746-a7fd-4735-8402-e504e014104c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3fe7aec9-8d63-443d-81ee-f89f4ac15132"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4224e8b2-b9c0-4438-b987-b809bb1636c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4db7e9c9-3a16-4d57-b497-3ec623d70bed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4dddf123-6124-4401-a058-1047cf5791df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fe3460a-384e-4c15-a242-f8b35c078aac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("539c6ae0-2af5-4179-a6fc-aee15f99d9db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("567aa8e7-01d4-43d1-a89b-e3bed7d36090"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5830955e-dee1-42da-8647-a845cc912893"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5cf564b5-24a6-408b-8c07-7067de0f87a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d6051e7-bcee-469d-b822-5277dd5b332a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64f7b284-eb72-4f86-a82b-73c22faf85f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d348b1f-4815-4a60-9c1a-64aa9fc2b08f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ee54c0f-fdbe-4f84-97f4-e60b85156861"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("703f944c-48ad-49e9-9204-6d5b484571a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7245fa93-ac79-4c90-8c52-408fbb9a7acf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74b36c71-dbf5-4cbf-adc3-43e15548ae0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75b87bcc-9d90-4316-a4b1-d5dbddba6078"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("762d6617-67ac-43bf-809e-14c9beddad6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76e3ae5e-2f19-4b2f-a44b-06ed637d5243"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7886a0b7-e0a6-4ecb-a2fe-528b35ea2079"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c0ce797-d6fc-45a0-bf6d-2080d76080be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8224ca33-2bd1-47a6-b783-fcce11f0aa62"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8390e656-655a-4d1d-9112-d12d5d8f837f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("844db742-fa41-42cf-931c-85eb70adf837"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87aca4a2-415f-4a06-bbd2-e73ba134822b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88a9b3ec-90c6-4e90-b89b-ca953b3e30c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b09fe50-8385-4c51-97c1-a18e33df3467"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b3976a9-62af-44c9-9e2f-b41ae9073103"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("950e74fd-5e40-4fca-b082-f3c2986e907a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98b9afa7-acff-4b09-8d99-9ac6b8c5b478"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98bbd08c-a4e3-4fff-b574-f5725e8e011f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a020c14-3220-4e0d-b0ba-84790dc520ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9eb55f52-9ff6-479b-a1e2-346b68100245"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae769c0e-b9db-4f0b-84d3-e68a9f4abbfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3c7ba6b-302c-498f-a763-e91157e07509"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4883f72-c0a2-4e7d-a461-dd3ca5bff9ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5ad69df-7fc7-4036-849b-4d3a46f3651c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b73a22fa-9661-437f-96fa-8e29a6bd60e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf1fd00b-7b7e-4850-b78a-1fabff34749f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c194fc82-72e4-4873-8260-2ce93114fe4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2e60f6c-a023-4655-8534-0b0e6cc6f7b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c693907d-7d10-4a4f-a77a-ed33a663bb7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9ad69bd-51c0-4c08-ac9c-df9e7a2ad3d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce0430d9-ffdf-485b-9eed-242ea42c0cb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce0e2004-4713-4956-ae39-01b45c3284d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cffaa220-1713-4896-a724-247c7a2255e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2eeb840-8009-41d4-b8cf-7b5a5e2654a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6d019a9-fabd-4bdb-9f4d-e5079ae07849"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7547870-49ff-4393-8a4b-892d8adbef4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9f11533-43e9-48aa-bb96-f0616e186abe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9f2eec8-23a0-43df-a4fb-74a72c035375"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dac2d92b-211c-411c-8a14-6f77150a4a9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e105d7df-0f08-4f4e-977e-e95fedda488a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e2698537-f484-4128-b130-e49b9a1e41cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea2ebc1d-6b1e-40f6-8d20-9c97cf874082"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f05451d4-1a18-49db-a914-785357338786"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa741a25-c862-41a6-bb43-6dc523ab17f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fbf08850-326c-4bc3-846c-a48d3a50e46f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f102af0-2cc2-4866-a568-0ab6aefbcb88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8922862c-301a-4089-a258-6be48674bcf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac231db3-dedc-47e5-b13b-1dad08a0e0f1"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("183ba907-83dc-431a-a59d-15751b58fb14"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Astérix & Obélix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("33b8700c-db9b-426e-aa33-0d7747e1c188"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("3fb630e9-c095-4caa-afdd-b86b62f85e67"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("7ef09379-1631-4a1a-a223-642884f8f16e"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("83c9ef6e-ad79-411e-80bc-1c1555ee7e84"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("971e2fe0-1857-4c1f-a957-1d065f468473"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("9bc0031b-6adb-4228-845c-49f677dc6f00"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("9efc2ade-32dd-4b98-83d4-587f687ac487"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("aaca1d48-ee03-44ac-9530-10184bae430f"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("fefddff1-b996-4153-a316-45cf3dc9b9dc"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("030fed5e-d5de-4f9a-8c38-38f77d676162"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("049c5960-30f0-459f-80d2-bb10bb8843f3"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("0b4a05a2-185c-4067-b0b2-4514abfe167d"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0cb8d412-5a93-4c43-afa3-27f5d72fbcca"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("10d8013a-af1d-4eb0-bcc0-3872f4d95313"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("18615c83-5ff9-401a-a4e1-e1b15598ba7a"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("18fb3bdf-515b-455c-a5c9-831da10173ca"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1c14c9b7-33ac-4930-87a8-6452a44a98b3"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1efa6d1f-14c8-4886-9ab2-f576f67f4f31"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2178fc7d-3888-4c00-827e-fe4a9b131842"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("22889cfb-d7a9-471f-91a0-bf86969cc5ee"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2453e816-98c4-4ab4-bcd3-5d0027a3ab7c"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2741d989-c5f2-4703-910d-911f82191ada"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2c6eb5a4-1eed-4c8f-91c2-dfcb35a32f38"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("2e31fcc1-f920-41df-9fc9-eee92913869d"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("3bd13374-2476-430f-88da-d8068d6bc6d7"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3c8a6d0e-6a39-4cf4-ad48-b1e351859d29"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("42156eb8-e03d-4d1f-9a43-c7ba18da4f2d"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("43bafe7f-6b83-4478-b231-9f6dda28e8d7"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4585de98-c606-4038-8019-abcf49257088"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("463d85b5-3b0a-48e4-a01f-4a3f6fbe6b77"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5ff26a14-3845-45bf-88bb-6c9c522633d7"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("61010d7d-1734-4ed6-8dbb-fd5e7fd02df2"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("61e73c4c-05c8-439e-986a-eab4ede4656f"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("66b45e3f-1c69-4c7b-af75-3ec6f5fd66cf"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("67063b32-330c-47df-9ca6-9921c6655a01"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("697d5683-a08a-4dc6-936c-08874928b69c"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("71e61a4a-f5b0-4ef8-b349-427ba563628a"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7fc9ee56-9f8e-457b-9cf5-463404ace9e6"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8149dedb-155c-4b77-a0e7-6ef0f3c1e473"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("86ceaab0-7410-46a9-8eb9-0b1f2a900a15"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8a64b313-0499-40d5-b8a9-e62e5a692968"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8ca0fc2a-4549-45aa-99e4-3eb6211ddefa"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8db29a0a-a705-461a-8c41-d68d530a6adf"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8f4b2e1d-0e0e-4b3e-9b34-e9ae90a428f8"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("909bbfa6-5a2e-46ce-9931-e83bf9512cd9"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("92886c14-c9dd-42cf-81b3-15dcce5f156a"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("943eccc3-be93-4a6b-a8ca-c02cffd3a065"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("94b1d724-4072-4815-a159-11c915198fa1"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("99b08a21-6570-487d-978d-43e458da6155"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9a291f5f-2ad5-47fc-a7db-6764eda8c57c"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9a2ea958-53ff-4566-b199-5515282c094e"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9dcb159a-bfb7-4070-99a6-c1806affee39"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9de1b263-1edc-4544-9306-53f49ddfdbb3"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a05344c2-c816-4c84-8fdb-4946213c6c63"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a05a88c0-c7d6-4b1d-aeca-536ce7676000"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a2ae0bd1-8d1c-4cc9-a8e7-b338a38961d4"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("a6b60c94-5337-471e-9b46-b1b997efa802"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a93baebd-8365-4752-9337-04f30f663022"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b0ce6008-b524-4f11-8298-6250057c8f6e"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b1220b35-d9e7-4364-87c1-d19a2c674348"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b2ff98ca-9444-40be-abfd-f5e547425509"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b436cfc7-367e-4182-aeae-54c040aefe91"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b4c01b4e-68d0-4d31-b928-991e3da63106"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("b614ce8c-fe90-4b5a-ac5f-bb73b31b59f9"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b8b4627e-f1e8-488d-ad80-13f4e5b095ba"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("bd1e5ec8-858a-45e6-af55-92372d58f5b4"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bdab8a79-0243-419f-b2d4-b40a6bc5ea0e"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("bf41445e-7482-4c8e-a9c9-a627d666b90b"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("c6bc1ac7-1923-4531-b814-10afcf43cbd4"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c7fac3db-3ce9-44cc-9541-9135a672fd21"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("ca262d55-5b36-439e-866c-f394b3621a07"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("cbec06d7-54cd-4db1-a6ed-f28df96d453c"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("cedb7aa7-82a1-40d6-b516-d568fbbe9335"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("cf814ed8-cbb7-43e2-ad93-dd504ecd586c"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d282abd9-6dea-4d53-9cf1-50d231cc2afb"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("dd15b02a-c0b4-4cc2-b453-7a9ad2a7e5bb"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("df249f4d-cd5d-49f2-a5b5-d2f45de7ebb2"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e2511008-2fcf-4a31-9043-9658f7cfbd1d"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("e6d7a43b-d19a-4a3f-8867-ae4afa72b849"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f1a1f279-fa98-44b8-9935-95543bc73045"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f358c97d-0c40-4767-9398-b910226c2f47"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f60cd9f1-7d14-4ad8-8843-51b4847c7aa4"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f7da9ff0-9562-4522-bf2e-2f948cea20b7"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("495401b2-a9aa-472d-866b-db96efdf3110"), new DateTime(2023, 4, 12, 10, 50, 41, 380, DateTimeKind.Local).AddTicks(2921), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" },
                    { new Guid("5d42c215-0b69-4ff3-9ddc-098c17c37e35"), new DateTime(2023, 4, 12, 10, 50, 41, 380, DateTimeKind.Local).AddTicks(2906), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("c7a48078-6227-4e99-831e-88a9e8c0ee7f"), new DateTime(2023, 4, 12, 10, 50, 41, 380, DateTimeKind.Local).AddTicks(2793), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("183ba907-83dc-431a-a59d-15751b58fb14"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("33b8700c-db9b-426e-aa33-0d7747e1c188"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3fb630e9-c095-4caa-afdd-b86b62f85e67"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7ef09379-1631-4a1a-a223-642884f8f16e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("83c9ef6e-ad79-411e-80bc-1c1555ee7e84"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("971e2fe0-1857-4c1f-a957-1d065f468473"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9bc0031b-6adb-4228-845c-49f677dc6f00"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9efc2ade-32dd-4b98-83d4-587f687ac487"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("aaca1d48-ee03-44ac-9530-10184bae430f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fefddff1-b996-4153-a316-45cf3dc9b9dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("030fed5e-d5de-4f9a-8c38-38f77d676162"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("049c5960-30f0-459f-80d2-bb10bb8843f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b4a05a2-185c-4067-b0b2-4514abfe167d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0cb8d412-5a93-4c43-afa3-27f5d72fbcca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10d8013a-af1d-4eb0-bcc0-3872f4d95313"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18615c83-5ff9-401a-a4e1-e1b15598ba7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18fb3bdf-515b-455c-a5c9-831da10173ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c14c9b7-33ac-4930-87a8-6452a44a98b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1efa6d1f-14c8-4886-9ab2-f576f67f4f31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2178fc7d-3888-4c00-827e-fe4a9b131842"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22889cfb-d7a9-471f-91a0-bf86969cc5ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2453e816-98c4-4ab4-bcd3-5d0027a3ab7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2741d989-c5f2-4703-910d-911f82191ada"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c6eb5a4-1eed-4c8f-91c2-dfcb35a32f38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e31fcc1-f920-41df-9fc9-eee92913869d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bd13374-2476-430f-88da-d8068d6bc6d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c8a6d0e-6a39-4cf4-ad48-b1e351859d29"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42156eb8-e03d-4d1f-9a43-c7ba18da4f2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43bafe7f-6b83-4478-b231-9f6dda28e8d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4585de98-c606-4038-8019-abcf49257088"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("463d85b5-3b0a-48e4-a01f-4a3f6fbe6b77"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ff26a14-3845-45bf-88bb-6c9c522633d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61010d7d-1734-4ed6-8dbb-fd5e7fd02df2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61e73c4c-05c8-439e-986a-eab4ede4656f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66b45e3f-1c69-4c7b-af75-3ec6f5fd66cf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67063b32-330c-47df-9ca6-9921c6655a01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("697d5683-a08a-4dc6-936c-08874928b69c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71e61a4a-f5b0-4ef8-b349-427ba563628a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7fc9ee56-9f8e-457b-9cf5-463404ace9e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8149dedb-155c-4b77-a0e7-6ef0f3c1e473"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86ceaab0-7410-46a9-8eb9-0b1f2a900a15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a64b313-0499-40d5-b8a9-e62e5a692968"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ca0fc2a-4549-45aa-99e4-3eb6211ddefa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8db29a0a-a705-461a-8c41-d68d530a6adf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f4b2e1d-0e0e-4b3e-9b34-e9ae90a428f8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("909bbfa6-5a2e-46ce-9931-e83bf9512cd9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92886c14-c9dd-42cf-81b3-15dcce5f156a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("943eccc3-be93-4a6b-a8ca-c02cffd3a065"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94b1d724-4072-4815-a159-11c915198fa1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99b08a21-6570-487d-978d-43e458da6155"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a291f5f-2ad5-47fc-a7db-6764eda8c57c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a2ea958-53ff-4566-b199-5515282c094e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9dcb159a-bfb7-4070-99a6-c1806affee39"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9de1b263-1edc-4544-9306-53f49ddfdbb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a05344c2-c816-4c84-8fdb-4946213c6c63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a05a88c0-c7d6-4b1d-aeca-536ce7676000"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2ae0bd1-8d1c-4cc9-a8e7-b338a38961d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6b60c94-5337-471e-9b46-b1b997efa802"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a93baebd-8365-4752-9337-04f30f663022"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0ce6008-b524-4f11-8298-6250057c8f6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1220b35-d9e7-4364-87c1-d19a2c674348"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2ff98ca-9444-40be-abfd-f5e547425509"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b436cfc7-367e-4182-aeae-54c040aefe91"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4c01b4e-68d0-4d31-b928-991e3da63106"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b614ce8c-fe90-4b5a-ac5f-bb73b31b59f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8b4627e-f1e8-488d-ad80-13f4e5b095ba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd1e5ec8-858a-45e6-af55-92372d58f5b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bdab8a79-0243-419f-b2d4-b40a6bc5ea0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf41445e-7482-4c8e-a9c9-a627d666b90b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6bc1ac7-1923-4531-b814-10afcf43cbd4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7fac3db-3ce9-44cc-9541-9135a672fd21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca262d55-5b36-439e-866c-f394b3621a07"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbec06d7-54cd-4db1-a6ed-f28df96d453c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cedb7aa7-82a1-40d6-b516-d568fbbe9335"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf814ed8-cbb7-43e2-ad93-dd504ecd586c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d282abd9-6dea-4d53-9cf1-50d231cc2afb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd15b02a-c0b4-4cc2-b453-7a9ad2a7e5bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df249f4d-cd5d-49f2-a5b5-d2f45de7ebb2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e2511008-2fcf-4a31-9043-9658f7cfbd1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e6d7a43b-d19a-4a3f-8867-ae4afa72b849"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1a1f279-fa98-44b8-9935-95543bc73045"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f358c97d-0c40-4767-9398-b910226c2f47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f60cd9f1-7d14-4ad8-8843-51b4847c7aa4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7da9ff0-9562-4522-bf2e-2f948cea20b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("495401b2-a9aa-472d-866b-db96efdf3110"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d42c215-0b69-4ff3-9ddc-098c17c37e35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7a48078-6227-4e99-831e-88a9e8c0ee7f"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("33cf3b01-7973-47e8-b25e-c0be69847ce1"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("4eed25bf-7789-43ea-b287-fe9b84aa483c"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("5d0f09d7-7b6f-4a0f-960c-6c5dfc1c2a1f"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("6af34b78-8c4b-4857-96f9-889bd42b5d67"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("7d8b1720-fead-413f-8b34-76e43a5be371"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("95897f6f-cd28-497a-b51f-6c19620f1f59"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("9aa95237-a381-4f56-b203-cf47fe97c37f"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("b712390b-22fd-468d-aaa9-69264018efd7"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("d90b3bd8-b9a6-4045-904b-35f4b873b4f4"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("ee82ab82-c685-4763-a814-cfaaf7bb7296"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("0238626f-050d-4454-8eee-ced851332d6d"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0379743d-0c71-48d3-a276-8083eda4aade"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0b05b7b2-a1a5-4695-8305-6889e2c1ba1f"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("105a4411-d5d7-48ed-a64e-84f6c7faa73c"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1998440b-f279-49b7-87f0-2f79239ca2b5"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1abfe456-464b-4b43-a367-56389f7f22bb"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("1c81c093-d04b-41f8-b83e-3ba66b1af6da"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1d27bca8-085b-4d77-b92c-c8ed985a4c7e"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("26b834b4-368d-4abe-a747-f741f5ece3be"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2ff4a78d-334a-4d9a-8db9-1e34f1f6f90c"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("3034f66b-9703-435a-9a82-2e45d74cb928"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3191ab41-18d9-4ae0-b4f0-da3419ab03db"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3932a524-1fd6-4dd2-bae5-a124f343da3d"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("3dc1abf1-8bf3-4428-aa4a-10819deaaf0a"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3ebeb5f1-a686-495d-840b-789c5a591625"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("3fe00746-a7fd-4735-8402-e504e014104c"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("3fe7aec9-8d63-443d-81ee-f89f4ac15132"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4224e8b2-b9c0-4438-b987-b809bb1636c0"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4db7e9c9-3a16-4d57-b497-3ec623d70bed"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4dddf123-6124-4401-a058-1047cf5791df"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4fe3460a-384e-4c15-a242-f8b35c078aac"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("539c6ae0-2af5-4179-a6fc-aee15f99d9db"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("567aa8e7-01d4-43d1-a89b-e3bed7d36090"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5830955e-dee1-42da-8647-a845cc912893"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5cf564b5-24a6-408b-8c07-7067de0f87a5"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5d6051e7-bcee-469d-b822-5277dd5b332a"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("64f7b284-eb72-4f86-a82b-73c22faf85f1"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("6d348b1f-4815-4a60-9c1a-64aa9fc2b08f"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("6ee54c0f-fdbe-4f84-97f4-e60b85156861"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("703f944c-48ad-49e9-9204-6d5b484571a7"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7245fa93-ac79-4c90-8c52-408fbb9a7acf"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("74b36c71-dbf5-4cbf-adc3-43e15548ae0b"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("75b87bcc-9d90-4316-a4b1-d5dbddba6078"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("762d6617-67ac-43bf-809e-14c9beddad6f"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("76e3ae5e-2f19-4b2f-a44b-06ed637d5243"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7886a0b7-e0a6-4ecb-a2fe-528b35ea2079"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7c0ce797-d6fc-45a0-bf6d-2080d76080be"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8224ca33-2bd1-47a6-b783-fcce11f0aa62"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8390e656-655a-4d1d-9112-d12d5d8f837f"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("844db742-fa41-42cf-931c-85eb70adf837"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("87aca4a2-415f-4a06-bbd2-e73ba134822b"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("88a9b3ec-90c6-4e90-b89b-ca953b3e30c4"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8b09fe50-8385-4c51-97c1-a18e33df3467"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8b3976a9-62af-44c9-9e2f-b41ae9073103"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("950e74fd-5e40-4fca-b082-f3c2986e907a"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("98b9afa7-acff-4b09-8d99-9ac6b8c5b478"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("98bbd08c-a4e3-4fff-b574-f5725e8e011f"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9a020c14-3220-4e0d-b0ba-84790dc520ad"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9eb55f52-9ff6-479b-a1e2-346b68100245"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ae769c0e-b9db-4f0b-84d3-e68a9f4abbfc"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b3c7ba6b-302c-498f-a763-e91157e07509"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b4883f72-c0a2-4e7d-a461-dd3ca5bff9ca"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b5ad69df-7fc7-4036-849b-4d3a46f3651c"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("b73a22fa-9661-437f-96fa-8e29a6bd60e9"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bf1fd00b-7b7e-4850-b78a-1fabff34749f"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c194fc82-72e4-4873-8260-2ce93114fe4a"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c2e60f6c-a023-4655-8534-0b0e6cc6f7b5"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("c693907d-7d10-4a4f-a77a-ed33a663bb7e"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c9ad69bd-51c0-4c08-ac9c-df9e7a2ad3d9"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ce0430d9-ffdf-485b-9eed-242ea42c0cb6"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("ce0e2004-4713-4956-ae39-01b45c3284d8"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("cffaa220-1713-4896-a724-247c7a2255e9"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d2eeb840-8009-41d4-b8cf-7b5a5e2654a0"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d6d019a9-fabd-4bdb-9f4d-e5079ae07849"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d7547870-49ff-4393-8a4b-892d8adbef4c"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("d9f11533-43e9-48aa-bb96-f0616e186abe"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("d9f2eec8-23a0-43df-a4fb-74a72c035375"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("dac2d92b-211c-411c-8a14-6f77150a4a9c"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("e105d7df-0f08-4f4e-977e-e95fedda488a"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e2698537-f484-4128-b130-e49b9a1e41cd"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ea2ebc1d-6b1e-40f6-8d20-9c97cf874082"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f05451d4-1a18-49db-a914-785357338786"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fa741a25-c862-41a6-bb43-6dc523ab17f4"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("fbf08850-326c-4bc3-846c-a48d3a50e46f"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("6f102af0-2cc2-4866-a568-0ab6aefbcb88"), new DateTime(2023, 4, 11, 14, 52, 3, 678, DateTimeKind.Local).AddTicks(9712), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("8922862c-301a-4089-a258-6be48674bcf8"), new DateTime(2023, 4, 11, 14, 52, 3, 678, DateTimeKind.Local).AddTicks(9938), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" },
                    { new Guid("ac231db3-dedc-47e5-b13b-1dad08a0e0f1"), new DateTime(2023, 4, 11, 14, 52, 3, 678, DateTimeKind.Local).AddTicks(9910), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" }
                });
        }
    }
}
