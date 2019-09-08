using graphQLComplexObjectDemo.Interface;
using graphQLComplexObjectDemo.Models;
using System.Collections.Generic;

namespace graphQLComplexObjectDemo.Repositories
{
    public class BooksRepo : IBooksRepo
    {
        private static readonly Response _response = new Response()
        {
            Books = new List<Book>()
                {
                    new Book()
                    {
                        Id = 1,
                        Title = "Java - The Complete Reference",
                        Publisher = "McGraw Hill Education",
                        Authors = new List<Author>()
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
                        Authors = new List<Author>()
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
        public Response GetAll()
        {
            return _response;
        }
    }
}
