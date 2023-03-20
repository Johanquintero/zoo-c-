using Zoo.DTO;
using Zoo.Models;
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
            String queryInsert = "INSERT INTO public.zones(name,extention) VALUES ('"+zone.name+"','"+zone.extention+"') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            // return responseBD;
            JArray array = JArray.Parse(responseBD.data);
            JObject zon = JObject.Parse(Convert.ToString(array[0]));
            zone.id = Convert.ToString(zon["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(zone),"");
        }
    }
}
