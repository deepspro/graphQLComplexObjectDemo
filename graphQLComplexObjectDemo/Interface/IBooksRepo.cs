using graphQLComplexObjectDemo.Models;

namespace graphQLComplexObjectDemo.Interface
{
    public interface IBooksRepo
    {
        Response GetAll();
        Book GetBookById(int id);
    }
}
