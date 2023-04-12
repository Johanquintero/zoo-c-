using Zoo.DTO;
using Zoo.Functions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MVegetationType
    {
        public MVegetationType()
        {

        }

        public ResponseDTO AddVegetationType(VegetationTypeDTO vegetationType)
        {
            String queryInsert = "INSERT INTO public.vegetation_types(name,description) VALUES ('" + vegetationType.name + "','" + vegetationType.description + "') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            // return responseBD;
            JArray array = JArray.Parse(responseBD.data);
            JObject vT = JObject.Parse(Convert.ToString(array[0]));
            vegetationType.id = Convert.ToString(vT["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(vegetationType), "");
        }
        public ResponseDTO UpdateVegetationType(int id, VegetationTypeUpdateDTO vtUpdate)
        {
            ZooFunctions zF = new ZooFunctions();
            
            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(vtUpdate));
            String queryUpdate = zF.GenerateUpdateQuery("vegetation_types", id, listTemp);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(vtUpdate), "");
        }

        public ResponseDTO DeleteVegetationType(int id)
        {
            String queryDelete = "DELETE FROM public.vegetation_types WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
        
        public ResponseDTO GetVegetationType(int id=0)
        {
            String query_condition = "";
            if (id != 0)
            {
                query_condition = "WHERE vegetation_types.id = " + id + "";
            }
            String query = "SELECT * FROM public.vegetation_types "+query_condition +";";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }

    }
}
