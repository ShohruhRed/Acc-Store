using Acc.Web.Models;
using Acc.Web.Services.IServices;

namespace Acc.Web.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDto responseDto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            throw new NotImplementedException();
        }
    }
}
