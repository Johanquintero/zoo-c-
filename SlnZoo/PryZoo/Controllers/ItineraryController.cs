using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class IntineraryController : Controller
    {
        public IntineraryController() { }

        [HttpGet("get-Itineraries")]
        public async Task<IActionResult> GetItineraries()
        {
            // ItineraryDTO Intinerary = new ItineraryDTO("1","Marina",5000);
            return Ok(1);
        }

        [HttpPost("add-intinerary")]
        public async Task<IActionResult> AddItineraries(ItineraryDTO Intinerary)
        {
            MItinerary MItinerary = new MItinerary();
            return Ok(MItinerary.AddItinerary(Intinerary));
        }
    }
}