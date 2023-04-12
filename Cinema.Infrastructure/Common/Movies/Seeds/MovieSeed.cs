using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Infrastructure.Common.Movies.Seeds;

internal class MovieSeed : IEntityTypeConfiguration<Movie>
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
                new MovieTrailerUrl("https://www.youtube.com/watch?v=bHXejJq5vr0&t=2s&ab_channel=SonyPicturesEntertainment"),
                MovieDescription.Create("Nakon katastrofalne nesreće na nepoznatoj planeti, pilot Mils (Adam Drajver) ubrzo otkriva da je zapravo bio nasukan na planetu Zemlju… pre 65 miliona godina.")
                ),
            Movie.Create(
                new MovieName("Creed 3"),
                MovieDirector.Create("Michael B. Jordan"),
                MovieDuration.Create(116),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2022),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=lvuR_Ny882g&ab_channel=BlitzFilmSrbija"),
                MovieDescription.Create("Nakon što je dominirao bokserskim svetom, Adonis Krid je napredovao u karijeri i porodičnom životu. Kada je prijatelj iz detinjstva i bivši boksersko čudo.")
                ),
            Movie.Create(
                new MovieName("Indigo Kristal"),
                MovieDirector.Create("Luka Mihailović"),
                MovieDuration.Create(105),
                new MovieDistributor("Art Vista"),
                new MovieCountry("Serbia"),
                MovieYear.Create(2022),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=8hULM38r66E&ab_channel=ArtVista"),
                MovieDescription.Create("Priča je smeštena u četiri dana i prati Vuka, tridesetogodišnjeg povratnika iz zatvora koji, gonjen samoubistvom najboljeg druga, pokušava da spase njegovog mlađeg brata na veče godišnjice samoubistva.")
                ),
            Movie.Create(
                new MovieName("Maybe I Do"),
                MovieDirector.Create("Michael Jacobs"),
                MovieDuration.Create(95),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=MU9wJyel8VU&ab_channel=BlitzFilmSrbija"),
                MovieDescription.Create("Mišel i Alen su u vezi. Odlučuju da pozovu svoje roditelje da se konačno sretnu kako bi se upoznali pre braka. Ispostavilo se da se roditelji već dobro poznaju, što dovodi do različitih mišljenja o braku.")
                ),
            Movie.Create(
                new MovieName("Scream 6"),
                MovieDirector.Create("Matt Bettinelli-Olpin"),
                MovieDuration.Create(123),
                new MovieDistributor("Taramount"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=h74AXqw4Opc&ab_channel=ParamountPictures"),
                MovieDescription.Create("Nakon poslednjih ubistava koje je počinio Goustfejs, četvoro preživelih napuštaju Vudsboro i započinju novo poglavlje. U filmu VRISAK 6 Melisa Berera („Sem Karpenter“), Jasmin Savoj Braun („Mindi Miks-Martin“), Mejson Guding („Čed Miks-Martin), Džena Ortega („Tara Karpenter“), Hajden Panetir („Kirbi Rid“) i Kortni Koks („Gejl Veders“) vraćaju se svojim ulogama u ovoj franšizi, zajedno sa Džekom Čempionom, Henrijem Černijem, Lijanom Liberato, Dermotom Malronijem, Devinom Nekodom, Tonijem Revolorijem, Džošom Segarom i Samarom Viving.")
                ),
            Movie.Create(
                new MovieName("John Wick: Chapter 4"),
                MovieDirector.Create("Chad Stahelski"),
                MovieDuration.Create(169),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=80zGq9ABI7k&ab_channel=BlitzFilmSrbija"),
                MovieDescription.Create("Radnja novog filma odvija se širom sveta i donosi akciju posebne vrste. Džon Vik se suočava sa svojim najsmrtonosnijim protivnicima dosad u nadolazećem četvrtom nastavku serijala.")
                ),
            Movie.Create(
                new MovieName("Dungeons & Dragons: Honor Among Thieves"),
                MovieDirector.Create("Jonathan Goldstein"),
                MovieDuration.Create(134),
                new MovieDistributor("Taramount"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=IiMinixSXII&t=11s&ab_channel=ParamountPictures"),
                MovieDescription.Create("Šarmantni lopov i grupa nesvakidašnjih avanturista upustili su se u epsku pljačku kako bi vratili izgubljenu relikviju. Međutim, kada se sukobe sa pogrešnim ljudima, stvari kreću po zlu.")
                ),
            Movie.Create(
                new MovieName("Astérix & Obélix: L'Empire du Milieu"),
                MovieDirector.Create("Guillaume Canet"),
                MovieDuration.Create(112),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2022),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=E1-qmncJ5zw&ab_channel=BlitzFilmSrbija"),
                MovieDescription.Create("Godina je 50. pne. Kineska carica je upravo zatvorena nakon državnog udara koji je podstaknuo Deng Tsin Kin, izdajnički princ. Uz pomoć Finaltesisa, feničanskog trgovca i njenog vernog telohranitelja Mai Vei, jedina ćerka carice, princeza Sas-Ji beži u Galiju da zatraži pomoć od dva hrabra ratnika Asteriksa i Obeliksa, koji su obdareni nadljudskom snagom zahvaljujući svom magičnom napitku. Naša dva nerazdvojna heroja rado prihvataju da pomognu princezi da spase svoju majku i oslobodi svoju zemlju. I tako počinje veliko putovanje i avantura na putu za Kinu. Ali Cezar i njegova moćna vojska, žedni novog osvajanja, takođe idu ka Srednjem kraljevstvu...")
                ),
            Movie.Create(
                new MovieName("A Man Called Otto"),
                MovieDirector.Create("Marc Forster"),
                MovieDuration.Create(126),
                new MovieDistributor("CON Film"),
                new MovieCountry("USA"),
                MovieYear.Create(2022),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=eFYUX9l-m5I&ab_channel=SonyPicturesEntertainment"),
                MovieDescription.Create("Zasnovan na komičnom i pokretačkom bestseleru Njujork Tajmsa, film Čovek zvani Oto govori o Otou Andersonu (Tom Henks), mrzovoljnom udovcu kome radost donosi jedino kritikovanje i osuđivanje svojih ogorčenih komšija.")
                ),
            Movie.Create(
                new MovieName("Air"),
                MovieDirector.Create("Ben Affleck"),
                MovieDuration.Create(112),
                new MovieDistributor("Blitz Film Video doo"),
                new MovieCountry("USA"),
                MovieYear.Create(2023),
                new MovieTrailerUrl("https://www.youtube.com/watch?v=QIo12F3Uk0s&ab_channel=BlitzFilmSrbija"),
                MovieDescription.Create("Oskarovska ekipa filma, predvođena Ben Aflekom i Met Dejmonom, u filmu o jednom od najuticajnijih sportskih brendova svih vremena. Priča o legendarnoj patici koja je oduševila Džordana i \"spasila\" Najk! Film nas vraća u period osamdesetih godina, a Met Dejmon tumači lik Sonija Vakare, zaslužnog za potpisivanje ugovora s tada mladom košarkaškom zvezdom Majkl Džordanom. Ben Aflek je u ulozi suosnivača Najka, legendarnog Fila Najta, Džejson Bejtman  je u ulozi Roba Strasera – njegovog direktora marketinga, dok je Vajola Dejvis u ulozi beskompromisne majke koja zna vrednost neizmernog talenta svog sina i košarkaškog fenomena koji će postati najveća sportska legenda svih vremena. U filmu pratimo Vakarovo nastojanje da stekne poverenje Džordanove porodice, trenera i najbližih saradnika s namerom da uveri tada veoma mladu NBA zvezdu u usponu da potpiše partnerski ugovor. Ugovor koji je Najku osigurao poziciju najvećeg brenda sportske odeće i obuće danas.")
                ));
    }
}
