using CalculaJuros.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJuros.API.Controllers
{
    [Route("api/showmethecode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly ShowMeTheCodeService _showMeTheCodeService;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="showMeTheCodeService"></param>
        public ShowMeTheCodeController(ShowMeTheCodeService showMeTheCodeService) => _showMeTheCodeService = showMeTheCodeService;

        /// <summary>
        /// Retorna a URL do github do sistema de api
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> GetUrlGit()
        {
            return _showMeTheCodeService.GetUrlGitHub();
        }
    }
}
