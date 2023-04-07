using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class created_tickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SeatId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

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
    }
}
