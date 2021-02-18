using CalculaJuros.API.Controllers;
using CalculaJuros.API.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJurosxUnitTest
{
    public class CalculaJurosUnitTestController
    {
        private readonly CalculaJurosService calculaJurosService;

        
        [Fact]
        public void GetCalculaJurosOk()
        {

            GetCalculoJurosAsyncOk().Wait();
        }

        [Fact]
        public void GetCalculaJurosFailed()
        {

            GetCalculoJurosAsyncFailed().Wait();
        }

        private async Task GetCalculoJurosAsyncOk()
        {
            // arrange
            var service = new CalculaJurosService();

            // act
            var data = await service.CalcularJurosAsync(100,5);


            // assert
            Assert.Equal("105,10", data.ToString());
        }

        private async Task GetCalculoJurosAsyncFailed()
        {
            // arrange
            var service = new CalculaJurosService();

            // act
            var data = await service.CalcularJurosAsync(102, 3);


            // assert
            Assert.Equal("105,10", data.ToString());
        }
    }
}
