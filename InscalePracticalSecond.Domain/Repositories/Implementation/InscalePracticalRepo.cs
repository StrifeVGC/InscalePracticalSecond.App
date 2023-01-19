using InscalePracticalSecond.Domain.Context;
using InscalePracticalSecond.Domain.Models;
using InscalePracticalSecond.Domain.Repositories.Contract;

namespace InscalePracticalSecond.Domain.Repositories.Implementation
{
    public class InscalePracticalRepo : IInscalePracticalRepo
    {
        private readonly InscalePracticalContext _context;
        public InscalePracticalRepo(InscalePracticalContext context)
        {
            _context = context;
        }

        public async Task BulkInsertPostDataAsync(List<PostData> postData)
        {
            await _context.PostDatas.AddRangeAsync(postData);
            await _context.SaveChangesAsync();
        }
    }
}
