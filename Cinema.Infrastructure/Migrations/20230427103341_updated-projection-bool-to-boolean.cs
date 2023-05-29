using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedprojectionbooltoboolean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("22f59abd-89c1-424b-9427-d06a61dfba11"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("45891c23-d7e6-4056-999d-92163a771206"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("83cd9fbb-5fc1-4461-81bc-7cddd3d58e7d"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("985c53a0-d42d-466d-84ee-f90bb5c2fa0e"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("9c608aad-667e-4cdd-b5f3-65d753dd1dfc"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("9e1eb952-2c84-4cf1-a13d-20889aad8889"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("a5a67659-e299-4cc4-9f4e-77f4e96daa6d"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("da0b53bc-3179-47ff-914c-239b02d42658"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("e755d64c-f8d5-4397-a194-a7acfd68e686"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("eb563027-2ee9-4335-85cd-f17f8428e6dc"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("044f2d98-6ad3-4e42-b2ac-0bcf1102d03b"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("0fa8eb89-b1ed-44b6-87c2-730edd70c84e"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("116b7c45-e0fa-4f13-9ec5-ccec6a528b2c"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("11f52556-470f-4d8b-b1e4-e8b867aeed16"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1616d340-f33e-4045-b5b2-c6a15be805c7"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("17bcded1-6baf-46e1-8f5d-ade1e095c5eb"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1a010e7a-2b65-4f41-b89d-073224f09a72"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("1dfa42b9-d679-439b-b2d5-afd0201e1016"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("25f9d4b5-6348-4c8d-a5bf-c6760bc85b98"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2a0e1638-650c-448b-9527-5d06686b0b50"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3218aac6-7dad-4820-b4a0-7228d4615d63"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("36d70ef0-4d42-4f1b-b137-c5b1c0516b32"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3bde2d76-061d-4940-99bb-1309a594643d"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("41a7d560-81ba-4e80-9171-50c5820747a6"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("44b5e053-54a1-440c-97aa-d59d4099abba"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("44d30a02-be36-44eb-ade8-3a36e2cf6bb2"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4cf5acd1-b2d2-4da3-9229-46fa58f5098a"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("52736e5a-7cd4-4f8c-9442-da29376d1e47"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5e1e11e6-5802-4073-ade9-605ffb97d47f"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("618cf44a-a24e-4bf5-b666-fffbe3890aec"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("652f4b18-040b-4efb-ba17-80bba6ef9376"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("692e1666-121c-42f3-ba4e-65a2fc1e2faf"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6abeebf6-b441-4df4-988a-baa90f2c09c7"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6bd727de-617e-4be0-bdad-5256011228e0"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6cb4aa2b-a0b8-48b1-8a0b-66f9ae01a317"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("72b2c504-ab13-494e-a433-5c62f53c3171"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("74800c51-cf2f-4931-bd68-0d1853edc868"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("7645f5d3-7527-487f-899f-3bfda3a12f43"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7ac28034-9ed6-47bd-b3c1-1c1d6e3a2916"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("82ca7f8d-fe65-4890-a592-0afcc161155d"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("84ae68b9-e725-4807-ac2b-6c65beed89df"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8503da19-d33d-4740-9623-4a3f10accbce"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("881cfa46-98dc-416a-81cd-ea2c6da05f4c"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("897df960-f5da-435e-af1c-ff52fd7c73d7"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8b0048fd-a1a2-4ac3-bd18-fb2015964108"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8b150c74-35a6-4989-8374-3751c836ffae"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8f1a8bd3-be1c-4d9e-8952-fab33adb427a"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8f371c79-1880-4c7a-bab2-14ecbea69b56"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("961b9daa-a615-4369-9331-203495b692d8"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("96a7012f-f957-42fc-afe9-7b010f2787cf"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("98527eb8-9199-4264-81bc-e8c1a784f381"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("991f15f1-5a27-497b-9da8-55dbd1440b4f"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("99ec2d2a-3b5b-4358-b845-b16ecaba9463"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a08c4dbd-75de-4fa3-ae7d-0520c441f3c1"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("a38d94c9-bc52-4f14-b0eb-7df7228963e4"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a6af72c6-47be-4580-8c4c-d723e8a0f330"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ab7b85a6-ba80-46b3-99c8-22e44df83fa9"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b2ae66a5-aeae-4ab7-bfa3-ba3822baa3b6"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b30841ff-69a3-4edb-b833-4bf4ee468665"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("b35a7f08-9ff4-4c2e-861a-00df93f10c6e"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("b5918646-9a3c-43c0-9441-c21772c8a4ec"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b8f51e0b-75f6-4683-9479-94157aa84122"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("bb148795-8bfe-417b-ba1b-a1f59c5097e5"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c193a0ea-aa2f-4926-b1d7-0fc25fa9fe6b"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("ca777666-6ab2-4448-8d9c-09264ed60d74"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cab7fad4-786f-4b87-8684-f7974d7968b3"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d0178907-ae7d-4d42-9767-3399292986eb"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d259e8e9-22b4-4c95-a6a2-84c829e3bbf3"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d288108a-8e1d-41e9-ac57-775dc33b917a"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d4221531-ef7c-44a8-86e0-ab4035c90a3d"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("da3db1a6-ad4f-4a1c-8eb9-f50163d51b36"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("de55acf4-acde-4980-8498-8e1cbd436bda"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("de70057c-84a8-450f-85ff-4164a50f2981"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e0f40bf0-0504-4f7a-81f1-e3a035277bb9"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("e402d292-9b9f-49d8-99b1-2de87e1bcdac"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e41a5e8d-44eb-41ef-b8e3-234e8dd46225"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e846f3a7-7a6f-496a-81b8-d9b60f0aea98"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e9174d9b-2408-463b-a6d9-ff4a4bfe48e4"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("ebd56e5f-e98b-4acd-aef8-cfc980833388"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f7984165-3990-4d4d-8b93-40b57d3bc3e5"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f7dcc55e-cde8-4eb1-952b-0a9db021cd7c"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("f8dce239-39e8-4b9d-ac03-e2a9a95ee331"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("fa09a415-b5b0-4236-8ba2-44541d851d30"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("fb26d6bf-6b98-4dff-94f2-64fa4b69ac0a"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("0c609c5c-730c-4581-808f-1dcf43ca98d1"), new DateTime(2023, 4, 27, 12, 33, 41, 332, DateTimeKind.Local).AddTicks(4688), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("86e02402-201c-4523-b89b-678280868add"), new DateTime(2023, 4, 27, 12, 33, 41, 332, DateTimeKind.Local).AddTicks(4558), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("d6cd8651-303e-49f9-b0ef-a86ea152e6b6"), new DateTime(2023, 4, 27, 12, 33, 41, 332, DateTimeKind.Local).AddTicks(4702), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("22f59abd-89c1-424b-9427-d06a61dfba11"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("45891c23-d7e6-4056-999d-92163a771206"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("83cd9fbb-5fc1-4461-81bc-7cddd3d58e7d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("985c53a0-d42d-466d-84ee-f90bb5c2fa0e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9c608aad-667e-4cdd-b5f3-65d753dd1dfc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9e1eb952-2c84-4cf1-a13d-20889aad8889"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a5a67659-e299-4cc4-9f4e-77f4e96daa6d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("da0b53bc-3179-47ff-914c-239b02d42658"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e755d64c-f8d5-4397-a194-a7acfd68e686"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("eb563027-2ee9-4335-85cd-f17f8428e6dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("044f2d98-6ad3-4e42-b2ac-0bcf1102d03b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fa8eb89-b1ed-44b6-87c2-730edd70c84e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("116b7c45-e0fa-4f13-9ec5-ccec6a528b2c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11f52556-470f-4d8b-b1e4-e8b867aeed16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1616d340-f33e-4045-b5b2-c6a15be805c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17bcded1-6baf-46e1-8f5d-ade1e095c5eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a010e7a-2b65-4f41-b89d-073224f09a72"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1dfa42b9-d679-439b-b2d5-afd0201e1016"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25f9d4b5-6348-4c8d-a5bf-c6760bc85b98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a0e1638-650c-448b-9527-5d06686b0b50"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3218aac6-7dad-4820-b4a0-7228d4615d63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("36d70ef0-4d42-4f1b-b137-c5b1c0516b32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bde2d76-061d-4940-99bb-1309a594643d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("41a7d560-81ba-4e80-9171-50c5820747a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44b5e053-54a1-440c-97aa-d59d4099abba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44d30a02-be36-44eb-ade8-3a36e2cf6bb2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cf5acd1-b2d2-4da3-9229-46fa58f5098a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("52736e5a-7cd4-4f8c-9442-da29376d1e47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e1e11e6-5802-4073-ade9-605ffb97d47f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("618cf44a-a24e-4bf5-b666-fffbe3890aec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("652f4b18-040b-4efb-ba17-80bba6ef9376"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("692e1666-121c-42f3-ba4e-65a2fc1e2faf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6abeebf6-b441-4df4-988a-baa90f2c09c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6bd727de-617e-4be0-bdad-5256011228e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6cb4aa2b-a0b8-48b1-8a0b-66f9ae01a317"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72b2c504-ab13-494e-a433-5c62f53c3171"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74800c51-cf2f-4931-bd68-0d1853edc868"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7645f5d3-7527-487f-899f-3bfda3a12f43"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ac28034-9ed6-47bd-b3c1-1c1d6e3a2916"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("82ca7f8d-fe65-4890-a592-0afcc161155d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84ae68b9-e725-4807-ac2b-6c65beed89df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8503da19-d33d-4740-9623-4a3f10accbce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("881cfa46-98dc-416a-81cd-ea2c6da05f4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("897df960-f5da-435e-af1c-ff52fd7c73d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b0048fd-a1a2-4ac3-bd18-fb2015964108"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b150c74-35a6-4989-8374-3751c836ffae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f1a8bd3-be1c-4d9e-8952-fab33adb427a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f371c79-1880-4c7a-bab2-14ecbea69b56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("961b9daa-a615-4369-9331-203495b692d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("96a7012f-f957-42fc-afe9-7b010f2787cf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98527eb8-9199-4264-81bc-e8c1a784f381"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("991f15f1-5a27-497b-9da8-55dbd1440b4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99ec2d2a-3b5b-4358-b845-b16ecaba9463"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a08c4dbd-75de-4fa3-ae7d-0520c441f3c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a38d94c9-bc52-4f14-b0eb-7df7228963e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6af72c6-47be-4580-8c4c-d723e8a0f330"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab7b85a6-ba80-46b3-99c8-22e44df83fa9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2ae66a5-aeae-4ab7-bfa3-ba3822baa3b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b30841ff-69a3-4edb-b833-4bf4ee468665"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b35a7f08-9ff4-4c2e-861a-00df93f10c6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5918646-9a3c-43c0-9441-c21772c8a4ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8f51e0b-75f6-4683-9479-94157aa84122"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb148795-8bfe-417b-ba1b-a1f59c5097e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c193a0ea-aa2f-4926-b1d7-0fc25fa9fe6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca777666-6ab2-4448-8d9c-09264ed60d74"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cab7fad4-786f-4b87-8684-f7974d7968b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0178907-ae7d-4d42-9767-3399292986eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d259e8e9-22b4-4c95-a6a2-84c829e3bbf3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d288108a-8e1d-41e9-ac57-775dc33b917a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4221531-ef7c-44a8-86e0-ab4035c90a3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da3db1a6-ad4f-4a1c-8eb9-f50163d51b36"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de55acf4-acde-4980-8498-8e1cbd436bda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de70057c-84a8-450f-85ff-4164a50f2981"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0f40bf0-0504-4f7a-81f1-e3a035277bb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e402d292-9b9f-49d8-99b1-2de87e1bcdac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e41a5e8d-44eb-41ef-b8e3-234e8dd46225"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e846f3a7-7a6f-496a-81b8-d9b60f0aea98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9174d9b-2408-463b-a6d9-ff4a4bfe48e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebd56e5f-e98b-4acd-aef8-cfc980833388"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7984165-3990-4d4d-8b93-40b57d3bc3e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7dcc55e-cde8-4eb1-952b-0a9db021cd7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8dce239-39e8-4b9d-ac03-e2a9a95ee331"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa09a415-b5b0-4236-8ba2-44541d851d30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb26d6bf-6b98-4dff-94f2-64fa4b69ac0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c609c5c-730c-4581-808f-1dcf43ca98d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86e02402-201c-4523-b89b-678280868add"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6cd8651-303e-49f9-b0ef-a86ea152e6b6"));

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
    }
}
