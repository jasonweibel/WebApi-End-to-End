using System;
using HeroVillainTour.Core;
using Microsoft.AspNetCore.Mvc;

namespace HeroVillainTour.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillainController : ControllerBase
    {
        private readonly IVillainService _villainService;

        public VillainController(IVillainService service)
        {
            _villainService = service;
        }

        [HttpGet]

        public IActionResult GetVillains()
        {
            try
            {
                return Ok(_villainService.GetVillains());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{name}")]

        public IActionResult GetVillains(string name)
        {
            try
            {
                return Ok(_villainService.GetVillains(name));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}