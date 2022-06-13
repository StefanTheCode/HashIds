using HashIds.Models;

namespace HashIds.Services
{
    public interface IUserService
    {
        ReturnUser GetUser(int id);
    }
}