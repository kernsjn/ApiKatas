
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ApiKatas.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class MumblingController : ControllerBase
  {

    [HttpGet]

    public ActionResult<string> GetMumble(string s)
    {
      return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }

  }
}