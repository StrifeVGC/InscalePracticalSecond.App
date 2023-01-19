using InscalePracticalSecond.Domain.Models;

namespace InscalePracticalSecond.Domain.Services.Contract
{
    public interface IDummyUserApiDomainService
    {
        Task<UserAPIObject> GetUserById(int userId);
    }
}