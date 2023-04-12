using Zoo.DTO;
using Zoo.Models;
using Zoo.Functions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MSpecie
    {
        public MSpecie()
        {

        }

        public ResponseDTO AddSpecie(SpecieDTO Specie)
        {
            String queryInsert = "INSERT INTO public.species(scientific_name,description,zone_id) VALUES ('" + Specie.scientific_name + "','" + Specie.description + "','" + Specie.zone.id + "') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject specie = JObject.Parse(Convert.ToString(array[0]));
            Specie.id = Convert.ToString(specie["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(Specie), "");
        }
        public ResponseDTO UpdateSpecie(int id, SpecieUpdateDTO specieEdit)
        {
            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(specieEdit));
            String queryUpdate = zF.GenerateUpdateQuery("species", id, listTemp);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(specieEdit), "");

        }
        public ResponseDTO DeleteSpecie(int id)
        {
            String queryDelete = "DELETE FROM public.species WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
        public ResponseDTO GetSpecie(int id=0)
        {
            String query_condition = "";
            if (id != 0)
            {
                query_condition = "WHERE species.id = " + id + "";
            }
            String query = "SELECT zones.name, zones.extention, species.* FROM public.species inner join zones on zones.id = species.zone_id "+query_condition+";";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }
    }
}
