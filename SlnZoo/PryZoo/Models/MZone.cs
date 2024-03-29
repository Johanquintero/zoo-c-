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

            JArray array = JArray.Parse(responseBD.data);
            JObject zon = JObject.Parse(Convert.ToString(array[0]));
            zone.id = Convert.ToString(zon["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(zone), "");
        }

        public ResponseDTO UpdateZone(int id, ZoneUpdateDTO zoneEdit)
        {
            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(zoneEdit));
            String queryUpdate = zF.GenerateUpdateQuery("zones", id, listTemp);

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
        public ResponseDTO GetZone(int id=0)
        {
            String query_condition = "";
            if (id != 0)
            {
                query_condition = "WHERE zones.id = " + id + "";
            }
            String query = "SELECT * FROM public.zones "+query_condition+";";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }
    }
}
