using ContactBook.BlazorServer.DTOs;

namespace ContactBook.BlazorServer.Services
{
    public interface IContactRepository : IBaseRepository<ContactDto>
    {
    }
}
