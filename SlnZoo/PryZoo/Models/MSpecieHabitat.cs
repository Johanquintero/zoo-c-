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
            String queryInsert = "INSERT INTO public.specie_habitats(specie_id, habitat_id) VALUES ('" + SpecieHabitat.specie.id + "','" + SpecieHabitat.habitat.id + "') RETURNING *";
            Console.WriteLine(queryInsert);
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject sh = JObject.Parse(Convert.ToString(array[0]));
            SpecieHabitat.id = Convert.ToString(sh["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(SpecieHabitat), "");
        }
        public ResponseDTO UpdateSpecieHabitat(int id, SpecieHabitatUpdateDTO specieHabitatEdit)
        {
            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(specieHabitatEdit));
            String queryUpdate = zF.GenerateUpdateQuery("specie_habitats", id, listTemp);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(specieHabitatEdit), "");

        }
        public ResponseDTO DeleteSpecieHabitat(int id)
        {
            String queryDelete = "DELETE FROM public.specie_habitats WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
        public ResponseDTO GetSpecieHabitat(int id = 0)
        {
            String query_condition = "";
            if (id != 0)
            {
                query_condition = "WHERE specie_habitats.id = " + id + "";
            }
            String query = "SELECT specie_habitats.id, habitats.name as habitat, species.scientific_name, species.description FROM PUBLIC.specie_habitats INNER JOIN species ON species.ID = specie_habitats.specie_id INNER JOIN habitats ON specie_habitats.habitat_id = habitats.ID "+query_condition+";";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }
    }
}
