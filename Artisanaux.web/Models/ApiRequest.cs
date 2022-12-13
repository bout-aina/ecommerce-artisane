using static Artisanaux.web.SD;

namespace Artisanaux.web.Models
{
    public class ApiRequest
    {
        public ApiType apiType { get; set; } = ApiType.GET;
        public string url { get; set; }


        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
