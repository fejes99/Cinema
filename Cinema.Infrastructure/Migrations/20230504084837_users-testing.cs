using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class userstesting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
