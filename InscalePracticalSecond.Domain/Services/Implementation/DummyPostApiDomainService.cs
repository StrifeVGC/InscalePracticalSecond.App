﻿using InscalePracticalSecond.Domain.Models;
using InscalePracticalSecond.Domain.Services.Contract;

namespace InscalePracticalSecond.Domain.Services.Implementation
{
    public class DummyPostApiDomainService : IDummyPostApiDomainService
    {
        private IHttpClientFactory _httpClientFactory;
        public HttpClient _httpClient;

        public DummyPostApiDomainService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient("DummyApiClient");
        }

        public async Task<IEnumerable<Post>> GetAllPostsFromAPIAsync()
            => await HttpUtils<IEnumerable<Post>>.GetAsync($"posts", _httpClient);
    }
}
