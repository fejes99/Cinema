using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class userstest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("20f28fc0-d350-48c4-9ef4-4b6d067148ff"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("2d8fcf21-8722-4645-b480-ac82397b74e5"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("3b71a3ca-cdd5-483f-97a9-28c4fd26b1ba"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("4031754a-8f3a-436a-bac9-27f58876d0ad"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("40c8345a-9d07-4076-a7a0-1e1f2554f2de"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("5fb40da4-7dee-4a8d-bed0-8132734d3a66"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("acb732dd-a178-46ec-86e1-bea1c54f660e"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("d2dd848d-f101-4364-be36-a61ea73b428b"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("ed74bbe1-a6ef-412a-8583-723a51e7a91d"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("fd5ebb33-153f-4210-b703-b52a89a304a1"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("0046b67d-fb1f-4bf7-892b-123c9a628c8b"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("0863af48-8ec8-4178-b0ae-0a87c7e138c8"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("09abb57f-2582-4c7e-aae5-258a46002586"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("0dd478ff-f56f-48fc-a2a4-de54f78f2b46"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0fe894c1-6336-4f06-b3a0-7060a8c790dc"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("100012b6-02f4-4527-a9d6-9c16c46c17cb"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("11143566-3cf3-4e75-86a9-7c4775667102"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1831143c-32f8-4841-ae25-c863c22202e0"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("222e74ae-7ae7-4cf3-9b7b-fee63e1f8da0"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("26f02883-fe6d-4483-96e3-f21ec1dc8ed5"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("28df4acc-89d8-4022-8e11-2b65cf376fe9"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("29aa5cdb-4a1d-49f5-9b08-e800520b7ed4"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2a8a1b3a-13d9-46c7-ba55-5d648544e55e"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2aac56f3-ecdb-4a6d-8e60-22ae886ba27a"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("2b0a0f22-a285-4e95-8186-0bb32848138e"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("2d3a45c4-b0f6-4ccd-88ec-16d4dc71d1b1"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("38c14711-9816-4318-ac2a-b553f458124b"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3bd2ad3b-8519-4754-bdbd-f131562ccf2d"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3d2e329a-84e2-4ca5-99de-313d388c81e9"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3d3034e7-add0-4998-b24d-a7f5c18cd8a0"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3db872f1-e7cb-48a6-92bb-50c39647c38f"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("400af73f-0a97-4e63-a5f6-20905b2da76a"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("41282c79-ceff-4de5-a3a8-aee5773bdff2"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("42d284ed-488f-4201-b3fc-66b787f9250e"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("4577bcce-4454-427d-9c74-6cf4a375ba6f"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("45ec884e-c27d-4589-91ff-5b4a321b6996"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("46432d05-eb59-431d-9c23-0d2c55eb4c1a"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4c1b9687-9603-4d9f-82ed-424c4751b254"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("4e66a06d-f5ff-491f-af97-e3edbeee59ef"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5048603d-241a-4af8-9691-b7817e8d693b"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5103d314-1258-4740-9697-3954ddb5a1b6"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5bcc886d-1b12-44b3-8cc8-d5ff2df3ae58"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5cd82d22-27a7-48d2-98e7-a595dad6ec43"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5e3ce801-8bc0-4d7a-9b6e-6d2947c2f4cb"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("67763dd9-2abd-4880-a318-0c825c579180"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("684364d8-e0b4-4a43-8e3c-74f749752956"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("69022a3e-6c16-4c43-a257-b4308ef0fc74"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("6bfd25e7-53c4-4c1d-b4de-8e7a0cf2cac3"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7115dc53-7db4-4ba0-8ef2-299b58d0b8d8"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("770dcd0e-b8e8-442a-8cd4-e3b46550599f"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("77602f7e-0e39-4c07-bea1-eaf8ccaf8be4"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7842956d-1684-4f98-a572-e06585dcf766"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("79ebd0f5-2c66-4d8e-b6b1-20bc67ac3a49"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8133da6d-44eb-4427-a796-2fb9ec30c4c3"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("867b2d0c-91bb-4686-874e-6a1c0f6efa3a"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("87fc03d7-7442-44bd-bc28-3d63aa186768"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8fb83d5d-49c4-4a9b-9e9f-8bf033ca4048"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("904e36bc-243c-42ec-b6fb-4f7e11ba7e58"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("974fbc40-d5db-4a21-884f-e4154479e403"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("99b35cdc-95ea-425d-bb2a-d661fa2941ab"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a001fe0e-8353-433c-92b7-8b01c1d8d10f"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a13f974c-547b-4006-8023-e6c32d79c025"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a7b7179d-f2c4-4f19-add6-62e18e96f8d5"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("afd6e800-b96f-4fde-b49f-4aa728e30b19"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("b59d3cc2-f878-41f3-9492-eec068adfbf4"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b97c5e83-b7ee-4d75-a85c-d70e119a715a"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c42a618d-c23a-4ad8-a10b-ad750fe0ea7c"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ca139881-2229-46c9-bc6e-290a4a62a25d"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("cc9b67ce-f447-42cf-b151-d75d02765d98"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cd370235-6c3a-4588-9da9-88d22c56a589"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("ce95338c-65d8-4cc3-b3af-11f6a9e8330c"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cf0dd795-8592-41af-8175-8e99576067b2"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d0419155-6d9d-4934-af9b-7d351efdc981"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d187a531-381b-4039-ba8d-fa2f3113d704"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d19da87d-301f-415c-864d-29a5c8c1e0c9"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("d81ce279-7c22-4b62-97d1-3c6244c56b58"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d901b512-9248-4f5f-a32b-2e3ec8579b7b"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d92d2bed-d754-4f64-8b14-ac3016147bce"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("dd38c62c-b9e4-4e3a-84fe-79c1a3a6f919"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e6a3d1d1-4200-47cc-bd60-71ad0ad81a85"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("f2a2ed74-7f49-41c5-a71e-b3b9a1087ffb"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f622d842-2624-40a3-ad7f-7b0bb87499fc"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("fa051c6b-07a9-4192-93b0-c28217bbd632"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fb425362-8d96-4873-a4d5-eb0f837a2c35"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3cfbc6e2-f5ea-465b-8279-0b2ff976977c"), new DateTime(2023, 5, 4, 10, 37, 31, 675, DateTimeKind.Local).AddTicks(2535), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" },
                    { new Guid("7a72cd6c-3290-4301-9453-3bc94f525075"), new DateTime(2023, 5, 4, 10, 37, 31, 675, DateTimeKind.Local).AddTicks(2460), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" },
                    { new Guid("d117194c-0b31-4c5a-8408-7681b6839b5d"), new DateTime(2023, 5, 4, 10, 37, 31, 675, DateTimeKind.Local).AddTicks(2310), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("20f28fc0-d350-48c4-9ef4-4b6d067148ff"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2d8fcf21-8722-4645-b480-ac82397b74e5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3b71a3ca-cdd5-483f-97a9-28c4fd26b1ba"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4031754a-8f3a-436a-bac9-27f58876d0ad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("40c8345a-9d07-4076-a7a0-1e1f2554f2de"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5fb40da4-7dee-4a8d-bed0-8132734d3a66"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("acb732dd-a178-46ec-86e1-bea1c54f660e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d2dd848d-f101-4364-be36-a61ea73b428b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ed74bbe1-a6ef-412a-8583-723a51e7a91d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fd5ebb33-153f-4210-b703-b52a89a304a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0046b67d-fb1f-4bf7-892b-123c9a628c8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0863af48-8ec8-4178-b0ae-0a87c7e138c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09abb57f-2582-4c7e-aae5-258a46002586"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0dd478ff-f56f-48fc-a2a4-de54f78f2b46"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fe894c1-6336-4f06-b3a0-7060a8c790dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("100012b6-02f4-4527-a9d6-9c16c46c17cb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11143566-3cf3-4e75-86a9-7c4775667102"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1831143c-32f8-4841-ae25-c863c22202e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("222e74ae-7ae7-4cf3-9b7b-fee63e1f8da0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26f02883-fe6d-4483-96e3-f21ec1dc8ed5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28df4acc-89d8-4022-8e11-2b65cf376fe9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29aa5cdb-4a1d-49f5-9b08-e800520b7ed4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a8a1b3a-13d9-46c7-ba55-5d648544e55e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2aac56f3-ecdb-4a6d-8e60-22ae886ba27a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b0a0f22-a285-4e95-8186-0bb32848138e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d3a45c4-b0f6-4ccd-88ec-16d4dc71d1b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38c14711-9816-4318-ac2a-b553f458124b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bd2ad3b-8519-4754-bdbd-f131562ccf2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d2e329a-84e2-4ca5-99de-313d388c81e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d3034e7-add0-4998-b24d-a7f5c18cd8a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3db872f1-e7cb-48a6-92bb-50c39647c38f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("400af73f-0a97-4e63-a5f6-20905b2da76a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("41282c79-ceff-4de5-a3a8-aee5773bdff2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42d284ed-488f-4201-b3fc-66b787f9250e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4577bcce-4454-427d-9c74-6cf4a375ba6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45ec884e-c27d-4589-91ff-5b4a321b6996"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46432d05-eb59-431d-9c23-0d2c55eb4c1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c1b9687-9603-4d9f-82ed-424c4751b254"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e66a06d-f5ff-491f-af97-e3edbeee59ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5048603d-241a-4af8-9691-b7817e8d693b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5103d314-1258-4740-9697-3954ddb5a1b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bcc886d-1b12-44b3-8cc8-d5ff2df3ae58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5cd82d22-27a7-48d2-98e7-a595dad6ec43"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e3ce801-8bc0-4d7a-9b6e-6d2947c2f4cb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67763dd9-2abd-4880-a318-0c825c579180"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("684364d8-e0b4-4a43-8e3c-74f749752956"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69022a3e-6c16-4c43-a257-b4308ef0fc74"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6bfd25e7-53c4-4c1d-b4de-8e7a0cf2cac3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7115dc53-7db4-4ba0-8ef2-299b58d0b8d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("770dcd0e-b8e8-442a-8cd4-e3b46550599f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77602f7e-0e39-4c07-bea1-eaf8ccaf8be4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7842956d-1684-4f98-a572-e06585dcf766"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("79ebd0f5-2c66-4d8e-b6b1-20bc67ac3a49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8133da6d-44eb-4427-a796-2fb9ec30c4c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("867b2d0c-91bb-4686-874e-6a1c0f6efa3a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87fc03d7-7442-44bd-bc28-3d63aa186768"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8fb83d5d-49c4-4a9b-9e9f-8bf033ca4048"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("904e36bc-243c-42ec-b6fb-4f7e11ba7e58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("974fbc40-d5db-4a21-884f-e4154479e403"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99b35cdc-95ea-425d-bb2a-d661fa2941ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a001fe0e-8353-433c-92b7-8b01c1d8d10f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a13f974c-547b-4006-8023-e6c32d79c025"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7b7179d-f2c4-4f19-add6-62e18e96f8d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afd6e800-b96f-4fde-b49f-4aa728e30b19"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b59d3cc2-f878-41f3-9492-eec068adfbf4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b97c5e83-b7ee-4d75-a85c-d70e119a715a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c42a618d-c23a-4ad8-a10b-ad750fe0ea7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca139881-2229-46c9-bc6e-290a4a62a25d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc9b67ce-f447-42cf-b151-d75d02765d98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd370235-6c3a-4588-9da9-88d22c56a589"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce95338c-65d8-4cc3-b3af-11f6a9e8330c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf0dd795-8592-41af-8175-8e99576067b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0419155-6d9d-4934-af9b-7d351efdc981"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d187a531-381b-4039-ba8d-fa2f3113d704"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d19da87d-301f-415c-864d-29a5c8c1e0c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d81ce279-7c22-4b62-97d1-3c6244c56b58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d901b512-9248-4f5f-a32b-2e3ec8579b7b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d92d2bed-d754-4f64-8b14-ac3016147bce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd38c62c-b9e4-4e3a-84fe-79c1a3a6f919"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e6a3d1d1-4200-47cc-bd60-71ad0ad81a85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2a2ed74-7f49-41c5-a71e-b3b9a1087ffb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f622d842-2624-40a3-ad7f-7b0bb87499fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa051c6b-07a9-4192-93b0-c28217bbd632"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb425362-8d96-4873-a4d5-eb0f837a2c35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3cfbc6e2-f5ea-465b-8279-0b2ff976977c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a72cd6c-3290-4301-9453-3bc94f525075"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d117194c-0b31-4c5a-8408-7681b6839b5d"));

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("4836b57f-9204-486a-9d00-05a906c92c1c"), new DateTime(2023, 5, 4, 10, 14, 15, 926, DateTimeKind.Local).AddTicks(3173), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" },
                    { new Guid("69aa0a75-8e21-4645-a5d7-4931a91c3bf1"), new DateTime(2023, 5, 4, 10, 14, 15, 926, DateTimeKind.Local).AddTicks(3189), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" },
                    { new Guid("c0a05dad-2f97-4b20-a456-9ace057ba6b6"), new DateTime(2023, 5, 4, 10, 14, 15, 926, DateTimeKind.Local).AddTicks(3002), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" }
                });
        }
    }
}
