using Demo.Application.Common.Interfaces;
using Demo.Infrastructure.Interface;
using Demo.Infrastructure.Shared;
using Demo.Infrastructure.VM;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class NewsController(INewsService newsService) : ControllerBase
    {
        private readonly INewsService _newsService = newsService;


        /// <summary>
        /// get a list of books
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get(int pageIndex = 0, int pageSize = 10)
            => Ok(await _newsService.Get(pageIndex, pageSize));
    }
}
