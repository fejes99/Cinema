using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedprojectionproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Projections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "Projections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("50394dce-9d82-4834-bbe2-6fa02aa41440"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("70b62b1f-58dd-4e54-a7c8-f4a54daaa93d"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("857fd540-c94d-4147-8300-a2cf2bd65e7b"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("895e5007-06ee-4126-809c-c38650fdedc0"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("99bdf360-6cb1-4a9a-a2ce-9bd38dc67ffb"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("a7b9853d-63a0-4179-9a72-461169e9bee9"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("c515105b-be02-4815-bbaf-cbf46a2ca9c3"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Astérix & Obélix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("c5f7ed44-e040-4ac7-874e-e3de5c33ed08"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("e5faae3f-06a2-4ea1-9ac2-41a162039100"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("f68a0b29-91b2-4884-ba25-81f18a3b7ac6"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("001bf436-121a-4a24-8331-794070399c61"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("00d53e1f-d8ca-42f4-a14c-9b0bd34bbd70"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("05bdb40f-5afa-4d0c-8e84-8a052c52a846"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("08d36a13-b78d-4dec-bcee-d467fb8942aa"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0e74d50c-8180-4906-9997-308ef50cccc3"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("14182ddb-29f3-488d-bd2d-59cf5fb13bc4"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("17f1af7f-24c2-45b4-b497-82fe5efea046"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("19e495c1-5141-42cd-a03b-2eb26e81643b"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1c87ffa3-6f56-47a7-b2c8-84b8e241613c"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("20c04730-88a4-4eb9-a68d-33b233b36a60"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("23f72b8e-241b-4b2e-99c1-6fbc071fd7ad"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("249c06b1-9061-47a7-85f6-455c915b7624"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2607e2d0-06fa-415c-af7d-bcbd179a953f"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("270d9e44-4ba5-4e82-97d4-5500a50640ca"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("2a0c003d-a75d-4fce-ab53-07c5e95cf24a"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2effb899-d239-489e-bbe9-56cda5f25296"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2f613abc-0b73-427e-bcf6-2483ee5e2db4"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("352455bb-7038-4b30-807f-9cd6f24e697c"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("360eb32a-7388-4a67-ba58-038fdbe5c0da"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3f8c4d75-0342-4f29-aff8-a9328e52f9cf"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("40fd2b3a-cecf-4d8f-8bee-f38cdda82f5d"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4409b82a-e6ea-4f7e-95d1-7a0d31929696"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("46c4464f-d299-40c7-b428-cf83ba0d6265"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("49a3ae4d-1642-4fd5-b81c-df350b52eb49"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5785c8ea-a67b-4386-abaa-7625a93e8062"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5a05725d-7f7b-4e46-bd5a-74c73e25c668"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5ce748d0-798e-4e7c-9221-bf3072aff854"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5cefb832-8ad7-4ac8-9bf8-793632ac7818"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5ea85381-04ba-44d6-a345-e0c451198af4"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5eab7373-6526-400b-bf30-df820617628b"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("60728b17-d01c-45ea-a65b-53b0ccab9600"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("637e84cb-1733-4675-90f1-3a9e0ce9849a"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("65699d10-112e-4ad9-8731-8fff408c638f"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("74442023-901f-4179-acc5-4cda82351eca"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7451455f-79f1-46e7-8b7d-205f57ce354d"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("7766e061-dc2d-4456-8f8c-661fa2d00a1a"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7b7385ae-b37b-4fe8-af17-9f568d3f1044"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7bd3bd10-01be-49b0-8caf-9ba703282541"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("807d3ac9-4c74-47ed-a898-5c0e7359f386"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8d65c230-0028-47c7-990d-4e161b157b69"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8dbfeb3a-9d63-46ef-9bcc-7a746fb3a71e"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("91d66dbb-f6ab-447b-b0bf-d0ed79317cd8"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("980b12c5-5f6a-4e82-8fd7-ed910aebf73d"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9da6859d-59fc-4f67-9101-16ca91ee497a"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a0fd7c63-94d8-47de-b223-7caca6795785"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("a56731ac-ac02-4bac-ae63-bf3974901186"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("a84b416f-f3cc-4d73-a476-ec5d4ba426d3"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a8e3fb7f-2153-410d-9966-9849b417da00"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("a9032a94-6a77-463d-a019-558029b9acac"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("acf8011a-1d6a-42b5-9e8f-5211309fd2b5"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b36f60b5-0ebe-4145-958a-233cc81ece2a"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b7a15d2b-eda6-475c-a44e-501def7989e3"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b93310d3-8671-49f1-bea9-98d9fa59dc5f"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c09b24a3-203c-49bc-b026-a13f8ae6ace2"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c46b41ea-aaf7-42c6-ac31-aa65e6280a24"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c8e95ffb-74ea-4ea2-8aa6-910738781fb3"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c99a177d-04bd-498a-8d82-8f659646b405"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d825620d-c3cf-42c2-9f8b-6909b5573d3d"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d99c5b1c-0d70-4212-b3f9-17e4431a2251"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("dee35ed4-f5ce-43d9-8a4f-cd5e826c23af"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e1f105b9-4f41-448a-9387-4add7a51ac1e"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e2f8a674-47cb-46d6-bea0-5dea3f1b2a27"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e6aa9925-d1e6-49eb-aa81-51d6559284c9"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("e7110e26-1bba-44f9-a382-11b9467f31a0"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("e794772a-b7e2-471d-bc3a-3a20525efe21"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e820f4ed-2a44-4c5d-a8cc-bc104229eb4e"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("ec70d24e-a608-4c06-9ff0-5fd4c7baa70e"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("eeed9281-171a-49df-bb0a-3850ed7b23d0"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f250575a-eca4-4363-90ae-54955b3c8d61"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f4386030-553f-453d-984c-abe1c35cefc7"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f7c1a61e-4426-4c8d-85d3-a3f0115c16b7"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fbcea388-6235-48d7-99d4-2bb7497d0645"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("fde55c47-4262-43cd-9cdb-1b5a3640c261"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("ff0a7525-5012-42d5-bb5d-4a7cdafdef2b"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("36b4b607-cd84-48fd-9836-c6675a7a7893"), new DateTime(2023, 4, 12, 14, 1, 41, 253, DateTimeKind.Local).AddTicks(6195), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("4e557e83-e22b-4996-ab58-a7df54102d85"), new DateTime(2023, 4, 12, 14, 1, 41, 253, DateTimeKind.Local).AddTicks(6334), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("e23bdbf7-77b5-42a8-bba3-43f12e448031"), new DateTime(2023, 4, 12, 14, 1, 41, 253, DateTimeKind.Local).AddTicks(6350), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("50394dce-9d82-4834-bbe2-6fa02aa41440"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("70b62b1f-58dd-4e54-a7c8-f4a54daaa93d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("857fd540-c94d-4147-8300-a2cf2bd65e7b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("895e5007-06ee-4126-809c-c38650fdedc0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("99bdf360-6cb1-4a9a-a2ce-9bd38dc67ffb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a7b9853d-63a0-4179-9a72-461169e9bee9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c515105b-be02-4815-bbaf-cbf46a2ca9c3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c5f7ed44-e040-4ac7-874e-e3de5c33ed08"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e5faae3f-06a2-4ea1-9ac2-41a162039100"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f68a0b29-91b2-4884-ba25-81f18a3b7ac6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("001bf436-121a-4a24-8331-794070399c61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00d53e1f-d8ca-42f4-a14c-9b0bd34bbd70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05bdb40f-5afa-4d0c-8e84-8a052c52a846"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08d36a13-b78d-4dec-bcee-d467fb8942aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e74d50c-8180-4906-9997-308ef50cccc3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14182ddb-29f3-488d-bd2d-59cf5fb13bc4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17f1af7f-24c2-45b4-b497-82fe5efea046"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19e495c1-5141-42cd-a03b-2eb26e81643b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c87ffa3-6f56-47a7-b2c8-84b8e241613c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("20c04730-88a4-4eb9-a68d-33b233b36a60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23f72b8e-241b-4b2e-99c1-6fbc071fd7ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("249c06b1-9061-47a7-85f6-455c915b7624"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2607e2d0-06fa-415c-af7d-bcbd179a953f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("270d9e44-4ba5-4e82-97d4-5500a50640ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a0c003d-a75d-4fce-ab53-07c5e95cf24a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2effb899-d239-489e-bbe9-56cda5f25296"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f613abc-0b73-427e-bcf6-2483ee5e2db4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("352455bb-7038-4b30-807f-9cd6f24e697c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("360eb32a-7388-4a67-ba58-038fdbe5c0da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f8c4d75-0342-4f29-aff8-a9328e52f9cf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40fd2b3a-cecf-4d8f-8bee-f38cdda82f5d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4409b82a-e6ea-4f7e-95d1-7a0d31929696"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46c4464f-d299-40c7-b428-cf83ba0d6265"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49a3ae4d-1642-4fd5-b81c-df350b52eb49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5785c8ea-a67b-4386-abaa-7625a93e8062"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a05725d-7f7b-4e46-bd5a-74c73e25c668"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ce748d0-798e-4e7c-9221-bf3072aff854"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5cefb832-8ad7-4ac8-9bf8-793632ac7818"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ea85381-04ba-44d6-a345-e0c451198af4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5eab7373-6526-400b-bf30-df820617628b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60728b17-d01c-45ea-a65b-53b0ccab9600"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("637e84cb-1733-4675-90f1-3a9e0ce9849a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65699d10-112e-4ad9-8731-8fff408c638f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74442023-901f-4179-acc5-4cda82351eca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7451455f-79f1-46e7-8b7d-205f57ce354d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7766e061-dc2d-4456-8f8c-661fa2d00a1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b7385ae-b37b-4fe8-af17-9f568d3f1044"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7bd3bd10-01be-49b0-8caf-9ba703282541"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("807d3ac9-4c74-47ed-a898-5c0e7359f386"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d65c230-0028-47c7-990d-4e161b157b69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8dbfeb3a-9d63-46ef-9bcc-7a746fb3a71e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91d66dbb-f6ab-447b-b0bf-d0ed79317cd8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("980b12c5-5f6a-4e82-8fd7-ed910aebf73d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9da6859d-59fc-4f67-9101-16ca91ee497a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0fd7c63-94d8-47de-b223-7caca6795785"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a56731ac-ac02-4bac-ae63-bf3974901186"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a84b416f-f3cc-4d73-a476-ec5d4ba426d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a8e3fb7f-2153-410d-9966-9849b417da00"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9032a94-6a77-463d-a019-558029b9acac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("acf8011a-1d6a-42b5-9e8f-5211309fd2b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b36f60b5-0ebe-4145-958a-233cc81ece2a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7a15d2b-eda6-475c-a44e-501def7989e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b93310d3-8671-49f1-bea9-98d9fa59dc5f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c09b24a3-203c-49bc-b026-a13f8ae6ace2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c46b41ea-aaf7-42c6-ac31-aa65e6280a24"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8e95ffb-74ea-4ea2-8aa6-910738781fb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c99a177d-04bd-498a-8d82-8f659646b405"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d825620d-c3cf-42c2-9f8b-6909b5573d3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d99c5b1c-0d70-4212-b3f9-17e4431a2251"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dee35ed4-f5ce-43d9-8a4f-cd5e826c23af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1f105b9-4f41-448a-9387-4add7a51ac1e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e2f8a674-47cb-46d6-bea0-5dea3f1b2a27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e6aa9925-d1e6-49eb-aa81-51d6559284c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e7110e26-1bba-44f9-a382-11b9467f31a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e794772a-b7e2-471d-bc3a-3a20525efe21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e820f4ed-2a44-4c5d-a8cc-bc104229eb4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec70d24e-a608-4c06-9ff0-5fd4c7baa70e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eeed9281-171a-49df-bb0a-3850ed7b23d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f250575a-eca4-4363-90ae-54955b3c8d61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4386030-553f-453d-984c-abe1c35cefc7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7c1a61e-4426-4c8d-85d3-a3f0115c16b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fbcea388-6235-48d7-99d4-2bb7497d0645"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fde55c47-4262-43cd-9cdb-1b5a3640c261"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff0a7525-5012-42d5-bb5d-4a7cdafdef2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36b4b607-cd84-48fd-9836-c6675a7a7893"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e557e83-e22b-4996-ab58-a7df54102d85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e23bdbf7-77b5-42a8-bba3-43f12e448031"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "Projections");

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
    }
}
