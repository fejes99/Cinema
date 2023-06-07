using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class hashpasswords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("10c86ef1-7e21-441f-8d62-e3054cff95f5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("23e263bd-30fa-47f4-bbf0-013657b1c507"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3b3e3990-3d6a-4aaf-b0e2-ed3eca4261fd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4004fea8-74d2-4a71-a3c8-f05c36536907"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4c4c4b8c-df57-4db1-8054-7ce438b04e4f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7cc6f3c7-a0fc-4440-8658-9fded1dcc9f4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("aa9f94a6-3388-45d9-9101-f1ec24e823ad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b4943141-f23c-4b27-8280-7bb6fae9e71b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c88c34e4-03e5-490e-a22c-0067fd122f73"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ec928e1d-ce3a-4d3f-86e8-0d589a8c68c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01449d1b-e1f4-41e8-83c0-542a7c9e33c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01943ad6-8a49-4e3e-bd76-92c9b1741188"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0405dba9-4e06-441d-94de-8a159b59f24b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04190d0a-73a1-439c-9e0a-2f2c55702f56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05eca72a-0b78-44fd-9d26-71c9c5675d68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("124a3273-6d2c-4e71-8a56-ce0026c0695e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15e57a3c-059c-4193-aacd-8e10fd59f38f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("173dd83d-f881-4be1-b83c-fa6063cb0c8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18226d1d-84b9-45ff-9c8f-62967759056f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b895433-f86e-47a1-b39a-f4743d4dd28d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f43615a-3fca-4a2c-b800-7c1cae161be8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ffcd6f1-5583-44d5-a28a-e49e762a9b15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2471c381-d1f1-4a29-bf46-558deed2c934"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a01d22c-5005-4f49-bf55-270cb969752c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b5cd9f6-43ba-4952-aa77-9bb15d1b69e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2bb1b74c-adbb-4fc3-bc64-e3edc89eaf1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30dd27bd-f1ae-4b17-b6d6-2f0a81fccf7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bc17172-b28c-4e6c-908c-7740f5717d52"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c040723-6d04-487f-9606-c40900346361"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c0790bd-f60e-4c0d-82b7-2d2995bfeab9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f4701a6-5863-4e2f-baee-e00f264c8a3a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48d0970e-707f-4992-a9dc-1a987a69d1da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e4cb5eb-4a3e-473b-ba43-03cc8d41146a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5045bc1d-f7ff-4e3e-8173-d06fb3162b91"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("52dd18a0-ddf4-4861-9285-0cdac4fb8fb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e442277-fcde-42bb-a8f9-87de46eae8d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60776fef-6417-44c5-9ac5-036d83d82933"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6552b201-8d54-4f06-b126-47ba9e6d1d02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6726afe8-42c8-4e6a-8449-991788d05363"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("680e36a4-2671-45c0-bfe1-48b8cbc0efdc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69a602d5-c900-4e0e-8c19-65e6e6224340"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fecc9b6-ef50-4c31-bfc1-1de27cdedc9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("725399b6-9169-4ed4-9e19-854fa89a9307"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74ef9938-6135-44ea-9577-e21b88052f85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c045a30-c0f6-4c22-9f1d-2ebc3694a1a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ca18c4e-eac7-4456-a81a-1dc2d36757a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d3cd869-1f03-4a69-8a01-381e769fdea3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d3fbac3-1f1c-4063-936e-9158693fe042"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8639559c-32c4-4646-9914-24a4cce8d92a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87bf0088-380f-43ef-a0bc-e3979f6dad44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88ab28f6-a737-40f5-8d3f-71036ad31286"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8deb73de-eb6e-4316-8153-439aa8568df7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91dd2eaa-1407-4cb2-9638-3c745f4f4e00"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("93be46e4-cdbc-4c39-807f-b32cac69c343"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94aad96c-74e3-4c98-9626-2f8c3dcbbb4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99af3ab1-2c1a-42d1-b4e6-c30998363320"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d25e738-8958-4b95-b428-a685b62e2cba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e764c8d-671b-4625-b1e6-e4bf081b0280"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4bec694-1867-4983-a04f-59d41e93b899"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abda2c0e-a32f-4f9e-8d05-9cdb3f81f3d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac4c8b68-b6d8-4019-bad6-f2f3468b2643"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2019762-2c83-44a2-a8c3-80fce9fc6bd3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7692d52-b934-4425-9ff0-7758f6765231"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ba334433-4889-4de7-8c2d-09364a78d850"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("badc8d35-5741-45a7-9855-07e1e834695a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2382137-578c-4f68-836f-509db9c8750c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c560dd83-8fb5-4583-8ea0-69c814d1a13e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c95396eb-5321-4123-bf94-8557ef3abcc3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca20bf6b-3d65-46ff-8c44-f30701b30757"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cba60072-258c-4d5e-9ada-46db55705fff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cee74c84-28f7-40a9-8306-bc584311899a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2768ac8-935b-4dd8-a3fc-6b83c46ec4a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d484a36c-684c-491a-9dc1-cceefa5fa812"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d890fe82-1c10-47e6-a58f-d2cc20a1880a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db35c1e6-9059-4974-8300-aa2400a29880"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e04e566c-2d87-404f-be14-2bd4d2ebe3a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e13bad23-7388-4fa2-b97d-761cb53614a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e861f5b7-fa78-4ef7-9181-dc71817dffd1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7a5ebf4-ffe0-45db-b9c4-89962586b7bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f93c7c4c-4bbb-45cd-ba6d-4e4877621da3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("faabec05-7d21-415b-8709-28f1e7f339ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fccb650b-14ba-49e2-9f5b-5f36c52ef1df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd51bdaf-6c28-4109-8790-5dd88c4a485a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff760ed3-c6b1-4462-bc35-22654d60b0ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16488b2b-14a8-431b-bf54-56c416a79137"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d6bf867-e024-4223-b2fc-63572cba211b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62411419-99f5-4bb3-b934-e1ee5e281b65"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("167e4cd1-9bea-47b3-aab7-367abd0c57d6"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("34ffff22-c291-4997-8f32-1fd6da6db1cf"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("3b24859f-1759-4f18-b390-4e7102ecae31"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("596ec78a-69df-4d5e-92d9-53ce545c9288"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("6902d178-108c-4af9-a2a2-90b6cd812636"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("93bda621-7e3e-4429-b58b-278c7797d029"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("980eaa7b-5a2a-4dc6-9f15-fd515f88ebd2"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("b18dd2f4-78c9-43b2-a209-8e693fa5434d"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("b98edfd6-2e39-48e8-af71-0141784b6573"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("ea6e627f-278f-411f-955c-83fde6bd9235"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("0011d922-8a00-4b16-b9fe-080a177bbeb5"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("04d3edaa-796f-45cc-b936-072ad32d5473"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("09782c51-dfad-4a9d-934a-07fb748c7206"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0ab63d84-315c-44f3-b127-45b581cc8714"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("196dce22-eadb-4069-b042-7c34ba4aa795"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("199ccfdc-74f5-47fe-88a0-9aca3a798402"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("1ba0b044-0444-4462-9d90-3819b7aeb91d"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2228b887-f4b5-4a6e-b153-b0aed4a8ba0a"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("24cd3655-5e46-4400-aaa3-5f963bba3ac7"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("27d307cd-4c38-4620-aadb-0d7853a16ef6"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("292935de-329c-4bb4-b8ff-36c815159db1"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2c0cdaea-9b57-4e93-8f36-317ea0efc513"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2c2038a5-ed73-469d-8130-2bfcf1817842"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2c7cb126-bd97-40dc-9bdf-f81eb30840b2"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2fdaf86c-51c3-4392-9b7f-0051c4db856e"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("317a5d8b-413f-434d-9ff7-700860c97291"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3b4ac823-a309-4bc5-8a6a-8c1d9cf5bb47"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("465ddef2-206f-49b6-819d-0e73372ee120"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("531e6dea-7e20-40ce-91f0-754ee0a92a45"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("58ef703a-95f8-41cf-9f3f-70608c60dd7f"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("58fc1bd5-f2c4-4ac6-b5d1-62b512d78444"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5c164500-d395-4fee-8f9e-71c1a1d4766d"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5e55bc81-b4c6-49da-933a-b3d67b6f4332"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5ffbe391-0ca0-450f-8ded-830f9472f982"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("61b18d53-a963-47e8-833e-e75dd1f1ca01"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("67656b12-b10b-4ebf-a61d-8695da675a00"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("67b76a0f-cd85-465f-8d9a-ec0347f6d463"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("68f8c5e3-a0cd-4512-ad79-88d4f934176a"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("6fd7dee4-5261-4875-b0ab-287a0b34ee96"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("71c70a10-c669-489c-b4d3-d146c063f238"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7402db3d-1597-4621-829e-1f45df976662"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("741acf48-2ec6-4228-a89f-cbdf40abd6e3"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("742251d2-c125-4b3c-9b0b-812594012d9a"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7a97ae1f-01e9-4da7-a9db-a1f435f340ae"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("7c6455a0-32cb-421c-8787-5dee67f50478"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7f959f6e-a7d4-4037-ae46-8287c467949d"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8e7969c9-452f-4edd-ba47-3a34f54c2c08"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("941f6701-8d04-4ba8-bf05-7698b1f277a3"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("94b57ee6-6d4e-4e4b-becc-94386a0b103d"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("95d4c708-0444-4bb9-8027-cf07198b2bc5"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9eab88ed-0467-4be9-b21d-38cc96bc7260"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9efd6c26-8cc4-49d4-96f5-fecbf3079f21"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("9f00d58a-6daf-42ac-8d31-f9d908d9563a"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ab37576c-e069-4be2-b405-5506e7b9eef0"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("acf5efa5-9b7f-42c3-b02c-febe1618527a"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ae691694-b0d5-4276-9455-ab56ec125525"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("aeb9c568-156b-499e-86de-264359909c1b"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b21f1c04-28a2-40b5-8a4b-d674fa30788f"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b5c53282-6fa8-4d63-8096-badff3535694"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("bba8b654-25be-4135-ad51-7133361723b1"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bd6118b6-3f22-4662-8ef6-a005614a4650"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("bf298b36-317d-4da5-9fd3-612a0fc7e978"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("bf68163d-9d8d-47c7-b2ef-2cf213a8c0cd"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("bf9ab98c-3912-4398-a353-314349fbaa90"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c49e51cb-d1b1-4ccb-a155-7a7037936d0f"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c5bcd9db-1e06-41e4-a0ea-2fba5642ca3c"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c5d4a064-c2e5-4b45-bf8b-2ea10a4334bd"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("ce10126e-e83a-4c4a-ab77-89f2be4fab2b"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("cfccb01f-0e5a-4f70-b849-77efb5315586"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d276ed0e-858c-4ef3-ae38-fa01774b3c32"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d99c8981-8f07-43a1-8180-2f6ef1fa6d84"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("da120745-53ae-4cbf-bb98-eace118f248f"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("da16f496-110a-41b3-95b3-8904fc522aa4"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("da67c345-5f0d-44b2-9dc5-993a9680081b"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("db271da4-27e9-4e17-b8f2-75da32385f16"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e9a81486-411c-418a-9715-799bbdb4fcdc"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("efac2ee8-e246-46bc-b669-7accc389184d"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f16fc2bf-76f9-4467-9c04-07b737013740"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("f317d2a0-2b04-4255-8cdf-81972422a534"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f698cecc-859e-4acb-9be3-fd114ead6952"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("f9751b58-6174-4ec0-a690-c6dccc2ebcd8"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("fa39a31f-0e3c-4462-93cd-872a730e6fbb"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("fa45cd27-d1a8-42f7-8b0e-075a414a44b4"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ffa762f6-5ef6-43ab-a411-c977bdc63256"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("41b60ed7-eb33-447f-b07c-d69ecd0ba948"), new DateTime(2023, 6, 6, 11, 19, 26, 171, DateTimeKind.Local).AddTicks(1314), "david.fejes@gmail.com", "David", "Fejes", "$2a$11$TukhT.m34UT.eAA64SiNW.AvFC6jlPAchXCTW7poyrNj0kyqU4aKy", "User", "davidfejes" },
                    { new Guid("9849d60e-f978-4b05-a3e1-8e9bdf45e6cb"), new DateTime(2023, 6, 6, 11, 19, 26, 325, DateTimeKind.Local).AddTicks(1913), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "$2a$11$4ck0R77zrv4j/Oy9JsbFmOPFnDsGyeGhscNtWa/fziRNdsZs/6BoG", "User", "stefanbulaja" },
                    { new Guid("f883d09f-6a12-495b-9aeb-fa3c7968f390"), new DateTime(2023, 6, 6, 11, 19, 26, 479, DateTimeKind.Local).AddTicks(5662), "andija.tasic@gmail.com", "Andrija", "Tasic", "$2a$11$/czC.HYOFUOt6C6CSGuCPOMk1nCG9VqKTpulHjstekB6ng47gEpWq", "User", "andrijatasic" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SeatId",
                table: "Tickets",
                column: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Seats_SeatId",
                table: "Tickets",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Seats_SeatId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_SeatId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("167e4cd1-9bea-47b3-aab7-367abd0c57d6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("34ffff22-c291-4997-8f32-1fd6da6db1cf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3b24859f-1759-4f18-b390-4e7102ecae31"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("596ec78a-69df-4d5e-92d9-53ce545c9288"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6902d178-108c-4af9-a2a2-90b6cd812636"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("93bda621-7e3e-4429-b58b-278c7797d029"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("980eaa7b-5a2a-4dc6-9f15-fd515f88ebd2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b18dd2f4-78c9-43b2-a209-8e693fa5434d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b98edfd6-2e39-48e8-af71-0141784b6573"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ea6e627f-278f-411f-955c-83fde6bd9235"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0011d922-8a00-4b16-b9fe-080a177bbeb5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04d3edaa-796f-45cc-b936-072ad32d5473"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09782c51-dfad-4a9d-934a-07fb748c7206"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0ab63d84-315c-44f3-b127-45b581cc8714"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("196dce22-eadb-4069-b042-7c34ba4aa795"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("199ccfdc-74f5-47fe-88a0-9aca3a798402"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ba0b044-0444-4462-9d90-3819b7aeb91d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2228b887-f4b5-4a6e-b153-b0aed4a8ba0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24cd3655-5e46-4400-aaa3-5f963bba3ac7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27d307cd-4c38-4620-aadb-0d7853a16ef6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("292935de-329c-4bb4-b8ff-36c815159db1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c0cdaea-9b57-4e93-8f36-317ea0efc513"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c2038a5-ed73-469d-8130-2bfcf1817842"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c7cb126-bd97-40dc-9bdf-f81eb30840b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2fdaf86c-51c3-4392-9b7f-0051c4db856e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("317a5d8b-413f-434d-9ff7-700860c97291"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b4ac823-a309-4bc5-8a6a-8c1d9cf5bb47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("465ddef2-206f-49b6-819d-0e73372ee120"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("531e6dea-7e20-40ce-91f0-754ee0a92a45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58ef703a-95f8-41cf-9f3f-70608c60dd7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58fc1bd5-f2c4-4ac6-b5d1-62b512d78444"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5c164500-d395-4fee-8f9e-71c1a1d4766d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e55bc81-b4c6-49da-933a-b3d67b6f4332"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ffbe391-0ca0-450f-8ded-830f9472f982"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61b18d53-a963-47e8-833e-e75dd1f1ca01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67656b12-b10b-4ebf-a61d-8695da675a00"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67b76a0f-cd85-465f-8d9a-ec0347f6d463"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("68f8c5e3-a0cd-4512-ad79-88d4f934176a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fd7dee4-5261-4875-b0ab-287a0b34ee96"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71c70a10-c669-489c-b4d3-d146c063f238"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7402db3d-1597-4621-829e-1f45df976662"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("741acf48-2ec6-4228-a89f-cbdf40abd6e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("742251d2-c125-4b3c-9b0b-812594012d9a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a97ae1f-01e9-4da7-a9db-a1f435f340ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c6455a0-32cb-421c-8787-5dee67f50478"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f959f6e-a7d4-4037-ae46-8287c467949d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e7969c9-452f-4edd-ba47-3a34f54c2c08"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("941f6701-8d04-4ba8-bf05-7698b1f277a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94b57ee6-6d4e-4e4b-becc-94386a0b103d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95d4c708-0444-4bb9-8027-cf07198b2bc5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9eab88ed-0467-4be9-b21d-38cc96bc7260"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9efd6c26-8cc4-49d4-96f5-fecbf3079f21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f00d58a-6daf-42ac-8d31-f9d908d9563a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab37576c-e069-4be2-b405-5506e7b9eef0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("acf5efa5-9b7f-42c3-b02c-febe1618527a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae691694-b0d5-4276-9455-ab56ec125525"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aeb9c568-156b-499e-86de-264359909c1b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b21f1c04-28a2-40b5-8a4b-d674fa30788f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5c53282-6fa8-4d63-8096-badff3535694"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bba8b654-25be-4135-ad51-7133361723b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd6118b6-3f22-4662-8ef6-a005614a4650"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf298b36-317d-4da5-9fd3-612a0fc7e978"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf68163d-9d8d-47c7-b2ef-2cf213a8c0cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf9ab98c-3912-4398-a353-314349fbaa90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c49e51cb-d1b1-4ccb-a155-7a7037936d0f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5bcd9db-1e06-41e4-a0ea-2fba5642ca3c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5d4a064-c2e5-4b45-bf8b-2ea10a4334bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce10126e-e83a-4c4a-ab77-89f2be4fab2b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfccb01f-0e5a-4f70-b849-77efb5315586"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d276ed0e-858c-4ef3-ae38-fa01774b3c32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d99c8981-8f07-43a1-8180-2f6ef1fa6d84"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da120745-53ae-4cbf-bb98-eace118f248f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da16f496-110a-41b3-95b3-8904fc522aa4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da67c345-5f0d-44b2-9dc5-993a9680081b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db271da4-27e9-4e17-b8f2-75da32385f16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9a81486-411c-418a-9715-799bbdb4fcdc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efac2ee8-e246-46bc-b669-7accc389184d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f16fc2bf-76f9-4467-9c04-07b737013740"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f317d2a0-2b04-4255-8cdf-81972422a534"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f698cecc-859e-4acb-9be3-fd114ead6952"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9751b58-6174-4ec0-a690-c6dccc2ebcd8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa39a31f-0e3c-4462-93cd-872a730e6fbb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa45cd27-d1a8-42f7-8b0e-075a414a44b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ffa762f6-5ef6-43ab-a411-c977bdc63256"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41b60ed7-eb33-447f-b07c-d69ecd0ba948"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9849d60e-f978-4b05-a3e1-8e9bdf45e6cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f883d09f-6a12-495b-9aeb-fa3c7968f390"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("10c86ef1-7e21-441f-8d62-e3054cff95f5"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("23e263bd-30fa-47f4-bbf0-013657b1c507"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("3b3e3990-3d6a-4aaf-b0e2-ed3eca4261fd"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("4004fea8-74d2-4a71-a3c8-f05c36536907"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("4c4c4b8c-df57-4db1-8054-7ce438b04e4f"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("7cc6f3c7-a0fc-4440-8658-9fded1dcc9f4"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("aa9f94a6-3388-45d9-9101-f1ec24e823ad"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("b4943141-f23c-4b27-8280-7bb6fae9e71b"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("c88c34e4-03e5-490e-a22c-0067fd122f73"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("ec928e1d-ce3a-4d3f-86e8-0d589a8c68c5"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("01449d1b-e1f4-41e8-83c0-542a7c9e33c2"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("01943ad6-8a49-4e3e-bd76-92c9b1741188"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0405dba9-4e06-441d-94de-8a159b59f24b"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("04190d0a-73a1-439c-9e0a-2f2c55702f56"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("05eca72a-0b78-44fd-9d26-71c9c5675d68"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("124a3273-6d2c-4e71-8a56-ce0026c0695e"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("15e57a3c-059c-4193-aacd-8e10fd59f38f"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("173dd83d-f881-4be1-b83c-fa6063cb0c8e"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("18226d1d-84b9-45ff-9c8f-62967759056f"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1b895433-f86e-47a1-b39a-f4743d4dd28d"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("1f43615a-3fca-4a2c-b800-7c1cae161be8"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("1ffcd6f1-5583-44d5-a28a-e49e762a9b15"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2471c381-d1f1-4a29-bf46-558deed2c934"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2a01d22c-5005-4f49-bf55-270cb969752c"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2b5cd9f6-43ba-4952-aa77-9bb15d1b69e6"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2bb1b74c-adbb-4fc3-bc64-e3edc89eaf1a"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("30dd27bd-f1ae-4b17-b6d6-2f0a81fccf7c"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("3bc17172-b28c-4e6c-908c-7740f5717d52"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3c040723-6d04-487f-9606-c40900346361"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3c0790bd-f60e-4c0d-82b7-2d2995bfeab9"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("3f4701a6-5863-4e2f-baee-e00f264c8a3a"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("48d0970e-707f-4992-a9dc-1a987a69d1da"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4e4cb5eb-4a3e-473b-ba43-03cc8d41146a"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("5045bc1d-f7ff-4e3e-8173-d06fb3162b91"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("52dd18a0-ddf4-4861-9285-0cdac4fb8fb3"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5e442277-fcde-42bb-a8f9-87de46eae8d3"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("60776fef-6417-44c5-9ac5-036d83d82933"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("6552b201-8d54-4f06-b126-47ba9e6d1d02"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6726afe8-42c8-4e6a-8449-991788d05363"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("680e36a4-2671-45c0-bfe1-48b8cbc0efdc"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("69a602d5-c900-4e0e-8c19-65e6e6224340"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6fecc9b6-ef50-4c31-bfc1-1de27cdedc9e"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("725399b6-9169-4ed4-9e19-854fa89a9307"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("74ef9938-6135-44ea-9577-e21b88052f85"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("7c045a30-c0f6-4c22-9f1d-2ebc3694a1a7"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7ca18c4e-eac7-4456-a81a-1dc2d36757a7"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("7d3cd869-1f03-4a69-8a01-381e769fdea3"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("7d3fbac3-1f1c-4063-936e-9158693fe042"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8639559c-32c4-4646-9914-24a4cce8d92a"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("87bf0088-380f-43ef-a0bc-e3979f6dad44"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("88ab28f6-a737-40f5-8d3f-71036ad31286"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8deb73de-eb6e-4316-8153-439aa8568df7"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("91dd2eaa-1407-4cb2-9638-3c745f4f4e00"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("93be46e4-cdbc-4c39-807f-b32cac69c343"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("94aad96c-74e3-4c98-9626-2f8c3dcbbb4a"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("99af3ab1-2c1a-42d1-b4e6-c30998363320"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9d25e738-8958-4b95-b428-a685b62e2cba"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9e764c8d-671b-4625-b1e6-e4bf081b0280"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a4bec694-1867-4983-a04f-59d41e93b899"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("abda2c0e-a32f-4f9e-8d05-9cdb3f81f3d7"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("ac4c8b68-b6d8-4019-bad6-f2f3468b2643"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b2019762-2c83-44a2-a8c3-80fce9fc6bd3"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b7692d52-b934-4425-9ff0-7758f6765231"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ba334433-4889-4de7-8c2d-09364a78d850"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("badc8d35-5741-45a7-9855-07e1e834695a"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c2382137-578c-4f68-836f-509db9c8750c"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c560dd83-8fb5-4583-8ea0-69c814d1a13e"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c95396eb-5321-4123-bf94-8557ef3abcc3"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("ca20bf6b-3d65-46ff-8c44-f30701b30757"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("cba60072-258c-4d5e-9ada-46db55705fff"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("cee74c84-28f7-40a9-8306-bc584311899a"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("d2768ac8-935b-4dd8-a3fc-6b83c46ec4a0"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d484a36c-684c-491a-9dc1-cceefa5fa812"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d890fe82-1c10-47e6-a58f-d2cc20a1880a"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("db35c1e6-9059-4974-8300-aa2400a29880"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("e04e566c-2d87-404f-be14-2bd4d2ebe3a9"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e13bad23-7388-4fa2-b97d-761cb53614a4"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e861f5b7-fa78-4ef7-9181-dc71817dffd1"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f7a5ebf4-ffe0-45db-b9c4-89962586b7bc"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("f93c7c4c-4bbb-45cd-ba6d-4e4877621da3"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("faabec05-7d21-415b-8709-28f1e7f339ff"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("fccb650b-14ba-49e2-9f5b-5f36c52ef1df"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("fd51bdaf-6c28-4109-8790-5dd88c4a485a"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ff760ed3-c6b1-4462-bc35-22654d60b0ca"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("16488b2b-14a8-431b-bf54-56c416a79137"), new DateTime(2023, 5, 4, 10, 57, 38, 137, DateTimeKind.Local).AddTicks(1557), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" },
                    { new Guid("2d6bf867-e024-4223-b2fc-63572cba211b"), new DateTime(2023, 5, 4, 10, 57, 38, 137, DateTimeKind.Local).AddTicks(1368), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" },
                    { new Guid("62411419-99f5-4bb3-b934-e1ee5e281b65"), new DateTime(2023, 5, 4, 10, 57, 38, 137, DateTimeKind.Local).AddTicks(1546), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" }
                });
        }
    }
}
