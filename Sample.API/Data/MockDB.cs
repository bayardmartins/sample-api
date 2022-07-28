using Sample.API.Models;

namespace Sample.API.Data
{
    public class MockDB
    {
        public List<Movie> GetMovies()
        {
            return movies;
        }

        public List<User> GetUsers()
        {
            return users;
        }

        private static List<User> users = new List<User>()
        {
            new User { Login = "test@mock.com", Password = "123pass" },
            new User { Login = "test2@mock.com", Password = "456pass" },
        };

        private static List<Movie> movies = new List<Movie>() {
            new Movie {
                Id = 1,
                Title = "Beetlejuice",
                Year = "1988",
                Runtime = "92",
                },
            new Movie {
                  Id = 2,
                  Title = "The Cotton Club",
                  Year = "1984",
                  Runtime = "127",
                },
            new Movie {
                Id = 3,
                  Title = "The Shawshank Redemption",
                  Year = "1994",
                  Runtime = "142",
                },
            new Movie {
                Id = 4,
                  Title = "Crocodile Dundee",
                  Year = "1986",
                  Runtime = "97",
                },
            new Movie {
                Id = 5,
                  Title = "Valkyrie",
                  Year = "2008",
                  Runtime = "121",
                },
            new Movie {
                Id = 6,
                  Title = "Ratatouille",
                  Year = "2007",
                  Runtime = "111",
                },
            new Movie {
                Id = 7,
                  Title = "City of God",
                  Year = "2002",
                  Runtime = "130",
                },
            new Movie {
                Id = 8,
                  Title = "Memento",
                  Year = "2000",
                  Runtime = "113",
                },
            new Movie {
                Id = 9,
                  Title = "The Intouchables",
                  Year = "2011",
                  Runtime = "112",
                },
            new Movie {
                Id = 10,
                  Title = "Stardust",
                  Year = "2007",
                  Runtime = "127",
                },
            new Movie {
                Id = 11,
                  Title = "Apocalypto",
                  Year = "2006",
                  Runtime = "139",
                },
            new Movie {
                Id = 12,
                  Title = "Taxi Driver",
                  Year = "1976",
                  Runtime = "113",
                },
            new Movie {
                Id = 13,
                  Title = "No Country for Old Men",
                  Year = "2007",
                  Runtime = "122",
                },
            new Movie {
                Id = 14,
                  Title = "Planet 51",
                  Year = "2009",
                  Runtime = "91",
                },
            new Movie {
                Id = 15,
                  Title = "Looper",
                  Year = "2012",
                  Runtime = "119",
                },
            new Movie {
                Id = 16,
                  Title = "Corpse Bride",
                  Year = "2005",
                  Runtime = "77",
                },
            new Movie {
                Id = 17,
                  Title = "The Third Man",
                  Year = "1949",
                  Runtime = "93",
                },
            new Movie {
                Id = 18,
                  Title = "The Beach",
                  Year = "2000",
                  Runtime = "119",
                },
            new Movie {
                Id = 19,
                  Title = "Scarface",
                  Year = "1983",
                  Runtime = "170",
                },
            new Movie {
                Id = 20,
                  Title = "Sid and Nancy",
                  Year = "1986",
                  Runtime = "112",
                },
            new Movie {
                Id = 21,
                  Title = "Black Swan",
                  Year = "2010",
                  Runtime = "108",
                },
            new Movie {
                Id = 22,
                  Title = "Inception",
                  Year = "2010",
                  Runtime = "148",
                },
            new Movie {
                Id = 23,
                  Title = "The Deer Hunter",
                  Year = "1978",
                  Runtime = "183",
                },
            new Movie {
                Id = 24,
                  Title = "Chasing Amy",
                  Year = "1997",
                  Runtime = "113",
                },
            new Movie {
                Id = 25,
                  Title = "Django Unchained",
                  Year = "2012",
                  Runtime = "165",
                },
            new Movie {
                Id = 26,
                  Title = "The Silence of the Lambs",
                  Year = "1991",
                  Runtime = "118",
                },
            new Movie {
                Id = 27,
                  Title = "American Beauty",
                  Year = "1999",
                  Runtime = "122",
                },
            new Movie {
                Id = 28,
                  Title = "Snatch",
                  Year = "2000",
                  Runtime = "102",
                },
            new Movie {
                Id = 29,
                  Title = "Midnight Express",
                  Year = "1978",
                  Runtime = "121",
                },
            new Movie {
                Id = 30,
                  Title = "Pulp Fiction",
                  Year = "1994",
                  Runtime = "154",
                },
            new Movie {
              Id = 31,
              Title = "Lock, Stock and Two Smoking Barrels",
              Year = "1998",
              Runtime = "107",
                },
            new Movie {
              Id = 32,
              Title = "Lucky Number Slevin",
              Year = "2006",
              Runtime = "110",
             },
            new Movie {
              Id = 33,
              Title = "Rear Window",
              Year = "1954",
              Runtime = "112",
              },
            new Movie {
            Id = 34,
              Title = "Pan's Labyrinth",
              Year = "2006",
              Runtime = "118",
              },
            new Movie {
            Id = 35,
              Title = "Shutter Island",
              Year = "2010",
              Runtime = "138",
             },
            new Movie {
            Id = 36,
              Title = "Reservoir Dogs",
              Year = "1992",
              Runtime = "99",
              },
            new Movie {
            Id = 37,
              Title = "The Shining",
              Year = "1980",
              Runtime = "146",
            },
            new Movie {
            Id = 38,
              Title = "Midnight in Paris",
              Year = "2011",
              Runtime = "94",
            },
            new Movie {
            Id = 39,
              Title = "Les Misérables",
              Year = "2012",
              Runtime = "158",
             },
            new Movie {
            Id = 40,
              Title = "L.A. Confidential",
              Year = "1997",
              Runtime = "138",
            },
            new Movie {
            Id = 41,
              Title = "Moneyball",
              Year = "2011",
              Runtime = "133",
            },
            new Movie {
            Id = 42,
              Title = "The Hangover",
              Year = "2009",
              Runtime = "100",
            },
            new Movie {
            Id = 43,
              Title = "The Great Beauty",
              Year = "2013",
              Runtime = "141",
            },
            new Movie {
            Id = 44,
              Title = "Gran Torino",
              Year = "2008",
              Runtime = "116",
            },
            new Movie {
            Id = 45,
              Title = "Mary and Max",
              Year = "2009",
              Runtime = "92",
            },
            new Movie {
            Id = 46,
              Title = "Flight",
              Year = "2012",
              Runtime = "138",
            },
            new Movie {
            Id = 47,
              Title = "One Flew Over the Cuckoo's Nest",
              Year = "1975",
              Runtime = "133",
            },
            new Movie {
            Id = 48,
              Title = "Requiem for a Dream",
              Year = "2000",
              Runtime = "102",
            },
            new Movie {
            Id = 49,
              Title = "The Truman Show",
              Year = "1998",
              Runtime = "103",
            },
            new Movie {
            Id = 50,
              Title = "The Artist",
              Year = "2011",
              Runtime = "100",
            }
        };
    }
}
