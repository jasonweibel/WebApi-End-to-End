using System;
using HeroVillainTour.ApiModels;
using HeroVillainTour.Core;
using Microsoft.AspNetCore.Mvc;

namespace HeroVillainTour.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;

        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet]
        public IActionResult GetHero()
        {
            try
            {
                
                return Ok(_heroService.GetHeros());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{name}")]
        public IActionResult GetHero(string name)
        {
            try
            {
                return Ok(_heroService.GetHeros(name));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] HeroApiModel hero)
        {
            try
            {
                _heroService.AddHero(hero);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}