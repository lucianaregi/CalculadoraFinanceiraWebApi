using System.Threading.Tasks;

namespace TaxaJuros.API.Service
{
    public class TaxaJurosService
    {
        public Task<decimal> GetTaxaJuros() => Task.FromResult(0.01M);
    }
}
