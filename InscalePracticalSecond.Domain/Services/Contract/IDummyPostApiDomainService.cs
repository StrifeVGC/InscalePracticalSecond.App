using InscalePracticalSecond.Domain.Models;

namespace InscalePracticalSecond.Domain.Services.Contract
{
    public interface IDummyPostApiDomainService
    {
        Task<IEnumerable<Post>> GetAllPostsFromAPIAsync();
    }
}