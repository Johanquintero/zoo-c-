using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MZone
    {
        public MZone()
        {

        }

        public ResponseDTO AddZone(ZoneDTO zone)
        {
            String queryInsert = "INSERT INTO public.zones(name,extention) VALUES ('" + zone.name + "','" + zone.extention + "') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            // return responseBD;
            /* Parsing the response from the database. */
            JArray array = JArray.Parse(responseBD.data);
            JObject zon = JObject.Parse(Convert.ToString(array[0]));
            zone.id = Convert.ToString(zon["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(zone), "");
        }

        public ResponseDTO UpdateZone(int id, ZoneUpdateDTO zoneEdit)
        {
            JObject zon = JObject.Parse(JsonConvert.SerializeObject(zoneEdit));
            Boolean is_name = !String.IsNullOrEmpty(Convert.ToString(zon["name"]));
            Boolean is_extension = !String.IsNullOrEmpty(Convert.ToString(zon["extention"]));
            
            String queryUpdate = "UPDATE public.zones SET " +
            (is_name ? $"name = '{zon["name"]}'" : "") +
            (is_extension ? (is_name ? "," : "") + $" extention = '{zon["extention"]}' " : "") +
            " WHERE id = '" + id + "' ";

            Console.WriteLine(queryUpdate);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(zoneEdit), "");

        }

    }
}
