using Zoo.DTO;
using Zoo.Functions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MUser
    {
        public MUser()
        {

        }

        public ResponseDTO AddUser(UserDTO User)
        {
            String queryInsert = "INSERT INTO public.users(name,address, phone, date_entry,user_type_id) VALUES ('" + User.name + "','" + User.address + "','" + User.phone + "','" + User.date_entry + "','" + User.user_type.id + "') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject use = JObject.Parse(Convert.ToString(array[0]));
            User.id = Convert.ToString(use["id"]);
            return new ResponseDTO(true, JsonConvert.SerializeObject(User), "");
        }

        public ResponseDTO UpdateUser(int id, UserUpdateDTO userUpdateDTO)
        {
            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(userUpdateDTO));
            String queryUpdate = zF.GenerateUpdateQuery("users", id, listTemp);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(userUpdateDTO), "");
        }

        public ResponseDTO DeleteUser(int id)
        {
            String queryDelete = "DELETE FROM public.users WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
        public ResponseDTO GetUser(int id=0)
        {
            String query_condition = "";
            if (id != 0)
            {
                query_condition = "WHERE users.id = " + id + "";
            }
            String query = "SELECT users.*, user_types.name user_type, user_types.description FROM PUBLIC.users INNER JOIN user_types ON user_types.id = users.user_type_id "+query_condition+";";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }
    }
}
