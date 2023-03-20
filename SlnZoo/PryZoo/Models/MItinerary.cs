using Zoo.DTO;
using Zoo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MItinerary
    {
        public MItinerary()
        {

        }

        public ResponseDTO AddItinerary(ItineraryDTO Itinerary)
        {
            String queryInsert = "INSERT INTO public.itineraries(init_datetime,end_datetime, distance, visitors) VALUES ('"+Itinerary.init_datetime+"','"+Itinerary.end_datetime+"','"+Itinerary.distance+"','"+Itinerary.visitors+"') RETURNING *";
            Console.WriteLine(queryInsert);
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject iti = JObject.Parse(Convert.ToString(array[0]));
            Itinerary.id = Convert.ToString(iti["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(Itinerary),"");
        }
    }
}
