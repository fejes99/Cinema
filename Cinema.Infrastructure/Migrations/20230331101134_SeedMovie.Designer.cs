﻿// <auto-generated />
using System;
using Cinema.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cinema.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230331101134_SeedMovie")]
    partial class SeedMovie
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Cinema.Domain.AggregateModels.Movies.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<string>("Distributor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cdef622d-58b1-4d00-b40e-e72aba7f50ba"),
                            Country = "USA",
                            Description = "Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.",
                            Director = "Scott Beck",
                            Distributor = "CON Film",
                            Duration = 93,
                            Name = "65",
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("914184ed-560a-4ee0-9054-a5f34feb7e47"),
                            Country = "USA",
                            Description = "Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.",
                            Director = "Michael B. Jordan",
                            Distributor = "Blitz Film Video doo",
                            Duration = 116,
                            Name = "Creed 3",
                            Year = 2022
                        },
                        new
                        {
                            Id = new Guid("3a36be8a-9b6e-4e1e-aede-c5f25b63b409"),
                            Country = "Serbia",
                            Description = "Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.",
                            Director = "Luka Mihailović",
                            Distributor = "Art Vista",
                            Duration = 105,
                            Name = "Indigo Kristal",
                            Year = 2022
                        },
                        new
                        {
                            Id = new Guid("24cbb901-a109-4f94-b4b5-11d023edcb8a"),
                            Country = "USA",
                            Description = "Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.",
                            Director = "Michael Jacobs",
                            Distributor = "Blitz Film Video doo",
                            Duration = 95,
                            Name = "Maybe I Do",
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("cac47e81-6472-463a-91b0-af0e74d6eafc"),
                            Country = "USA",
                            Description = "Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.",
                            Director = "Matt Bettinelli-Olpin",
                            Distributor = "Taramount",
                            Duration = 123,
                            Name = "Scream 6",
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("b6de1e9d-4669-44f7-894d-d3f39cf6a958"),
                            Country = "USA",
                            Description = "Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.",
                            Director = "Chad Stahelski",
                            Distributor = "Blitz Film Video doo",
                            Duration = 169,
                            Name = "John Wick: Chapter 4",
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("fd8bd474-47ca-40f8-9a78-d7bda2a21fc1"),
                            Country = "USA",
                            Description = "Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.",
                            Director = "Jonathan Goldstein",
                            Distributor = "Taramount",
                            Duration = 134,
                            Name = "Dungeons & Dragons: Honor Among Thieves",
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("10e9309e-9cd3-47c1-9c7a-822368eee5f2"),
                            Country = "USA",
                            Description = "Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...",
                            Director = "Guillaume Canet",
                            Distributor = "Blitz Film Video doo",
                            Duration = 112,
                            Name = "Astérix & Obélix: L'Empire du Milieu",
                            Year = 2022
                        },
                        new
                        {
                            Id = new Guid("2e2329c2-5eb5-44ae-a7e8-deefea663509"),
                            Country = "USA",
                            Description = "Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.",
                            Director = "Marc Forster",
                            Distributor = "CON Film",
                            Duration = 126,
                            Name = "A Man Called Otto",
                            Year = 2022
                        },
                        new
                        {
                            Id = new Guid("b213e390-7515-4593-a8ff-4e4b39a4921d"),
                            Country = "France",
                            Description = "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u  siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.",
                            Director = "James Huth",
                            Distributor = "MegaCom Film",
                            Duration = 112,
                            Name = "Le nouveau jouet",
                            Year = 2022
                        });
                });

            modelBuilder.Entity("Cinema.Domain.AggregateModels.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
