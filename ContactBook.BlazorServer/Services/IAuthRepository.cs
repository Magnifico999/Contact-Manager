using ContactBook.BlazorServer.DTOs;

namespace ContactBook.BlazorServer.Services
{
    public interface IAuthRepository
    {
        public Task<bool> Register(UserDTO dto);
        public Task<bool> Login(LoginDto dto);
        public Task Logout();

    }
}
