using Zoo.DTO;
using Zoo.Models;
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
            String queryInsert = "INSERT INTO public.vegetation_types(name,description) VALUES ('"+vegetationType.name+"','"+vegetationType.description+"') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            // return responseBD;
            JArray array = JArray.Parse(responseBD.data);
            JObject vT = JObject.Parse(Convert.ToString(array[0]));
            vegetationType.id = Convert.ToString(vT["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(vegetationType),"");
        }
    }
}
