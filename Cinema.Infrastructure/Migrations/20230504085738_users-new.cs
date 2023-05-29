using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class usersnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1d9be87c-5635-48ba-b148-084ffce70228"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3dd3e513-055b-4f76-ab7d-98308a597b8b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4f13971e-66eb-448e-8fa8-407ed1ecb88a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("639b0c12-baee-4f77-8fd6-131e11241f41"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9ef1eee5-766b-40c8-aa89-5c3a370e02b8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b60c5ae6-a0a5-4222-b36d-f5a6fb2a50fc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bd82f3a4-cfa4-44f7-b2f1-878fb6ad04f1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("be785ef5-8edb-4dea-9efe-db7ad259bce6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dc3f6aa8-4edd-4de2-ae43-ea55977268b7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dfed6b8e-96e3-4cc4-9f02-c47da7a50c2e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("063775e7-4dee-4e78-9546-9c28d98f17a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c2cc6d9-ff47-4b06-bd84-38f8ad909238"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0da79cac-74aa-483a-83c0-65c551a42faa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10bccb11-ecd7-4256-a450-a8c2340a56e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12d6926f-b987-4e9d-ab03-cee796e3365a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12d80f9b-df17-4b1d-937d-b4df1c1b3fc1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b736b91-939d-4b53-8436-2e0540b5eb0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("200f3a3c-aa11-4289-9836-83290906e55a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24a66725-80ca-4303-a016-f3a5fca0c87a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24c29a46-de5a-488c-829c-40050ac38ae8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28ce73aa-1f78-46f3-972c-afb9177abbd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29c7081c-dc1d-4b65-9072-eb05e1b2f34d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b11401f-d408-483d-b75f-7ee1d1debfd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2dbdffbc-24ee-4d82-a810-af60ee7f5839"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ea40d02-67a9-408a-9950-555117e136f5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f5da82b-1a26-48ae-9fb3-e0eb31320799"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32400c60-e217-4005-9056-ed368a016fb0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3445c759-9ff0-407b-9083-c31de90c45c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3915c958-79a9-41af-b6aa-6a03962587bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39e9ac0a-ac43-4b31-83c3-5037b4520b8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a84ebfe-4eab-49fc-a9e8-05006982e489"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43fbd3e7-b06b-49d8-843e-80ef36c46f81"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44c60196-63b9-4180-8bb6-0354be2110ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4626b4d1-b637-453c-ad97-bb161660a9e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("488f5fa4-a65f-43d2-a7e5-f4c6f866bbbd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("489943b8-0412-4d36-b31f-deaaae7e907c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("495d2d2b-8af2-4ebb-a048-a2815d058b0d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5829ee80-5cce-464f-ad84-92ebd3ad3d20"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59f14f61-0525-4a8b-b8fb-76ece22d7b74"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5aa394d0-b727-41c2-ab44-7741a68ef241"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5c5f6340-81b8-4b86-8682-dce1fba7eb96"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("618a2067-f146-4c6d-94ed-478b04ef673d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62b151cf-c481-41ef-b7d7-b34d8b412d3e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71753505-4dda-4d7a-a08d-9184eb4f36fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72e814b7-7bba-4ae2-9108-4414a5b8dd53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c094731-d7f7-4c5c-b088-ee04b257cb39"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7e19a8be-481c-43de-928d-50e178bc5f90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ef6a563-b464-46d8-a66b-803dd574a6ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84af24d2-e0c3-4c4a-8ab8-899dc624365d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89d9acf4-b59e-49b5-a429-84a20fdf3bfb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a788d2c-76f2-4021-8d0c-31dbff03c552"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ad2d472-d1ff-4c7a-a376-773f000c0c49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98e905ce-950f-48fc-82bf-a151c2ff29c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9dc451f9-ba41-4d3c-937f-b6249904b36e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aadd0404-d55d-4d9e-971e-00a9f526b590"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad6ae441-939e-4af4-b518-4dd1b8180782"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b426c785-bfeb-48ef-a173-4639ac7dd4b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b6d3f4ca-b90a-45e6-b4ba-077a262470d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b714042c-f9cd-473b-8aba-a257194c7d16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b725a275-4698-4fd8-aa37-02207753cd6c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd82949f-aa9c-412c-b8d4-30a91bbc9e8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf21d6f9-dc48-4a91-860d-c75fc40cd80b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2fa5138-a9e3-4b2f-b69c-7e7f30c49004"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6eb45d4-2ea0-4bab-8303-74f1d5027f14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7776621-eb7c-402f-b995-2539f36c6bd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c919975f-734d-4a87-9f34-279227ecf328"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce3f504b-481d-46e3-846b-8cafd8e723a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfacc769-0ca8-45d9-bb53-abe5c190da17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d345280e-6424-494a-b623-8c4b65dfdaa0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d526c31c-c31e-4e00-a84b-4092ba724709"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8db4072-e448-4ef3-b36f-28dfc4688c86"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da10667e-19bc-41c1-99ff-64b3cdde7fdc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("daaae2bf-bf39-4414-a1c1-ba72a967a391"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dbd35a5d-46de-4269-9400-046a07b3c21a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0e5693d-54bb-454c-bd2c-5475809f1cb0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e969a9e7-8fa8-4206-8c4e-5551ad366f59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9ee960d-1311-413e-8fed-a7a60e938fe1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea986a28-beb9-404b-ad14-83a0de80bd6a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2a35a33-25ae-4d18-8de3-f820fdf984a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f473f027-9ceb-40fa-96c3-b59299519b9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6b84865-a931-4587-868e-b23ba6210ee3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa06ff0f-ca86-4c99-90ca-617566c1ba91"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb3dc1bf-78c5-492f-8e31-2d612b5b98fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe04f539-77cd-435c-ae17-80a8b7924c52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("756e7aa4-abc4-402b-9247-c7bd5223f55e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ff29dec-d849-425c-be6a-3a426d661a61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b99a9e01-00b3-40ac-b208-4282e60b3e24"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1d9be87c-5635-48ba-b148-084ffce70228"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("3dd3e513-055b-4f76-ab7d-98308a597b8b"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("4f13971e-66eb-448e-8fa8-407ed1ecb88a"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("639b0c12-baee-4f77-8fd6-131e11241f41"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("9ef1eee5-766b-40c8-aa89-5c3a370e02b8"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("b60c5ae6-a0a5-4222-b36d-f5a6fb2a50fc"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("bd82f3a4-cfa4-44f7-b2f1-878fb6ad04f1"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("be785ef5-8edb-4dea-9efe-db7ad259bce6"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("dc3f6aa8-4edd-4de2-ae43-ea55977268b7"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("dfed6b8e-96e3-4cc4-9f02-c47da7a50c2e"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("063775e7-4dee-4e78-9546-9c28d98f17a1"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0c2cc6d9-ff47-4b06-bd84-38f8ad909238"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0da79cac-74aa-483a-83c0-65c551a42faa"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("10bccb11-ecd7-4256-a450-a8c2340a56e4"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("12d6926f-b987-4e9d-ab03-cee796e3365a"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("12d80f9b-df17-4b1d-937d-b4df1c1b3fc1"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1b736b91-939d-4b53-8436-2e0540b5eb0b"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("200f3a3c-aa11-4289-9836-83290906e55a"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("24a66725-80ca-4303-a016-f3a5fca0c87a"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("24c29a46-de5a-488c-829c-40050ac38ae8"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("28ce73aa-1f78-46f3-972c-afb9177abbd5"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("29c7081c-dc1d-4b65-9072-eb05e1b2f34d"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2b11401f-d408-483d-b75f-7ee1d1debfd2"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2dbdffbc-24ee-4d82-a810-af60ee7f5839"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2ea40d02-67a9-408a-9950-555117e136f5"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2f5da82b-1a26-48ae-9fb3-e0eb31320799"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("32400c60-e217-4005-9056-ed368a016fb0"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3445c759-9ff0-407b-9083-c31de90c45c2"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("3915c958-79a9-41af-b6aa-6a03962587bb"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("39e9ac0a-ac43-4b31-83c3-5037b4520b8b"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3a84ebfe-4eab-49fc-a9e8-05006982e489"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("43fbd3e7-b06b-49d8-843e-80ef36c46f81"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("44c60196-63b9-4180-8bb6-0354be2110ec"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4626b4d1-b637-453c-ad97-bb161660a9e9"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("488f5fa4-a65f-43d2-a7e5-f4c6f866bbbd"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("489943b8-0412-4d36-b31f-deaaae7e907c"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("495d2d2b-8af2-4ebb-a048-a2815d058b0d"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5829ee80-5cce-464f-ad84-92ebd3ad3d20"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("59f14f61-0525-4a8b-b8fb-76ece22d7b74"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5aa394d0-b727-41c2-ab44-7741a68ef241"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5c5f6340-81b8-4b86-8682-dce1fba7eb96"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("618a2067-f146-4c6d-94ed-478b04ef673d"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("62b151cf-c481-41ef-b7d7-b34d8b412d3e"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("71753505-4dda-4d7a-a08d-9184eb4f36fc"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("72e814b7-7bba-4ae2-9108-4414a5b8dd53"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("7c094731-d7f7-4c5c-b088-ee04b257cb39"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7e19a8be-481c-43de-928d-50e178bc5f90"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7ef6a563-b464-46d8-a66b-803dd574a6ff"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("84af24d2-e0c3-4c4a-8ab8-899dc624365d"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("89d9acf4-b59e-49b5-a429-84a20fdf3bfb"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8a788d2c-76f2-4021-8d0c-31dbff03c552"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8ad2d472-d1ff-4c7a-a376-773f000c0c49"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("98e905ce-950f-48fc-82bf-a151c2ff29c0"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9dc451f9-ba41-4d3c-937f-b6249904b36e"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("aadd0404-d55d-4d9e-971e-00a9f526b590"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ad6ae441-939e-4af4-b518-4dd1b8180782"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b426c785-bfeb-48ef-a173-4639ac7dd4b0"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b6d3f4ca-b90a-45e6-b4ba-077a262470d8"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b714042c-f9cd-473b-8aba-a257194c7d16"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b725a275-4698-4fd8-aa37-02207753cd6c"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("bd82949f-aa9c-412c-b8d4-30a91bbc9e8e"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bf21d6f9-dc48-4a91-860d-c75fc40cd80b"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c2fa5138-a9e3-4b2f-b69c-7e7f30c49004"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c6eb45d4-2ea0-4bab-8303-74f1d5027f14"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c7776621-eb7c-402f-b995-2539f36c6bd5"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c919975f-734d-4a87-9f34-279227ecf328"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("ce3f504b-481d-46e3-846b-8cafd8e723a4"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("cfacc769-0ca8-45d9-bb53-abe5c190da17"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d345280e-6424-494a-b623-8c4b65dfdaa0"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d526c31c-c31e-4e00-a84b-4092ba724709"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d8db4072-e448-4ef3-b36f-28dfc4688c86"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("da10667e-19bc-41c1-99ff-64b3cdde7fdc"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("daaae2bf-bf39-4414-a1c1-ba72a967a391"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("dbd35a5d-46de-4269-9400-046a07b3c21a"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e0e5693d-54bb-454c-bd2c-5475809f1cb0"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e969a9e7-8fa8-4206-8c4e-5551ad366f59"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("e9ee960d-1311-413e-8fed-a7a60e938fe1"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("ea986a28-beb9-404b-ad14-83a0de80bd6a"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("f2a35a33-25ae-4d18-8de3-f820fdf984a2"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f473f027-9ceb-40fa-96c3-b59299519b9d"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f6b84865-a931-4587-868e-b23ba6210ee3"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("fa06ff0f-ca86-4c99-90ca-617566c1ba91"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fb3dc1bf-78c5-492f-8e31-2d612b5b98fe"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fe04f539-77cd-435c-ae17-80a8b7924c52"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("756e7aa4-abc4-402b-9247-c7bd5223f55e"), new DateTime(2023, 5, 4, 10, 48, 37, 653, DateTimeKind.Local).AddTicks(5954), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" },
                    { new Guid("9ff29dec-d849-425c-be6a-3a426d661a61"), new DateTime(2023, 5, 4, 10, 48, 37, 653, DateTimeKind.Local).AddTicks(5963), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" },
                    { new Guid("b99a9e01-00b3-40ac-b208-4282e60b3e24"), new DateTime(2023, 5, 4, 10, 48, 37, 653, DateTimeKind.Local).AddTicks(5798), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" }
                });
        }
    }
}
