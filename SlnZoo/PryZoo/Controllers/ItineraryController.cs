using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class ItineraryController : Controller
    {
        public ItineraryController() { }

        [HttpGet("itinerary")]
        public async Task<IActionResult> GetItineraries()
        {
            // ItineraryDTO Itinerary = new ItineraryDTO("1","Marina",5000);
            return Ok(1);
        }

        [HttpPost("itinerary")]
        public async Task<IActionResult> AddItineraries(ItineraryDTO Itinerary)
        {
            MItinerary MItinerary = new MItinerary();
            return Ok(MItinerary.AddItinerary(Itinerary));
        }
        [HttpPut("itinerary/{id}")]
        public async Task<IActionResult> UpdateItinerary(int id, ItineraryUpdateDTO itineraryUpdate)
        {
            MItinerary mItinerary = new MItinerary();
            return Ok(mItinerary.UpdateItinerary(id, itineraryUpdate));
        }

        [HttpDelete("itinerary/{id}")]
        public async Task<IActionResult> DeleteItinerary(int id)
        {
            MItinerary mItinerary = new MItinerary();
            return Ok(mItinerary.DeleteItinerary(id));
        }
    }
}