using GraphQL.Types;
using graphQLComplexObjectDemo.GraphQL.Types;
using graphQLComplexObjectDemo.Interface;

namespace graphQLComplexObjectDemo.GraphQL.Queries
{
    public class ResponseQuery : ObjectGraphType
    {
        public ResponseQuery(IBooksRepo booksRepo)
        {
            Field<ResponseType>(
         "response",
          resolve: context => booksRepo.GetAll()
      );
        }
    }
}
