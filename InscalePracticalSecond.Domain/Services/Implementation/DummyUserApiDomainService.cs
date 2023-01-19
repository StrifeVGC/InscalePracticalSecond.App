using InscalePracticalSecond.Domain.Models;
using InscalePracticalSecond.Domain.Services.Contract;

namespace InscalePracticalSecond.Domain.Services.Implementation
{
    public class DummyUserApiDomainService : IDummyUserApiDomainService
    {
        private IHttpClientFactory _httpClientFactory;
        public HttpClient _httpClient;

        public DummyUserApiDomainService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient("DummyApiClient");
        }

        public async Task<UserAPIObject> GetUserById(int userId)
            => await HttpUtils<UserAPIObject>.GetAsync($"users/{userId}", _httpClient);

    }
}
