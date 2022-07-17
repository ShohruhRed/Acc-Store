using Acc.Web.Models;

namespace Acc.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseDto { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest)
    }
}
