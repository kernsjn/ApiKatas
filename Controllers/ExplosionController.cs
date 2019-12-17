
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ApiKatas.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class ExplosionController : ControllerBase
  {

    [HttpGet]

    public ActionResult<string> GetExplosion(string s)
    {
      return string.Join("", s.Select(i => new String(i, int.Parse(i.ToString()))));
    }

  }
}