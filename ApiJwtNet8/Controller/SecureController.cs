using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
[ApiController]
[Route("api/secure")]
public class SecureController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Accesso con Identity + JWT riuscito 🚀");
    }



  [HttpGet("me")]
  public IActionResult Me()
   {
      return Ok(new
      {
        User.Identity?.Name,
        Claims = User.Claims.Select(c => new { c.Type, c.Value })
     });
   }

}

