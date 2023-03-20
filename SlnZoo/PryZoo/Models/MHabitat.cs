using Zoo.DTO;
using Zoo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MHabitat
    {
        public MHabitat()
        {

        }

        public ResponseDTO AddHabitat(HabitatDTO Habitat)
        {
            String queryInsert = "INSERT INTO public.habitats(name,weather) VALUES ('"+Habitat.name+"','"+Habitat.weather+"') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject habit = JObject.Parse(Convert.ToString(array[0]));
            Habitat.id = Convert.ToString(habit["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(Habitat),"");
        }
    }
}
