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
            JObject vt = JObject.Parse(JsonConvert.SerializeObject(vtUpdate));
            Boolean is_name = !String.IsNullOrEmpty(Convert.ToString(vt["name"]));
            Boolean is_description = !String.IsNullOrEmpty(Convert.ToString(vt["description"]));

            String queryUpdate = "UPDATE public.vegetation_types SET " +
            (is_name ? $"name = '{vt["name"]}'" : "") +
            (is_description ? (is_name ? "," : "") + $" description = '{vt["description"]}' " : "") +
            " WHERE id = '" + id + "' ";

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

    }
}
