using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedmoviesseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "TrailerUrl",
                table: "Movies",
                type: "TEXT",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TrailerUrl",
                table: "Movies");

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
    }
}
