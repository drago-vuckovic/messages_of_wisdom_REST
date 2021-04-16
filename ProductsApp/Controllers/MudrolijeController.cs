using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mudrolije.Models;

namespace Mudrolije.Controllers
{
    public class MudrolijeController : ApiController
    {
        //private mudrolija[] products = new mudrolija[]
        //{
        //    new mudrolija {MudrolijaId = 1, MudrolijaNaslov = "Tomato Soup", Smislenost = "Groceries", Stepen = 1},
        //    new mudrolija {MudrolijaId = 2, MudrolijaNaslov = "Yo-Yo", Smislenost = "Toys", Stepen = 3.75M},
        //    new mudrolija {MudrolijaId = 3, MudrolijaNaslov = "Hammer", Smislenost = "Hardware", Stepen = 16.99M}
        //};

        public Models.Mudrolije Get()
        {
            //var definisaneMudrolije = new Mudrolije();
            return new Models.Mudrolije()
            {
                new mudrolija
                {
                    MudrolijaId = 1,
                    MudrolijaNaslov = "Isaac Asimov",
                    Vrsta = "Isaac Asimov Vrsta",
                    Opis = "Ljudi koji misle da znaju sve, velika su gnjavaža za one od nas koji ne znamo baš sve",
                    Stepen = 350,
                    Period = "1919 - 1992",
                    Smislenost = "2",
                    Uticaj = 2,
                    Slika = "isaac_asimov",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 2,
                    MudrolijaNaslov = "Oliver Herford",
                    Vrsta = "Oliver Herford Vrsta",
                    Opis = "Ženin um je čišći nego čovjekov! Ona ga češće mijenja",
                    Stepen = 1863,
                    Period = "1919 - 1992",
                    Smislenost = "2",
                    Uticaj = 2,
                    Slika = "isaac_asimov",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 11,
                    MudrolijaNaslov = "Elbert Hubbard",
                    Vrsta = "Elbert Hubbard Vrsta",
                    Opis = "Nemojte uzeti život previše ozbiljno. Nikada ne ćete izaći iz njega živi",
                    Stepen = 6000,
                    Period = "1856 - 1915",
                    Smislenost = "Ogromna",
                    Uticaj = 14,
                    Slika = "elbert_hubbard",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 9,
                    MudrolijaNaslov = "Alice Roosevelt Longworth",
                    Vrsta = "Alice Roosevelt Longworth Vrsta",
                    Opis = "Ako nemate ništa lijepo za reći o bilo kome, dođi sjedi pored mene",
                    Stepen = 1000,
                    Period = "1884 - 1980",
                    Smislenost = "Minimalna",
                    Uticaj = 3,
                    Slika = "alice_roosevelt_longworth",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 3,
                    MudrolijaNaslov = "Margaret Mead",
                    Vrsta = "Margaret Mead Vrsta",
                    Opis = "Uvijek zapamtite da ste apsolutno jedinstveni. Baš kao i svi drugi",
                    Stepen = 350,
                    Period = "1919 - 1992",
                    Smislenost = "Prosječna",
                    Uticaj = 3,
                    Slika = "margaret_mead",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 4,
                    MudrolijaNaslov = "W. H. Auden",
                    Vrsta = "W. H. Auden Vrsta",
                    Opis = "Mi smo svi ovdje na Zemlji da pomognemo drugima; samo ne znam šta ostali rade na Zemlji",
                    Stepen = 150,
                    Period = "1907 - 1937",
                    Smislenost = "Minimalna",
                    Uticaj = 1,
                    Slika = "w_h_auden",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 5,
                    MudrolijaNaslov = "Mark Twain",
                    Vrsta = "Mark Twain Vrsta",
                    Opis = "Prikupite sve vaše činjenice, a zatim možete ih iskriviti kako god želite",
                    Stepen = 1500,
                    Period = "1803 - 1890",
                    Smislenost = "Ogromna",
                    Uticaj = 4,
                    Slika = "mark_twain",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 6,
                    MudrolijaNaslov = "Ron White",
                    Vrsta = "Ron White Vrsta",
                    Opis = "Vjerujem da, ako je život vam daje limun, napravite limunadu ... pokušajte naći nekoga kome je život dao votku, i zabavite se!",
                    Stepen = 1200,
                    Period = "1956 - ..",
                    Smislenost = "Promenljiva",
                    Uticaj = 0,
                    Slika = "ron_white",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 7,
                    MudrolijaNaslov = "Franklin P. Jones",
                    Vrsta = "Franklin P. Jones Vrsta",
                    Opis = "Jedna od prednosti kada govorite sami sa sobom jeste da znate da barem neko sluša",
                    Stepen = 550,
                    Period = "1774 - 1848",
                    Smislenost = "Minimalna",
                    Uticaj = 1,
                    Slika = "franklin_pierce_jones",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 8,
                    MudrolijaNaslov = "Douglas Adams",
                    Vrsta = "Douglas Adams Vrsta",
                    Opis = "Volim rokove. Volim njihov šumeći zvuk dok proleću pored nas ",
                    Stepen = 600,
                    Period = "1952 - 2001",
                    Smislenost = "Prosječna",
                    Uticaj = 2,
                    Slika = "douglas_adams",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 9,
                    MudrolijaNaslov = "Lana Turner",
                    Vrsta = "Lana Turner Vrsta",
                    Opis = "Uspješan muškarac je onaj koji zaradi više novca nego što njegova žena može potrošiti. Uspješna žena je ona koja  može naći takvog čovjeka",
                    Stepen = 500,
                    Period = "1921 - 1995",
                    Smislenost = "Prosječna",
                    Uticaj = 2,
                    Slika = "lana_turner",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 10,
                    MudrolijaNaslov = "Oscar Wilde",
                    Vrsta = "Oscar Wilde Vrsta",
                    Opis = "Ja mogu odoljeti svemu osim iskušenja",
                    Stepen = 400,
                    Period = "1854 - 1900",
                    Smislenost = "Minimalna",
                    Uticaj = 3,
                    Slika = "oscar_wilde",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 11,
                    MudrolijaNaslov = "Winston Churchill",
                    Vrsta = "Winston Churchill Vrsta",
                    Opis = "Ja mogu biti pijan, gospođice, ali ujutro ću biti trijezan, a ti će i dalje biti ružna.",
                    Stepen = 225,
                    Period = "1874 - 1965",
                    Smislenost = "Minimalna",
                    Uticaj = 1,
                    Slika = "winston_churchill",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 12,
                    MudrolijaNaslov = "Don Marquis",
                    Vrsta = "Winston Churchill Vrsta",
                    Opis = "Ja mogu biti pijan, gospođice, ali ujutro ću biti trijezan, a ti će i dalje biti ružna.",
                    Stepen = 225,
                    Period = "1878 - 1937",
                    Smislenost = "Ogromna",
                    Uticaj = 3,
                    Slika = "don_marquis",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 13,
                    MudrolijaNaslov = "Laurence J. Peter",
                    Vrsta = "Laurence J. Peter Vrsta",
                    Opis = "Ako dve nepravde ne učine pravdu, pokušajte s tri",
                    Stepen = 150,
                    Period = "1919 - 1990",
                    Smislenost = "Minimalna",
                    Uticaj = 1,
                    Slika = "laurence_j_peter",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 14,
                    MudrolijaNaslov = "Albert Einstein",
                    Vrsta = "Albert Einstein Vrsta",
                    Opis = "Kada se udvarate lijepoj djevojci, sat vremena izgleda kao sekund. Kada sjedite na užarenom pepelu, sekund izgleda kao sat. To je relativnost",
                    Stepen = 200,
                    Period = "1879 - 1955",
                    Smislenost = "Minimalna",
                    Uticaj = 1,
                    Slika = "albert_einstein",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 15,
                    MudrolijaNaslov = "Robin Williams",
                    Vrsta = "Robin Williams Vrsta",
                    Opis = "Žao mi je, kada bi bio u pravu, složio bih se s tobom",
                    Stepen = 800,
                    Period = "1951 - 2014",
                    Smislenost = "Ogromna",
                    Uticaj = 4,
                    Slika = "robin_williams",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 16,
                    MudrolijaNaslov = "Henry A. Kissinger",
                    Vrsta = "Henry A. Kissinger Vrsta",
                    Opis = "Kriza ne može biti kriza sljedeće sedmice. Moj raspored je već popunjen",
                    Stepen = 1000,
                    Period = "1923 - ..",
                    Smislenost = "Minimalna",
                    Uticaj = 3,
                    Slika = "henry_kissinger",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 17,
                    MudrolijaNaslov = "Mark Twain",
                    Vrsta = "Mark Twain Vrsta",
                    Opis = "Idi na nebo ako želiš ljepšu klimu, a u pakao za bolje društvo",
                    Stepen = 200,
                    Period = "1803 - 1890",
                    Smislenost = "Minimalna",
                    Uticaj = 1,
                    Slika = "mark_twain",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 18,
                    MudrolijaNaslov = "George Jean Nathan",
                    Vrsta = "George Jean Nathan Vrsta",
                    Opis = "Optimista je čovjek koji vjeruje da kućna muva traži izlaz napolje",
                    Stepen = 2500,
                    Period = "1882 - 1958",
                    Smislenost = "Prosječna",
                    Uticaj = 6,
                    Slika = "george_jean_nathan",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 19,
                    MudrolijaNaslov = "Paul Engle",
                    Vrsta = "Paul Engle Vrsta",
                    Opis = "Mudrost je znati kada ne možete biti mudri",
                    Stepen = 800,
                    Period = "1908 - 1991",
                    Smislenost = "Ogromna",
                    Uticaj = 3,
                    Slika = "touch_of_god",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 20,
                    MudrolijaNaslov = "Rudyard Kipling",
                    Vrsta = "Rudyard Kipling Vrsta",
                    Opis = "Čini se kao mudrost, ali da li je umjetnost?",
                    Stepen = 75,
                    Period = "1865 - 1936",
                    Smislenost = "Minimalna",
                    Uticaj = 1,
                    Slika = "touch_of_god",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 21,
                    MudrolijaNaslov = "Paul Dirac",
                    Vrsta = "Paul Dirac Vrsta",
                    Opis = "U nauci, ljudima se nastoji pojasniti nepoznat pojam na takav na čin da bude razumljiv svima. Ali u poeziji, to je potpuno suprotno",
                    Stepen = 350,
                    Period = "1902 - 1984",
                    Smislenost = "Minimalna",
                    Uticaj = 3,
                    Slika = "touch_of_god",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 22,
                    MudrolijaNaslov = "Mahatma Gandhi",
                    Vrsta = "Mahatma Gandhi Vrsta",
                    Opis = "Svake noći kada zaspim,umrem. Sljedećeg jutra, kada se probudim, rodim se ponovo",
                    Stepen = 900,
                    Period = "1869 - 1948",
                    Smislenost = "Minimalna",
                    Uticaj = 2,
                    Slika = "touch_of_god",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 23,
                    MudrolijaNaslov = "Amy Tan",
                    Vrsta = "Amy Tan Vrsta",
                    Opis = "Na prvom koraku je prilika, dok sreća dolazi poslije toga",
                    Stepen = 250,
                    Period = "1952 - ..",
                    Smislenost = "Ogromna",
                    Uticaj = 2,
                    Slika = "touch_of_god",
                    Link = "http://www.vuckovic.co"
                },
                new mudrolija
                {
                    MudrolijaId = 24,
                    MudrolijaNaslov = "Neil Armstrong",
                    Vrsta = "Neil Armstrong Vrsta",
                    Opis = "Vjerujem da svako ima beskonačan broj otkucaja srca. Ne namjeravam da protraćim niti jedan",
                    Stepen = 650,
                    Period = "1930 - 2012",
                    Smislenost = "Ogromna",
                    Uticaj = 4,
                    Slika = "touch_of_god",
                    Link = "http://www.vuckovic.co"
                }

            };
        }

        //public IEnumerable<mudrolija> GetAllProducts()
        //{
        //    return products;
        //}

        //public IHttpActionResult GetProduct(int id)
        //{
        //    var product = products.FirstOrDefault((p) => p.MudrolijaId == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}

        //public Mudrolije GetMudrolije()
        //{
        //    var mdr = new Mudrolije();

        //    new mudrolija
        //    {
        //        MudrolijaId = 1,
        //        MudrolijaNaslov = "Isaac Asimov",
        //        Vrsta = "Isaac Asimov Vrsta",
        //        Opis = "Ljudi koji misle da znaju sve, velika su gnjavaža za one od nas koji ne znamo baš sve",
        //        Stepen = 350,
        //        Period = "1919 - 1992",
        //        Smislenost = "2",
        //        Uticaj = 2,
        //        Slika = "isaac_asimov",
        //        Link = "http://www.vuckovic.co"
        //    };

        //    return mdr;
        //}
    }
}
