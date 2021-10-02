using Microsoft.AspNetCore.Http;

namespace SportStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request, string anchor = "")
            => request.QueryString.HasValue ? $"{request.Path}{request.QueryString}{anchor}" : request.Path.ToString();
    }
}