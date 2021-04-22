using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IsItMyBirthday.Controllers
{
    [ApiController]
    [Route("check-birthday")]
    public class BirthdayController : ControllerBase
    {
        private readonly ILogger<BirthdayController> _logger;

        public BirthdayController(ILogger<BirthdayController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{myBirthday}")]
        public ActionResult Get(DateTime myBirthday) => Ok(BirthdayChecker.IsItMyBirthday(myBirthday));
    }
}
