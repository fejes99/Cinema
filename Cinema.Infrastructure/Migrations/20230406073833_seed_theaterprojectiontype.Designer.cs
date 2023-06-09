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
    [Migration("20230406073833_seed_theaterprojectiontype")]
    partial class seed_theaterprojectiontype
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
                            Id = new Guid("7f61e3ab-bc7a-498a-bdef-5b1c841e3040"),
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
                            Id = new Guid("b25af7bc-a370-4103-9527-2ba9f1600f28"),
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
                            Id = new Guid("7ac355da-f2ac-49b5-86e2-add2b01fe094"),
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
                            Id = new Guid("b6c12067-834e-42c8-a75c-fc9d77eb867d"),
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
                            Id = new Guid("135789f9-ddab-4ec4-b512-099dc79f54ec"),
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
                            Id = new Guid("ddf521b2-55da-4dad-82a8-9bd43136f0cc"),
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
                            Id = new Guid("4bf91c57-1a63-4b20-9522-58183fc6dec0"),
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
                            Id = new Guid("298f34ea-87bb-40dc-bc8b-dbc72eccfd7f"),
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
                            Id = new Guid("ac035726-76db-429e-9a89-7073f188ff79"),
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
                            Id = new Guid("c6cf9c38-9aa3-42d6-b6a8-7da3b0864fe1"),
                            Country = "France",
                            Description = "Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.",
                            Director = "James Huth",
                            Distributor = "MegaCom Film",
                            Duration = 112,
                            Name = "Le nouveau jouet",
                            Year = 2022
                        });
                });

            modelBuilder.Entity("Cinema.Domain.AggregateModels.Theaters.ProjectionType", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProjectionTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106"),
                            Name = "2D"
                        },
                        new
                        {
                            Id = new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2"),
                            Name = "3D"
                        },
                        new
                        {
                            Id = new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6"),
                            Name = "4D"
                        });
                });

            modelBuilder.Entity("Cinema.Domain.AggregateModels.Theaters.Theater", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Theaters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"),
                            Name = "Sala 1"
                        },
                        new
                        {
                            Id = new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"),
                            Name = "Sala 2"
                        },
                        new
                        {
                            Id = new Guid("a322aedb-053b-4507-895e-150390686b12"),
                            Name = "Sala 3"
                        },
                        new
                        {
                            Id = new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"),
                            Name = "Sala 4"
                        },
                        new
                        {
                            Id = new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb"),
                            Name = "Sala 5"
                        },
                        new
                        {
                            Id = new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1"),
                            Name = "Sala 6"
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

            modelBuilder.Entity("TheaterProjectionType", b =>
                {
                    b.Property<Guid>("TheaterId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProjectionTypeId")
                        .HasColumnType("TEXT");

                    b.HasKey("TheaterId", "ProjectionTypeId");

                    b.HasIndex("ProjectionTypeId");

                    b.ToTable("TheaterProjectionType");

                    b.HasData(
                        new
                        {
                            TheaterId = new Guid("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3"),
                            ProjectionTypeId = new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106")
                        },
                        new
                        {
                            TheaterId = new Guid("52900eaf-4ba1-40a1-aaa9-c564e532afa8"),
                            ProjectionTypeId = new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106")
                        },
                        new
                        {
                            TheaterId = new Guid("a322aedb-053b-4507-895e-150390686b12"),
                            ProjectionTypeId = new Guid("e77354fc-8661-4a2c-80d1-d8e0557d4106")
                        },
                        new
                        {
                            TheaterId = new Guid("a322aedb-053b-4507-895e-150390686b12"),
                            ProjectionTypeId = new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2")
                        },
                        new
                        {
                            TheaterId = new Guid("7f251baa-0f7f-4fb4-ba9b-e807553b1335"),
                            ProjectionTypeId = new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2")
                        },
                        new
                        {
                            TheaterId = new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb"),
                            ProjectionTypeId = new Guid("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2")
                        },
                        new
                        {
                            TheaterId = new Guid("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb"),
                            ProjectionTypeId = new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6")
                        },
                        new
                        {
                            TheaterId = new Guid("d77c00d9-8913-4bad-83f9-5d9a054c81d1"),
                            ProjectionTypeId = new Guid("dfb97424-2128-4cba-854e-5ef051d2e2e6")
                        });
                });

            modelBuilder.Entity("TheaterProjectionType", b =>
                {
                    b.HasOne("Cinema.Domain.AggregateModels.Theaters.ProjectionType", null)
                        .WithMany()
                        .HasForeignKey("ProjectionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinema.Domain.AggregateModels.Theaters.Theater", null)
                        .WithMany()
                        .HasForeignKey("TheaterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
