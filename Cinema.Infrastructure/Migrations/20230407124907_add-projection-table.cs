using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addprojectiontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("2637debe-222e-43c7-a0f3-65be9f459525"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", 2023 },
                    { new Guid("54d6f992-bd76-4186-abf0-cedccda2b968"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", 2022 },
                    { new Guid("58086cfa-445a-4f8e-9b58-0dad59d05d6f"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", 2023 },
                    { new Guid("7972ad14-d603-49e3-870c-406e79669428"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", 2022 },
                    { new Guid("887d4ba5-42d2-40d3-ac95-425eed995655"), "France", "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.", "James Huth", "MegaCom Film", 112, "Le nouveau jouet", 2022 },
                    { new Guid("9967a3c7-aee2-4410-a03f-4369ad7bc95c"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", 2023 },
                    { new Guid("9b457feb-74f0-4381-8934-4fb4ecdb3224"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", 2023 },
                    { new Guid("a90e0e81-2aab-47a4-986e-ff841245f88c"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", 2022 },
                    { new Guid("eff8c039-b405-44a6-b726-a7779fdc9a99"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", 2022 },
                    { new Guid("fabb1354-4270-4484-935b-6e8760fe743b"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("00354cb6-d382-43c2-bbb9-f2332ed15b3d"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("03c275d2-58f3-4241-b333-47aaa1553150"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("040412f7-2d70-4343-bdf5-5b3dc708e82b"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("061efc2e-3ff0-4e9a-bae2-746f65ab1d7a"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0674cfd6-b467-44af-8d43-4374eff2ad67"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0b94ee79-a339-45a1-a872-2e285b4e1bd3"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("0d25ade5-afff-423d-b19e-0fcc655c86f1"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("145c1202-528d-4bd8-b835-7d31396f95d1"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("148dec1b-b85f-43c3-a488-01ddd3662360"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("178b3c73-4786-4394-acd0-d3daea546aeb"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("1c4407d7-7faa-46aa-8240-c3d9e8892698"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1c98f8f9-bdaa-4a4b-a760-14650e1c946c"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1f23ee80-f105-4d94-b5ee-9073157402ea"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1f3ee35a-c9c9-4c85-87ac-7b63d039f433"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("28a7d37c-19b7-4bc8-971e-b3b216a7094b"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("31e0bcb3-d6f6-4ed6-8167-2fd9da0e026a"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("33a69deb-98bb-4c56-8557-6a49ad2b6fa6"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("33a8e0ca-5137-434a-83a8-6a8111fa7846"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("358dce03-a804-467d-9636-e085d542290a"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3c494abe-7bd5-4af6-ba6f-4b88189ad67e"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3c5877f8-09f4-4a81-b951-cec9a5628d60"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3dc13666-b0dd-4c94-8d68-b4f56ecaf021"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("3fd574ff-b52f-476f-ad04-903e3b9b1760"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("44b79c21-25b1-4fc8-948c-0fd29c076e3a"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("4b9c0bd0-c265-4484-9c2f-87ed502f437f"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4e5a1aa3-cb1b-4ff7-93c1-d5c7b31e17d8"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("586f7ec0-2f92-42c8-83a1-c6574aa4bc20"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5b961f14-c3bf-4d2f-8f00-126b18a52e40"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5d7336b3-f4a3-4d73-b06e-5e53216b7820"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5f181d17-e478-4492-9957-3b15e1e095e1"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("60184cf6-a1cf-4bc2-b7bb-e42a84e12cc4"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("62c40bad-364d-4525-8a03-10012996362c"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("63f42463-0e07-4b7d-a8b9-a7f5d69c7416"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("659503ab-d39d-47b5-9e1b-c3982e678837"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("6be1d6dc-d680-4b0e-bf50-6e25e0b53d7b"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("7c240307-295f-4d2b-bf38-23e2a4028de1"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8007efa2-ef58-468a-bbc9-8e1943fde32e"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("80eb5bdc-907b-484d-98d7-caf4aad326e4"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("845da1c3-f27f-4934-8a29-5119c0835d4a"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8cd05550-5e44-4f42-a146-72326a7a3d62"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("90364019-1eda-4201-9bbb-2d3831f88b63"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("95ef5e8a-630c-4156-8670-6329da180e7c"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("99ab9134-6d12-4ae4-9874-410dba6c982b"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9a4d46eb-11fb-4815-8e43-84bf2a7395bb"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9c70c6bc-62d0-4673-970a-64a6e400e3a0"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("a14b1d87-9e2a-4a1c-a652-9ef9e77eeaa1"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a35f2089-dc02-4896-a724-8065dd46a4d4"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a6b57b05-b34c-43b2-afb1-e70d2757f87c"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a898a71d-c1d6-425b-9e08-6d473b57141e"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a97bb129-ed73-4cd5-aefc-e6ebabd312ce"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("adf72329-d6b0-4f19-8f37-58d955d73f34"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b177d523-2d61-461f-be6e-d5cc4676b8b7"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b4d7e64b-6104-4591-8b4f-d071b259a653"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b77ce178-3ba3-425b-ab93-951895e330a6"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b9a6bd78-3004-49db-8e50-0d66942311f9"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b9c61eda-bdba-41e9-a77b-b7cdba91bd7d"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bacc4261-e616-4afd-8d66-4a0292d885be"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("bc22a8b7-9172-4053-9718-3a20210b8b5e"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("bf6238b0-f90b-4f56-9f12-7d4441ed66d9"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d42873a5-5077-4433-a3d9-1285166f2b81"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d6e10878-8e82-42f7-afbc-420ce92f9b9a"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d862be64-738f-4642-9fa7-33cdc6109e1a"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("db63b4ae-9745-465a-b0db-a57d035aa782"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e0797daa-2690-48b1-8c84-8a5ad5d7f32e"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("e1b9806a-1658-4751-a54c-c35bba856fb8"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e5d1b583-08ad-455d-91cc-f05cf267b46a"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("e806e62b-028e-4f99-9f48-3bacadfb1b5a"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e8fcf922-f588-4d88-a210-fa4e81488298"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("eb64a0fd-0347-4925-969a-0ed4f7cb74bc"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("edf6d8af-d4dd-4742-bd63-251d1d1c4aa9"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("eff72538-ef5a-423b-beb8-4000a482697c"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f2a7c320-65c0-40c3-9cd2-6dc39ce4d15f"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f795761c-d5dd-4d93-9410-f1cb3e509698"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("fa41b600-968f-46b8-ac83-7d47936730b0"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("830fa90a-94f8-4b9e-8128-19e4cce41fc5"), new DateTime(2023, 4, 7, 14, 49, 7, 572, DateTimeKind.Local).AddTicks(2482), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" },
                    { new Guid("91e36a4c-6866-45f2-81e3-6bbebbce4def"), new DateTime(2023, 4, 7, 14, 49, 7, 572, DateTimeKind.Local).AddTicks(2465), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("ceefec89-fd65-4d31-b25c-eeaf19f6a7bc"), new DateTime(2023, 4, 7, 14, 49, 7, 572, DateTimeKind.Local).AddTicks(2323), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2637debe-222e-43c7-a0f3-65be9f459525"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("54d6f992-bd76-4186-abf0-cedccda2b968"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("58086cfa-445a-4f8e-9b58-0dad59d05d6f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7972ad14-d603-49e3-870c-406e79669428"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("887d4ba5-42d2-40d3-ac95-425eed995655"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9967a3c7-aee2-4410-a03f-4369ad7bc95c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9b457feb-74f0-4381-8934-4fb4ecdb3224"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a90e0e81-2aab-47a4-986e-ff841245f88c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("eff8c039-b405-44a6-b726-a7779fdc9a99"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fabb1354-4270-4484-935b-6e8760fe743b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00354cb6-d382-43c2-bbb9-f2332ed15b3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03c275d2-58f3-4241-b333-47aaa1553150"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("040412f7-2d70-4343-bdf5-5b3dc708e82b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("061efc2e-3ff0-4e9a-bae2-746f65ab1d7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0674cfd6-b467-44af-8d43-4374eff2ad67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b94ee79-a339-45a1-a872-2e285b4e1bd3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d25ade5-afff-423d-b19e-0fcc655c86f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("145c1202-528d-4bd8-b835-7d31396f95d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("148dec1b-b85f-43c3-a488-01ddd3662360"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("178b3c73-4786-4394-acd0-d3daea546aeb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c4407d7-7faa-46aa-8240-c3d9e8892698"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c98f8f9-bdaa-4a4b-a760-14650e1c946c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f23ee80-f105-4d94-b5ee-9073157402ea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f3ee35a-c9c9-4c85-87ac-7b63d039f433"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28a7d37c-19b7-4bc8-971e-b3b216a7094b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("31e0bcb3-d6f6-4ed6-8167-2fd9da0e026a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33a69deb-98bb-4c56-8557-6a49ad2b6fa6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33a8e0ca-5137-434a-83a8-6a8111fa7846"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("358dce03-a804-467d-9636-e085d542290a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c494abe-7bd5-4af6-ba6f-4b88189ad67e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c5877f8-09f4-4a81-b951-cec9a5628d60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3dc13666-b0dd-4c94-8d68-b4f56ecaf021"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3fd574ff-b52f-476f-ad04-903e3b9b1760"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44b79c21-25b1-4fc8-948c-0fd29c076e3a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b9c0bd0-c265-4484-9c2f-87ed502f437f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e5a1aa3-cb1b-4ff7-93c1-d5c7b31e17d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("586f7ec0-2f92-42c8-83a1-c6574aa4bc20"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b961f14-c3bf-4d2f-8f00-126b18a52e40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d7336b3-f4a3-4d73-b06e-5e53216b7820"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f181d17-e478-4492-9957-3b15e1e095e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60184cf6-a1cf-4bc2-b7bb-e42a84e12cc4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62c40bad-364d-4525-8a03-10012996362c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63f42463-0e07-4b7d-a8b9-a7f5d69c7416"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("659503ab-d39d-47b5-9e1b-c3982e678837"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6be1d6dc-d680-4b0e-bf50-6e25e0b53d7b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c240307-295f-4d2b-bf38-23e2a4028de1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8007efa2-ef58-468a-bbc9-8e1943fde32e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80eb5bdc-907b-484d-98d7-caf4aad326e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("845da1c3-f27f-4934-8a29-5119c0835d4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cd05550-5e44-4f42-a146-72326a7a3d62"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90364019-1eda-4201-9bbb-2d3831f88b63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95ef5e8a-630c-4156-8670-6329da180e7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99ab9134-6d12-4ae4-9874-410dba6c982b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a4d46eb-11fb-4815-8e43-84bf2a7395bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c70c6bc-62d0-4673-970a-64a6e400e3a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a14b1d87-9e2a-4a1c-a652-9ef9e77eeaa1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a35f2089-dc02-4896-a724-8065dd46a4d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6b57b05-b34c-43b2-afb1-e70d2757f87c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a898a71d-c1d6-425b-9e08-6d473b57141e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a97bb129-ed73-4cd5-aefc-e6ebabd312ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("adf72329-d6b0-4f19-8f37-58d955d73f34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b177d523-2d61-461f-be6e-d5cc4676b8b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4d7e64b-6104-4591-8b4f-d071b259a653"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b77ce178-3ba3-425b-ab93-951895e330a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9a6bd78-3004-49db-8e50-0d66942311f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9c61eda-bdba-41e9-a77b-b7cdba91bd7d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bacc4261-e616-4afd-8d66-4a0292d885be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc22a8b7-9172-4053-9718-3a20210b8b5e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf6238b0-f90b-4f56-9f12-7d4441ed66d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d42873a5-5077-4433-a3d9-1285166f2b81"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6e10878-8e82-42f7-afbc-420ce92f9b9a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d862be64-738f-4642-9fa7-33cdc6109e1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db63b4ae-9745-465a-b0db-a57d035aa782"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0797daa-2690-48b1-8c84-8a5ad5d7f32e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1b9806a-1658-4751-a54c-c35bba856fb8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5d1b583-08ad-455d-91cc-f05cf267b46a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e806e62b-028e-4f99-9f48-3bacadfb1b5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8fcf922-f588-4d88-a210-fa4e81488298"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb64a0fd-0347-4925-969a-0ed4f7cb74bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("edf6d8af-d4dd-4742-bd63-251d1d1c4aa9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eff72538-ef5a-423b-beb8-4000a482697c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2a7c320-65c0-40c3-9cd2-6dc39ce4d15f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f795761c-d5dd-4d93-9410-f1cb3e509698"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa41b600-968f-46b8-ac83-7d47936730b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("830fa90a-94f8-4b9e-8128-19e4cce41fc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91e36a4c-6866-45f2-81e3-6bbebbce4def"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ceefec89-fd65-4d31-b25c-eeaf19f6a7bc"));

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
        }
    }
}
