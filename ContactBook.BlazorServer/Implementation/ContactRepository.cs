using Blazored.LocalStorage;
using ContactBook.BlazorServer.DTOs;
using ContactBook.BlazorServer.Services;

namespace ContactBook.BlazorServer.Implementation
{
    public class ContactRepository : BaseRepository<ContactDto>, IContactRepository
    {
        public ContactRepository(IHttpClientFactory httpClientFactory, ILocalStorageService storageService) : base(httpClientFactory, storageService)
        {
        }
    }
}
