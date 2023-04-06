using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed_theaterprojectiontype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("35283925-9289-4e46-be21-b2ab03a73962"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("53c4e547-b3c1-4d8f-b5ac-ecfed4bd132a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("63473a01-922c-47e3-8632-ce5b67dcf4fe"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6f43fc57-6fb4-46e5-a568-ee838000a1fc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7a53f52c-2658-4db0-9087-281bb32f20b7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a46d6acc-2fe3-4975-9bbe-331cb9e9846a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a768c607-4caf-4adf-a5bf-8be5c0f7370b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ab7b362c-03d3-43ee-a59f-473a034e8684"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c432aa88-b13e-4817-9de9-5bcfbaeb33a0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e66d183a-05ae-48f7-b28c-e0b51cc04de8"));

            migrationBuilder.DeleteData(
                table: "ProjectionTypes",
                keyColumn: "Id",
                keyValue: new Guid("89c8a5cb-378c-44eb-9c64-f736bcf8b670"));

            migrationBuilder.DeleteData(
                table: "ProjectionTypes",
                keyColumn: "Id",
                keyValue: new Guid("bda215e1-4cc1-42d5-b07e-6c8b9ffe6b26"));

            migrationBuilder.DeleteData(
                table: "ProjectionTypes",
                keyColumn: "Id",
                keyValue: new Guid("c0360c90-87dc-4264-adeb-6f600a49a341"));

            migrationBuilder.CreateTable(
                name: "TheaterProjectionType",
                columns: table => new
                {
                    TheaterId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProjectionTypeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheaterProjectionType", x => new { x.TheaterId, x.ProjectionTypeId });
                    table.ForeignKey(
                        name: "FK_TheaterProjectionType_ProjectionTypes_ProjectionTypeId",
                        column: x => x.ProjectionTypeId,
                        principalTable: "ProjectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TheaterProjectionType_Theaters_TheaterId",
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

            migrationBuilder.InsertData(
                table: "ProjectionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), "4D" },
                    { new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), "2D" },
                    { new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), "3D" }
                });

            migrationBuilder.InsertData(
                table: "Theaters",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"), "Sala 2" },
                    { new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb"), "Sala 5" },
                    { new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"), "Sala 4" },
                    { new Guid("a322aedb-053b-4507-895e-150390686b12"), "Sala 3" },
                    { new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1"), "Sala 6" },
                    { new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"), "Sala 1" }
                });

            migrationBuilder.InsertData(
                table: "TheaterProjectionType",
                columns: new[] { "ProjectionTypeId", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TheaterProjectionType_ProjectionTypeId",
                table: "TheaterProjectionType",
                column: "ProjectionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TheaterProjectionType");

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

            migrationBuilder.DeleteData(
                table: "ProjectionTypes",
                keyColumn: "Id",
                keyValue: new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"));

            migrationBuilder.DeleteData(
                table: "ProjectionTypes",
                keyColumn: "Id",
                keyValue: new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"));

            migrationBuilder.DeleteData(
                table: "ProjectionTypes",
                keyColumn: "Id",
                keyValue: new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"));

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"));

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb"));

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"));

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: new Guid("a322aedb-053b-4507-895e-150390686b12"));

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1"));

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("35283925-9289-4e46-be21-b2ab03a73962"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", 2023 },
                    { new Guid("53c4e547-b3c1-4d8f-b5ac-ecfed4bd132a"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", 2023 },
                    { new Guid("63473a01-922c-47e3-8632-ce5b67dcf4fe"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", 2023 },
                    { new Guid("6f43fc57-6fb4-46e5-a568-ee838000a1fc"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", 2022 },
                    { new Guid("7a53f52c-2658-4db0-9087-281bb32f20b7"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", 2023 },
                    { new Guid("a46d6acc-2fe3-4975-9bbe-331cb9e9846a"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", 2022 },
                    { new Guid("a768c607-4caf-4adf-a5bf-8be5c0f7370b"), "France", "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.", "James Huth", "MegaCom Film", 112, "Le nouveau jouet", 2022 },
                    { new Guid("ab7b362c-03d3-43ee-a59f-473a034e8684"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", 2022 },
                    { new Guid("c432aa88-b13e-4817-9de9-5bcfbaeb33a0"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", 2023 },
                    { new Guid("e66d183a-05ae-48f7-b28c-e0b51cc04de8"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", 2022 }
                });

            migrationBuilder.InsertData(
                table: "ProjectionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("89c8a5cb-378c-44eb-9c64-f736bcf8b670"), "3D" },
                    { new Guid("bda215e1-4cc1-42d5-b07e-6c8b9ffe6b26"), "4D" },
                    { new Guid("c0360c90-87dc-4264-adeb-6f600a49a341"), "2D" }
                });
        }
    }
}
