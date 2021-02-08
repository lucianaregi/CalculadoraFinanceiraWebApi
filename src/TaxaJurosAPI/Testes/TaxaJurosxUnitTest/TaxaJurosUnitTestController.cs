using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaxaJuros.API.Controllers;
using TaxaJuros.API.Service;
using Xunit;

namespace TaxaJurosxUnitTest
{
    public class TaxaJurosUnitTestController
    {
        private readonly TaxaJurosService taxaJurosService;

        [Fact]
        public void GetTaxaJurosWait()
        {
            GetTaxaJurosAsync().Wait();
        }

        [Fact]
        public async void TestFailedValue()
        {
            // arrange
            var juros = new TaxaJurosService();

            // act
            var data = await juros.GetTaxaJuros();

            Assert.Equal("0.01", data.ToString());
            
        }

        [Fact]
        public async void TestSuccessValue()
        {
            // arrange
            var juros = new TaxaJurosService();

            // act
            var data = await juros.GetTaxaJuros();

            Assert.Equal("0,01", data.ToString());

        }

        private async Task GetTaxaJurosAsync()
        {
            // arrange
            var controller = new TaxaJurosController(taxaJurosService);

            // act
            var data = await controller.Get();

            // assert
            Assert.NotNull(data);
        }

       

    }
}
