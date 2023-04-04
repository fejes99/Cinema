using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "Description", "Director", "Distributor", "Duration", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("10e9309e-9cd3-47c1-9c7a-822368eee5f2"), "USA", "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...", "Guillaume Canet", "Blitz Film Video doo", 112, "Astérix & Obélix: L'Empire du Milieu", 2022 },
                    { new Guid("24cbb901-a109-4f94-b4b5-11d023edcb8a"), "USA", "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.", "Michael Jacobs", "Blitz Film Video doo", 95, "Maybe I Do", 2023 },
                    { new Guid("2e2329c2-5eb5-44ae-a7e8-deefea663509"), "USA", "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.", "Marc Forster", "CON Film", 126, "A Man Called Otto", 2022 },
                    { new Guid("3a36be8a-9b6e-4e1e-aede-c5f25b63b409"), "Serbia", "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.", "Luka Mihailović", "Art Vista", 105, "Indigo Kristal", 2022 },
                    { new Guid("914184ed-560a-4ee0-9054-a5f34feb7e47"), "USA", "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.", "Michael B. Jordan", "Blitz Film Video doo", 116, "Creed 3", 2022 },
                    { new Guid("b213e390-7515-4593-a8ff-4e4b39a4921d"), "France", "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u  siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.", "James Huth", "MegaCom Film", 112, "Le nouveau jouet", 2022 },
                    { new Guid("b6de1e9d-4669-44f7-894d-d3f39cf6a958"), "USA", "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.", "Chad Stahelski", "Blitz Film Video doo", 169, "John Wick: Chapter 4", 2023 },
                    { new Guid("cac47e81-6472-463a-91b0-af0e74d6eafc"), "USA", "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.", "Matt Bettinelli-Olpin", "Taramount", 123, "Scream 6", 2023 },
                    { new Guid("cdef622d-58b1-4d00-b40e-e72aba7f50ba"), "USA", "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.", "Scott Beck", "CON Film", 93, "65", 2023 },
                    { new Guid("fd8bd474-47ca-40f8-9a78-d7bda2a21fc1"), "USA", "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.", "Jonathan Goldstein", "Taramount", 134, "Dungeons & Dragons: Honor Among Thieves", 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("10e9309e-9cd3-47c1-9c7a-822368eee5f2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("24cbb901-a109-4f94-b4b5-11d023edcb8a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2e2329c2-5eb5-44ae-a7e8-deefea663509"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3a36be8a-9b6e-4e1e-aede-c5f25b63b409"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("914184ed-560a-4ee0-9054-a5f34feb7e47"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b213e390-7515-4593-a8ff-4e4b39a4921d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b6de1e9d-4669-44f7-894d-d3f39cf6a958"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cac47e81-6472-463a-91b0-af0e74d6eafc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cdef622d-58b1-4d00-b40e-e72aba7f50ba"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fd8bd474-47ca-40f8-9a78-d7bda2a21fc1"));
        }
    }
}
