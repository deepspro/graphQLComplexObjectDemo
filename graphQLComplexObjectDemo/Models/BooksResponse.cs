using System.Collections.Generic;

namespace graphQLComplexObjectDemo.Models
{
    public class Response
    {
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public List<Author> Authors { get; set; }
        public string[] Categories { get; set; }
    }

    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
