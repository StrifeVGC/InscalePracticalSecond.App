using InscalePracticalSecond.Domain.Models;
using InscalePracticalSecond.Domain.Repositories.Contract;
using InscalePracticalSecond.Domain.Services.Contract;

namespace InscalePracticalSecond.Infrastructure.Services.Implementation
{
    public class DummyApiService
    {
        private readonly IInscalePracticalRepo _inscalePracticalRepo;
        private readonly IDummyPostApiDomainService _dummyPostApiDomainService;
        private readonly IDummyUserApiDomainService _dummyUserDomainService;

        public DummyApiService(IInscalePracticalRepo inscalePracticalRepo, IDummyPostApiDomainService dummyPostApiDomainService, IDummyUserApiDomainService dummyPostUserDomainService)
        {
            _inscalePracticalRepo = inscalePracticalRepo;
            _dummyPostApiDomainService = dummyPostApiDomainService;
            _dummyUserDomainService = dummyPostUserDomainService;
        }

        public async Task GetAndProcessPostDataFromPosts()
        {
            var posts = await _dummyPostApiDomainService.GetAllPostsFromAPIAsync();

            List<PostData> postData = new List<PostData>();

            foreach (Post p in posts)
            {
                postData.Add(new PostData
                {
                    PostId = p.Id,
                    UserName = (await _dummyUserDomainService.GetUserById(p.UserId)).Username,
                    HasFrenchTag = p.Tags.Contains("french"),
                    HasFictionTag = p.Tags.Contains("fiction"),
                    HasMoreThanTwoReactions = p.Reactions > 2
                });
            }

            await _inscalePracticalRepo.BulkInsertPostDataAsync(postData);
        }
    }
}
