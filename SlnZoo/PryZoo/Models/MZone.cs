using Zoo.DTO;
using Zoo.Functions;
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

            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = new Dictionary<string, string>();
            JObject zon = JObject.Parse(JsonConvert.SerializeObject(zoneEdit));

            foreach (var item in zon)
            {
               listTemp.Add(item.Key,zon[item.Key].ToString());
            }

            Console.WriteLine(listTemp);

            String queryUpdate = zF.GenerateUpdateQuery("zones", id, listTemp);


            // JObject zon = JObject.Parse(JsonConvert.SerializeObject(zoneEdit));
            // Boolean is_name = !String.IsNullOrEmpty(Convert.ToString(zon["name"]));
            // Boolean is_extension = !String.IsNullOrEmpty(Convert.ToString(zon["extention"]));

            // String queryUpdate = "UPDATE public.zones SET " +
            // (is_name ? $"name = '{zon["name"]}'" : "") +
            // (is_extension ? (is_name ? "," : "") + $" extention = '{zon["extention"]}' " : "") +
            // " WHERE id = '" + id + "' ";

            // Console.WriteLine(queryUpdate);
            
            Console.WriteLine(queryUpdate);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(zoneEdit), "");

        }
        public ResponseDTO DeleteZone(int id)
        {
            String queryDelete = "DELETE FROM public.zones WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
    }
}
