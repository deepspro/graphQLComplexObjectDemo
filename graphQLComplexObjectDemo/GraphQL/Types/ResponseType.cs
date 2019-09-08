using GraphQL.Types;
using graphQLComplexObjectDemo.Models;

namespace graphQLComplexObjectDemo.GraphQL.Types
{
    public class ResponseType : ObjectGraphType<Response>
    {
        public ResponseType()
        {
            Field(x => x.Books, type: typeof(ListGraphType<BookType>)).Description("Books type");
        }
    }
}
