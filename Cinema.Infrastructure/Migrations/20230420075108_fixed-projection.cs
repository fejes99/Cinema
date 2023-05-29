using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixedprojection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projections_Movies_MovieId1",
                table: "Projections");

            migrationBuilder.DropForeignKey(
                name: "FK_Projections_ProjectionTypes_ProjectionTypeId1",
                table: "Projections");

            migrationBuilder.DropForeignKey(
                name: "FK_Projections_Theaters_TheaterId1",
                table: "Projections");

            migrationBuilder.DropIndex(
                name: "IX_Projections_MovieId1",
                table: "Projections");

            migrationBuilder.DropIndex(
                name: "IX_Projections_ProjectionTypeId1",
                table: "Projections");

            migrationBuilder.DropIndex(
                name: "IX_Projections_TheaterId1",
                table: "Projections");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3094e5b9-9014-4ce3-8768-b2dd00bc8952"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("54e55e63-69b9-4a3e-a9c1-0979849d7015"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5572f9dd-3186-463c-934b-434a13bf6616"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5f1e082a-9c88-42ef-9db8-d5a2eb56ab23"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("77fe051a-4e0b-443f-b75c-3cdc20a28e4c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9983a371-a0da-40ab-9f05-862afc7bb6fb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b6a2cf24-1c5a-4178-9ef3-2bf14168026e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d36f09bc-f9fd-4ddf-a96a-6bbedef444be"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dc74c0e3-d525-41b7-86e1-b50a48307c3e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fe3ba5a3-9894-424a-a2b6-018a378b8b55"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("47c13a07-c890-4718-94f9-dbd82632a557"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04816eec-f46f-4214-bcec-46295e636ba6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08c4d27c-d6c5-453c-adbb-08873ba36e94"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0dcf3daf-e0e2-49c1-b583-e4cc279e8596"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12f85304-ec7b-438e-96b7-da000598e447"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13948e86-cca8-4fff-9fa2-090d77fb7a6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17593e9d-e2ce-4da1-abb9-4c6bb7adcead"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1908d3d3-476b-4215-9b88-7b73c53bddb8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2176a9b9-f586-4da7-a562-60c94fed655e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2270f137-2a96-4fdb-9bb3-d87a7fab47d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22ce86ac-7398-476b-85bb-4eae57633e6d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25131550-01c0-4bfc-8f74-01c5f5498da1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28a76c56-55db-4e2f-aed7-865ae379cba8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d711af2-6a1b-4a3c-a910-0893b69d1a7d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e0f05a6-92c9-4c3f-973b-496aa5e92c08"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f37abe3-cbf2-4908-94dd-4de7e20efef9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("319da221-bc0b-41ca-ab87-f8033a148a86"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33766ed9-6fd4-45d6-bbb1-1d6149de08fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("36ea8ff7-0993-4e45-9a94-ced17fb56328"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3963315b-2da5-47ee-9752-ab53ac2b932e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f6da8cc-8dd1-491b-8b97-0b1f1b150ea4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40bc9ab3-7c09-4bb4-8ecf-1b1eae56a76b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("41ac559e-3e9f-457c-8c89-e0d9204b4a47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("441a13d0-3a71-49f2-ad66-2af37d4a258e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44928ee1-950a-44d5-a43a-54d826978314"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f00d1cf-a073-4da2-a1bf-3e93beac7e02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5897d60e-d921-43b3-afb2-55e7be768b51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59d65494-d895-46f9-a09b-7c689416696a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61e0ee28-8e40-440c-9499-f0d573aeb9cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64648f82-c40a-405d-b41c-beb895974f3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ad07e2e-dec6-4bbb-b920-a980ad804f27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c6be953-f153-4e2c-ba3c-4410532e1214"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("719fe0c5-9978-4895-9355-cbe91bfe36b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71dc739b-a8cb-48b2-9aa9-7351e3100527"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7938b48e-ffef-4ef6-b76a-6bfd5df9ea58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("856f7366-2035-4966-b6df-0812cc282c1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89544b80-798a-4a5a-b113-24d5fc45f7da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89a324c2-d908-4694-9932-d403494bf2ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d990edc-928f-45b6-b29b-c49c89bcf79a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97ed9f79-f515-4751-9600-3c064dd7ea7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ca03123-8355-408c-afe8-9909fe01d618"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0a3416e-ddd6-437c-ada4-3942542f10d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1663235-ba9a-4d49-bbd4-4d7cf682d416"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1922f35-6f6e-431e-b3e4-60d8eb986ace"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a78dd827-ef50-4530-b8f1-b3bfa703773d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac243e42-947c-4fb0-a47b-d7654b554493"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afc061fa-e1d1-4779-900b-8945bafd3ab9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1130c72-0a6a-4180-a551-f9803c7fe140"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1dae04e-9307-4391-a722-e1f7b6a99b3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc04445b-5948-439a-8e55-5e60a7727e03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bdaf2662-f677-44cb-abf5-e5e3a37c821d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c28713ba-84d3-4dd7-853e-9b1b762060d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c36afbee-7a7e-4f10-92af-a91ecd3d4a0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9e4be8d-a71d-46bb-898e-2b189c5d873e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cae275de-4a88-47d4-80e5-d825f1a58cb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc16ffdb-af08-4efc-b04b-4c2fe90834b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d48267b7-86dc-4415-ae01-06ab4f2e1ff5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d679b49f-77bc-47e5-b9ab-b71b525ea1de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6ece622-4e32-4da9-adeb-907597c42456"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d755190d-f708-4f28-ba5c-2d3a787efd5c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da231c85-3a96-4303-9ebc-4e211f610ddc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e09178b8-4d9a-4108-8fb8-844e6b6d124a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9eb2f43-cd02-4996-8ab2-d0f2e63c4b6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec33164f-0064-487c-afce-1b56c23147bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed1ee50d-c158-4612-8017-184ed8b602e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f34c768f-6448-4aae-bd22-0bc3e94fac22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4ce9898-0a0c-4d05-92f6-94c033743a56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f5bc43c1-5e4e-4e4f-b69e-657ab284de23"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7ee3d67-3e5f-43b5-aeb1-b324a62269c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8944228-1f2b-4e7a-8b24-b34a95f8870e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f97ef200-066c-4690-99e5-3270fcdec9c6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9b63149-342d-4ff9-95b5-4670759820a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa3095c2-28af-401f-8ca5-ab11c4a0cf40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd6e4c92-c742-4019-931b-e87a7d9c798d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd9d8e8e-5c3d-4c9c-af5a-3570a7c24dac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("133e7b30-9350-4598-b6f4-0425822e5fcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4dd5ad4-9265-4f6a-b9c7-e42c6eb00ae8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c666ed8e-5b05-432f-b7cd-fb0fe957d2bc"));

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "ProjectionTypeId1",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "TheaterId1",
                table: "Projections");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("17b90cc0-ecbe-4e14-abf3-e5a365104b03"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("52d4bba9-7071-4ecc-8c1b-819c34c8b303"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("6da514f1-4336-4a96-ab5b-06bb3c919aa2"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Astérix & Obélix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("7813ec38-74a7-42fc-bb09-39a5c7d2e3e9"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("9c6951a4-2e82-41ad-8a11-5de9d95e0c09"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("bc56efa8-ef21-452b-97a1-1ec5912bb022"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("bcf1be38-c865-4dab-989b-ccfc9bcf88bc"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("e7162fd7-a6d8-4d39-84c3-72bd3231bab0"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("f598e9dc-b92e-4db5-95fe-8c6b910bd1c7"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("fdef3351-fd9a-41cb-95e1-e91ea7ec28b6"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("004ccfa0-9124-4a61-9772-c7a149a36223"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("0091011f-a268-4c76-8cc8-79ee4b712479"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("046f3259-2cdf-4313-9911-34f9717ca4ec"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("074b405e-2dc5-4387-b046-aef41f93bf08"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("092ca8d4-591b-4103-a110-39f1ac739128"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("0aa4d7dd-fca9-4008-9797-d6626d112fab"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("0ec9adde-0079-4f6c-bbb8-dec8467578e6"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("16a87d9f-255c-4016-80c7-7091fb9799c2"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1725b2b4-cf46-4f3d-9d78-ae1ded98a2c9"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1ba47f31-5ee6-4dfb-91ac-c575369a22e3"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("220e093c-fe96-4f33-b270-2e17bf7278a6"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2861267e-bf39-4855-a9cd-3cedaf558ff2"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2cc33d9c-415b-499c-895f-be3386afc9ad"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("316e5197-c5dc-4bf5-85f2-bb56b680b3fe"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("3b52e991-843b-4b6a-b32d-a6a796df51b8"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("3dcd9ccb-5dfb-4b0e-92d7-27671fe87417"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("4b95cf04-8209-4c7b-adf4-ebb55db2c878"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("4e02c016-8bd9-4605-9fa3-c0227f706a36"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("53469a0f-7ff8-4cf2-b113-aa11def5a906"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("54fce57f-6b53-4250-b1e0-7122cd932b9a"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5716aeae-ccbc-430e-9c36-0a05eab4fe51"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5a1e33a3-003f-4781-a7d7-8416d5bacd41"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("5ab4887e-d950-4bfc-8951-44c8cde0e3c4"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5bb6161e-efb2-49e4-bce9-239e4f5ded6b"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5f9c2cf3-f57f-434d-87c6-be5a34e72226"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("653671f6-6fda-451b-8253-ff8ffc4f6c09"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("67d68b7a-fd3b-4d0c-8a31-7a66cc88d7d2"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("6b8a6b24-7000-462a-b2cb-569adc746878"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("70b73d65-b8ea-4ab1-afee-bfbf187af079"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("722dc446-1a50-4497-aacd-c11590d68f42"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7591d3c6-5b3f-48f5-929f-c11808b457de"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7a10f347-2f57-4846-b8fd-8e8333bd031a"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("7a1a632b-93db-4692-84f0-2a5bc7d9d21c"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("7a750796-455e-4033-baea-4fedd4c09aba"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7b157f16-c520-49f2-8b5a-547dc0f08e73"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8181e51f-b083-4c7d-9f1a-21efff48ce5b"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("866d81d3-f9d5-4ce3-b8df-52c5dce3555e"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("86b5c6ad-6fbe-456b-b041-7768241f3a2c"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8b20b260-e99e-4d46-af60-b6ff5225e103"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8d35e368-3c8a-4fdd-a6e9-cf096f08a91e"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("98232573-c2a2-4ad5-a939-350f1a84b6ec"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9bcb1ba6-2d7e-4bcb-812a-8bc90a45c985"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9bdff9e6-ad43-44e8-98c1-843e480d5f9c"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9c17dd99-4136-43fb-8a20-e2b7d0c8e9dd"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9c587ba9-1940-472b-b8a6-1e8ac677e2e8"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9e230bf8-e2f5-4bd2-88dc-50556b253074"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9fa7684d-5dee-445a-8a29-45025d063db2"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("a098695d-a0cb-4c00-bccd-09e232242a79"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a336b284-8ee3-4c53-a367-c051f77de31f"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("a8db0cb9-0324-4c7e-a322-e2fe2a818550"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("ad2da4bf-b48c-4330-a199-db0a86052a2f"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("af07ce34-83e3-4da0-ba19-57d6d9756894"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b0c3706b-ad9b-45b8-943f-975525f4b280"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b26a02fc-c5a1-4725-b4e0-69fcd24d4bc7"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b303d9b7-5fa3-457f-b4af-9060decf5551"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("b832a3a5-d91b-4696-8827-dd6623c9fbc5"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b881278c-2a5a-4a0b-8323-a71242db88aa"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("b9902320-8203-40c0-b076-234d4e2537bf"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bc6470fb-3014-497d-a403-7158cf89dd0a"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("cb45a65d-e365-48d8-8b6d-513b71d22df5"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("cbc26607-e2b1-49f9-bd39-9f39dd54f4cb"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cfaf727b-2781-4daf-85e0-66726f57a896"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d4b2c110-d3e6-4440-b2bd-f604f940ceeb"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("def435b6-1aad-4ecb-ad1c-612ea0831b53"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("dfd7d366-8067-4b6c-bdef-98910583ae49"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("e147a6f1-e7d6-4407-93de-1ed8e8fc7916"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e54c453e-7fe3-4335-bc2b-d87bf9634c5e"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ea9491f6-dcc0-4178-9dd7-3498a895badb"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f200f265-bbf1-4273-92ca-e82b660f2841"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f2762452-afaf-40ea-a4e2-f60dc0a6ae03"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f32e088d-ec4c-4c47-bae0-c12e27880b9b"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f35ba864-37b2-4256-80c7-2c94cdab85b6"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f781ef3b-e42d-451f-9f1a-3548da7ce02e"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("fafe2efd-28cf-4631-8409-a6877e88b8ad"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("0ba4d0ec-015b-4c2c-b865-208cc96d5efd"), new DateTime(2023, 4, 20, 9, 51, 8, 40, DateTimeKind.Local).AddTicks(2812), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("3b43f7f4-5c54-4646-8007-1ef7bcd1f209"), new DateTime(2023, 4, 20, 9, 51, 8, 40, DateTimeKind.Local).AddTicks(2928), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("c09757f5-61de-48bd-9d58-60e372747a08"), new DateTime(2023, 4, 20, 9, 51, 8, 40, DateTimeKind.Local).AddTicks(2942), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("17b90cc0-ecbe-4e14-abf3-e5a365104b03"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("52d4bba9-7071-4ecc-8c1b-819c34c8b303"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6da514f1-4336-4a96-ab5b-06bb3c919aa2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7813ec38-74a7-42fc-bb09-39a5c7d2e3e9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9c6951a4-2e82-41ad-8a11-5de9d95e0c09"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bc56efa8-ef21-452b-97a1-1ec5912bb022"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bcf1be38-c865-4dab-989b-ccfc9bcf88bc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e7162fd7-a6d8-4d39-84c3-72bd3231bab0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f598e9dc-b92e-4db5-95fe-8c6b910bd1c7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fdef3351-fd9a-41cb-95e1-e91ea7ec28b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("004ccfa0-9124-4a61-9772-c7a149a36223"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0091011f-a268-4c76-8cc8-79ee4b712479"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("046f3259-2cdf-4313-9911-34f9717ca4ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("074b405e-2dc5-4387-b046-aef41f93bf08"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("092ca8d4-591b-4103-a110-39f1ac739128"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0aa4d7dd-fca9-4008-9797-d6626d112fab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0ec9adde-0079-4f6c-bbb8-dec8467578e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16a87d9f-255c-4016-80c7-7091fb9799c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1725b2b4-cf46-4f3d-9d78-ae1ded98a2c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ba47f31-5ee6-4dfb-91ac-c575369a22e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("220e093c-fe96-4f33-b270-2e17bf7278a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2861267e-bf39-4855-a9cd-3cedaf558ff2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cc33d9c-415b-499c-895f-be3386afc9ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("316e5197-c5dc-4bf5-85f2-bb56b680b3fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b52e991-843b-4b6a-b32d-a6a796df51b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3dcd9ccb-5dfb-4b0e-92d7-27671fe87417"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b95cf04-8209-4c7b-adf4-ebb55db2c878"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e02c016-8bd9-4605-9fa3-c0227f706a36"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53469a0f-7ff8-4cf2-b113-aa11def5a906"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54fce57f-6b53-4250-b1e0-7122cd932b9a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5716aeae-ccbc-430e-9c36-0a05eab4fe51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a1e33a3-003f-4781-a7d7-8416d5bacd41"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ab4887e-d950-4bfc-8951-44c8cde0e3c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bb6161e-efb2-49e4-bce9-239e4f5ded6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2cf3-f57f-434d-87c6-be5a34e72226"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("653671f6-6fda-451b-8253-ff8ffc4f6c09"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67d68b7a-fd3b-4d0c-8a31-7a66cc88d7d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b8a6b24-7000-462a-b2cb-569adc746878"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70b73d65-b8ea-4ab1-afee-bfbf187af079"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("722dc446-1a50-4497-aacd-c11590d68f42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7591d3c6-5b3f-48f5-929f-c11808b457de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a10f347-2f57-4846-b8fd-8e8333bd031a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a1a632b-93db-4692-84f0-2a5bc7d9d21c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a750796-455e-4033-baea-4fedd4c09aba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b157f16-c520-49f2-8b5a-547dc0f08e73"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8181e51f-b083-4c7d-9f1a-21efff48ce5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("866d81d3-f9d5-4ce3-b8df-52c5dce3555e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86b5c6ad-6fbe-456b-b041-7768241f3a2c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b20b260-e99e-4d46-af60-b6ff5225e103"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d35e368-3c8a-4fdd-a6e9-cf096f08a91e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98232573-c2a2-4ad5-a939-350f1a84b6ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bcb1ba6-2d7e-4bcb-812a-8bc90a45c985"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bdff9e6-ad43-44e8-98c1-843e480d5f9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c17dd99-4136-43fb-8a20-e2b7d0c8e9dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c587ba9-1940-472b-b8a6-1e8ac677e2e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e230bf8-e2f5-4bd2-88dc-50556b253074"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9fa7684d-5dee-445a-8a29-45025d063db2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a098695d-a0cb-4c00-bccd-09e232242a79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a336b284-8ee3-4c53-a367-c051f77de31f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a8db0cb9-0324-4c7e-a322-e2fe2a818550"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad2da4bf-b48c-4330-a199-db0a86052a2f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af07ce34-83e3-4da0-ba19-57d6d9756894"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0c3706b-ad9b-45b8-943f-975525f4b280"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b26a02fc-c5a1-4725-b4e0-69fcd24d4bc7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b303d9b7-5fa3-457f-b4af-9060decf5551"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b832a3a5-d91b-4696-8827-dd6623c9fbc5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b881278c-2a5a-4a0b-8323-a71242db88aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9902320-8203-40c0-b076-234d4e2537bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc6470fb-3014-497d-a403-7158cf89dd0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb45a65d-e365-48d8-8b6d-513b71d22df5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbc26607-e2b1-49f9-bd39-9f39dd54f4cb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfaf727b-2781-4daf-85e0-66726f57a896"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4b2c110-d3e6-4440-b2bd-f604f940ceeb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("def435b6-1aad-4ecb-ad1c-612ea0831b53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dfd7d366-8067-4b6c-bdef-98910583ae49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e147a6f1-e7d6-4407-93de-1ed8e8fc7916"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e54c453e-7fe3-4335-bc2b-d87bf9634c5e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea9491f6-dcc0-4178-9dd7-3498a895badb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f200f265-bbf1-4273-92ca-e82b660f2841"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2762452-afaf-40ea-a4e2-f60dc0a6ae03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f32e088d-ec4c-4c47-bae0-c12e27880b9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f35ba864-37b2-4256-80c7-2c94cdab85b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f781ef3b-e42d-451f-9f1a-3548da7ce02e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fafe2efd-28cf-4631-8409-a6877e88b8ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ba4d0ec-015b-4c2c-b865-208cc96d5efd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b43f7f4-5c54-4646-8007-1ef7bcd1f209"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c09757f5-61de-48bd-9d58-60e372747a08"));

            migrationBuilder.AddColumn<Guid>(
                name: "MovieId1",
                table: "Projections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectionTypeId1",
                table: "Projections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TheaterId1",
                table: "Projections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("3094e5b9-9014-4ce3-8768-b2dd00bc8952"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("54e55e63-69b9-4a3e-a9c1-0979849d7015"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("5572f9dd-3186-463c-934b-434a13bf6616"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("5f1e082a-9c88-42ef-9db8-d5a2eb56ab23"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Astérix & Obélix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("77fe051a-4e0b-443f-b75c-3cdc20a28e4c"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("9983a371-a0da-40ab-9f05-862afc7bb6fb"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("b6a2cf24-1c5a-4178-9ef3-2bf14168026e"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("d36f09bc-f9fd-4ddf-a96a-6bbedef444be"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("dc74c0e3-d525-41b7-86e1-b50a48307c3e"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("fe3ba5a3-9894-424a-a2b6-018a378b8b55"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "IsDeleted", "IsSold", "MovieId", "MovieId1", "Price", "ProjectionTypeId", "ProjectionTypeId1", "TheaterId", "TheaterId1", "Time" },
                values: new object[] { new Guid("47c13a07-c890-4718-94f9-dbd82632a557"), false, false, new Guid("f68a0b29-91b2-4884-ba25-81f18a3b7ac6"), null, 500, new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), null, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"), null, new DateTime(2023, 5, 16, 23, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("04816eec-f46f-4214-bcec-46295e636ba6"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("08c4d27c-d6c5-453c-adbb-08873ba36e94"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("0dcf3daf-e0e2-49c1-b583-e4cc279e8596"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("12f85304-ec7b-438e-96b7-da000598e447"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("13948e86-cca8-4fff-9fa2-090d77fb7a6e"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("17593e9d-e2ce-4da1-abb9-4c6bb7adcead"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("1908d3d3-476b-4215-9b88-7b73c53bddb8"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2176a9b9-f586-4da7-a562-60c94fed655e"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2270f137-2a96-4fdb-9bb3-d87a7fab47d4"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("22ce86ac-7398-476b-85bb-4eae57633e6d"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("25131550-01c0-4bfc-8f74-01c5f5498da1"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("28a76c56-55db-4e2f-aed7-865ae379cba8"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2d711af2-6a1b-4a3c-a910-0893b69d1a7d"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("2e0f05a6-92c9-4c3f-973b-496aa5e92c08"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("2f37abe3-cbf2-4908-94dd-4de7e20efef9"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("319da221-bc0b-41ca-ab87-f8033a148a86"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("33766ed9-6fd4-45d6-bbb1-1d6149de08fb"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("36ea8ff7-0993-4e45-9a94-ced17fb56328"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3963315b-2da5-47ee-9752-ab53ac2b932e"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3f6da8cc-8dd1-491b-8b97-0b1f1b150ea4"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("40bc9ab3-7c09-4bb4-8ecf-1b1eae56a76b"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("41ac559e-3e9f-457c-8c89-e0d9204b4a47"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("441a13d0-3a71-49f2-ad66-2af37d4a258e"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("44928ee1-950a-44d5-a43a-54d826978314"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("4f00d1cf-a073-4da2-a1bf-3e93beac7e02"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("5897d60e-d921-43b3-afb2-55e7be768b51"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("59d65494-d895-46f9-a09b-7c689416696a"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("61e0ee28-8e40-440c-9499-f0d573aeb9cc"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("64648f82-c40a-405d-b41c-beb895974f3d"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6ad07e2e-dec6-4bbb-b920-a980ad804f27"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6c6be953-f153-4e2c-ba3c-4410532e1214"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("719fe0c5-9978-4895-9355-cbe91bfe36b7"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("71dc739b-a8cb-48b2-9aa9-7351e3100527"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7938b48e-ffef-4ef6-b76a-6bfd5df9ea58"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("856f7366-2035-4966-b6df-0812cc282c1d"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("89544b80-798a-4a5a-b113-24d5fc45f7da"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("89a324c2-d908-4694-9932-d403494bf2ff"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8d990edc-928f-45b6-b29b-c49c89bcf79a"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("97ed9f79-f515-4751-9600-3c064dd7ea7a"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("9ca03123-8355-408c-afe8-9909fe01d618"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("a0a3416e-ddd6-437c-ada4-3942542f10d0"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a1663235-ba9a-4d49-bbd4-4d7cf682d416"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a1922f35-6f6e-431e-b3e4-60d8eb986ace"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("a78dd827-ef50-4530-b8f1-b3bfa703773d"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ac243e42-947c-4fb0-a47b-d7654b554493"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("afc061fa-e1d1-4779-900b-8945bafd3ab9"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b1130c72-0a6a-4180-a551-f9803c7fe140"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("b1dae04e-9307-4391-a722-e1f7b6a99b3d"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("bc04445b-5948-439a-8e55-5e60a7727e03"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bdaf2662-f677-44cb-abf5-e5e3a37c821d"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c28713ba-84d3-4dd7-853e-9b1b762060d2"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c36afbee-7a7e-4f10-92af-a91ecd3d4a0a"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c9e4be8d-a71d-46bb-898e-2b189c5d873e"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("cae275de-4a88-47d4-80e5-d825f1a58cb9"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("cc16ffdb-af08-4efc-b04b-4c2fe90834b2"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d48267b7-86dc-4415-ae01-06ab4f2e1ff5"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d679b49f-77bc-47e5-b9ab-b71b525ea1de"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d6ece622-4e32-4da9-adeb-907597c42456"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("d755190d-f708-4f28-ba5c-2d3a787efd5c"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("da231c85-3a96-4303-9ebc-4e211f610ddc"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e09178b8-4d9a-4108-8fb8-844e6b6d124a"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e9eb2f43-cd02-4996-8ab2-d0f2e63c4b6b"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ec33164f-0064-487c-afce-1b56c23147bb"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ed1ee50d-c158-4612-8017-184ed8b602e7"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f34c768f-6448-4aae-bd22-0bc3e94fac22"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f4ce9898-0a0c-4d05-92f6-94c033743a56"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f5bc43c1-5e4e-4e4f-b69e-657ab284de23"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f7ee3d67-3e5f-43b5-aeb1-b324a62269c2"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f8944228-1f2b-4e7a-8b24-b34a95f8870e"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("f97ef200-066c-4690-99e5-3270fcdec9c6"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f9b63149-342d-4ff9-95b5-4670759820a6"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fa3095c2-28af-401f-8ca5-ab11c4a0cf40"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("fd6e4c92-c742-4019-931b-e87a7d9c798d"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("fd9d8e8e-5c3d-4c9c-af5a-3570a7c24dac"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("133e7b30-9350-4598-b6f4-0425822e5fcf"), new DateTime(2023, 4, 19, 17, 24, 40, 923, DateTimeKind.Local).AddTicks(6630), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("a4dd5ad4-9265-4f6a-b9c7-e42c6eb00ae8"), new DateTime(2023, 4, 19, 17, 24, 40, 923, DateTimeKind.Local).AddTicks(6806), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" },
                    { new Guid("c666ed8e-5b05-432f-b7cd-fb0fe957d2bc"), new DateTime(2023, 4, 19, 17, 24, 40, 923, DateTimeKind.Local).AddTicks(6775), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projections_MovieId1",
                table: "Projections",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_ProjectionTypeId1",
                table: "Projections",
                column: "ProjectionTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_TheaterId1",
                table: "Projections",
                column: "TheaterId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Projections_Movies_MovieId1",
                table: "Projections",
                column: "MovieId1",
                principalTable: "Movies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projections_ProjectionTypes_ProjectionTypeId1",
                table: "Projections",
                column: "ProjectionTypeId1",
                principalTable: "ProjectionTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projections_Theaters_TheaterId1",
                table: "Projections",
                column: "TheaterId1",
                principalTable: "Theaters",
                principalColumn: "Id");
        }
    }
}
