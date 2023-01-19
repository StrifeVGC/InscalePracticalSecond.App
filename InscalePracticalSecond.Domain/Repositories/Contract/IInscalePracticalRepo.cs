using InscalePracticalSecond.Domain.Models;

namespace InscalePracticalSecond.Domain.Repositories.Contract
{
    public interface IInscalePracticalRepo
    {
        Task BulkInsertPostDataAsync(List<PostData> postData);
    }
}