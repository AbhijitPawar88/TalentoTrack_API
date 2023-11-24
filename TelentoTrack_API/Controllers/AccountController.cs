using Microsoft.AspNetCore.Mvc;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Services;

namespace TelentoTrack_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {
       

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;

        public AccountController(ILogger<AccountController> logger ,IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpPost(Name = "Login")]
        public async Task<LoginResponse > Login([FromBody]LoginRequest request)
        {
            var response= await _accountService.VerifyLoginDetails(request);
           // var response=new LoginResponse();
           
           return response;
        }
    }
}