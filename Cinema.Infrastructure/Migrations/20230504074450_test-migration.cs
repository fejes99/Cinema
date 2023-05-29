using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3f447120-98c3-4d06-bb5d-55adb4f6ba0e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5add3d80-dabb-4b6f-9351-510946d5659a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("67b4211e-36fa-41f1-bb0d-04c49ba37759"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a11e19c2-93a4-4e7b-ae55-60c9db73f5ca"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("aff66548-646d-4ee6-b3ed-1b089569e87b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d7498685-ee3b-4a02-8cc4-ef8812669a7e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dd657905-3f59-4e52-96ab-39101c7e9fcb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e1591225-37bd-4567-b89c-5ad8cd894c53"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f0beee10-2dbc-40a6-af22-afd1e12f54df"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f4f6a93f-3b1b-4ea7-8b21-2aaa3cb5f084"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0166fd85-4ff2-49c8-a2cf-a6e30ce33f47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d245529-6753-4107-bb3b-230b64b9248f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e3842b2-41a4-47c4-a93c-28e8366a3558"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11345c3c-607f-4624-92e6-4d8c34fa026f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13a4f158-e203-4dad-924f-d483e0b65c99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16a67f60-f716-4059-86dc-3049fa79e31e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1da49e82-5757-4b77-ad33-d80a474a7219"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1fd35d0a-0e76-4615-84d6-7e6116be0e79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("239e31e5-4d43-46f7-a414-10c25c796141"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2bccf560-a88b-480b-965c-6bcd1cd0c18a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d859d2c-8be1-4030-baf1-d846887286f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f5c0c89-0b9d-44c0-967b-b440d90b1ceb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38b15c6f-3fdb-483e-a941-ad630011fef3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a2401b6-9517-466b-adf5-c83fd1a0cbc5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a59adca-23d8-4be2-a59e-0373fa5c1cd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("400bcd02-5ff4-4b1d-84e8-a2a6e1ad581d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4146d1fd-c1ae-4d84-a590-a68844366b26"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43ffd46f-da8f-4246-8d4d-8f086113833f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4602be33-13b5-46af-9a71-8deadd35bd4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49e59159-5cd7-46fe-b027-8060d960a896"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("548f98bc-4aed-4f2a-bfa5-3cf6e9ad68d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5aa704a2-37b1-4fc3-bd90-f35b63dff4e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5c692b2c-5986-4760-a23d-3b7889633eb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5eeafe3d-92a1-4084-8b93-f3976ad3c9e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("600aa756-93fd-4383-ac3d-e0901ccbd69b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62cdf12d-ba7e-429b-97ee-d4393a96973a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64a3a3ac-15e2-44ad-a038-772eb6840f59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c3b2740-e052-4ee7-bc8f-d57d3a49eecb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("779a4ce3-b737-416d-9b69-f96054ef999a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7e15cc11-ee26-4d0e-b0f6-e78550ab9cfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8392d943-2362-408c-961a-e5b966470f2b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83a2d9c2-ca71-4ac1-8667-e1a7ebc9ebd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("853c11d2-05e5-4dd3-b018-f8e88b98e878"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85a3776d-07a3-4bf6-a95d-a7c5e8940b6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("892053d8-9c75-4882-a4ac-6cd6b6cada3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89d432d6-91f8-47af-8720-0d70ab13a419"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c4d65a2-838f-4213-b5f3-0d897df4d328"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d7c9198-ad98-431e-b4b0-d98a1cb8a4c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8eeaabde-5e7a-4534-9f14-e14f0898435d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91a3ad07-55e0-42d4-b498-e14dac95b020"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94fc1c8e-7a19-4083-805e-c7be438c6818"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95a4ecc4-e18e-436f-8bce-e91c852335c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e1ca660-8534-4e7f-b09b-01da3bdb0bee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a04ca547-f40c-4346-a604-0fda3f8b6aa9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a04cae4e-fef2-4b46-8cad-61ff121e212a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a121c3da-10fe-4fb2-acb9-c219c707866b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a95f1700-af7d-4c10-bc19-1fc5500226e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aad22070-8e37-4900-92e3-8726af5c3713"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b048f1bb-078d-4371-9b15-0993b2364cdf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7ba6742-5c55-49e5-8ce5-bef304b85412"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be9a35c5-29b9-4648-87f8-47a0a63857d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1b04dc9-3a19-45c2-a40f-41aa9bde743a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2596a9b-7c9c-45bb-85ca-bcf8fab32b8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c4a05b1f-4cb9-42a3-b3a8-15637569da3a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c51ff4bd-ef60-4955-9822-a3d462ef4da5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc05a37c-9262-4a00-8123-9e41f5d6e9bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d42d72ee-fe1a-47ca-8a24-a27ec763e7af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d510b0dd-8274-40d8-9702-52b77672adcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5152049-5ffb-423d-8d03-4fd2e3ca8913"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d75eaf48-56e9-4275-9c9d-65af70e6fedf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d76d9cdb-3d31-4fbb-a510-f441faf8cfb7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8636e35-cb5f-4c06-89b1-27b09b2ccb8f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd43c8a8-1732-42df-b6f5-64c1d762e117"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e526cd1a-d1b9-4495-8468-0c9681a39b47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8aa4b2e-c740-420c-a98f-5aac6332bfee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb583bdf-f4e6-41a8-8df9-9607915306c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebbeefb4-5170-4d6a-a433-bc5ad36bc691"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebe703e5-385e-40d4-9d73-b623a44a68e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0e20a9c-dffc-4505-bb90-b60542fe1a3e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f16a3a0b-ed7e-45d4-aa58-9c35c0c1d3c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f345f7f6-f56b-44e1-9b6a-7c590faf6fd0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6068314-2bd8-459f-8409-9b3f9fc309ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb7998fd-f087-4300-8036-06d20b0c48d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc136324-2262-4d75-b138-fe96bb27d584"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("241d5f88-03ba-4a77-b258-a81db799e363"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81768215-d78f-4dc7-be83-d46e087e1e25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("983c6755-b318-40f3-af5e-697e69d2b49a"));

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("182c655f-a5ed-4811-8c0e-b05de766010d"), new DateTime(2023, 5, 4, 9, 44, 50, 539, DateTimeKind.Local).AddTicks(9855), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" },
                    { new Guid("5ea61f5b-e6f0-4050-bf8c-3f2e5cd41a8c"), new DateTime(2023, 5, 4, 9, 44, 50, 540, DateTimeKind.Local).AddTicks(143), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" },
                    { new Guid("88369948-116e-4e3c-a3a5-922ab47f9f60"), new DateTime(2023, 5, 4, 9, 44, 50, 540, DateTimeKind.Local).AddTicks(125), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("3f447120-98c3-4d06-bb5d-55adb4f6ba0e"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("5add3d80-dabb-4b6f-9351-510946d5659a"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("67b4211e-36fa-41f1-bb0d-04c49ba37759"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("a11e19c2-93a4-4e7b-ae55-60c9db73f5ca"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("aff66548-646d-4ee6-b3ed-1b089569e87b"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("d7498685-ee3b-4a02-8cc4-ef8812669a7e"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("dd657905-3f59-4e52-96ab-39101c7e9fcb"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("e1591225-37bd-4567-b89c-5ad8cd894c53"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("f0beee10-2dbc-40a6-af22-afd1e12f54df"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("f4f6a93f-3b1b-4ea7-8b21-2aaa3cb5f084"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("0166fd85-4ff2-49c8-a2cf-a6e30ce33f47"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0d245529-6753-4107-bb3b-230b64b9248f"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0e3842b2-41a4-47c4-a93c-28e8366a3558"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("11345c3c-607f-4624-92e6-4d8c34fa026f"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("13a4f158-e203-4dad-924f-d483e0b65c99"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("16a67f60-f716-4059-86dc-3049fa79e31e"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1da49e82-5757-4b77-ad33-d80a474a7219"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("1fd35d0a-0e76-4615-84d6-7e6116be0e79"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("239e31e5-4d43-46f7-a414-10c25c796141"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2bccf560-a88b-480b-965c-6bcd1cd0c18a"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2d859d2c-8be1-4030-baf1-d846887286f9"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2f5c0c89-0b9d-44c0-967b-b440d90b1ceb"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("38b15c6f-3fdb-483e-a941-ad630011fef3"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3a2401b6-9517-466b-adf5-c83fd1a0cbc5"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("3a59adca-23d8-4be2-a59e-0373fa5c1cd2"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("400bcd02-5ff4-4b1d-84e8-a2a6e1ad581d"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4146d1fd-c1ae-4d84-a590-a68844366b26"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("43ffd46f-da8f-4246-8d4d-8f086113833f"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("4602be33-13b5-46af-9a71-8deadd35bd4a"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("49e59159-5cd7-46fe-b027-8060d960a896"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("548f98bc-4aed-4f2a-bfa5-3cf6e9ad68d1"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5aa704a2-37b1-4fc3-bd90-f35b63dff4e0"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5c692b2c-5986-4760-a23d-3b7889633eb9"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5eeafe3d-92a1-4084-8b93-f3976ad3c9e5"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("600aa756-93fd-4383-ac3d-e0901ccbd69b"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("62cdf12d-ba7e-429b-97ee-d4393a96973a"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("64a3a3ac-15e2-44ad-a038-772eb6840f59"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6c3b2740-e052-4ee7-bc8f-d57d3a49eecb"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("779a4ce3-b737-416d-9b69-f96054ef999a"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7e15cc11-ee26-4d0e-b0f6-e78550ab9cfc"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8392d943-2362-408c-961a-e5b966470f2b"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("83a2d9c2-ca71-4ac1-8667-e1a7ebc9ebd2"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("853c11d2-05e5-4dd3-b018-f8e88b98e878"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("85a3776d-07a3-4bf6-a95d-a7c5e8940b6f"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("892053d8-9c75-4882-a4ac-6cd6b6cada3d"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("89d432d6-91f8-47af-8720-0d70ab13a419"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8c4d65a2-838f-4213-b5f3-0d897df4d328"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8d7c9198-ad98-431e-b4b0-d98a1cb8a4c3"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8eeaabde-5e7a-4534-9f14-e14f0898435d"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("91a3ad07-55e0-42d4-b498-e14dac95b020"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("94fc1c8e-7a19-4083-805e-c7be438c6818"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("95a4ecc4-e18e-436f-8bce-e91c852335c7"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9e1ca660-8534-4e7f-b09b-01da3bdb0bee"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a04ca547-f40c-4346-a604-0fda3f8b6aa9"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a04cae4e-fef2-4b46-8cad-61ff121e212a"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("a121c3da-10fe-4fb2-acb9-c219c707866b"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a95f1700-af7d-4c10-bc19-1fc5500226e5"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("aad22070-8e37-4900-92e3-8726af5c3713"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b048f1bb-078d-4371-9b15-0993b2364cdf"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b7ba6742-5c55-49e5-8ce5-bef304b85412"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("be9a35c5-29b9-4648-87f8-47a0a63857d6"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c1b04dc9-3a19-45c2-a40f-41aa9bde743a"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("c2596a9b-7c9c-45bb-85ca-bcf8fab32b8b"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c4a05b1f-4cb9-42a3-b3a8-15637569da3a"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c51ff4bd-ef60-4955-9822-a3d462ef4da5"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("cc05a37c-9262-4a00-8123-9e41f5d6e9bc"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d42d72ee-fe1a-47ca-8a24-a27ec763e7af"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d510b0dd-8274-40d8-9702-52b77672adcc"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d5152049-5ffb-423d-8d03-4fd2e3ca8913"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d75eaf48-56e9-4275-9c9d-65af70e6fedf"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d76d9cdb-3d31-4fbb-a510-f441faf8cfb7"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d8636e35-cb5f-4c06-89b1-27b09b2ccb8f"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("dd43c8a8-1732-42df-b6f5-64c1d762e117"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e526cd1a-d1b9-4495-8468-0c9681a39b47"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("e8aa4b2e-c740-420c-a98f-5aac6332bfee"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("eb583bdf-f4e6-41a8-8df9-9607915306c2"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ebbeefb4-5170-4d6a-a433-bc5ad36bc691"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ebe703e5-385e-40d4-9d73-b623a44a68e4"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f0e20a9c-dffc-4505-bb90-b60542fe1a3e"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f16a3a0b-ed7e-45d4-aa58-9c35c0c1d3c1"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("f345f7f6-f56b-44e1-9b6a-7c590faf6fd0"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f6068314-2bd8-459f-8409-9b3f9fc309ee"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fb7998fd-f087-4300-8036-06d20b0c48d2"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("fc136324-2262-4d75-b138-fe96bb27d584"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("241d5f88-03ba-4a77-b258-a81db799e363"), new DateTime(2023, 5, 4, 9, 38, 19, 569, DateTimeKind.Local).AddTicks(4361), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" },
                    { new Guid("81768215-d78f-4dc7-be83-d46e087e1e25"), new DateTime(2023, 5, 4, 9, 38, 19, 569, DateTimeKind.Local).AddTicks(4520), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" },
                    { new Guid("983c6755-b318-40f3-af5e-697e69d2b49a"), new DateTime(2023, 5, 4, 9, 38, 19, 569, DateTimeKind.Local).AddTicks(4504), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" }
                });
        }
    }
}
