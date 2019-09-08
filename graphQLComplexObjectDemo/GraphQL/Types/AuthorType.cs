using GraphQL.Types;
using graphQLComplexObjectDemo.Models;

namespace graphQLComplexObjectDemo.GraphQL.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(x => x.FirstName).Description("First name of Author");
            Field(x => x.LastName).Description("Last name of Author");
        }
    }
}
