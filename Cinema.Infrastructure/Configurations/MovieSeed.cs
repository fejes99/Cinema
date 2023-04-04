using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Configurations;

public class MovieSeed : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasData(
            Movie.Create(
                new MovieName("65"),
                MovieDirector.Create("Scott Beck"),
                MovieDuration.Create(93),
                new MovieDistributor("CON Film"),
                new MovieCountry("USA"),
        MovieYear.Create(2023),
                MovieDescription.Create("Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("Creed 3"),
                MovieDirector.Create("Michael B. Jordan"),
                MovieDuration.Create(116),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2022),
                MovieDescription.Create("Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("Indigo Kristal"),
                MovieDirector.Create("Luka Mihailović"),
                MovieDuration.Create(105),
                new MovieDistributor("Art Vista"),
                new MovieCountry("Serbia"),
                MovieYear.Create(2022),
                MovieDescription.Create("Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("Maybe I Do"),
                MovieDirector.Create("Michael Jacobs"),
                MovieDuration.Create(95),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                MovieDescription.Create("Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("Scream 6"),
                MovieDirector.Create("Matt Bettinelli-Olpin"),
                MovieDuration.Create(123),
                new MovieDistributor("Taramount"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                MovieDescription.Create("Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("John Wick: Chapter 4"),
                MovieDirector.Create("Chad Stahelski"),
                MovieDuration.Create(169),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                MovieDescription.Create("Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("Dungeons & Dragons: Honor Among Thieves"),
                MovieDirector.Create("Jonathan Goldstein"),
                MovieDuration.Create(134),
                new MovieDistributor("Taramount"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                MovieDescription.Create("Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("Astérix & Obélix: L'Empire du Milieu"),
                MovieDirector.Create("Guillaume Canet"),
                MovieDuration.Create(112),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2022),
                MovieDescription.Create("Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("A Man Called Otto"),
                MovieDirector.Create("Marc Forster"),
                MovieDuration.Create(126),
                new MovieDistributor("CON Film"),
                new MovieCountry("USA"),
                MovieYear.Create(2022),
                MovieDescription.Create("Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.")
                ));

        builder.HasData(
            Movie.Create(
                new MovieName("Le nouveau jouet"),
                MovieDirector.Create("James Huth"),
                MovieDuration.Create(112),
                new MovieDistributor("MegaCom Film"),
                new MovieCountry("France"),
                MovieYear.Create(2022),
                MovieDescription.Create("Zajedno  sa  svojom suprugom Alisom, Semi živi srećno u  siromašnom urbanom naselju među prijateljima i komšijama. Za rođendan svog sina, najbogatiji čovek Francuske otvorio je svoju robnu kuću, nudeći dečaku da izabere šta god poželi.")
                ));
    }
}
