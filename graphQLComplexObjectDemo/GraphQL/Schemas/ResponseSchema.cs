using GraphQL;
using GraphQL.Types;
using graphQLComplexObjectDemo.GraphQL.Queries;

namespace graphQLComplexObjectDemo.GraphQL.Schemas
{
    public class ResponseSchema : Schema
    {
        public ResponseSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ResponseQuery>();
        }
    }
}
