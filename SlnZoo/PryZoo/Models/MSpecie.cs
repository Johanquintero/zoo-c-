using Zoo.DTO;
using Zoo.Models;
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
            String queryInsert = "INSERT INTO public.species(scientific_name,description) VALUES ('"+Specie.scientific_name+"','"+Specie.description+"') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject specie = JObject.Parse(Convert.ToString(array[0]));
            Specie.id = Convert.ToString(specie["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(Specie),"");
        }
    }
}
