using Refit;
using System;

namespace ConsumoApi
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            try{
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");
                Console.WriteLine("Informe seu cep:");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine($"Consultando informações do CEP: {cepInformado}");

                var adress = await cepClient.GetAdressAsync(cepInformado);
                Console.Write($"\nLogradouro: {adress.Logradouro}\nComplemento: {adress.Complemento}\nBairro: {adress.Bairro}\nLocalidade: {adress.Localidade}\nUF: {adress.Uf}\nIbge: {adress.Ibge}\nGia: {adress.Gia}\nDDD: {adress.Ddd}\nSiafi: {adress.Siafi}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro na consulta do cep: {ex.Message}");
            }
        }
    }
}