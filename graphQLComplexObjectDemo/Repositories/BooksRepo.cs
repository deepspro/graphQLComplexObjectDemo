using graphQLComplexObjectDemo.Interface;
using graphQLComplexObjectDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphQLComplexObjectDemo.Repositories
{
    public class BooksRepo : IBooksRepo
    {
        private static readonly Response _response = new Response()
        {
           Books =
            {
                new Book()
                {
                    Id = 1,
                    Title = "Java - The Complete Reference",
                    Publisher = "McGraw Hill Education",
                    Authors = 
                    {
                        new Author()
                        {
                            FirstName = "Herbert",
                            LastName = "Schildt"
                        }
                    },
                    Category = "Programming Languages (Books)"
                },
                 new Book()
                {
                    Id = 2,
                    Title = "Database Management Systems",
                    Publisher = "McGraw-Hili",
                    Authors =
                    {
                        new Author()
                        {
                            FirstName = "Raghu",
                            LastName = "Ramakrishnan"
                        },
                        new Author()
                        {
                            FirstName = "Johannes",
                            LastName = "Gehrke"
                        }
                    },
                    Category = "Computer Science Books"
                }
            }
        };

        public Response GetAll() => _response;
    }
}
