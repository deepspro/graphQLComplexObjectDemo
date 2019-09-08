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
                        Categories = new string[] {"Programming Languages (Books)"},
                        Description = "This book is a comprehensive guide to the Java language, describing its syntax," +
                        " keywords and fundamental programming principles. "
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
                        Categories = new string[] {"Computer Science Books", "Computer Databases (Books)" },
                        Description = "Database Management Systems provides comprehensive and up-to-date" +
                        " coverage of the fundamentals of database systems. Coherent explanations and" +
                        " practical examples have made this one of the leading texts in the field."
                    }
                }
        };
        public Response GetAll()
        {
            return _response;
        }
    }
}
