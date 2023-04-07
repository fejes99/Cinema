using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed_seat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("135789f9-ddab-4ec4-b512-099dc79f54ec"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("298f34ea-87bb-40dc-bc8b-dbc72eccfd7f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4bf91c57-1a63-4b20-9522-58183fc6dec0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7ac355da-f2ac-49b5-86e2-add2b01fe094"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7f61e3ab-bc7a-498a-bdef-5b1c841e3040"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ac035726-76db-429e-9a89-7073f188ff79"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b25af7bc-a370-4103-9527-2ba9f1600f28"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b6c12067-834e-42c8-a75c-fc9d77eb867d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c6cf9c38-9aa3-42d6-b6a8-7da3b0864fe1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ddf521b2-55da-4dad-82a8-9bd43136f0cc"));

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    TheaterId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("2d56706c-c8d3-4e07-81ad-ecee50c3c2ed"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", 2023 },
                    { new Guid("2e3748a0-312d-46bb-b340-1b7361d871f1"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", 2022 },
                    { new Guid("2f488e60-5b6c-4fb9-842a-eeb3b3c378d4"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", 2022 },
                    { new Guid("42ccf832-5657-4135-8075-93ac62a8555d"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", 2023 },
                    { new Guid("7b212d8b-52d0-4873-a44c-3b7fcd5c0df3"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", 2023 },
                    { new Guid("7d2000bd-6486-4dd7-be04-de9e62308d05"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", 2022 },
                    { new Guid("90a5c670-5b13-4114-9188-bacffffa5e87"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", 2022 },
                    { new Guid("a788b166-3e65-4cf2-a373-fd3c46f24f6f"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", 2023 },
                    { new Guid("d2fc81a6-f966-49c5-9f15-e00605c74b6b"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", 2023 },
                    { new Guid("e14fa2f8-75a5-4b30-a3f2-2deb8e522532"), "France", "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.", "James Huth", "MegaCom Film", 112, "Le nouveau jouet", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("00fb2b8e-c9d5-408d-b229-859ff1751996"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0227baf1-4397-4437-adc9-cf63a219dfab"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("09b37d5d-33b5-48c9-a2c6-590fe8fd86c0"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("09e6f5cc-0c30-4542-b6fc-bc3e98552ac6"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0d964816-9e92-4e06-a3a7-e59db0108c79"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0e60d2f7-1507-49ea-b9c2-6bade76d99b1"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0f93ca5a-80e0-4cbf-98af-c2c7e6db045f"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("12ee648a-aafe-4da2-8f4c-25922f47c65e"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("170f9b2a-d955-49d7-8080-f7f9d2de6f39"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("1a20fd04-5cfd-4630-8134-3b47612aab60"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1e26da84-d2c2-4442-a808-f057083f1bbc"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1f89428a-c813-42cc-9e22-2d56b2f67712"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("22bd892c-23ef-4045-8acc-e2dbacd69604"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2399a6a4-0c92-4f34-b504-478bc1cda29c"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("25468896-3009-4f33-9c0b-97bcb0ca5ac4"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("257eaaf7-8495-4d1d-ba8e-4663b8357f84"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("274de24e-cbbf-462f-ad84-37e536e23c0b"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2b1184d1-5f8b-41fb-b3d0-45887b7abc83"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2c8b3f44-7b43-44df-ac69-8a2d7f582fb2"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("2cb28272-4917-4cd7-acc5-478cfbdfb075"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("33e3d501-1ca7-4eb6-8306-6ec8f6563e75"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("399a07b4-4316-4968-9b7c-90082f195ee4"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3aa94d43-f5ed-4ca8-b23c-84a05841f154"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("3bfa7b47-b7d1-4e01-a9f0-8e10ed3e7834"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3ff41ddd-a891-4c08-af07-a8d9876414a9"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("43929a1f-07d8-4ecb-8ec6-caf86fb38b61"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("44223d41-df60-4b88-b4e0-8d0ef2004a7c"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("46057102-6dc6-4fda-a1c1-dd4c9301102f"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4881ae91-531b-4eef-af9d-061fa0ef2938"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4cd090df-1bbe-45b9-aecb-7907e2d1dedb"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4eaa2901-07df-46dd-a308-f91b4350b066"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("53418da8-db38-4edd-81e5-deef870e3b1d"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("53a296bc-cd9b-408d-a3c2-87886dccc5a2"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("53ff27be-acb9-4e60-a0a5-3863b0334de5"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("590f838e-9be1-483f-863c-21a13497e98f"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5c4f9a6e-9929-4c1a-9d26-1b5af42f5542"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("60f6af85-226d-4227-97ab-02ec120ac51b"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("649fda8c-0ce7-4535-8182-0bec3abb67b3"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("75090149-da0a-46e3-ac78-dfde5d1da8dd"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("75989ec0-ee7c-4362-a9cb-39b71fc78d42"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("766dcaef-c251-4cf9-8c50-16302c9d9deb"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7b6241f4-8239-40c8-ab87-a3a829f9b174"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("7d3b5b39-a42f-4e1c-9dab-a8de2f5af99b"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7d81dcc1-ef65-44c5-9297-4d2002795b1b"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("82c6b566-60c9-413f-bab4-140450bcafdb"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("83c3e666-1c27-4ca7-b99d-11aa6a67a288"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("83fb2826-74b8-43b4-9d9d-6b581bfe3112"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8536d652-45c5-41e1-a5b0-fa18edecbbeb"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("871770a2-0664-4638-8bf2-a9b31f5ae5ac"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8e7efaea-ebad-4f95-8518-b43328b05171"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("90f6a815-3f91-496e-931d-a9c414bb0e15"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9797b42f-2614-45dc-8732-bf8fe6515301"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("994bca66-af81-411c-8512-ba69818aaf9f"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9ca9422d-7268-4c6f-bc26-7a319b423fb8"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9f3a6235-cab1-4a2f-9c47-7ae3184514df"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a1fac40c-5455-41e4-87ce-ebd49dfb2018"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("ac11a264-a03c-4043-8705-64d5f0771d2b"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ae63a880-4805-40aa-9466-8278657ff279"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("b17cbedf-d2fc-4d72-be97-bff1ed18361d"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("b3808847-ad98-4761-94df-f2be18ba7bac"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("ba37bc67-eb70-4696-8760-9cefff95372f"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("baa49091-9ed6-49ae-8060-22e0da0892fb"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c18a92d8-08f2-4025-874f-c3ccdd0bd1d6"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c6bfc7bf-ffc7-4d41-b9bf-899555787e16"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("c893e61f-033b-4f40-a5b3-0278d525f274"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cb0a9984-ab92-46bd-b9b8-3dfd79f0ab68"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d1a3629a-7e5f-4b77-b355-40acf6e4a592"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d2a6472d-06f3-4cf1-a15f-fa213510e855"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d4c77e0a-c874-41aa-99d4-8d29aad15afb"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d54313fd-29bf-4a16-87d5-3cadb007b014"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d935933b-168a-4a5a-a755-715b29133566"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("daa1df14-86a3-4e23-9862-242d96bac79b"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e24b63cc-5d2c-4227-ac8b-6d0aaf18c3f1"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("e27bf4ce-ea52-4704-8c2d-17e5165973d0"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TheaterId",
                table: "Seats",
                column: "TheaterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2d56706c-c8d3-4e07-81ad-ecee50c3c2ed"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2e3748a0-312d-46bb-b340-1b7361d871f1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2f488e60-5b6c-4fb9-842a-eeb3b3c378d4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("42ccf832-5657-4135-8075-93ac62a8555d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7b212d8b-52d0-4873-a44c-3b7fcd5c0df3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7d2000bd-6486-4dd7-be04-de9e62308d05"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("90a5c670-5b13-4114-9188-bacffffa5e87"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a788b166-3e65-4cf2-a373-fd3c46f24f6f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d2fc81a6-f966-49c5-9f15-e00605c74b6b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e14fa2f8-75a5-4b30-a3f2-2deb8e522532"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("135789f9-ddab-4ec4-b512-099dc79f54ec"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", 2023 },
                    { new Guid("298f34ea-87bb-40dc-bc8b-dbc72eccfd7f"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", 2022 },
                    { new Guid("4bf91c57-1a63-4b20-9522-58183fc6dec0"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", 2023 },
                    { new Guid("7ac355da-f2ac-49b5-86e2-add2b01fe094"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", 2022 },
                    { new Guid("7f61e3ab-bc7a-498a-bdef-5b1c841e3040"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", 2023 },
                    { new Guid("ac035726-76db-429e-9a89-7073f188ff79"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", 2022 },
                    { new Guid("b25af7bc-a370-4103-9527-2ba9f1600f28"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", 2022 },
                    { new Guid("b6c12067-834e-42c8-a75c-fc9d77eb867d"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", 2023 },
                    { new Guid("c6cf9c38-9aa3-42d6-b6a8-7da3b0864fe1"), "France", "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.", "James Huth", "MegaCom Film", 112, "Le nouveau jouet", 2022 },
                    { new Guid("ddf521b2-55da-4dad-82a8-9bd43136f0cc"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", 2023 }
                });
        }
    }
}
