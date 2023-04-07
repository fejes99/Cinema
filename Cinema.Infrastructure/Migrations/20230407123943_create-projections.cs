using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class createprojections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("019ac017-8bd5-4e5c-9b6d-4b28c16bef8a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("050312d7-c303-4e90-853c-4f7c87e2b932"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("26a31de6-2dec-4467-a299-08bad9b2be29"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3211b59f-0876-4d1f-bd3e-52a38ccb6ddd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("39ee5456-5b57-4028-a350-e51eb456eaad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("57d65748-8502-439f-8612-bb2f1a3162c8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8559ab71-1437-4925-8e08-2deb9e7865bf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a349c004-d160-47fc-a57b-420722b339ec"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b1db1064-f7f8-4c4c-b9da-3000b19fbd05"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fe05f89a-d935-4404-b76c-351c75a0003c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05f94682-e10c-4b87-9f7d-dd3e16d62c70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0634c593-4a58-4778-9810-00c21edf4218"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06f6feae-0b30-477b-8cc2-d97f46fceab2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f35c39d-ff46-408a-a052-cebc3f66b4cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0faa2117-8932-44a2-af30-076c7e1bcde9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("103ef69b-d56e-4ab5-aed3-3667df40ebd6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13786dc6-aa65-4fce-890e-8db018a8e649"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e8225d9-2f2a-420c-9e5f-073fdf0b37f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f96f806-dc6d-4e29-9550-67f966ef542e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("209c8c44-0443-4600-b58d-593cca3f9ce1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23cd3152-947d-474e-9851-dee024a1efcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("260f14e3-e367-42bf-8bdd-1788deaee30b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("261105ab-635a-41ce-a787-cfce56c5a3e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2884c2e6-bea8-4332-bcb0-7b9b72ab97fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("31c67caa-9ef8-447f-9427-d9fafb031d61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3644e3aa-b1d4-4f55-b30f-3c3ad922ebf6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("435aae59-5057-48a9-9ab8-8de562bb428b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("471126a8-9149-4940-8c16-78265b37726f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("498009a1-3413-486d-a9db-370aa5a74ffb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e08db81-b5dc-4dd1-b998-34a52e262c0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e7917c2-2174-4a2c-9b46-40afe39da133"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f95a9e5-4a1a-43ad-8cad-d29942253937"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("51fdc809-b2d0-4aef-be8e-c3b6f5daeeaf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("570e4b19-80ab-4187-b1e3-7a233fc3508d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58c1327d-0cd8-4415-b3d8-9aac926bd014"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61d3e148-10ec-4de0-8013-776092a028bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67a63981-8242-4f63-bdbf-c5b5ea04dabd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e08a20a-6f70-46ad-9775-eec54328f24d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("704377a9-9a56-414c-9a32-8d61b258828b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b995b9b-f09a-48d2-a7e6-7feb79723924"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f843e13-9bbd-4d98-be41-70f0e631983d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83529742-48b1-42fd-876c-d9a57bcd1e64"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85f5ab77-32bf-475c-ade6-c9b947787d99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86a128f6-2761-4bc8-952a-6906cdf7d3d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89394597-601c-4c15-96c0-02083c3ec82e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89d3a1bd-fde5-4d9f-be90-964030d9f918"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91ea1604-c702-473e-8b02-f29c94154e3b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("93c56089-1c55-4185-9113-a4519c0c89b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9477b7b3-1df1-4484-b026-e0a9a72055d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9492ee5e-6a82-42c4-ab50-0fef1c4fe9ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95b9de7f-0fc2-456a-bd6d-1246bcec7218"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("993d681c-43ed-4fd3-a244-ef8b0bd19a70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a2f767c-694f-43f0-9e57-5b311ee41a7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9acb7f0a-c0a9-45ef-a8e6-721cb9a490d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a15c93ae-827e-4260-819b-ed2093417454"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1b27b50-e888-429d-91df-dfe2da0a7cb0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5514046-2c8b-4044-86c5-514e8f370855"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9406f29-cea9-46a4-84a7-0f080e335676"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa352b37-438c-43d6-8fb7-fd4c73e5ed8f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abc6c10d-53e4-4c00-837f-3f3713ae5f96"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b26d7aa2-ef0c-49d2-b34a-e2c159259c21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4e738e5-c99b-4ee4-8f19-ca3c9eecfdd6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c940ebf0-4283-4ef8-864c-d687fb6ae57e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c940f68d-bd22-413d-a975-e3e726090eca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c952bf3f-9e16-4f4a-98e5-a38e797fbdfb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c99f1cba-75e7-4643-ae90-24c88e03ab6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca008c80-171d-46fc-ab70-4caaa0a7756e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbacbab5-abb0-48e8-b718-ecbc34fb1f3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0c9a045-52de-476b-9c96-db7542642387"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d371daf1-6706-4131-90eb-d80962b3f7d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db09e788-c386-4fd1-ad03-42d61cd18e9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd186c2f-f865-4313-823b-47f77803c53b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1bb0fc1-8e70-4207-97a7-51d2be551d42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e39e6fe1-adf4-4919-a973-8bdeed48a0c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5b944a1-42b8-446b-b22e-7917d1970b24"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eaa689e9-ceda-4e0d-8b13-166fd709769e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eada5494-aa38-4aeb-8226-972e0f9ffe1e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee7c80f5-dd8b-4256-bc65-67f0b6d66f0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f08bf584-7040-4e6c-b76d-bd5c49d5dee9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1626ce3-17a8-42a2-a720-9e781c5e83af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4fbc97d-b709-46b4-923b-cc5ce657b2ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f676c6c5-bbaf-4b7d-be3c-fe2c97f5d853"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa616c4d-cdb4-49b1-8ac3-5de380a42de9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fbbd9e5f-d13e-4830-a60b-9a62f7f68392"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5652ec80-d01d-4bc3-a069-282a0255dd04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89e99670-a3e6-4d34-8d42-39d7c2921c0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0410884-29b6-4c8b-a41c-505c1f1a8e65"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectionId",
                table: "Tickets",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Projections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    MovieId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProjectionTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TheaterId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projections_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projections_ProjectionTypes_ProjectionTypeId",
                        column: x => x.ProjectionTypeId,
                        principalTable: "ProjectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projections_Theaters_TheaterId",
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
                    { new Guid("325dff8d-9dac-4b91-9d80-dd36f74c6a84"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", 2023 },
                    { new Guid("423ebdca-cde1-4d87-b100-514eaee8feb1"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", 2023 },
                    { new Guid("45a71d65-36a1-4f99-b7e8-334a15fa9375"), "France", "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.", "James Huth", "MegaCom Film", 112, "Le nouveau jouet", 2022 },
                    { new Guid("6b36eef5-3f2f-403d-b600-ccf16325bf58"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", 2022 },
                    { new Guid("804beffa-137f-4c2a-b46f-dc19ce1c581d"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", 2022 },
                    { new Guid("8edf654a-2fb8-47b0-b0a5-117e8e417e1c"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", 2023 },
                    { new Guid("b80cd5a2-9c37-4af1-9228-ed286559d08d"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", 2023 },
                    { new Guid("c5ddcb71-8077-4eaf-b383-04258379789a"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", 2022 },
                    { new Guid("cc275437-1263-4182-883e-df27fdf194eb"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", 2023 },
                    { new Guid("f257c6e7-3193-4cec-80a7-df618651c6af"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("0124fca0-1b49-4392-807c-018622830201"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0204f416-b5cf-4a9e-ad2e-64ceed249990"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("054b3d8d-4de0-4b28-8d9f-71ecc25a4153"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0677aae3-738e-489e-a801-4b1f367a9d20"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("09b07e16-0aba-420f-9ebb-3de2b54e8c8f"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0a51c0d1-d5df-4814-a5c0-bf8b85da10e6"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0b6bea72-9b6f-4a49-a486-6b6ab5943be3"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("0c94f727-14ef-4a86-a2dc-31d21fb6bc8e"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0f1f965e-f2e9-4a2e-a390-ee0bd951d2cc"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1499356c-272d-4bdc-81de-0b3d4bafdf15"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("15217988-a8d5-4107-aea6-b5db6dc41be0"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1525f157-724c-4d52-aec2-817ec35831ee"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1797adc5-637c-489c-bdfb-f499aa6a7fca"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("185729af-2951-4923-b61d-808ab046ce95"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1e7c5daa-009b-48a3-9dd7-bb07f704040d"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("242e0eb3-b0a0-4bb1-9058-6cd9372b7e22"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3416479d-7dbb-430f-95de-2664503f6cee"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3b1da660-f32c-4b9f-9200-ad5b619ce467"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3bf5b2e6-bd9f-4325-8cf9-7828d3184a44"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("4a53bb30-ed26-4587-b963-6b0784c74305"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4c497e65-8ec9-4848-99de-c27257d96e21"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5290b86d-9b83-4074-b411-432454c2ce18"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("537d2ab8-c8ed-4234-8b05-6e1e8b5eb32e"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("578f2765-04a6-4439-9912-0fb19a350656"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("58be8c8f-20e6-47fa-99f0-b28d9440d0eb"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("639f03a7-c3fd-46fa-92e6-e61f5cba0704"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("67349d89-f09a-4731-9487-fb6a0337807f"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("6936300a-b8a2-4c2d-8575-6e47fb184884"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("69568caf-5f88-42de-b5b5-acb14b6e2c0c"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7186d0f6-8021-4849-8c20-0641be60b99c"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("739e3e0b-9966-4557-975c-a7fcf581e0cc"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("76959c34-b82c-4e6b-8d81-c1751cb8c772"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7808bc56-fc88-4e62-8daf-5d214d433b99"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("782a9c02-9205-4f79-830e-50bbc984b1dc"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("7ed6f40a-4962-4dc6-88ef-615820a1d3ed"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("819dfda1-c344-4b88-9f4f-562b49b47733"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8537687a-0b7e-43d3-9e30-75b9a60baaaf"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8797d467-1ae2-4aa3-8914-d29bcfdaec1b"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8a17a697-0bca-4beb-aae6-f5dd0a5e53ee"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8cc6f306-031d-4f54-859f-50d2d8fcdae7"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8f719a95-7175-4cbd-8291-6ee4fdf326bd"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8f921d34-fbc8-49bf-81ac-20809b975ce9"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("90a49ec3-c92b-4382-b02e-aa57ec9b5515"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("92984afa-73ac-40c8-b695-51880559687a"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("97faf199-5219-4dcd-88fc-b7fdf6901b8c"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9c0582bd-f339-4222-b3ba-1a44106e8719"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9d06c29c-1666-4403-acb1-968729d3a7b2"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a0f5967e-596a-415e-ba91-1822ccaf5315"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("a67d7c9e-a03f-4139-bd55-23891dececd0"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("a71aedff-fa25-4f02-b33f-3af80d8b8611"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("a7bab58f-2eaf-49a3-8be7-f8f79099fb0b"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("aa658c67-1be9-4b91-b468-a5f506b7c942"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("ad2e5c62-e5a2-4349-b6d2-a1cbcd2ee0b9"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b0d3a38e-c9f4-41a0-9b05-0e7183a1dcf5"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b19fa4b6-dfb6-4bc7-8a65-5b1da491d7c8"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("b33cfd0e-5e5e-4829-83e5-3cd91ff1300c"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b6d30f6e-4a52-4f50-8e85-e8d92654bae2"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c00bb135-9928-4911-babc-d9d3c67b4392"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c1a9b824-3e1c-4c31-9b42-cab6b4078ae1"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c226e415-a548-4793-bba5-9271e2920f9d"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c5b2ceac-ac37-4631-8029-220067885393"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cea67c84-a3e0-4e3d-98df-0abbeaa7599d"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d35280bd-c046-42a5-9e9d-d7bfbdf7f35a"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d9555a55-3d96-48fe-8489-677bf1214989"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d97f30a9-36ef-43d1-99fe-801611694d98"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e25d507a-c66e-47e0-9e5f-c619e1abcaad"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("eaba6d7b-c36b-4f0c-b9d6-07ea6b65ff10"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ebb3b9c1-35f6-4a79-8282-ef7f8acf7bfc"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("ed172829-4eee-42c3-bde3-6e21eb750ce5"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("f2b0c596-95b2-4a6d-9b97-cdb8e68ac0b3"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f4b35fd5-ad3a-48d6-8aca-0382ab1f0b10"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("fc8eb13f-78f5-448a-a5a7-a482de039f50"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("fd6c11bc-4117-4df9-ae49-7d6df667e2ef"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ff9341cf-02fd-42d7-8cd9-7c472b76e1df"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("2b412283-325c-4a62-a0d4-1b2881864de9"), new DateTime(2023, 4, 7, 14, 39, 43, 606, DateTimeKind.Local).AddTicks(8320), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("add6599d-4a7d-4365-b3bc-5e895fa47f5c"), new DateTime(2023, 4, 7, 14, 39, 43, 606, DateTimeKind.Local).AddTicks(8467), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("af7db1fc-4aba-48c9-8c6d-76ce92097d7e"), new DateTime(2023, 4, 7, 14, 39, 43, 606, DateTimeKind.Local).AddTicks(8485), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProjectionId",
                table: "Tickets",
                column: "ProjectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_MovieId",
                table: "Projections",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_ProjectionTypeId",
                table: "Projections",
                column: "ProjectionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_TheaterId",
                table: "Projections",
                column: "TheaterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Projections_ProjectionId",
                table: "Tickets",
                column: "ProjectionId",
                principalTable: "Projections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Projections_ProjectionId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Projections");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ProjectionId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("325dff8d-9dac-4b91-9d80-dd36f74c6a84"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("423ebdca-cde1-4d87-b100-514eaee8feb1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("45a71d65-36a1-4f99-b7e8-334a15fa9375"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6b36eef5-3f2f-403d-b600-ccf16325bf58"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("804beffa-137f-4c2a-b46f-dc19ce1c581d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8edf654a-2fb8-47b0-b0a5-117e8e417e1c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b80cd5a2-9c37-4af1-9228-ed286559d08d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c5ddcb71-8077-4eaf-b383-04258379789a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cc275437-1263-4182-883e-df27fdf194eb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f257c6e7-3193-4cec-80a7-df618651c6af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0124fca0-1b49-4392-807c-018622830201"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0204f416-b5cf-4a9e-ad2e-64ceed249990"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("054b3d8d-4de0-4b28-8d9f-71ecc25a4153"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0677aae3-738e-489e-a801-4b1f367a9d20"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09b07e16-0aba-420f-9ebb-3de2b54e8c8f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a51c0d1-d5df-4814-a5c0-bf8b85da10e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b6bea72-9b6f-4a49-a486-6b6ab5943be3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c94f727-14ef-4a86-a2dc-31d21fb6bc8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f1f965e-f2e9-4a2e-a390-ee0bd951d2cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1499356c-272d-4bdc-81de-0b3d4bafdf15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15217988-a8d5-4107-aea6-b5db6dc41be0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1525f157-724c-4d52-aec2-817ec35831ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1797adc5-637c-489c-bdfb-f499aa6a7fca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("185729af-2951-4923-b61d-808ab046ce95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e7c5daa-009b-48a3-9dd7-bb07f704040d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("242e0eb3-b0a0-4bb1-9058-6cd9372b7e22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3416479d-7dbb-430f-95de-2664503f6cee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b1da660-f32c-4b9f-9200-ad5b619ce467"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bf5b2e6-bd9f-4325-8cf9-7828d3184a44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a53bb30-ed26-4587-b963-6b0784c74305"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c497e65-8ec9-4848-99de-c27257d96e21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5290b86d-9b83-4074-b411-432454c2ce18"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("537d2ab8-c8ed-4234-8b05-6e1e8b5eb32e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("578f2765-04a6-4439-9912-0fb19a350656"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58be8c8f-20e6-47fa-99f0-b28d9440d0eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("639f03a7-c3fd-46fa-92e6-e61f5cba0704"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67349d89-f09a-4731-9487-fb6a0337807f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6936300a-b8a2-4c2d-8575-6e47fb184884"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69568caf-5f88-42de-b5b5-acb14b6e2c0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7186d0f6-8021-4849-8c20-0641be60b99c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("739e3e0b-9966-4557-975c-a7fcf581e0cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76959c34-b82c-4e6b-8d81-c1751cb8c772"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7808bc56-fc88-4e62-8daf-5d214d433b99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("782a9c02-9205-4f79-830e-50bbc984b1dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ed6f40a-4962-4dc6-88ef-615820a1d3ed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("819dfda1-c344-4b88-9f4f-562b49b47733"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8537687a-0b7e-43d3-9e30-75b9a60baaaf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8797d467-1ae2-4aa3-8914-d29bcfdaec1b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a17a697-0bca-4beb-aae6-f5dd0a5e53ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cc6f306-031d-4f54-859f-50d2d8fcdae7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f719a95-7175-4cbd-8291-6ee4fdf326bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f921d34-fbc8-49bf-81ac-20809b975ce9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90a49ec3-c92b-4382-b02e-aa57ec9b5515"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92984afa-73ac-40c8-b695-51880559687a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97faf199-5219-4dcd-88fc-b7fdf6901b8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c0582bd-f339-4222-b3ba-1a44106e8719"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d06c29c-1666-4403-acb1-968729d3a7b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0f5967e-596a-415e-ba91-1822ccaf5315"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a67d7c9e-a03f-4139-bd55-23891dececd0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a71aedff-fa25-4f02-b33f-3af80d8b8611"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7bab58f-2eaf-49a3-8be7-f8f79099fb0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa658c67-1be9-4b91-b468-a5f506b7c942"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad2e5c62-e5a2-4349-b6d2-a1cbcd2ee0b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0d3a38e-c9f4-41a0-9b05-0e7183a1dcf5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b19fa4b6-dfb6-4bc7-8a65-5b1da491d7c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b33cfd0e-5e5e-4829-83e5-3cd91ff1300c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b6d30f6e-4a52-4f50-8e85-e8d92654bae2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c00bb135-9928-4911-babc-d9d3c67b4392"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1a9b824-3e1c-4c31-9b42-cab6b4078ae1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c226e415-a548-4793-bba5-9271e2920f9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5b2ceac-ac37-4631-8029-220067885393"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cea67c84-a3e0-4e3d-98df-0abbeaa7599d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d35280bd-c046-42a5-9e9d-d7bfbdf7f35a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9555a55-3d96-48fe-8489-677bf1214989"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d97f30a9-36ef-43d1-99fe-801611694d98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e25d507a-c66e-47e0-9e5f-c619e1abcaad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eaba6d7b-c36b-4f0c-b9d6-07ea6b65ff10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebb3b9c1-35f6-4a79-8282-ef7f8acf7bfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed172829-4eee-42c3-bde3-6e21eb750ce5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2b0c596-95b2-4a6d-9b97-cdb8e68ac0b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4b35fd5-ad3a-48d6-8aca-0382ab1f0b10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc8eb13f-78f5-448a-a5a7-a482de039f50"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd6c11bc-4117-4df9-ae49-7d6df667e2ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff9341cf-02fd-42d7-8cd9-7c472b76e1df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b412283-325c-4a62-a0d4-1b2881864de9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("add6599d-4a7d-4365-b3bc-5e895fa47f5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af7db1fc-4aba-48c9-8c6d-76ce92097d7e"));

            migrationBuilder.DropColumn(
                name: "ProjectionId",
                table: "Tickets");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("019ac017-8bd5-4e5c-9b6d-4b28c16bef8a"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", 2022 },
                    { new Guid("050312d7-c303-4e90-853c-4f7c87e2b932"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", 2022 },
                    { new Guid("26a31de6-2dec-4467-a299-08bad9b2be29"), "France", "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.", "James Huth", "MegaCom Film", 112, "Le nouveau jouet", 2022 },
                    { new Guid("3211b59f-0876-4d1f-bd3e-52a38ccb6ddd"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", 2023 },
                    { new Guid("39ee5456-5b57-4028-a350-e51eb456eaad"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", 2023 },
                    { new Guid("57d65748-8502-439f-8612-bb2f1a3162c8"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", 2022 },
                    { new Guid("8559ab71-1437-4925-8e08-2deb9e7865bf"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", 2022 },
                    { new Guid("a349c004-d160-47fc-a57b-420722b339ec"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", 2023 },
                    { new Guid("b1db1064-f7f8-4c4c-b9da-3000b19fbd05"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", 2023 },
                    { new Guid("fe05f89a-d935-4404-b76c-351c75a0003c"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("05f94682-e10c-4b87-9f7d-dd3e16d62c70"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0634c593-4a58-4778-9810-00c21edf4218"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("06f6feae-0b30-477b-8cc2-d97f46fceab2"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0f35c39d-ff46-408a-a052-cebc3f66b4cd"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0faa2117-8932-44a2-af30-076c7e1bcde9"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("103ef69b-d56e-4ab5-aed3-3667df40ebd6"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("13786dc6-aa65-4fce-890e-8db018a8e649"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("1e8225d9-2f2a-420c-9e5f-073fdf0b37f1"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("1f96f806-dc6d-4e29-9550-67f966ef542e"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("209c8c44-0443-4600-b58d-593cca3f9ce1"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("23cd3152-947d-474e-9851-dee024a1efcc"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("260f14e3-e367-42bf-8bdd-1788deaee30b"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("261105ab-635a-41ce-a787-cfce56c5a3e3"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2884c2e6-bea8-4332-bcb0-7b9b72ab97fb"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("31c67caa-9ef8-447f-9427-d9fafb031d61"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3644e3aa-b1d4-4f55-b30f-3c3ad922ebf6"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("435aae59-5057-48a9-9ab8-8de562bb428b"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("471126a8-9149-4940-8c16-78265b37726f"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("498009a1-3413-486d-a9db-370aa5a74ffb"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("4e08db81-b5dc-4dd1-b998-34a52e262c0a"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("4e7917c2-2174-4a2c-9b46-40afe39da133"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4f95a9e5-4a1a-43ad-8cad-d29942253937"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("51fdc809-b2d0-4aef-be8e-c3b6f5daeeaf"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("570e4b19-80ab-4187-b1e3-7a233fc3508d"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("58c1327d-0cd8-4415-b3d8-9aac926bd014"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("61d3e148-10ec-4de0-8013-776092a028bb"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("67a63981-8242-4f63-bdbf-c5b5ea04dabd"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("6e08a20a-6f70-46ad-9775-eec54328f24d"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("704377a9-9a56-414c-9a32-8d61b258828b"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7b995b9b-f09a-48d2-a7e6-7feb79723924"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("7f843e13-9bbd-4d98-be41-70f0e631983d"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("83529742-48b1-42fd-876c-d9a57bcd1e64"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("85f5ab77-32bf-475c-ade6-c9b947787d99"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("86a128f6-2761-4bc8-952a-6906cdf7d3d4"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("89394597-601c-4c15-96c0-02083c3ec82e"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("89d3a1bd-fde5-4d9f-be90-964030d9f918"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("91ea1604-c702-473e-8b02-f29c94154e3b"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("93c56089-1c55-4185-9113-a4519c0c89b4"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9477b7b3-1df1-4484-b026-e0a9a72055d9"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9492ee5e-6a82-42c4-ab50-0fef1c4fe9ef"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("95b9de7f-0fc2-456a-bd6d-1246bcec7218"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("993d681c-43ed-4fd3-a244-ef8b0bd19a70"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9a2f767c-694f-43f0-9e57-5b311ee41a7f"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9acb7f0a-c0a9-45ef-a8e6-721cb9a490d8"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a15c93ae-827e-4260-819b-ed2093417454"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a1b27b50-e888-429d-91df-dfe2da0a7cb0"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a5514046-2c8b-4044-86c5-514e8f370855"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a9406f29-cea9-46a4-84a7-0f080e335676"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("aa352b37-438c-43d6-8fb7-fd4c73e5ed8f"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("abc6c10d-53e4-4c00-837f-3f3713ae5f96"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b26d7aa2-ef0c-49d2-b34a-e2c159259c21"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b4e738e5-c99b-4ee4-8f19-ca3c9eecfdd6"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c940ebf0-4283-4ef8-864c-d687fb6ae57e"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c940f68d-bd22-413d-a975-e3e726090eca"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c952bf3f-9e16-4f4a-98e5-a38e797fbdfb"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c99f1cba-75e7-4643-ae90-24c88e03ab6f"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ca008c80-171d-46fc-ab70-4caaa0a7756e"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cbacbab5-abb0-48e8-b718-ecbc34fb1f3d"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d0c9a045-52de-476b-9c96-db7542642387"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d371daf1-6706-4131-90eb-d80962b3f7d4"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("db09e788-c386-4fd1-ad03-42d61cd18e9c"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("dd186c2f-f865-4313-823b-47f77803c53b"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e1bb0fc1-8e70-4207-97a7-51d2be551d42"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("e39e6fe1-adf4-4919-a973-8bdeed48a0c1"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e5b944a1-42b8-446b-b22e-7917d1970b24"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("eaa689e9-ceda-4e0d-8b13-166fd709769e"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("eada5494-aa38-4aeb-8226-972e0f9ffe1e"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ee7c80f5-dd8b-4256-bc65-67f0b6d66f0c"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("f08bf584-7040-4e6c-b76d-bd5c49d5dee9"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f1626ce3-17a8-42a2-a720-9e781c5e83af"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f4fbc97d-b709-46b4-923b-cc5ce657b2ab"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f676c6c5-bbaf-4b7d-be3c-fe2c97f5d853"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("fa616c4d-cdb4-49b1-8ac3-5de380a42de9"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("fbbd9e5f-d13e-4830-a60b-9a62f7f68392"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("5652ec80-d01d-4bc3-a069-282a0255dd04"), new DateTime(2023, 4, 7, 11, 50, 44, 360, DateTimeKind.Local).AddTicks(5838), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("89e99670-a3e6-4d34-8d42-39d7c2921c0b"), new DateTime(2023, 4, 7, 11, 50, 44, 360, DateTimeKind.Local).AddTicks(5853), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" },
                    { new Guid("f0410884-29b6-4c8b-a41c-505c1f1a8e65"), new DateTime(2023, 4, 7, 11, 50, 44, 360, DateTimeKind.Local).AddTicks(5717), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" }
                });
        }
    }
}
