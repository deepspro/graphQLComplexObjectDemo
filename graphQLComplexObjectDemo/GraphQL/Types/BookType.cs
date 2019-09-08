using GraphQL.Types;
using graphQLComplexObjectDemo.Models;

namespace graphQLComplexObjectDemo.GraphQL.Types
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of book");
            Field(x => x.Title).Description("Name of the book");
            Field(x => x.Description).Description("Description of the book");
            Field(x => x.Publisher).Description("Publisher of the book");
            Field(x => x.Category).Description("Category pf the book");
            Field(x => x.Authors, type: typeof(ListGraphType<AuthorType>)).Description("Details of auther");
        }
    }
}
