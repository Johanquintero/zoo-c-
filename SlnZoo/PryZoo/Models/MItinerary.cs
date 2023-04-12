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
            String queryVerify = "SELECT * FROM itineraries WHERE  user_id = " + Itinerary.user.id + " AND '" + Itinerary.init_datetime + "' BETWEEN init_datetime AND end_datetime AND '" + Itinerary.end_datetime + "' BETWEEN init_datetime AND end_datetime";
            Console.WriteLine(queryVerify);
            MData data = new MData();
            ResponseDTO responseVerify = data.execute(queryVerify);
            JArray arrayVerify = JArray.Parse(responseVerify.data);
            if (arrayVerify.Count() > 0)
            {
                return new ResponseDTO(false, arrayVerify.ToString(), "No es posible asignar un nuevo itinerario, los horarios están ocupados");
            }


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
        public ResponseDTO GetItinerary(int id = 0)
        {
            String query_condition = "";
            if (id != 0)
            {
                query_condition = "WHERE itineraries.id = " + id + "";
            }
            String query = "SELECT users.name, users.id as user_id, itineraries.* FROM public.itineraries inner join users on users.id = itineraries.user_id "+query_condition+";";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }
    }
}
