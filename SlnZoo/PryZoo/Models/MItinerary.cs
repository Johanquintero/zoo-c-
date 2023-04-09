using Zoo.DTO;
using Zoo.Functions;
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
            String queryInsert = "INSERT INTO public.itineraries(init_datetime,end_datetime, distance, visitors,user_id) VALUES ('" + Itinerary.init_datetime + "','" + Itinerary.end_datetime + "','" + Itinerary.distance + "','" + Itinerary.visitors + "','" + Itinerary.user.id + "') RETURNING *";
            Console.WriteLine(queryInsert);
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject iti = JObject.Parse(Convert.ToString(array[0]));
            Itinerary.id = Convert.ToString(iti["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(Itinerary), "");
        }
        public ResponseDTO UpdateItinerary(int id, ItineraryUpdateDTO itineraryEdit)
        {
            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(itineraryEdit));
            String queryUpdate = zF.GenerateUpdateQuery("itineraries", id, listTemp);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(itineraryEdit), "");

        }
        public ResponseDTO DeleteItinerary(int id)
        {
            String queryDelete = "DELETE FROM public.itineraries WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
        public ResponseDTO GetItinerary()
        {
            String query = "SELECT * FROM public.itineraries;";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }
    }
}
