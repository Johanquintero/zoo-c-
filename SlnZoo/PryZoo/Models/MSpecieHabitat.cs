using Zoo.DTO;
using Zoo.Models;
using Zoo.Functions;
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
        public ResponseDTO UpdateSpecieHabitat(int id, SpecieHabitatUpdateDTO specieHabitatEdit)
        {
            ZooFunctions zF = new ZooFunctions();
            
            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(specieHabitatEdit));
            String queryUpdate = zF.GenerateUpdateQuery("specie_habitat", id, listTemp);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(specieHabitatEdit), "");

        }
        public ResponseDTO DeleteSpecieHabitat(int id)
        {
            String queryDelete = "DELETE FROM public.specie_habitat WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
    }
}
