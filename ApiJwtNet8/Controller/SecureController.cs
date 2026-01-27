using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/secure")] // forziamo il controller name minuscolo
public class SecureController : ControllerBase
{
    [Authorize]
    [HttpGet("secure")] // /api/secure/secure
    public IActionResult GetSecure()
    {
        return Ok(new { message = "Accesso autorizzato!" });
    }

    [HttpGet("public")]
    public IActionResult GetPublic()
    {
        return Ok(new { message = "Endpoint pubblico" });
    }

    [AllowAnonymous]
[HttpGet("ping")]
public IActionResult Ping()
{
    return Ok("pong");
}
}
