using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00fb2b8e-c9d5-408d-b229-859ff1751996"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0227baf1-4397-4437-adc9-cf63a219dfab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09b37d5d-33b5-48c9-a2c6-590fe8fd86c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09e6f5cc-0c30-4542-b6fc-bc3e98552ac6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d964816-9e92-4e06-a3a7-e59db0108c79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e60d2f7-1507-49ea-b9c2-6bade76d99b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f93ca5a-80e0-4cbf-98af-c2c7e6db045f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12ee648a-aafe-4da2-8f4c-25922f47c65e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("170f9b2a-d955-49d7-8080-f7f9d2de6f39"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a20fd04-5cfd-4630-8134-3b47612aab60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e26da84-d2c2-4442-a808-f057083f1bbc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f89428a-c813-42cc-9e22-2d56b2f67712"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22bd892c-23ef-4045-8acc-e2dbacd69604"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2399a6a4-0c92-4f34-b504-478bc1cda29c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25468896-3009-4f33-9c0b-97bcb0ca5ac4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("257eaaf7-8495-4d1d-ba8e-4663b8357f84"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("274de24e-cbbf-462f-ad84-37e536e23c0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b1184d1-5f8b-41fb-b3d0-45887b7abc83"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c8b3f44-7b43-44df-ac69-8a2d7f582fb2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cb28272-4917-4cd7-acc5-478cfbdfb075"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33e3d501-1ca7-4eb6-8306-6ec8f6563e75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("399a07b4-4316-4968-9b7c-90082f195ee4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3aa94d43-f5ed-4ca8-b23c-84a05841f154"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bfa7b47-b7d1-4e01-a9f0-8e10ed3e7834"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ff41ddd-a891-4c08-af07-a8d9876414a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43929a1f-07d8-4ecb-8ec6-caf86fb38b61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44223d41-df60-4b88-b4e0-8d0ef2004a7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46057102-6dc6-4fda-a1c1-dd4c9301102f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4881ae91-531b-4eef-af9d-061fa0ef2938"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cd090df-1bbe-45b9-aecb-7907e2d1dedb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4eaa2901-07df-46dd-a308-f91b4350b066"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53418da8-db38-4edd-81e5-deef870e3b1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53a296bc-cd9b-408d-a3c2-87886dccc5a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53ff27be-acb9-4e60-a0a5-3863b0334de5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("590f838e-9be1-483f-863c-21a13497e98f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5c4f9a6e-9929-4c1a-9d26-1b5af42f5542"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60f6af85-226d-4227-97ab-02ec120ac51b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("649fda8c-0ce7-4535-8182-0bec3abb67b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75090149-da0a-46e3-ac78-dfde5d1da8dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75989ec0-ee7c-4362-a9cb-39b71fc78d42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("766dcaef-c251-4cf9-8c50-16302c9d9deb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b6241f4-8239-40c8-ab87-a3a829f9b174"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d3b5b39-a42f-4e1c-9dab-a8de2f5af99b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d81dcc1-ef65-44c5-9297-4d2002795b1b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("82c6b566-60c9-413f-bab4-140450bcafdb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83c3e666-1c27-4ca7-b99d-11aa6a67a288"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83fb2826-74b8-43b4-9d9d-6b581bfe3112"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8536d652-45c5-41e1-a5b0-fa18edecbbeb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("871770a2-0664-4638-8bf2-a9b31f5ae5ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e7efaea-ebad-4f95-8518-b43328b05171"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90f6a815-3f91-496e-931d-a9c414bb0e15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9797b42f-2614-45dc-8732-bf8fe6515301"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("994bca66-af81-411c-8512-ba69818aaf9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ca9422d-7268-4c6f-bc26-7a319b423fb8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f3a6235-cab1-4a2f-9c47-7ae3184514df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1fac40c-5455-41e4-87ce-ebd49dfb2018"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac11a264-a03c-4043-8705-64d5f0771d2b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae63a880-4805-40aa-9466-8278657ff279"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b17cbedf-d2fc-4d72-be97-bff1ed18361d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3808847-ad98-4761-94df-f2be18ba7bac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ba37bc67-eb70-4696-8760-9cefff95372f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("baa49091-9ed6-49ae-8060-22e0da0892fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c18a92d8-08f2-4025-874f-c3ccdd0bd1d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6bfc7bf-ffc7-4d41-b9bf-899555787e16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c893e61f-033b-4f40-a5b3-0278d525f274"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb0a9984-ab92-46bd-b9b8-3dfd79f0ab68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1a3629a-7e5f-4b77-b355-40acf6e4a592"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2a6472d-06f3-4cf1-a15f-fa213510e855"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4c77e0a-c874-41aa-99d4-8d29aad15afb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d54313fd-29bf-4a16-87d5-3cadb007b014"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d935933b-168a-4a5a-a755-715b29133566"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("daa1df14-86a3-4e23-9862-242d96bac79b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e24b63cc-5d2c-4227-ac8b-6d0aaf18c3f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e27bf4ce-ea52-4704-8c2d-17e5165973d0"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("16450c11-0543-4a6b-8b6b-a31ed6f8f838"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", 2022 },
                    { new Guid("3ed18469-0b9a-4a54-b7fa-af999c6772f9"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", 2023 },
                    { new Guid("6c0d4de5-b77a-4054-aaef-de03e7277af2"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", 2022 },
                    { new Guid("7a8f886e-8ce2-44eb-9050-34e8b81ba383"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", 2023 },
                    { new Guid("8742c359-a591-49d7-8ac2-c0958c36be62"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", 2023 },
                    { new Guid("9dc7e196-b780-46a6-a503-bc9513443650"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", 2023 },
                    { new Guid("b1d377df-5ec0-4e31-bcc1-67042df46a42"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", 2023 },
                    { new Guid("ea99e2ba-e11e-45a7-89c3-ef1d485b2a2e"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", 2022 },
                    { new Guid("ed3f6348-9624-482f-9bff-315f34d01de5"), "France", "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.", "James Huth", "MegaCom Film", 112, "Le nouveau jouet", 2022 },
                    { new Guid("f86dda56-5f84-40c7-a4b2-fe82a340719f"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("02d3d3e0-36d0-490b-8cfb-bc212d0b6d5d"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("06883c23-4ed5-4eb2-9a66-dd596da1ed6f"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("10735d45-63f0-4e43-8ce1-57a4c3828a9f"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("19ce48f1-781c-406b-b34c-58990791ca72"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1a12f434-7ed6-4718-9e2f-0b6d387b57f3"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("1a47a4f5-661a-42b2-9fa6-29fa45ebc9f3"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("227991e0-c3b3-474f-b2f6-cd0580192dcb"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("28316415-1d46-4dda-9e51-11d18605cc7f"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("29b37adf-26ba-450d-855b-3326950f4952"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2a90e0e5-294b-49ee-9cac-375e135311bc"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2aab20df-c5ee-48c0-a770-e3f3c5574217"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2ab51b1c-6def-4871-af5e-9007ba891898"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2d355468-2e17-4275-8221-5f5bad5c6430"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3022c92a-e929-4e67-b2f8-a0d8a2f3859a"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("31dbc4b1-b181-45d9-87d0-96bd1016e2ad"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3345f8d9-1152-4fe8-871f-6855d37e1527"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("339b0e44-e897-416c-852e-efebd5caac39"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3614ce2c-3936-445d-b9d6-8cf5fb8fb926"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("372d2834-5704-4333-ba17-7d999c85616d"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("39edb8da-643a-4e23-8295-54fb6549ff2f"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3cc82845-dea1-4eb4-9190-9e357921cd44"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3d04df33-5c1d-4cd1-ad37-a487f1850346"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3f8b3fcb-c012-43f4-8651-101a08f99664"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("540e7130-d6c0-4bae-a84a-282d1d2799bd"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("58379448-4438-4251-ab5d-ed271500aeea"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("61b8a9a1-7343-4431-aab9-042a9cec46ca"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6abc3446-af9c-41ad-9857-667b638b58c1"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7005f455-59be-4eab-b3f0-37c8fad5c2b3"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("71c0bbf2-ee98-41bd-8bac-5a784100c139"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("733b3017-e3f0-414f-8cad-0aa746a208e0"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("73de133f-c2d7-4969-ad60-9d68729747c0"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("756c1079-f15f-42e0-ab1e-5d0c46c5b00b"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("76984286-e8bb-44f1-934b-b3f0effb1a66"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("76c4b246-8426-4036-8ebb-ed5e6f507639"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7d1010c5-0d92-41db-aeca-c6d22633d3ab"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("80c97b59-8f0d-47f0-9c70-cec1ba1be931"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("87586702-3313-487b-b641-1303e6deb8c1"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("88529f6b-b0ec-4064-b11e-c289d2bd617f"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8adfcd1d-fe3c-4814-b886-65e4e5455a77"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8b59031a-61f7-4443-950d-f984577abf32"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8fd01809-a969-4743-abe5-cfd1bfa2e998"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("906c79d8-9673-4d05-934f-0c2dd40026f9"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9234d0b3-0994-4a44-8942-9fb7781aacee"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("97f090c4-7456-4855-aa22-d6ad81d91e38"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9843eeca-85bf-427a-8db3-37e2d4849e5a"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("998c0267-1e92-42f9-b0e6-0aa3f0e0cf71"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9ca0e747-4871-4e14-a137-563473ee45a2"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9e3a2fee-aa3b-4511-85ab-e5408b46838e"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9f0c05bd-63ad-4129-9156-386e2fc9123d"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9f6c6e63-0594-4649-bc04-6858a6aefe63"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a0223a9d-8e9e-4d49-bd9d-af89b00c4956"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("a249df7a-e54a-4ccf-8f0b-8f06edaf850f"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a3c4d2c8-5018-4259-bfe3-8c0f2f3d585f"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a57adceb-96da-41cc-ac25-f235170f0f6d"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("a5af42c7-b63f-4d2b-842b-11a00292b71e"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("a85fb144-114e-43cc-8354-cfd9db23a73b"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("aa0fb759-40cd-4500-954e-eae81e9e261a"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b5334949-d155-40f2-ba13-c612604da581"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b731b33c-6f33-4026-b8c2-a0113d5ba9f5"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b8b1be8b-a737-469f-9155-6b6596cf6051"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b9d162fe-6d22-43d9-a531-a2f876b0f9a0"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c2797dd4-220e-4c50-b851-a27fc2c53826"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c8d32ea3-245a-46b6-ad88-e5d88743cd79"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("c9005368-e5dc-4325-abf7-e3c8c98add12"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ccef466e-aa39-49fc-baa4-d85378a664f8"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d5c30778-3341-44de-b07c-ba7b34beb5a7"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("da0636ed-2c8a-4b7b-8186-5553a553f38e"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("dcb8c6c7-079f-483b-8663-1edf861a1148"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e18fabe7-4ed8-463b-b1cf-f7967f81ff3a"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e8cdc1d5-4cb9-408c-a16a-f005233d5a7f"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ecda369a-16e4-4d46-b19b-be73c6977bec"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f06ca890-284a-42a1-99e8-aca750b039a8"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f6a529f7-aaa9-4bea-b69f-e59f5ba4df03"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f91a8aa1-5f60-4032-8a88-b76877d291bb"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("d62c5533-c92a-4d68-91da-4720085b898c"), new DateTime(2023, 4, 6, 14, 57, 14, 820, DateTimeKind.Local).AddTicks(4077), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("df9de6bd-c17d-4881-a8ac-73d6962f3207"), new DateTime(2023, 4, 6, 14, 57, 14, 820, DateTimeKind.Local).AddTicks(4301), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("eeca3381-a742-47bc-8a2b-56d1e6cd4de2"), new DateTime(2023, 4, 6, 14, 57, 14, 820, DateTimeKind.Local).AddTicks(4330), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("16450c11-0543-4a6b-8b6b-a31ed6f8f838"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3ed18469-0b9a-4a54-b7fa-af999c6772f9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6c0d4de5-b77a-4054-aaef-de03e7277af2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7a8f886e-8ce2-44eb-9050-34e8b81ba383"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8742c359-a591-49d7-8ac2-c0958c36be62"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9dc7e196-b780-46a6-a503-bc9513443650"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b1d377df-5ec0-4e31-bcc1-67042df46a42"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ea99e2ba-e11e-45a7-89c3-ef1d485b2a2e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ed3f6348-9624-482f-9bff-315f34d01de5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f86dda56-5f84-40c7-a4b2-fe82a340719f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("02d3d3e0-36d0-490b-8cfb-bc212d0b6d5d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06883c23-4ed5-4eb2-9a66-dd596da1ed6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10735d45-63f0-4e43-8ce1-57a4c3828a9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19ce48f1-781c-406b-b34c-58990791ca72"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a12f434-7ed6-4718-9e2f-0b6d387b57f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a47a4f5-661a-42b2-9fa6-29fa45ebc9f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("227991e0-c3b3-474f-b2f6-cd0580192dcb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28316415-1d46-4dda-9e51-11d18605cc7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29b37adf-26ba-450d-855b-3326950f4952"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a90e0e5-294b-49ee-9cac-375e135311bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2aab20df-c5ee-48c0-a770-e3f3c5574217"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ab51b1c-6def-4871-af5e-9007ba891898"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d355468-2e17-4275-8221-5f5bad5c6430"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3022c92a-e929-4e67-b2f8-a0d8a2f3859a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("31dbc4b1-b181-45d9-87d0-96bd1016e2ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3345f8d9-1152-4fe8-871f-6855d37e1527"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("339b0e44-e897-416c-852e-efebd5caac39"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3614ce2c-3936-445d-b9d6-8cf5fb8fb926"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("372d2834-5704-4333-ba17-7d999c85616d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39edb8da-643a-4e23-8295-54fb6549ff2f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3cc82845-dea1-4eb4-9190-9e357921cd44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d04df33-5c1d-4cd1-ad37-a487f1850346"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f8b3fcb-c012-43f4-8651-101a08f99664"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("540e7130-d6c0-4bae-a84a-282d1d2799bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58379448-4438-4251-ab5d-ed271500aeea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61b8a9a1-7343-4431-aab9-042a9cec46ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6abc3446-af9c-41ad-9857-667b638b58c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7005f455-59be-4eab-b3f0-37c8fad5c2b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71c0bbf2-ee98-41bd-8bac-5a784100c139"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("733b3017-e3f0-414f-8cad-0aa746a208e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73de133f-c2d7-4969-ad60-9d68729747c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("756c1079-f15f-42e0-ab1e-5d0c46c5b00b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76984286-e8bb-44f1-934b-b3f0effb1a66"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76c4b246-8426-4036-8ebb-ed5e6f507639"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d1010c5-0d92-41db-aeca-c6d22633d3ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80c97b59-8f0d-47f0-9c70-cec1ba1be931"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87586702-3313-487b-b641-1303e6deb8c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88529f6b-b0ec-4064-b11e-c289d2bd617f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8adfcd1d-fe3c-4814-b886-65e4e5455a77"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b59031a-61f7-4443-950d-f984577abf32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8fd01809-a969-4743-abe5-cfd1bfa2e998"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("906c79d8-9673-4d05-934f-0c2dd40026f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9234d0b3-0994-4a44-8942-9fb7781aacee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97f090c4-7456-4855-aa22-d6ad81d91e38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9843eeca-85bf-427a-8db3-37e2d4849e5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("998c0267-1e92-42f9-b0e6-0aa3f0e0cf71"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ca0e747-4871-4e14-a137-563473ee45a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e3a2fee-aa3b-4511-85ab-e5408b46838e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f0c05bd-63ad-4129-9156-386e2fc9123d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f6c6e63-0594-4649-bc04-6858a6aefe63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0223a9d-8e9e-4d49-bd9d-af89b00c4956"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a249df7a-e54a-4ccf-8f0b-8f06edaf850f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a3c4d2c8-5018-4259-bfe3-8c0f2f3d585f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a57adceb-96da-41cc-ac25-f235170f0f6d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5af42c7-b63f-4d2b-842b-11a00292b71e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a85fb144-114e-43cc-8354-cfd9db23a73b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa0fb759-40cd-4500-954e-eae81e9e261a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5334949-d155-40f2-ba13-c612604da581"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b731b33c-6f33-4026-b8c2-a0113d5ba9f5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8b1be8b-a737-469f-9155-6b6596cf6051"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9d162fe-6d22-43d9-a531-a2f876b0f9a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2797dd4-220e-4c50-b851-a27fc2c53826"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8d32ea3-245a-46b6-ad88-e5d88743cd79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9005368-e5dc-4325-abf7-e3c8c98add12"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ccef466e-aa39-49fc-baa4-d85378a664f8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5c30778-3341-44de-b07c-ba7b34beb5a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da0636ed-2c8a-4b7b-8186-5553a553f38e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dcb8c6c7-079f-483b-8663-1edf861a1148"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e18fabe7-4ed8-463b-b1cf-f7967f81ff3a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8cdc1d5-4cb9-408c-a16a-f005233d5a7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ecda369a-16e4-4d46-b19b-be73c6977bec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f06ca890-284a-42a1-99e8-aca750b039a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6a529f7-aaa9-4bea-b69f-e59f5ba4df03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f91a8aa1-5f60-4032-8a88-b76877d291bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d62c5533-c92a-4d68-91da-4720085b898c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df9de6bd-c17d-4881-a8ac-73d6962f3207"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeca3381-a742-47bc-8a2b-56d1e6cd4de2"));

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
        }
    }
}
