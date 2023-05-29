using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class projectionseedtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00acb23e-ac54-44cc-8de9-ff438fb67194"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("435bc946-29e7-4113-97fa-e493c32eed5a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("79bf7a4f-c5dc-4e43-9d16-061baafcd80f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("81db0d6f-9170-4489-8f05-878b7b2710c3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("91e94a34-de98-42d5-943b-808b8604c2ff"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a671b3ed-d87f-40fe-b4b8-538e228cb518"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c4a7b061-0b1e-4861-af6f-6a98defde571"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d0de2140-1003-45a7-a9cd-7899f7ba2460"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dfd5049c-6305-4a75-8725-6a53f9d5140b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fe0f9deb-ac15-42a3-baab-c74af2de488c"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("047ec9f2-e637-41bf-8594-472be353ce71"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("05744d1a-d176-428c-ae1f-0bf4dac3b3f0"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("0ac84cff-2335-4c7e-a302-1689084679ce"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("0bcffd1b-2b46-4943-b346-298f240c8daa"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("0ce35f0f-7710-42b7-89f0-88073879c190"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("0d1c6bc5-29ab-41d1-a836-d48938410e17"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("2897a398-eadf-49ca-9af7-557349651b48"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("346c6ceb-a571-4478-b17b-f336fd07fa86"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("34d70bf8-1b97-4ac2-92d8-198cbde25022"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("4e13a256-3c8d-4d68-b782-2d379f9d95df"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("585c11dd-52e1-49d7-9d0e-9bd7919da9a4"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("587d89ae-e805-49f5-8d38-2dd35615275b"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("5cff070e-5364-4f7e-8ffa-cdce63f7e6d6"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("60ebfb2d-cde6-437e-8ca2-cf17a662a74c"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("654b11d9-6747-4f07-88ee-28ee556f53b1"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("6b235c3b-6c05-459d-9c43-35e1f7471e8a"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("6f36d102-972e-43ed-8ad6-a6318f7dddc3"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("a18c26ee-c068-400c-ac26-13599407bca3"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("a358b67a-ccee-47d0-b57f-56e87074525e"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("a8296e6b-06c9-4546-b161-f3c3e0f3d7ce"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("aee313c3-1ac6-4f11-a70c-d4e52dd81661"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("b7b42a6d-3aad-4255-ab34-4773ac8c2ab9"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("c4ec9089-1920-453b-959d-836c715d44ed"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("c7f4fed6-4f06-4a64-b43d-d76e804c7c64"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("d6a0021e-da68-44ee-a1b5-dd03e7018a3e"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("e11a798a-2523-4fc7-9c33-5b7ae55bba5f"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("e71eecbe-4338-4460-9eee-b02d89936743"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("ef004d6e-5059-4481-9eba-bc0c965b0956"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("f4e9dde1-a6be-4ed0-a71e-21bf69ef0c00"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("fa84284b-adf1-425f-bdf7-5c27d68b8d8f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00dfd860-92d7-4882-8bc3-afd511cbb8ba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0321b714-b41f-4df3-9829-b233df775ab8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03f11b58-3604-4ff3-acc4-8d6e42039780"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b858d15-4154-4ee4-a47d-38e6a8700340"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d1a24c5-dd13-4914-a113-bcd55b78f81c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("163b596e-937b-4ff1-a535-c7c74f5d9e89"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ee884c5-386d-4690-a3d8-25b9c0050bc9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25b4afb5-f611-4377-9d02-e7618684e80b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a24cd00-a80d-4580-9034-b7e4932a5334"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2baff9f4-f3aa-498c-8d42-a84820606fe8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e7048d6-467a-48a1-ac3f-d69632ba6cc1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("356ec0c9-87ee-487d-9528-5f663eb14695"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("35bde995-57e6-4779-ba16-f35dd7fac9f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("379c327d-c6bd-4a92-afcf-0f0c0699a9e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38130635-96bc-4acd-9c0b-06e4e489f7a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a080576-afc7-406a-a8d9-eb707dd0c2c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3afba016-2720-4d87-9baa-65d40c7c6a1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3baa7053-77f9-4b57-ab58-6b46e1d02b35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c7b8dbb-18f6-462b-9db9-81b929fd1940"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f593d01-3b30-4765-a604-e94b7a0c36d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43fac8f8-033f-4a32-9cef-ed1a5b9151b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49f0e04d-5b1a-4834-88c2-598be371fd0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b394108-fdc4-498a-b220-81e99327713d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("51970330-680d-40b8-8a7f-fde2369f1dea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("525d87f3-7751-4128-a5f8-49a9990c604a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ab3ef5f-19bb-4c36-bb51-c5fe2993fa81"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("651c88e8-12ec-454f-bfe0-fe93fa5b5433"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c1adaf0-84ff-4546-84a1-b0c8b7c180bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d4eff12-6f6b-4ef4-a6d7-36c5024aad36"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71372a4b-eaf2-4f46-aa6c-462020b3d360"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("730dde35-36f3-45dd-97c3-7b1be7046238"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7477e503-5071-439a-ae06-f8c4d9e0a3b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77ff6973-ca1d-41da-8dc4-8c011e776162"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78ac9c7e-7242-4d2d-9caa-f54d115aaa1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c6f785e-e070-4fbc-933f-997dc84be4e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f326b27-ada2-4126-a262-c3a1f68971a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80db6c64-5b50-4632-b998-1e518fe23e49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8293a51a-ecd2-4246-aa6f-207a7deffa56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84d1aa0d-d35a-46d0-b4b9-ec8236a2cb80"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("853811f9-0e34-409a-a159-f9641ec458c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85ca83cb-0563-4e73-89bc-e3c6808b4c33"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87e92a64-21a1-4da2-a338-e7534086bd88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95b44c96-820f-4ba3-aa00-bfe2af8cdfb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9810d7f6-dc2f-40fd-8eae-5c6b4f8391a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c757057-ce97-4560-8530-be885f0855fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa7ea7f6-0d80-44a8-b8ef-6bb7a9fa8625"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aaea55d3-0b7d-41e5-acc9-0efaead3e5a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abc604a5-185c-493e-9c42-46104a75ae18"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af1960f0-deaf-4696-b2e9-461791991138"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b21cdbfc-227f-405b-b7fc-2add2c67cb1e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2247127-0e85-4286-acf2-90190ff55488"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3d53b4e-dc30-41a8-a7aa-7e3aa4057c4d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b452877a-d647-45d2-b4e5-66ef5a72b90e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb71f0e6-80d0-493a-a1bf-02d94f008053"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc1ac9e1-9e57-4353-bf37-a57baa0f846e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc77707d-1089-4c59-800d-25d30ebc6f3a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2e1d40d-0229-4789-92b0-8dae7e888141"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5793486-60b7-42da-8e8f-4a976b22cc48"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7ef396d-f293-46f7-882c-bc8541d0c096"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cafc725b-b208-4822-8756-7223e76024fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cdb0c627-89ad-4f93-94ba-11901195b5fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce1d7fee-cfd4-4fd1-8d7c-bfec8b9ac0a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce6d64c3-beef-4d2e-b585-7ead6c61f8a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf68cf50-af76-43f0-ae18-3a5aa52f148f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4a96f91-4462-4c3f-b6e9-5ed458e35ecb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da0e6daa-4c57-4122-8fd0-f39ccce676c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc7d9363-727c-4fb6-b9e3-841eae0803ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dca064b9-f698-4400-9cc7-5125efdf06af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd8cf998-66f4-4e56-88ca-318977c7ac33"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ddc6cf3d-6e21-44b7-8da1-63ebff826899"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0292671-17a2-4b2f-8bfa-f915143e183b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5f1b20c-b778-4940-9138-024c26f3bdcb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8fa4593-ed54-4b5a-8299-348ade4b883d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fba0d0e2-ab11-47a2-a532-a681fa3c017c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d445fa8-d4aa-405f-8efc-72183e8dce76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f72aa9a-8f91-4aa6-b865-e4fe3f6c1da5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6f55b47-7e10-4cd7-8eb2-7361e23b6f4e"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("0bd1334f-aa3d-40ee-bf78-b76a849d0fb7"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("2a81b8c0-0ba7-4ccb-9762-7ddddb10d859"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("3233c115-afcc-41aa-9048-45a1f8c224cd"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("333c54d5-e6bc-44d7-ba4a-94e7e39bcc2d"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("3b2d0188-4e40-4a36-a9aa-ea0c20c78973"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("3bd8b143-8152-4113-834b-9e90392be53d"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("4d5ec906-8d48-41f4-8558-923ce2afd5a4"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Astérix & Obélix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("9e59cb82-8e0d-4301-8f6c-a801fe7759a9"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("bab9bed6-d934-4cda-a4c0-5eb29e6e4661"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("d6f1e89a-050f-4489-8cfe-f7b5c014c672"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("018951e9-81b6-4f88-ad18-90393e334e14"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("047bb07b-f770-4d76-912f-f89c42355231"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("09685cbf-ce23-40d5-bd23-3e107d76b38e"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1196b99a-d93b-4e62-8077-ad4a9d5741f3"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("14ec3f7b-7784-42d0-8b0f-778059dc5049"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("19188122-27fb-49e3-a777-2957de1c46a2"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1949b2f5-ec1a-4a8d-bb6f-884137902b6d"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("1adab77a-a0ab-4965-ba70-1ba1555f1895"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("1ecbbf3f-14f2-40a2-a412-e4e5dddc792e"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("200f4ff3-97f1-43e5-b1ce-1f8740a4984f"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("21f13677-fa2f-490b-8b74-639870bd05a1"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("2358aab3-f120-47cd-9d6a-77b250c39d2e"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("282676f8-ce9d-43b9-860e-377900de9218"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2879d30a-894f-420d-8fc0-190940c44757"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2f14ebe4-3170-4cce-aadd-4cc1fa95ef61"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("32fd5659-c5b1-42ea-97ef-9e1a12ffeef3"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("33aeebc2-54ed-4c5e-832e-01bc73fae367"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("372064d2-2bcf-4789-a385-9c4ff50f382f"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("38c1b8e2-684d-47ac-9c45-10e42b5d1e05"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("3915d338-be56-4421-97a4-beb4e0d57271"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3c879b51-cfba-45d1-93b0-17e32391aae4"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3ef6712e-d0b3-4ff8-9c5a-d12d556ec323"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("42548302-9a49-4d98-b4ef-221a83c3ec8d"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("45329113-c29b-44c6-b1e6-089e42406203"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("53b87e96-d8c2-4ae2-8849-371dac0ecc45"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5597cbfe-5e72-4c36-866a-07c248bb77ea"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("56aae86d-f7b5-4fc8-ae4e-d189bc852266"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("58772279-8abf-42a4-b8db-5862779b28bb"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("60519659-c48c-4d6b-ba49-da6ed7a0b0fd"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("63268b87-af3b-4a51-9198-e58a71c071ab"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("63caea8f-1d6f-44f9-b14e-f63b2cedb78c"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("64b200aa-d810-4548-aad9-9fb26c07af5f"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("64b4c62b-4360-4d65-ad5a-f4646116cdc3"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("6b412e7f-9737-44ee-ab48-9ce46b2a941d"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6f6847b2-41f3-44cc-9473-ac76ba7ae683"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("778901a0-e8dc-4fab-9433-c5e45c143f00"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("796dba15-d775-40fd-9dfa-b1ecacb00628"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("7f9f8057-0d50-4f3e-a27e-7c93ec6c87e0"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("82b68340-295d-4bbf-9e07-b963b4377e7b"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("836ee7c1-14fc-4c89-9a07-02d96fd5c4bd"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("856d35db-311a-496e-b2e9-e59c2d0a16cd"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("87ce0f09-783e-450b-8b09-1915b781b17f"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("88ac1f40-0c23-4f77-b3e4-59022003e539"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8bce07bf-9ec1-4391-9017-058e28f7fbfc"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("8d189c01-82b7-487d-9305-f3e80ffb6bb2"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8d46aa7d-57a2-4bf5-a90d-c3802a2ba63c"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("929d5665-812e-4834-aead-f62220d2e6b6"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("97a598ef-dd39-474b-a47e-75b81ecc1699"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("9a0e2741-2e8a-4eb8-9a79-920d001d1e84"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("aa79e484-3639-495e-ae56-43d1ac013b6e"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ab5c7e00-a75c-4814-8d3b-66d995fd36e9"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b7204043-ab09-45b7-8db1-188946782a78"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b771e5bd-ebc4-41e1-bc4e-4c0e4b39bd56"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("b801e423-2470-4213-a622-9080bbf602d2"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("bafbc91f-203a-4728-bee4-f3aeca12ba65"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("c2abb97b-f07f-4ec1-b808-38acb1d4e24f"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("c3bcd736-a800-4d75-ae19-d789a4859ec0"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c61bc37a-3d14-4760-9863-4862ad78035d"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cb154012-3973-4b2b-9766-a3e3256fb624"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d1709bf6-caf5-4322-9ead-3048b700edf9"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d2c0fa8b-db86-40a3-9af2-bbe87f42ce85"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d50c9a9e-de16-4860-812e-bcc345063227"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("d7392918-5be5-472a-a834-b4e3c8355f4c"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("d9a3deba-8ee1-4182-b45a-0c59a58b7266"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("dc85e87d-c85d-4dc2-a21d-86a5e1c0473e"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("e90d4d00-2fc8-4aaa-9d8d-92fe774d03db"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("e9ee5aa0-d322-4a46-b3f8-8dd01dca3840"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("eb965e52-e327-4dc8-92df-c24c92898dd2"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("ed99daad-0bb3-4af9-a09f-250f7d0526b9"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("f07df117-2d27-41ed-9242-7877fda888e4"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("f0c82b23-7a1e-4891-a24e-9f2a793a7df6"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("f304455a-1d44-4c95-8c08-5fa1e8636a32"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("f31e780c-a1b7-4560-bcaf-94faf62de6bf"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("f8094175-ac3c-495a-b921-b5fe87b5ac4c"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("28b571fe-f448-429d-9b7d-740d5a22c84a"), new DateTime(2023, 4, 19, 16, 54, 40, 437, DateTimeKind.Local).AddTicks(6853), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" },
                    { new Guid("73fc1122-f226-4912-8e41-0f1b81234f5f"), new DateTime(2023, 4, 19, 16, 54, 40, 437, DateTimeKind.Local).AddTicks(6838), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("8dc802c9-2019-404d-84ce-4bab72c78d3d"), new DateTime(2023, 4, 19, 16, 54, 40, 437, DateTimeKind.Local).AddTicks(6707), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0bd1334f-aa3d-40ee-bf78-b76a849d0fb7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2a81b8c0-0ba7-4ccb-9762-7ddddb10d859"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3233c115-afcc-41aa-9048-45a1f8c224cd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("333c54d5-e6bc-44d7-ba4a-94e7e39bcc2d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3b2d0188-4e40-4a36-a9aa-ea0c20c78973"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3bd8b143-8152-4113-834b-9e90392be53d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4d5ec906-8d48-41f4-8558-923ce2afd5a4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9e59cb82-8e0d-4301-8f6c-a801fe7759a9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bab9bed6-d934-4cda-a4c0-5eb29e6e4661"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d6f1e89a-050f-4489-8cfe-f7b5c014c672"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("018951e9-81b6-4f88-ad18-90393e334e14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("047bb07b-f770-4d76-912f-f89c42355231"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09685cbf-ce23-40d5-bd23-3e107d76b38e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1196b99a-d93b-4e62-8077-ad4a9d5741f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14ec3f7b-7784-42d0-8b0f-778059dc5049"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19188122-27fb-49e3-a777-2957de1c46a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1949b2f5-ec1a-4a8d-bb6f-884137902b6d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1adab77a-a0ab-4965-ba70-1ba1555f1895"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ecbbf3f-14f2-40a2-a412-e4e5dddc792e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("200f4ff3-97f1-43e5-b1ce-1f8740a4984f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21f13677-fa2f-490b-8b74-639870bd05a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2358aab3-f120-47cd-9d6a-77b250c39d2e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("282676f8-ce9d-43b9-860e-377900de9218"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2879d30a-894f-420d-8fc0-190940c44757"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f14ebe4-3170-4cce-aadd-4cc1fa95ef61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32fd5659-c5b1-42ea-97ef-9e1a12ffeef3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33aeebc2-54ed-4c5e-832e-01bc73fae367"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("372064d2-2bcf-4789-a385-9c4ff50f382f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38c1b8e2-684d-47ac-9c45-10e42b5d1e05"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3915d338-be56-4421-97a4-beb4e0d57271"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c879b51-cfba-45d1-93b0-17e32391aae4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ef6712e-d0b3-4ff8-9c5a-d12d556ec323"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42548302-9a49-4d98-b4ef-221a83c3ec8d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45329113-c29b-44c6-b1e6-089e42406203"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53b87e96-d8c2-4ae2-8849-371dac0ecc45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5597cbfe-5e72-4c36-866a-07c248bb77ea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("56aae86d-f7b5-4fc8-ae4e-d189bc852266"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58772279-8abf-42a4-b8db-5862779b28bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60519659-c48c-4d6b-ba49-da6ed7a0b0fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63268b87-af3b-4a51-9198-e58a71c071ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63caea8f-1d6f-44f9-b14e-f63b2cedb78c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64b200aa-d810-4548-aad9-9fb26c07af5f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64b4c62b-4360-4d65-ad5a-f4646116cdc3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b412e7f-9737-44ee-ab48-9ce46b2a941d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f6847b2-41f3-44cc-9473-ac76ba7ae683"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("778901a0-e8dc-4fab-9433-c5e45c143f00"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("796dba15-d775-40fd-9dfa-b1ecacb00628"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f9f8057-0d50-4f3e-a27e-7c93ec6c87e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("82b68340-295d-4bbf-9e07-b963b4377e7b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("836ee7c1-14fc-4c89-9a07-02d96fd5c4bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("856d35db-311a-496e-b2e9-e59c2d0a16cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87ce0f09-783e-450b-8b09-1915b781b17f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88ac1f40-0c23-4f77-b3e4-59022003e539"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8bce07bf-9ec1-4391-9017-058e28f7fbfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d189c01-82b7-487d-9305-f3e80ffb6bb2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d46aa7d-57a2-4bf5-a90d-c3802a2ba63c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("929d5665-812e-4834-aead-f62220d2e6b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97a598ef-dd39-474b-a47e-75b81ecc1699"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a0e2741-2e8a-4eb8-9a79-920d001d1e84"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa79e484-3639-495e-ae56-43d1ac013b6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab5c7e00-a75c-4814-8d3b-66d995fd36e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7204043-ab09-45b7-8db1-188946782a78"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b771e5bd-ebc4-41e1-bc4e-4c0e4b39bd56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b801e423-2470-4213-a622-9080bbf602d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bafbc91f-203a-4728-bee4-f3aeca12ba65"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2abb97b-f07f-4ec1-b808-38acb1d4e24f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3bcd736-a800-4d75-ae19-d789a4859ec0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c61bc37a-3d14-4760-9863-4862ad78035d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb154012-3973-4b2b-9766-a3e3256fb624"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1709bf6-caf5-4322-9ead-3048b700edf9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2c0fa8b-db86-40a3-9af2-bbe87f42ce85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d50c9a9e-de16-4860-812e-bcc345063227"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7392918-5be5-472a-a834-b4e3c8355f4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9a3deba-8ee1-4182-b45a-0c59a58b7266"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc85e87d-c85d-4dc2-a21d-86a5e1c0473e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e90d4d00-2fc8-4aaa-9d8d-92fe774d03db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9ee5aa0-d322-4a46-b3f8-8dd01dca3840"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb965e52-e327-4dc8-92df-c24c92898dd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed99daad-0bb3-4af9-a09f-250f7d0526b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f07df117-2d27-41ed-9242-7877fda888e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0c82b23-7a1e-4891-a24e-9f2a793a7df6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f304455a-1d44-4c95-8c08-5fa1e8636a32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f31e780c-a1b7-4560-bcaf-94faf62de6bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8094175-ac3c-495a-b921-b5fe87b5ac4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28b571fe-f448-429d-9b7d-740d5a22c84a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73fc1122-f226-4912-8e41-0f1b81234f5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dc802c9-2019-404d-84ce-4bab72c78d3d"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "IsDeleted", "Name", "TrailerUrl", "Year" },
                values: new object[,]
                {
                    { new Guid("00acb23e-ac54-44cc-8de9-ff438fb67194"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, false, "Maybe I Do", "https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("435bc946-29e7-4113-97fa-e493c32eed5a"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, false, "Creed 3", "https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("79bf7a4f-c5dc-4e43-9d16-061baafcd80f"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, false, "Indigo Kristal", "https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista", 2022 },
                    { new Guid("81db0d6f-9170-4489-8f05-878b7b2710c3"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, false, "Dungeons & Dragons: Honor Among Thieves", "https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures", 2023 },
                    { new Guid("91e94a34-de98-42d5-943b-808b8604c2ff"), "USA", "Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.", "Ben Affleck", "Blitz Film Video doo", 112, false, "Air", "https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija", 2023 },
                    { new Guid("a671b3ed-d87f-40fe-b4b8-538e228cb518"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, false, "Scream 6", "https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures", 2023 },
                    { new Guid("c4a7b061-0b1e-4861-af6f-6a98defde571"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, false, "Astérix & Obélix: L'Empire du Milieu", "https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija", 2022 },
                    { new Guid("d0de2140-1003-45a7-a9cd-7899f7ba2460"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, false, "65", "https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment", 2023 },
                    { new Guid("dfd5049c-6305-4a75-8725-6a53f9d5140b"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, false, "A Man Called Otto", "https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment", 2022 },
                    { new Guid("fe0f9deb-ac15-42a3-baab-c74af2de488c"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, false, "John Wick: Chapter 4", "https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija", 2023 }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "IsDeleted", "IsSold", "MovieId", "Price", "ProjectionTypeId", "TheaterId", "Time" },
                values: new object[,]
                {
                    { new Guid("047ec9f2-e637-41bf-8594-472be353ce71"), false, false, new Guid("895e5007-06ee-4126-809c-c38650fdedc0"), 600, new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1"), new DateTime(2023, 5, 16, 23, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("05744d1a-d176-428c-ae1f-0bf4dac3b3f0"), false, false, new Guid("e5faae3f-06a2-4ea1-9ac2-41a162039100"), 500, new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"), new DateTime(2023, 5, 17, 23, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0ac84cff-2335-4c7e-a302-1689084679ce"), false, false, new Guid("70b62b1f-58dd-4e54-a7c8-f4a54daaa93d"), 500, new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"), new DateTime(2023, 5, 16, 20, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0bcffd1b-2b46-4943-b346-298f240c8daa"), false, false, new Guid("50394dce-9d82-4834-bbe2-6fa02aa41440"), 350, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"), new DateTime(2023, 5, 15, 16, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0ce35f0f-7710-42b7-89f0-88073879c190"), false, false, new Guid("99bdf360-6cb1-4a9a-a2ce-9bd38dc67ffb"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("a322aedb-053b-4507-895e-150390686b12"), new DateTime(2023, 5, 15, 22, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0d1c6bc5-29ab-41d1-a836-d48938410e17"), false, false, new Guid("857fd540-c94d-4147-8300-a2cf2bd65e7b"), 350, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("a322aedb-053b-4507-895e-150390686b12"), new DateTime(2023, 5, 17, 17, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2897a398-eadf-49ca-9af7-557349651b48"), false, false, new Guid("50394dce-9d82-4834-bbe2-6fa02aa41440"), 350, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"), new DateTime(2023, 5, 15, 16, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("346c6ceb-a571-4478-b17b-f336fd07fa86"), false, false, new Guid("70b62b1f-58dd-4e54-a7c8-f4a54daaa93d"), 350, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"), new DateTime(2023, 5, 16, 18, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("34d70bf8-1b97-4ac2-92d8-198cbde25022"), false, false, new Guid("50394dce-9d82-4834-bbe2-6fa02aa41440"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"), new DateTime(2023, 5, 15, 18, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("4e13a256-3c8d-4d68-b782-2d379f9d95df"), false, false, new Guid("70b62b1f-58dd-4e54-a7c8-f4a54daaa93d"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("585c11dd-52e1-49d7-9d0e-9bd7919da9a4"), false, false, new Guid("50394dce-9d82-4834-bbe2-6fa02aa41440"), 500, new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"), new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("587d89ae-e805-49f5-8d38-2dd35615275b"), false, false, new Guid("857fd540-c94d-4147-8300-a2cf2bd65e7b"), 500, new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("a322aedb-053b-4507-895e-150390686b12"), new DateTime(2023, 5, 17, 23, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5cff070e-5364-4f7e-8ffa-cdce63f7e6d6"), false, false, new Guid("50394dce-9d82-4834-bbe2-6fa02aa41440"), 500, new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"), new DateTime(2023, 5, 15, 22, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("60ebfb2d-cde6-437e-8ca2-cf17a662a74c"), false, false, new Guid("a7b9853d-63a0-4179-9a72-461169e9bee9"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"), new DateTime(2023, 5, 18, 20, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("654b11d9-6747-4f07-88ee-28ee556f53b1"), false, false, new Guid("70b62b1f-58dd-4e54-a7c8-f4a54daaa93d"), 350, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"), new DateTime(2023, 5, 16, 16, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6b235c3b-6c05-459d-9c43-35e1f7471e8a"), false, false, new Guid("c515105b-be02-4815-bbaf-cbf46a2ca9c3"), 350, new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"), new DateTime(2023, 5, 16, 18, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6f36d102-972e-43ed-8ad6-a6318f7dddc3"), false, false, new Guid("c515105b-be02-4815-bbaf-cbf46a2ca9c3"), 550, new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1"), new DateTime(2023, 5, 16, 20, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a18c26ee-c068-400c-ac26-13599407bca3"), false, false, new Guid("895e5007-06ee-4126-809c-c38650fdedc0"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"), new DateTime(2023, 5, 15, 21, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a358b67a-ccee-47d0-b57f-56e87074525e"), false, false, new Guid("c5f7ed44-e040-4ac7-874e-e3de5c33ed08"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("a322aedb-053b-4507-895e-150390686b12"), new DateTime(2023, 5, 16, 20, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a8296e6b-06c9-4546-b161-f3c3e0f3d7ce"), false, false, new Guid("857fd540-c94d-4147-8300-a2cf2bd65e7b"), 600, new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1"), new DateTime(2023, 5, 17, 23, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("aee313c3-1ac6-4f11-a70c-d4e52dd81661"), false, false, new Guid("c5f7ed44-e040-4ac7-874e-e3de5c33ed08"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("a322aedb-053b-4507-895e-150390686b12"), new DateTime(2023, 5, 16, 23, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b7b42a6d-3aad-4255-ab34-4773ac8c2ab9"), false, false, new Guid("857fd540-c94d-4147-8300-a2cf2bd65e7b"), 600, new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb"), new DateTime(2023, 5, 17, 23, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c4ec9089-1920-453b-959d-836c715d44ed"), false, false, new Guid("c515105b-be02-4815-bbaf-cbf46a2ca9c3"), 450, new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb"), new DateTime(2023, 5, 15, 18, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c7f4fed6-4f06-4a64-b43d-d76e804c7c64"), false, false, new Guid("895e5007-06ee-4126-809c-c38650fdedc0"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"), new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d6a0021e-da68-44ee-a1b5-dd03e7018a3e"), false, false, new Guid("99bdf360-6cb1-4a9a-a2ce-9bd38dc67ffb"), 600, new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"), new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1"), new DateTime(2023, 5, 15, 22, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e11a798a-2523-4fc7-9c33-5b7ae55bba5f"), false, false, new Guid("a7b9853d-63a0-4179-9a72-461169e9bee9"), 500, new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"), new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"), new DateTime(2023, 5, 18, 23, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e71eecbe-4338-4460-9eee-b02d89936743"), false, false, new Guid("a7b9853d-63a0-4179-9a72-461169e9bee9"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("a322aedb-053b-4507-895e-150390686b12"), new DateTime(2023, 5, 18, 22, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ef004d6e-5059-4481-9eba-bc0c965b0956"), false, false, new Guid("857fd540-c94d-4147-8300-a2cf2bd65e7b"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("a322aedb-053b-4507-895e-150390686b12"), new DateTime(2023, 5, 17, 20, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f4e9dde1-a6be-4ed0-a71e-21bf69ef0c00"), false, false, new Guid("70b62b1f-58dd-4e54-a7c8-f4a54daaa93d"), 400, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"), new DateTime(2023, 5, 16, 22, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("fa84284b-adf1-425f-bdf7-5c27d68b8d8f"), false, false, new Guid("50394dce-9d82-4834-bbe2-6fa02aa41440"), 350, new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"), new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"), new DateTime(2023, 5, 15, 18, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "TheaterId" },
                values: new object[,]
                {
                    { new Guid("00dfd860-92d7-4882-8bc3-afd511cbb8ba"), 9, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("0321b714-b41f-4df3-9829-b233df775ab8"), 6, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("03f11b58-3604-4ff3-acc4-8d6e42039780"), 4, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("0b858d15-4154-4ee4-a47d-38e6a8700340"), 7, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("0d1a24c5-dd13-4914-a113-bcd55b78f81c"), 6, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("163b596e-937b-4ff1-a535-c7c74f5d9e89"), 5, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("1ee884c5-386d-4690-a3d8-25b9c0050bc9"), 2, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("25b4afb5-f611-4377-9d02-e7618684e80b"), 4, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("2a24cd00-a80d-4580-9034-b7e4932a5334"), 16, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2baff9f4-f3aa-498c-8d42-a84820606fe8"), 12, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("2e7048d6-467a-48a1-ac3f-d69632ba6cc1"), 9, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("356ec0c9-87ee-487d-9528-5f663eb14695"), 10, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("35bde995-57e6-4779-ba16-f35dd7fac9f7"), 1, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("379c327d-c6bd-4a92-afcf-0f0c0699a9e6"), 14, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("38130635-96bc-4acd-9c0b-06e4e489f7a8"), 15, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3a080576-afc7-406a-a8d9-eb707dd0c2c0"), 10, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3afba016-2720-4d87-9baa-65d40c7c6a1d"), 5, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("3baa7053-77f9-4b57-ab58-6b46e1d02b35"), 7, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("3c7b8dbb-18f6-462b-9db9-81b929fd1940"), 6, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("3f593d01-3b30-4765-a604-e94b7a0c36d0"), 20, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("43fac8f8-033f-4a32-9cef-ed1a5b9151b6"), 12, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("49f0e04d-5b1a-4834-88c2-598be371fd0e"), 10, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("4b394108-fdc4-498a-b220-81e99327713d"), 11, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("51970330-680d-40b8-8a7f-fde2369f1dea"), 8, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("525d87f3-7751-4128-a5f8-49a9990c604a"), 17, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("5ab3ef5f-19bb-4c36-bb51-c5fe2993fa81"), 10, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("651c88e8-12ec-454f-bfe0-fe93fa5b5433"), 13, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("6c1adaf0-84ff-4546-84a1-b0c8b7c180bd"), 8, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("6d4eff12-6f6b-4ef4-a6d7-36c5024aad36"), 1, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("71372a4b-eaf2-4f46-aa6c-462020b3d360"), 6, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("730dde35-36f3-45dd-97c3-7b1be7046238"), 4, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("7477e503-5071-439a-ae06-f8c4d9e0a3b5"), 3, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("77ff6973-ca1d-41da-8dc4-8c011e776162"), 1, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("78ac9c7e-7242-4d2d-9caa-f54d115aaa1f"), 1, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("7c6f785e-e070-4fbc-933f-997dc84be4e4"), 9, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("7f326b27-ada2-4126-a262-c3a1f68971a6"), 13, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("80db6c64-5b50-4632-b998-1e518fe23e49"), 4, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("8293a51a-ecd2-4246-aa6f-207a7deffa56"), 15, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("84d1aa0d-d35a-46d0-b4b9-ec8236a2cb80"), 4, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("853811f9-0e34-409a-a159-f9641ec458c5"), 5, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("85ca83cb-0563-4e73-89bc-e3c6808b4c33"), 1, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("87e92a64-21a1-4da2-a338-e7534086bd88"), 7, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("95b44c96-820f-4ba3-aa00-bfe2af8cdfb6"), 5, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("9810d7f6-dc2f-40fd-8eae-5c6b4f8391a6"), 3, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("9c757057-ce97-4560-8530-be885f0855fc"), 8, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("aa7ea7f6-0d80-44a8-b8ef-6bb7a9fa8625"), 2, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("aaea55d3-0b7d-41e5-acc9-0efaead3e5a2"), 3, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("abc604a5-185c-493e-9c42-46104a75ae18"), 2, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("af1960f0-deaf-4696-b2e9-461791991138"), 7, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b21cdbfc-227f-405b-b7fc-2add2c67cb1e"), 2, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("b2247127-0e85-4286-acf2-90190ff55488"), 8, new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1") },
                    { new Guid("b3d53b4e-dc30-41a8-a7aa-7e3aa4057c4d"), 9, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("b452877a-d647-45d2-b4e5-66ef5a72b90e"), 2, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("bb71f0e6-80d0-493a-a1bf-02d94f008053"), 6, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bc1ac9e1-9e57-4353-bf37-a57baa0f846e"), 7, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("bc77707d-1089-4c59-800d-25d30ebc6f3a"), 3, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("c2e1d40d-0229-4789-92b0-8dae7e888141"), 5, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("c5793486-60b7-42da-8e8f-4a976b22cc48"), 1, new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8") },
                    { new Guid("c7ef396d-f293-46f7-882c-bc8541d0c096"), 13, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cafc725b-b208-4822-8756-7223e76024fe"), 18, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cdb0c627-89ad-4f93-94ba-11901195b5fb"), 14, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("ce1d7fee-cfd4-4fd1-8d7c-bfec8b9ac0a4"), 15, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ce6d64c3-beef-4d2e-b585-7ead6c61f8a7"), 4, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("cf68cf50-af76-43f0-ae18-3a5aa52f148f"), 19, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("d4a96f91-4462-4c3f-b6e9-5ed458e35ecb"), 11, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("da0e6daa-4c57-4122-8fd0-f39ccce676c4"), 3, new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3") },
                    { new Guid("dc7d9363-727c-4fb6-b9e3-841eae0803ae"), 2, new Guid("a322aedb-053b-4507-895e-150390686b12") },
                    { new Guid("dca064b9-f698-4400-9cc7-5125efdf06af"), 11, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("dd8cf998-66f4-4e56-88ca-318977c7ac33"), 14, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("ddc6cf3d-6e21-44b7-8da1-63ebff826899"), 8, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("e0292671-17a2-4b2f-8bfa-f915143e183b"), 12, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e5f1b20c-b778-4940-9138-024c26f3bdcb"), 10, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") },
                    { new Guid("e8fa4593-ed54-4b5a-8299-348ade4b883d"), 9, new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335") },
                    { new Guid("fba0d0e2-ab11-47a2-a532-a681fa3c017c"), 3, new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("5d445fa8-d4aa-405f-8efc-72183e8dce76"), new DateTime(2023, 4, 19, 16, 50, 49, 662, DateTimeKind.Local).AddTicks(2349), "stefan.bulaja@gmail.com", "Stefan", "Bulaja", "stefanbulaja", "LoggedUser", "stefanbulaja" },
                    { new Guid("5f72aa9a-8f91-4aa6-b865-e4fe3f6c1da5"), new DateTime(2023, 4, 19, 16, 50, 49, 662, DateTimeKind.Local).AddTicks(2217), "david.fejes@gmail.com", "David", "Fejes", "davidfejes", "LoggedUser", "davidfejes" },
                    { new Guid("c6f55b47-7e10-4cd7-8eb2-7361e23b6f4e"), new DateTime(2023, 4, 19, 16, 50, 49, 662, DateTimeKind.Local).AddTicks(2364), "andija.tasic@gmail.com", "Andrija", "Tasic", "andrijatasic", "LoggedUser", "andrijatasic" }
                });
        }
    }
}
