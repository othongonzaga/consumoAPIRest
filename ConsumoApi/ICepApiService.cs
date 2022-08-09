using Refit;
using System;
using System.Threading.Tasks;

namespace ConsumoApi
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAdressAsync(string cep);
    }
}
