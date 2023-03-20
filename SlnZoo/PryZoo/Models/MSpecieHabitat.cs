using Zoo.DTO;
using Zoo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MSpecieHabitat
    {
        public MSpecieHabitat()
        {

        }

        public ResponseDTO AddSpecieHabitat(SpecieHabitatDTO SpecieHabitat)
        {
            String queryInsert = "INSERT INTO public.specie_habitats(specie_id, habitat_id) VALUES ('"+SpecieHabitat.specie.id+"','"+SpecieHabitat.habitat.id+"') RETURNING *";
            Console.WriteLine(queryInsert);
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject sh = JObject.Parse(Convert.ToString(array[0]));
            SpecieHabitat.id = Convert.ToString(sh["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(SpecieHabitat),"");
        }
    }
}
