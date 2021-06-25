using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviewAppAPI.DataLayer;
using MoviewAppAPI.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MoviewAppAPI.Controllers
{
    [EnableCors("AllowOrigin")]
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class MovieDataController : ControllerBase
    {
        [System.Web.Http.HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject (DataProvider.getMovieModels());
        }
    }
}
