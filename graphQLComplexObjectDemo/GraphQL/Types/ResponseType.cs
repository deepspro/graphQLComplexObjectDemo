using GraphQL.Types;
using graphQLComplexObjectDemo.Models;

namespace graphQLComplexObjectDemo.GraphQL.Types
{
    public class ResponseType : ObjectGraphType<Response>
    {
        public ResponseType()
        {
            Field(x => x.Books, type: typeof(ListGraphType<BookType>)).Description("Books type");
            Field<BookType>("book",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => context.Source.Books.Find(c => c.Id == context.GetArgument<int>("id")));
        }
    }
}
