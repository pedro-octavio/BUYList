using BUYList.Application.DTOs;

namespace BUYList.Application.Interfaces
{
    public interface ITokenApplicationService
    {
        string GenerateToken(UserDTO userDTO);
    }
}
