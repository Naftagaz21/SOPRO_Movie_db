using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                
                //Actors
                if (!context.People.Any())
                {
                    context.People.AddRange(new List<Person>()
                    {
                        new Person()
                        {
                            FullName = "Johny Depp",
                            
                        },
                        new Person()
                        {
                            FullName = "Michael Wayne",
                        },
                        new Person()
                        {
                            FullName = "Bruce Willis",

                        },
                        new Person()
                        {
                            FullName = "Mila Kunis",

                        },
                        new Person()
                        {
                            FullName = "Johny Jovovich",

                        },
                        new Person()
                        {
                            FullName = "Mila Jovovich",

                        },
                        new Person()
                        {
                            FullName = "Siena Depp",

                        },
                        new Person()
                        {
                            FullName = "John Wayne",

                        }

                    });
                    context.SaveChanges();
                }

    
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Taxi Driver",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BM2M1MmVhNDgtNmI0YS00ZDNmLTkyNjctNTJiYTQ2N2NmYzc2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                           //enreIds = new List<int> {2}
                        },
                        new Movie()
                        {
                            Name = "Akira",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BM2ZiZTk1ODgtMTZkNS00NTYxLWIxZTUtNWExZGYwZTRjODViXkEyXkFqcGdeQXVyMTE2MzA3MDM@._V1_FMjpg_UX1000_.jpg",
                            //GenreIds = new List<int> {3}
                        },
                        new Movie()
                        {
                            Name = "12 Angry Men",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/12_Angry_Men_%281957_film_poster%29.jpg/800px-12_Angry_Men_%281957_film_poster%29.jpg",
                            //GenreIds = new List<int> {1}
                        },
                        new Movie()
                        {
                            Name = "Léon: The Professional",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BODllNWE0MmEtYjUwZi00ZjY3LThmNmQtZjZlMjI2YTZjYmQ0XkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_FMjpg_UX1000_.jpg",
                            //Genres = new List<Genre> { },
                        },
                        new Movie()
                        {
                            Name = "Goodfellas",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                            //Genres = new List<Genre> { },
                        },
                        new Movie()
                        {
                            Name = "The Matrix",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_FMjpg_UX1000_.jpg",
                            //Genres = new List<Genre> { },
                        },
                        new Movie()
                        {
                            Name = "Casablanca",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/b/b3/CasablancaPoster-Gold.jpg",
                            //Genres = new List<Genre> { },
                           // Genres.Add(new Genre )
                        }
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}