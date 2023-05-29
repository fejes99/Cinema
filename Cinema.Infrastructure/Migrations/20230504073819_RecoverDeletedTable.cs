using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RecoverDeletedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2a057a61-3f07-4f18-a79c-00610ce2eb9f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3e2bd12b-2786-4cc2-89dd-d6a76916c919"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("594c373b-632e-4934-a71a-72c5e02137fd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6c4a93e1-9939-461b-8f47-2cca413f3bdc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9c9b0b0b-993b-425e-ad47-8b043b48a603"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b67c86f7-5c77-49a3-9ab3-b2d42d2375d8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b97e8940-22f0-4b20-a1a4-11f3d674684b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c0504a93-bbff-4ad4-9a67-5b033a8667d5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d9e7cee5-d18d-4f99-881e-d433a510ab2c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e554c302-f451-4957-b7b1-d6b112fa5691"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("058ae6f4-6a62-475b-9910-f27a21b228fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b59191c-acbf-47bb-92e1-a97b39a75736"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c1b7792-9a14-449e-9da3-6daf2a508f88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d25935e-8d59-45c8-a8d5-1fc526a01276"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f63d46f-a3d5-4dc1-9336-3384244a87e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10843b40-fa7b-4192-9ffa-dfa2e4908faa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10a6a4a3-548f-4db3-9b4d-1968947958f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10b608e3-db1b-431d-8b1b-5abfe55ee70d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11f64bb1-a56a-4a6c-89eb-ad87cb460fea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("152416e9-59d2-4299-8946-26d4b2745c9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19baada4-fcc9-49e1-a4ac-26443a104ed3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1d6de834-cef3-42ab-a01d-5ad8d286cc2e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21201ea7-3db4-45f0-b68d-e4411af00935"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26de8d6b-7741-48d3-8bd7-2f697e79b0d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("284aadff-a76b-4077-b9fc-94c7fe73c7fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c06b23d-7c3c-4a0d-a145-74949f0fa786"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39035796-ef6a-4323-86d8-4aa85fbd5d8a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("398e30fd-4ad3-493e-92db-2557e9527071"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b9bb2c9-5b87-4b6f-add7-fc24807f3ec5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3cee491d-83a3-4f6c-b844-040e0efaacb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d5e8072-008a-4571-830a-c4133ff91c85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f51710e-8d15-4f00-ac41-451618bb434a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40792ee1-591e-4b0b-a02d-25bbc0f1744b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42d9b6c8-6e81-4be2-92b9-8b9180d8d2a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44e95760-f479-4477-9cfd-a2dda9d5929d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a0c557d-4d86-4258-9279-f2df42f862a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d0ae1e6-ffc7-4aaf-95b5-466b33da796a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("509a800b-3a5f-413e-b462-70c21e032252"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54a925d9-b39c-4471-b47d-4c9b3288ad1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55080752-064b-40b1-89c3-dc410aaedff1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f8ae3cc-6e27-48d6-a717-b9b318201d45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6041decf-aee5-4fc0-b6ec-9c37d53f1530"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("645b856c-dab9-440c-8ec7-88a8c582eb1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("669ce83b-a1fe-45b6-a090-9e07dd35a971"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6765808a-4a1a-4373-9d7e-3712311bddb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f0324fe-7278-4fe1-9c51-77c2bb7de550"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76cd73fc-6ffd-426f-92e5-692d98af942a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77caaff1-be81-4653-9f3f-69cdbcf38704"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f933d1d-93e0-4921-8e50-e310dd5a1bf0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80f7c0db-37bf-4cc4-9224-41d7355830b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("819d012c-f826-431e-aa80-b369088be4e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8306e611-db47-47dd-a42c-775d966227c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8706b11e-3778-4ec3-a3f7-b7b798856ae4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b99209b-022f-44ed-826a-3b273a5534d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e02e60d-f9a7-49f2-9ee5-224e655b7ad9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("936ec55d-a8c7-4119-a9d8-9c05fe4f566a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98893bd9-1ea1-4684-a377-5949d5e6d9f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d4aaf96-97c2-463f-a49c-69a3885d4eb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9a7c446-3ffe-475b-84be-50ff3f8f155a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab6495ea-ef74-48fd-810c-db17df2dfd1e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2e883d7-b617-4cbe-8457-41efd0e0be94"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4436eb5-3bc7-4112-9bd9-fbc2e254f10c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b47cc357-e86f-4945-8f88-e48825d497e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b714b465-368e-417e-b2e3-498427a942a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8004b91-a75d-4cb4-8b59-b9ac19121896"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8577f75-8215-474e-8404-c94efc9a3153"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be298b3c-4daf-4726-b14d-f362356a2fc4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0912596-32bc-43b2-adc1-ccb38896d3e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1da79b3-27c5-4eb3-8f0a-a23bf93b48e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c343f12a-3685-402c-8ebc-21c170141fdb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5aca5a9-3935-4f17-bc82-bd5e00906097"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7a82656-0f3f-42de-9222-788869950075"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("caefa80a-faa3-404a-bceb-8ee935559914"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ccfb6f76-1b64-4d39-9463-ce95e09bc452"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d030476b-6f46-40e1-b6ad-564ee44dbd90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7b4fdcb-48c5-4c02-b7a1-bc7b4bdd7770"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e99aa29c-d770-43c0-bf0f-a71fb49b34d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec11b695-bfbf-49a3-af39-120139b153eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed352746-dd2c-4d2d-a942-020687f61640"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee77a4c1-1363-4ae7-8fbe-6ba586dddc65"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2628e0b-2b01-4b40-a304-a2a733b11dda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa48f5b9-9536-4f0d-b1e8-749eb5d69b0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb4bd6ff-c2e7-4b35-8507-9f02f564f09f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb5690bb-ed5d-471a-9ae6-61d61324699b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3533ee98-6ac9-439c-9873-2aea37676f13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("774ec70c-4101-43ef-8b7c-07e88bd9d0c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("776a3ec6-b7a2-47f9-af9e-c79f408f4698"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("3f447120-98c3-4d06-bb5d-55adb4f6ba0e"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("5add3d80-dabb-4b6f-9351-510946d5659a"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("67b4211e-36fa-41f1-bb0d-04c49ba37759"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("a11e19c2-93a4-4e7b-ae55-60c9db73f5ca"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("aff66548-646d-4ee6-b3ed-1b089569e87b"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("d7498685-ee3b-4a02-8cc4-ef8812669a7e"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("dd657905-3f59-4e52-96ab-39101c7e9fcb"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("e1591225-37bd-4567-b89c-5ad8cd894c53"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("f0beee10-2dbc-40a6-af22-afd1e12f54df"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("f4f6a93f-3b1b-4ea7-8b21-2aaa3cb5f084"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("0166fd85-4ff2-49c8-a2cf-a6e30ce33f47"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0d245529-6753-4107-bb3b-230b64b9248f"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0e3842b2-41a4-47c4-a93c-28e8366a3558"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("11345c3c-607f-4624-92e6-4d8c34fa026f"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("13a4f158-e203-4dad-924f-d483e0b65c99"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("16a67f60-f716-4059-86dc-3049fa79e31e"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1da49e82-5757-4b77-ad33-d80a474a7219"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("1fd35d0a-0e76-4615-84d6-7e6116be0e79"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("239e31e5-4d43-46f7-a414-10c25c796141"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2bccf560-a88b-480b-965c-6bcd1cd0c18a"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("2d859d2c-8be1-4030-baf1-d846887286f9"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2f5c0c89-0b9d-44c0-967b-b440d90b1ceb"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("38b15c6f-3fdb-483e-a941-ad630011fef3"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3a2401b6-9517-466b-adf5-c83fd1a0cbc5"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("3a59adca-23d8-4be2-a59e-0373fa5c1cd2"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("400bcd02-5ff4-4b1d-84e8-a2a6e1ad581d"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4146d1fd-c1ae-4d84-a590-a68844366b26"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("43ffd46f-da8f-4246-8d4d-8f086113833f"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("4602be33-13b5-46af-9a71-8deadd35bd4a"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("49e59159-5cd7-46fe-b027-8060d960a896"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("548f98bc-4aed-4f2a-bfa5-3cf6e9ad68d1"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("5aa704a2-37b1-4fc3-bd90-f35b63dff4e0"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("5c692b2c-5986-4760-a23d-3b7889633eb9"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5eeafe3d-92a1-4084-8b93-f3976ad3c9e5"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("600aa756-93fd-4383-ac3d-e0901ccbd69b"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("62cdf12d-ba7e-429b-97ee-d4393a96973a"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("64a3a3ac-15e2-44ad-a038-772eb6840f59"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6c3b2740-e052-4ee7-bc8f-d57d3a49eecb"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("779a4ce3-b737-416d-9b69-f96054ef999a"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7e15cc11-ee26-4d0e-b0f6-e78550ab9cfc"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8392d943-2362-408c-961a-e5b966470f2b"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("83a2d9c2-ca71-4ac1-8667-e1a7ebc9ebd2"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("853c11d2-05e5-4dd3-b018-f8e88b98e878"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("85a3776d-07a3-4bf6-a95d-a7c5e8940b6f"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("892053d8-9c75-4882-a4ac-6cd6b6cada3d"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("89d432d6-91f8-47af-8720-0d70ab13a419"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8c4d65a2-838f-4213-b5f3-0d897df4d328"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8d7c9198-ad98-431e-b4b0-d98a1cb8a4c3"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8eeaabde-5e7a-4534-9f14-e14f0898435d"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("91a3ad07-55e0-42d4-b498-e14dac95b020"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("94fc1c8e-7a19-4083-805e-c7be438c6818"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("95a4ecc4-e18e-436f-8bce-e91c852335c7"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("9e1ca660-8534-4e7f-b09b-01da3bdb0bee"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a04ca547-f40c-4346-a604-0fda3f8b6aa9"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("a04cae4e-fef2-4b46-8cad-61ff121e212a"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("a121c3da-10fe-4fb2-acb9-c219c707866b"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a95f1700-af7d-4c10-bc19-1fc5500226e5"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("aad22070-8e37-4900-92e3-8726af5c3713"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b048f1bb-078d-4371-9b15-0993b2364cdf"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b7ba6742-5c55-49e5-8ce5-bef304b85412"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("be9a35c5-29b9-4648-87f8-47a0a63857d6"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("c1b04dc9-3a19-45c2-a40f-41aa9bde743a"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("c2596a9b-7c9c-45bb-85ca-bcf8fab32b8b"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c4a05b1f-4cb9-42a3-b3a8-15637569da3a"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c51ff4bd-ef60-4955-9822-a3d462ef4da5"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("cc05a37c-9262-4a00-8123-9e41f5d6e9bc"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d42d72ee-fe1a-47ca-8a24-a27ec763e7af"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d510b0dd-8274-40d8-9702-52b77672adcc"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d5152049-5ffb-423d-8d03-4fd2e3ca8913"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d75eaf48-56e9-4275-9c9d-65af70e6fedf"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d76d9cdb-3d31-4fbb-a510-f441faf8cfb7"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d8636e35-cb5f-4c06-89b1-27b09b2ccb8f"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("dd43c8a8-1732-42df-b6f5-64c1d762e117"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e526cd1a-d1b9-4495-8468-0c9681a39b47"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("e8aa4b2e-c740-420c-a98f-5aac6332bfee"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("eb583bdf-f4e6-41a8-8df9-9607915306c2"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ebbeefb4-5170-4d6a-a433-bc5ad36bc691"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ebe703e5-385e-40d4-9d73-b623a44a68e4"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f0e20a9c-dffc-4505-bb90-b60542fe1a3e"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f16a3a0b-ed7e-45d4-aa58-9c35c0c1d3c1"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("f345f7f6-f56b-44e1-9b6a-7c590faf6fd0"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f6068314-2bd8-459f-8409-9b3f9fc309ee"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fb7998fd-f087-4300-8036-06d20b0c48d2"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("fc136324-2262-4d75-b138-fe96bb27d584"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("241d5f88-03ba-4a77-b258-a81db799e363"), new DateTime(2023, 5, 4, 9, 38, 19, 569, DateTimeKind.Local).AddTicks(4361), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" },
                    { new Guid("81768215-d78f-4dc7-be83-d46e087e1e25"), new DateTime(2023, 5, 4, 9, 38, 19, 569, DateTimeKind.Local).AddTicks(4520), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" },
                    { new Guid("983c6755-b318-40f3-af5e-697e69d2b49a"), new DateTime(2023, 5, 4, 9, 38, 19, 569, DateTimeKind.Local).AddTicks(4504), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3f447120-98c3-4d06-bb5d-55adb4f6ba0e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5add3d80-dabb-4b6f-9351-510946d5659a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("67b4211e-36fa-41f1-bb0d-04c49ba37759"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a11e19c2-93a4-4e7b-ae55-60c9db73f5ca"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("aff66548-646d-4ee6-b3ed-1b089569e87b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d7498685-ee3b-4a02-8cc4-ef8812669a7e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dd657905-3f59-4e52-96ab-39101c7e9fcb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e1591225-37bd-4567-b89c-5ad8cd894c53"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f0beee10-2dbc-40a6-af22-afd1e12f54df"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f4f6a93f-3b1b-4ea7-8b21-2aaa3cb5f084"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0166fd85-4ff2-49c8-a2cf-a6e30ce33f47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d245529-6753-4107-bb3b-230b64b9248f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e3842b2-41a4-47c4-a93c-28e8366a3558"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11345c3c-607f-4624-92e6-4d8c34fa026f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13a4f158-e203-4dad-924f-d483e0b65c99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16a67f60-f716-4059-86dc-3049fa79e31e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1da49e82-5757-4b77-ad33-d80a474a7219"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1fd35d0a-0e76-4615-84d6-7e6116be0e79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("239e31e5-4d43-46f7-a414-10c25c796141"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2bccf560-a88b-480b-965c-6bcd1cd0c18a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d859d2c-8be1-4030-baf1-d846887286f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f5c0c89-0b9d-44c0-967b-b440d90b1ceb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38b15c6f-3fdb-483e-a941-ad630011fef3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a2401b6-9517-466b-adf5-c83fd1a0cbc5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a59adca-23d8-4be2-a59e-0373fa5c1cd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("400bcd02-5ff4-4b1d-84e8-a2a6e1ad581d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4146d1fd-c1ae-4d84-a590-a68844366b26"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43ffd46f-da8f-4246-8d4d-8f086113833f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4602be33-13b5-46af-9a71-8deadd35bd4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49e59159-5cd7-46fe-b027-8060d960a896"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("548f98bc-4aed-4f2a-bfa5-3cf6e9ad68d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5aa704a2-37b1-4fc3-bd90-f35b63dff4e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5c692b2c-5986-4760-a23d-3b7889633eb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5eeafe3d-92a1-4084-8b93-f3976ad3c9e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("600aa756-93fd-4383-ac3d-e0901ccbd69b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62cdf12d-ba7e-429b-97ee-d4393a96973a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64a3a3ac-15e2-44ad-a038-772eb6840f59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c3b2740-e052-4ee7-bc8f-d57d3a49eecb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("779a4ce3-b737-416d-9b69-f96054ef999a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7e15cc11-ee26-4d0e-b0f6-e78550ab9cfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8392d943-2362-408c-961a-e5b966470f2b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83a2d9c2-ca71-4ac1-8667-e1a7ebc9ebd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("853c11d2-05e5-4dd3-b018-f8e88b98e878"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85a3776d-07a3-4bf6-a95d-a7c5e8940b6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("892053d8-9c75-4882-a4ac-6cd6b6cada3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89d432d6-91f8-47af-8720-0d70ab13a419"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c4d65a2-838f-4213-b5f3-0d897df4d328"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d7c9198-ad98-431e-b4b0-d98a1cb8a4c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8eeaabde-5e7a-4534-9f14-e14f0898435d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91a3ad07-55e0-42d4-b498-e14dac95b020"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94fc1c8e-7a19-4083-805e-c7be438c6818"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95a4ecc4-e18e-436f-8bce-e91c852335c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e1ca660-8534-4e7f-b09b-01da3bdb0bee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a04ca547-f40c-4346-a604-0fda3f8b6aa9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a04cae4e-fef2-4b46-8cad-61ff121e212a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a121c3da-10fe-4fb2-acb9-c219c707866b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a95f1700-af7d-4c10-bc19-1fc5500226e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aad22070-8e37-4900-92e3-8726af5c3713"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b048f1bb-078d-4371-9b15-0993b2364cdf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7ba6742-5c55-49e5-8ce5-bef304b85412"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be9a35c5-29b9-4648-87f8-47a0a63857d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1b04dc9-3a19-45c2-a40f-41aa9bde743a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2596a9b-7c9c-45bb-85ca-bcf8fab32b8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c4a05b1f-4cb9-42a3-b3a8-15637569da3a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c51ff4bd-ef60-4955-9822-a3d462ef4da5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc05a37c-9262-4a00-8123-9e41f5d6e9bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d42d72ee-fe1a-47ca-8a24-a27ec763e7af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d510b0dd-8274-40d8-9702-52b77672adcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5152049-5ffb-423d-8d03-4fd2e3ca8913"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d75eaf48-56e9-4275-9c9d-65af70e6fedf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d76d9cdb-3d31-4fbb-a510-f441faf8cfb7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8636e35-cb5f-4c06-89b1-27b09b2ccb8f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd43c8a8-1732-42df-b6f5-64c1d762e117"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e526cd1a-d1b9-4495-8468-0c9681a39b47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8aa4b2e-c740-420c-a98f-5aac6332bfee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb583bdf-f4e6-41a8-8df9-9607915306c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebbeefb4-5170-4d6a-a433-bc5ad36bc691"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebe703e5-385e-40d4-9d73-b623a44a68e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0e20a9c-dffc-4505-bb90-b60542fe1a3e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f16a3a0b-ed7e-45d4-aa58-9c35c0c1d3c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f345f7f6-f56b-44e1-9b6a-7c590faf6fd0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6068314-2bd8-459f-8409-9b3f9fc309ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb7998fd-f087-4300-8036-06d20b0c48d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc136324-2262-4d75-b138-fe96bb27d584"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("241d5f88-03ba-4a77-b258-a81db799e363"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81768215-d78f-4dc7-be83-d46e087e1e25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("983c6755-b318-40f3-af5e-697e69d2b49a"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("2a057a61-3f07-4f18-a79c-00610ce2eb9f"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("3e2bd12b-2786-4cc2-89dd-d6a76916c919"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("594c373b-632e-4934-a71a-72c5e02137fd"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("6c4a93e1-9939-461b-8f47-2cca413f3bdc"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("9c9b0b0b-993b-425e-ad47-8b043b48a603"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("b67c86f7-5c77-49a3-9ab3-b2d42d2375d8"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Asterix & Obelix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("b97e8940-22f0-4b20-a1a4-11f3d674684b"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("c0504a93-bbff-4ad4-9a67-5b033a8667d5"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("d9e7cee5-d18d-4f99-881e-d433a510ab2c"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("e554c302-f451-4957-b7b1-d6b112fa5691"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("058ae6f4-6a62-475b-9910-f27a21b228fe"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0b59191c-acbf-47bb-92e1-a97b39a75736"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("0c1b7792-9a14-449e-9da3-6daf2a508f88"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0d25935e-8d59-45c8-a8d5-1fc526a01276"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("0f63d46f-a3d5-4dc1-9336-3384244a87e1"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("10843b40-fa7b-4192-9ffa-dfa2e4908faa"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("10a6a4a3-548f-4db3-9b4d-1968947958f6"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("10b608e3-db1b-431d-8b1b-5abfe55ee70d"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("11f64bb1-a56a-4a6c-89eb-ad87cb460fea"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("152416e9-59d2-4299-8946-26d4b2745c9b"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("19baada4-fcc9-49e1-a4ac-26443a104ed3"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1d6de834-cef3-42ab-a01d-5ad8d286cc2e"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("21201ea7-3db4-45f0-b68d-e4411af00935"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("26de8d6b-7741-48d3-8bd7-2f697e79b0d7"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("284aadff-a76b-4077-b9fc-94c7fe73c7fb"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("2c06b23d-7c3c-4a0d-a145-74949f0fa786"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("39035796-ef6a-4323-86d8-4aa85fbd5d8a"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("398e30fd-4ad3-493e-92db-2557e9527071"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3b9bb2c9-5b87-4b6f-add7-fc24807f3ec5"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("3cee491d-83a3-4f6c-b844-040e0efaacb4"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3d5e8072-008a-4571-830a-c4133ff91c85"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3f51710e-8d15-4f00-ac41-451618bb434a"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("40792ee1-591e-4b0b-a02d-25bbc0f1744b"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("42d9b6c8-6e81-4be2-92b9-8b9180d8d2a6"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("44e95760-f479-4477-9cfd-a2dda9d5929d"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4a0c557d-4d86-4258-9279-f2df42f862a8"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("4d0ae1e6-ffc7-4aaf-95b5-466b33da796a"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("509a800b-3a5f-413e-b462-70c21e032252"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("54a925d9-b39c-4471-b47d-4c9b3288ad1d"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("55080752-064b-40b1-89c3-dc410aaedff1"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5f8ae3cc-6e27-48d6-a717-b9b318201d45"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6041decf-aee5-4fc0-b6ec-9c37d53f1530"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("645b856c-dab9-440c-8ec7-88a8c582eb1d"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("669ce83b-a1fe-45b6-a090-9e07dd35a971"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6765808a-4a1a-4373-9d7e-3712311bddb6"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6f0324fe-7278-4fe1-9c51-77c2bb7de550"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("76cd73fc-6ffd-426f-92e5-692d98af942a"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("77caaff1-be81-4653-9f3f-69cdbcf38704"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("7f933d1d-93e0-4921-8e50-e310dd5a1bf0"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("80f7c0db-37bf-4cc4-9224-41d7355830b3"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("819d012c-f826-431e-aa80-b369088be4e3"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("8306e611-db47-47dd-a42c-775d966227c9"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8706b11e-3778-4ec3-a3f7-b7b798856ae4"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("8b99209b-022f-44ed-826a-3b273a5534d1"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("8e02e60d-f9a7-49f2-9ee5-224e655b7ad9"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("936ec55d-a8c7-4119-a9d8-9c05fe4f566a"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("98893bd9-1ea1-4684-a377-5949d5e6d9f0"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9d4aaf96-97c2-463f-a49c-69a3885d4eb9"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("a9a7c446-3ffe-475b-84be-50ff3f8f155a"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ab6495ea-ef74-48fd-810c-db17df2dfd1e"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b2e883d7-b617-4cbe-8457-41efd0e0be94"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b4436eb5-3bc7-4112-9bd9-fbc2e254f10c"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("b47cc357-e86f-4945-8f88-e48825d497e4"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("b714b465-368e-417e-b2e3-498427a942a0"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b8004b91-a75d-4cb4-8b59-b9ac19121896"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("b8577f75-8215-474e-8404-c94efc9a3153"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("be298b3c-4daf-4726-b14d-f362356a2fc4"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c0912596-32bc-43b2-adc1-ccb38896d3e9"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c1da79b3-27c5-4eb3-8f0a-a23bf93b48e2"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c343f12a-3685-402c-8ebc-21c170141fdb"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c5aca5a9-3935-4f17-bc82-bd5e00906097"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c7a82656-0f3f-42de-9222-788869950075"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("caefa80a-faa3-404a-bceb-8ee935559914"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ccfb6f76-1b64-4d39-9463-ce95e09bc452"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d030476b-6f46-40e1-b6ad-564ee44dbd90"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d7b4fdcb-48c5-4c02-b7a1-bc7b4bdd7770"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("e99aa29c-d770-43c0-bf0f-a71fb49b34d1"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ec11b695-bfbf-49a3-af39-120139b153eb"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("ed352746-dd2c-4d2d-a942-020687f61640"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ee77a4c1-1363-4ae7-8fbe-6ba586dddc65"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("f2628e0b-2b01-4b40-a304-a2a733b11dda"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fa48f5b9-9536-4f0d-b1e8-749eb5d69b0c"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("fb4bd6ff-c2e7-4b35-8507-9f02f564f09f"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("fb5690bb-ed5d-471a-9ae6-61d61324699b"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3533ee98-6ac9-439c-9873-2aea37676f13"), new DateTime(2023, 5, 4, 9, 31, 54, 665, DateTimeKind.Local).AddTicks(5814), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "User", "stefanbulaja" },
                    { new Guid("774ec70c-4101-43ef-8b7c-07e88bd9d0c4"), new DateTime(2023, 5, 4, 9, 31, 54, 665, DateTimeKind.Local).AddTicks(5510), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "User", "davidfejes" },
                    { new Guid("776a3ec6-b7a2-47f9-af9e-c79f408f4698"), new DateTime(2023, 5, 4, 9, 31, 54, 665, DateTimeKind.Local).AddTicks(5919), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "User", "andrijatasic" }
                });
        }
    }
}
