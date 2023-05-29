using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class usersrestore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("12cefbaa-61e1-407c-9fa1-74fdc3fe5ba6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("22104d45-4a93-4a7e-9189-26a520aa5091"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("49f0ffb3-9ae1-428e-96e8-f28edb4569e5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5d0ccc10-f7b7-4041-9c3a-edd913000ff3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8dd3cd93-9c6c-4811-857e-e434b3b51880"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d0d48794-3f8c-4260-ba85-f2044022d8cf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d734a0a7-4c33-4465-bfc8-34378f5da464"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ddba394f-5fbc-420d-82d0-c1799e8479de"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e85cd689-34de-4e9f-b328-a91880f18803"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fc562630-1df0-4929-a479-8c4ebc1febd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("037f62bd-fc7e-4ec1-90db-c4f0d7204cbd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("070b929d-abc1-4b8d-834f-e2e422468ef0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08659c4d-7f73-456c-91b2-82a48034a823"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d41e12c-6e19-442d-8163-b938978c63a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e0e56ee-1ea1-474d-84ae-6dcf9930f1e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12b8d05a-01ef-4d11-adf8-851e2ad93c0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14d634ba-4a8d-41db-9531-bf83e00ace04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ecae618-7ebc-410e-8742-3c288d79e2b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ef5d4d9-7ed0-44b3-b84d-8f650e04c806"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21d09b1a-2059-4e1a-bd77-a8d614ec23a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2679ee15-0d1b-4252-9d16-088506803e67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("267eb3e9-5cbd-4f9e-bba3-f6ef638a4353"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b33de4b-833a-439a-87f2-ea3ea78fd121"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f74e7f0-f823-439d-b7f1-297345a15016"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("335f155c-ccb1-415f-ad1d-f72f091e733a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34800704-b47e-42f5-8686-07981809f673"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("36a40109-cfd4-49a4-b556-05be1efea041"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3995f8f3-39c0-41bb-9626-2bf6592eacb8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3fa68a1b-4f95-4de6-b4d8-0a21e1cb06f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46cfebeb-8066-43db-82d1-240f51b1c4a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ba10cce-5a5d-48c7-8f14-015517a9f20b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d2fb36b-aa7d-46d1-a043-e3511835d5e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4eb6148f-c7e3-44df-9aa3-f3c753d18564"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f6acdf6-595b-46a9-8dea-bb7bec7e6069"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5adb34d2-fd3e-4c04-b7cd-6ebc4667123d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5dfedcdf-d12a-409d-a4a7-56b98fadf957"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e23575d-11ea-4d0e-8689-52f3b1a4bf6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f5bbba4-bc5b-497a-a417-b7512d517752"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6127ebf0-cacc-4494-bd3e-c9e5f54049fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61cc2105-1c67-4f8a-9398-a6e7fd8758ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64a24834-7ff5-482e-924d-639b7be53802"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6629ca47-7ea6-4923-a6a4-87d5a91c7fef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67e65719-bffd-4dc2-badd-2a2a28e862fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6a478321-2ccd-491b-a8b3-cad7dcbf8248"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d90ead8-d627-4c35-aff7-3bdcc1774289"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77b85ea2-1808-4c87-9b37-801d25bd243b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7aebf520-ecec-4887-b44d-ab2b476bf20a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d95d866-5f12-4dc6-8915-146e23e83272"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8463e933-955a-4d9e-8355-c12e03afb729"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cb6be0e-c2e2-499a-bfac-b4c5871ebc38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8daa14fa-ed33-4973-8fb8-d83f974b8471"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90bfbc20-f9a5-453c-90c7-c445ce327128"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("931676b5-006f-4f82-a64c-0ee6b56f2180"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("965a3f20-aa6a-4fe8-a61d-040864b95f8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("96d74d9f-652e-4289-92b5-8cfbf74b9a80"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97e72392-0571-4656-ba43-6e95177a214d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99571443-7cf5-4f76-af3b-3d22bd9badcf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ba522e5-001b-419a-84ed-3fe355a443fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c7f8727-4083-4194-a967-6424b0ceb565"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d5c45a1-7e41-4715-a858-54bf2da3ee4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a05459d1-3166-4adb-a54c-1296cd31a57e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a3d0866e-d9a4-415c-a44d-38179db7f0fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b091ad2c-1b8f-4a0d-a896-4ae96810c83f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7ce41ec-c81c-496a-adac-69ee62376711"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c174210a-6198-463f-aff7-544593d4d26a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2b0b1c4-af4b-4ba9-bc2c-ad39719d67ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8dcaf24-c614-47c2-85ca-21a1b57b46ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9565754-19ed-447f-bfc2-ee7c92472236"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("caaba330-79b4-4e4f-a742-669103861e2c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbbe64ff-5f58-44c8-960d-7497ca0c5988"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd0a7def-09db-4a10-aa7c-7039003ea251"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce82626d-a33f-4af0-a962-60d7bf42074e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2e0bc5f-2597-4b83-b831-f462f922ee60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d908f6a2-f881-4b49-b56b-d58e10dff90d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da41a5ef-bd38-4784-b651-8c2398865961"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da5fb393-9b7b-4ae1-832c-a1ec245f4fe8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df88e24d-5f23-47c6-874c-44f8be9e7491"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0313f2e-c56d-4610-ae57-0596033954fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8c8626f-4fc6-4f32-8d64-f15d38884c44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebf00422-0286-4ea1-85b6-7f73536dd4c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed297899-9c1e-4589-bdb6-bbc8eb175275"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efaf1804-50a6-40dd-a816-8dda9e83f176"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8c61687-9565-4510-8f5d-9abe751b61f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb18b695-e7a1-4c1e-9143-c50bff07c270"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("182c655f-a5ed-4811-8c0e-b05de766010d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ea61f5b-e6f0-4050-bf8c-3f2e5cd41a8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88369948-116e-4e3c-a3a5-922ab47f9f60"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("203a6a52-0663-4051-bc36-6c08e3699984"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("32d566e0-e635-4c50-bc11-b9beb09d2d3b"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("4d9f2eba-1554-41c5-8f43-c462223038d6"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("5f37ba7d-5445-4ef3-b9d8-97749367941b"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("635d4c70-f55d-425e-8ebe-4e2db1239424"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("69c8bbb5-d924-47f8-aeb0-6de7cfb8e4aa"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("74497798-36c5-4fa4-ae5a-3c1a1e2dbb04"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("9ab798d5-efeb-40a2-b78d-c6667e2c47a4"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("c4fcfe6d-7ad8-4d12-809e-fafb3dd6b9ec"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("e801500e-629d-4461-b364-256195006ade"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("03ae070d-0fb8-4f85-8e05-d0bd647345ac"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("03da4c0c-0644-48ab-becc-340ee5bc2bc7"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("058f4061-b01a-4ff0-b48e-b8d3d64d8b04"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("0850b27c-ff13-4e5f-a75e-9890219e9450"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0aecc7ba-75b3-4604-b97b-54a0d3f49e94"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0d01bd7a-7f30-4052-853a-83a437e5ec88"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("12db7f63-c1b3-4763-8526-dbd1b6c3ebab"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("16b08344-2c12-497a-b24c-079e36afcc08"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("17a39ab7-1ced-421f-8b9c-bcd887c7a54e"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1a3e55c0-66ce-4489-8ea6-d456263d01ba"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("260750df-bd1b-499c-86be-26ff0fe3c2dc"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("290501f7-efdf-4609-bbed-2fa3d6745b9f"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2cd7bd23-b6ef-4d6d-a47f-0a30547f36a3"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("32962939-3049-41cd-9060-0dff5711a66f"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("34292eaa-befb-40b5-b145-4d74039475be"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3f13cf85-5a15-4e53-b8fc-3c88dfc77a95"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("40e06801-75d7-4396-a977-019e3dd6e57a"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("410cf105-349e-4201-954c-e43f2fdc167b"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("45fa2df6-5209-4e20-9173-5ececf3fdcab"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("49491720-82c6-40ef-bc0d-d03c04a8fc4e"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4c2e80ab-7c10-4d5f-bed8-8eefba53286e"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("4eff53eb-430b-4c29-acfd-069044379d5d"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4f32b6da-89b4-425d-8971-06af3a4cde8c"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("503b9474-2a93-4ace-b3cd-443cfd530071"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5102090f-c925-4b36-b5bc-4842e586b053"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("5ffc2795-0dcf-40e3-ab73-121e788ec8a6"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("6139dd7c-8028-43aa-9dd0-28e25030724c"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("6147c67e-1f17-48ec-abad-098485db4d78"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("636babfa-39dc-4524-8636-bd4efac34be9"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("6501744d-ba06-48ba-b146-b4c3af6e8572"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("655b827d-497c-45aa-a064-c73215398686"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("678981a9-34b3-4cef-aa01-130acedfa0f1"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6931aaf6-efee-4b0d-9bb6-d02d68c63947"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6fcac737-2106-4bd0-9349-8b015cbe3043"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("72d2c31d-f3d7-4ecb-a0f9-5b7a58dd8e30"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7709430c-b231-4e9a-b248-ec5599e68c7f"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("770ecfc5-4797-4c79-91f7-ae05bfd4abd0"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("852e51c9-ebc6-48eb-80ff-038c17704f3e"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("86f41cd6-0346-4fbd-9511-4e349f102b43"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("887838ad-733b-406d-bf62-71aafda05f99"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8a68090c-5947-4e23-b9ec-53c2dd5a6404"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8f9ae661-614e-4b5c-a06d-3de5dc04fb09"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("9087fcad-91e8-49a8-bb2d-a04b9bc159d5"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("966a8394-12f0-4193-ba39-7ea8799d6907"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9fdc40a5-47bf-4426-b93f-2fda1c6068c4"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a1d77d40-0987-4b11-b0f1-5605992ee319"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ad96b9df-3895-4877-8547-bcbe286a895b"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("adb313d8-adc3-4899-a99d-9f4c88ebf98b"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b19634b3-a945-4a08-ad60-458bd02057ff"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b77bd99f-6a29-45ab-9750-876c85e6581e"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("bce6435d-b2de-4829-9c91-3e982be56747"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("bd13b66d-34bb-4dac-90d6-9853720f9913"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bd518258-106b-48fb-9473-0060b12d76ad"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("bde76af7-3679-4b4b-b785-e965585305f7"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c410c012-3855-4598-b9e9-87d444bc9073"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c6a1521c-c1ad-49fe-bc20-95ba4a684041"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c7929967-a862-4ad5-834f-23e133fed343"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c83f5e7d-2e34-4ccf-ac97-67181d702cea"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("cc7ea70c-9372-48f4-845c-66038bef4e2d"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("ce26fbba-7e3f-4e18-a011-09e224eacee7"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("cebd8988-674e-462c-8745-64e15ec6cc5c"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d0ae327d-97bd-4028-9422-a1a29061cbe4"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d4edd994-0628-4e12-9058-153ce09f027f"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d51538be-9a2f-4f59-95fb-f0fd7ae6c80b"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d5d1ab53-64c9-4fdb-b6d0-fcac8e9d1ea6"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d787ebb2-e259-40cb-9810-975b4ef68844"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("dc5f595a-b2b4-4b0b-a410-cd37eae11e1a"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("dcaf6b6f-d85f-498c-bb63-d4a3ecd3a266"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("eb452ffd-d725-4c19-a046-8e40a2ddffc7"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("eea7e419-8515-4ea7-84d8-5d6b28694a14"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f16e7f11-f30c-4b67-a203-e92333045329"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f51858cb-a5d0-43e1-87e0-b0b5780ad0fc"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("fa065e14-832f-4ff7-b313-765eafa7557e"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("fc3b0ed9-ae84-4ced-851a-20d1a483cc3d"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") }
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("4836b57f-9204-486a-9d00-05a906c92c1c"), new DateTime(2023, 5, 4, 10, 14, 15, 926, DateTimeKind.Local).AddTicks(3173), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" },
                    { new Guid("69aa0a75-8e21-4645-a5d7-4931a91c3bf1"), new DateTime(2023, 5, 4, 10, 14, 15, 926, DateTimeKind.Local).AddTicks(3189), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" },
                    { new Guid("c0a05dad-2f97-4b20-a456-9ace057ba6b6"), new DateTime(2023, 5, 4, 10, 14, 15, 926, DateTimeKind.Local).AddTicks(3002), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("203a6a52-0663-4051-bc36-6c08e3699984"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("32d566e0-e635-4c50-bc11-b9beb09d2d3b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4d9f2eba-1554-41c5-8f43-c462223038d6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5f37ba7d-5445-4ef3-b9d8-97749367941b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("635d4c70-f55d-425e-8ebe-4e2db1239424"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("69c8bbb5-d924-47f8-aeb0-6de7cfb8e4aa"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("74497798-36c5-4fa4-ae5a-3c1a1e2dbb04"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9ab798d5-efeb-40a2-b78d-c6667e2c47a4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c4fcfe6d-7ad8-4d12-809e-fafb3dd6b9ec"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e801500e-629d-4461-b364-256195006ade"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03ae070d-0fb8-4f85-8e05-d0bd647345ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03da4c0c-0644-48ab-becc-340ee5bc2bc7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("058f4061-b01a-4ff0-b48e-b8d3d64d8b04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0850b27c-ff13-4e5f-a75e-9890219e9450"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0aecc7ba-75b3-4604-b97b-54a0d3f49e94"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d01bd7a-7f30-4052-853a-83a437e5ec88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12db7f63-c1b3-4763-8526-dbd1b6c3ebab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16b08344-2c12-497a-b24c-079e36afcc08"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17a39ab7-1ced-421f-8b9c-bcd887c7a54e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a3e55c0-66ce-4489-8ea6-d456263d01ba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("260750df-bd1b-499c-86be-26ff0fe3c2dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("290501f7-efdf-4609-bbed-2fa3d6745b9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cd7bd23-b6ef-4d6d-a47f-0a30547f36a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32962939-3049-41cd-9060-0dff5711a66f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34292eaa-befb-40b5-b145-4d74039475be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f13cf85-5a15-4e53-b8fc-3c88dfc77a95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40e06801-75d7-4396-a977-019e3dd6e57a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("410cf105-349e-4201-954c-e43f2fdc167b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45fa2df6-5209-4e20-9173-5ececf3fdcab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49491720-82c6-40ef-bc0d-d03c04a8fc4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c2e80ab-7c10-4d5f-bed8-8eefba53286e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4eff53eb-430b-4c29-acfd-069044379d5d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f32b6da-89b4-425d-8971-06af3a4cde8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("503b9474-2a93-4ace-b3cd-443cfd530071"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5102090f-c925-4b36-b5bc-4842e586b053"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ffc2795-0dcf-40e3-ab73-121e788ec8a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6139dd7c-8028-43aa-9dd0-28e25030724c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6147c67e-1f17-48ec-abad-098485db4d78"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("636babfa-39dc-4524-8636-bd4efac34be9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6501744d-ba06-48ba-b146-b4c3af6e8572"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("655b827d-497c-45aa-a064-c73215398686"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("678981a9-34b3-4cef-aa01-130acedfa0f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6931aaf6-efee-4b0d-9bb6-d02d68c63947"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fcac737-2106-4bd0-9349-8b015cbe3043"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72d2c31d-f3d7-4ecb-a0f9-5b7a58dd8e30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7709430c-b231-4e9a-b248-ec5599e68c7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("770ecfc5-4797-4c79-91f7-ae05bfd4abd0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("852e51c9-ebc6-48eb-80ff-038c17704f3e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86f41cd6-0346-4fbd-9511-4e349f102b43"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("887838ad-733b-406d-bf62-71aafda05f99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a68090c-5947-4e23-b9ec-53c2dd5a6404"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f9ae661-614e-4b5c-a06d-3de5dc04fb09"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9087fcad-91e8-49a8-bb2d-a04b9bc159d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("966a8394-12f0-4193-ba39-7ea8799d6907"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9fdc40a5-47bf-4426-b93f-2fda1c6068c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1d77d40-0987-4b11-b0f1-5605992ee319"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad96b9df-3895-4877-8547-bcbe286a895b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("adb313d8-adc3-4899-a99d-9f4c88ebf98b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b19634b3-a945-4a08-ad60-458bd02057ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b77bd99f-6a29-45ab-9750-876c85e6581e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bce6435d-b2de-4829-9c91-3e982be56747"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd13b66d-34bb-4dac-90d6-9853720f9913"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd518258-106b-48fb-9473-0060b12d76ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bde76af7-3679-4b4b-b785-e965585305f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c410c012-3855-4598-b9e9-87d444bc9073"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6a1521c-c1ad-49fe-bc20-95ba4a684041"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7929967-a862-4ad5-834f-23e133fed343"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c83f5e7d-2e34-4ccf-ac97-67181d702cea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc7ea70c-9372-48f4-845c-66038bef4e2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce26fbba-7e3f-4e18-a011-09e224eacee7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cebd8988-674e-462c-8745-64e15ec6cc5c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0ae327d-97bd-4028-9422-a1a29061cbe4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4edd994-0628-4e12-9058-153ce09f027f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d51538be-9a2f-4f59-95fb-f0fd7ae6c80b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5d1ab53-64c9-4fdb-b6d0-fcac8e9d1ea6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d787ebb2-e259-40cb-9810-975b4ef68844"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc5f595a-b2b4-4b0b-a410-cd37eae11e1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dcaf6b6f-d85f-498c-bb63-d4a3ecd3a266"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb452ffd-d725-4c19-a046-8e40a2ddffc7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eea7e419-8515-4ea7-84d8-5d6b28694a14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f16e7f11-f30c-4b67-a203-e92333045329"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f51858cb-a5d0-43e1-87e0-b0b5780ad0fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa065e14-832f-4ff7-b313-765eafa7557e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc3b0ed9-ae84-4ced-851a-20d1a483cc3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4836b57f-9204-486a-9d00-05a906c92c1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69aa0a75-8e21-4645-a5d7-4931a91c3bf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0a05dad-2f97-4b20-a456-9ace057ba6b6"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("12cefbaa-61e1-407c-9fa1-74fdc3fe5ba6"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("22104d45-4a93-4a7e-9189-26a520aa5091"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("49f0ffb3-9ae1-428e-96e8-f28edb4569e5"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("5d0ccc10-f7b7-4041-9c3a-edd913000ff3"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("8dd3cd93-9c6c-4811-857e-e434b3b51880"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("d0d48794-3f8c-4260-ba85-f2044022d8cf"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("d734a0a7-4c33-4465-bfc8-34378f5da464"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("ddba394f-5fbc-420d-82d0-c1799e8479de"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("e85cd689-34de-4e9f-b328-a91880f18803"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("fc562630-1df0-4929-a479-8c4ebc1febd5"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("037f62bd-fc7e-4ec1-90db-c4f0d7204cbd"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("070b929d-abc1-4b8d-834f-e2e422468ef0"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("08659c4d-7f73-456c-91b2-82a48034a823"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0d41e12c-6e19-442d-8163-b938978c63a7"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("0e0e56ee-1ea1-474d-84ae-6dcf9930f1e2"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("12b8d05a-01ef-4d11-adf8-851e2ad93c0a"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("14d634ba-4a8d-41db-9531-bf83e00ace04"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1ecae618-7ebc-410e-8742-3c288d79e2b8"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1ef5d4d9-7ed0-44b3-b84d-8f650e04c806"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("21d09b1a-2059-4e1a-bd77-a8d614ec23a7"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2679ee15-0d1b-4252-9d16-088506803e67"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("267eb3e9-5cbd-4f9e-bba3-f6ef638a4353"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("2b33de4b-833a-439a-87f2-ea3ea78fd121"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2f74e7f0-f823-439d-b7f1-297345a15016"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("335f155c-ccb1-415f-ad1d-f72f091e733a"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("34800704-b47e-42f5-8686-07981809f673"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("36a40109-cfd4-49a4-b556-05be1efea041"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3995f8f3-39c0-41bb-9626-2bf6592eacb8"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3fa68a1b-4f95-4de6-b4d8-0a21e1cb06f7"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("46cfebeb-8066-43db-82d1-240f51b1c4a5"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4ba10cce-5a5d-48c7-8f14-015517a9f20b"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4d2fb36b-aa7d-46d1-a043-e3511835d5e9"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4eb6148f-c7e3-44df-9aa3-f3c753d18564"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("4f6acdf6-595b-46a9-8dea-bb7bec7e6069"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5adb34d2-fd3e-4c04-b7cd-6ebc4667123d"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5dfedcdf-d12a-409d-a4a7-56b98fadf957"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5e23575d-11ea-4d0e-8689-52f3b1a4bf6e"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5f5bbba4-bc5b-497a-a417-b7512d517752"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6127ebf0-cacc-4494-bd3e-c9e5f54049fe"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("61cc2105-1c67-4f8a-9398-a6e7fd8758ae"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("64a24834-7ff5-482e-924d-639b7be53802"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("6629ca47-7ea6-4923-a6a4-87d5a91c7fef"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("67e65719-bffd-4dc2-badd-2a2a28e862fa"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6a478321-2ccd-491b-a8b3-cad7dcbf8248"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("6d90ead8-d627-4c35-aff7-3bdcc1774289"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("77b85ea2-1808-4c87-9b37-801d25bd243b"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("7aebf520-ecec-4887-b44d-ab2b476bf20a"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7d95d866-5f12-4dc6-8915-146e23e83272"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8463e933-955a-4d9e-8355-c12e03afb729"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8cb6be0e-c2e2-499a-bfac-b4c5871ebc38"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8daa14fa-ed33-4973-8fb8-d83f974b8471"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("90bfbc20-f9a5-453c-90c7-c445ce327128"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("931676b5-006f-4f82-a64c-0ee6b56f2180"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("965a3f20-aa6a-4fe8-a61d-040864b95f8c"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("96d74d9f-652e-4289-92b5-8cfbf74b9a80"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("97e72392-0571-4656-ba43-6e95177a214d"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("99571443-7cf5-4f76-af3b-3d22bd9badcf"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9ba522e5-001b-419a-84ed-3fe355a443fe"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9c7f8727-4083-4194-a967-6424b0ceb565"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9d5c45a1-7e41-4715-a858-54bf2da3ee4a"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a05459d1-3166-4adb-a54c-1296cd31a57e"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a3d0866e-d9a4-415c-a44d-38179db7f0fb"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b091ad2c-1b8f-4a0d-a896-4ae96810c83f"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b7ce41ec-c81c-496a-adac-69ee62376711"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c174210a-6198-463f-aff7-544593d4d26a"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c2b0b1c4-af4b-4ba9-bc2c-ad39719d67ce"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c8dcaf24-c614-47c2-85ca-21a1b57b46ec"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c9565754-19ed-447f-bfc2-ee7c92472236"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("caaba330-79b4-4e4f-a742-669103861e2c"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("cbbe64ff-5f58-44c8-960d-7497ca0c5988"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cd0a7def-09db-4a10-aa7c-7039003ea251"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("ce82626d-a33f-4af0-a962-60d7bf42074e"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d2e0bc5f-2597-4b83-b831-f462f922ee60"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d908f6a2-f881-4b49-b56b-d58e10dff90d"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("da41a5ef-bd38-4784-b651-8c2398865961"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("da5fb393-9b7b-4ae1-832c-a1ec245f4fe8"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("df88e24d-5f23-47c6-874c-44f8be9e7491"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e0313f2e-c56d-4610-ae57-0596033954fd"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e8c8626f-4fc6-4f32-8d64-f15d38884c44"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("ebf00422-0286-4ea1-85b6-7f73536dd4c1"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ed297899-9c1e-4589-bdb6-bbc8eb175275"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("efaf1804-50a6-40dd-a816-8dda9e83f176"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("f8c61687-9565-4510-8f5d-9abe751b61f2"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("fb18b695-e7a1-4c1e-9143-c50bff07c270"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") }
                });

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
