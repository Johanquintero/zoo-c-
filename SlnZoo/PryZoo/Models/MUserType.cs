using Zoo.DTO;
using Zoo.Functions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MUserType
    {
        public MUserType()
        {

        }

        public ResponseDTO AddUserType(UserTypeDTO userType)
        {
            String queryInsert = "INSERT INTO public.user_types(name) VALUES ('" + userType.name + "') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            // return responseBD;
            JArray array = JArray.Parse(responseBD.data);
            JObject uT = JObject.Parse(Convert.ToString(array[0]));
            userType.id = Convert.ToString(uT["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(userType), "");
        }

        public ResponseDTO UpdateUserType(int id, UserTypeDTO userType)
        {
            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(userType));
            String queryUpdate = zF.GenerateUpdateQuery("user_types", id, listTemp);
            return new ResponseDTO(true, JsonConvert.SerializeObject(userType), "");
        }

        public ResponseDTO DeleteUserType(int id)
        {
            String queryDelete = "DELETE FROM public.user_types WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
    }
}
