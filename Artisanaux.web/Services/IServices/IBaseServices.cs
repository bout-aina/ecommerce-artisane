using Artisanaux.web.Models;
using Artisanaux.Web.Models;

namespace Artisanaux.web.Services.IServices
{
    public interface IBaseServices : IDisposable
    {
        ResponseDto ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
