using Task10.Entities;
using Task10.Models;

namespace Task10.Services;

public interface IUserService
{
    public Task AddUserAsync(LoginDto loginDto);
    public Task<TokenDto> LoginUserAsync(LoginDto loginDto);
    public Task<TokenDto> UpdateTokensAysnc(RefreshTokenDto refreshTokenDto);
}