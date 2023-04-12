using Zoo.DTO;
using Zoo.Functions;
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
            String queryInsert = "INSERT INTO public.habitats(name,weather,vegetation_type_id) VALUES ('" + Habitat.name + "','" + Habitat.weather + "','" + Habitat.vegetation_type.id + "') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject habit = JObject.Parse(Convert.ToString(array[0]));
            Habitat.id = Convert.ToString(habit["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(Habitat), "");
        }
        public ResponseDTO UpdateHabitat(int id, HabitatUpdateDTO habitatEdit)
        {
            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(habitatEdit));
            String queryUpdate = zF.GenerateUpdateQuery("habitats", id, listTemp);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(habitatEdit), "");

        }
        public ResponseDTO DeleteHabitat(int id)
        {
            String queryDelete = "DELETE FROM public.habitats WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
        public ResponseDTO GetHabitat(int id) {
            String query_condition = "";
            if(id != 0){
                query_condition = "WHERE habitats.id = "+id+"";
            }
            
            String query = "SELECT habitats.*, vegetation_types.name as vegetation_type, vegetation_types.description FROM public.habitats inner join vegetation_types on vegetation_types.id = habitats.vegetation_type_id "+query_condition+" ;";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }
    }
}
