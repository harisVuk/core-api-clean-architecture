using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    [Authorize]
    [Route("/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
    }
}
