using Zoo.DTO;
using Zoo.Models;
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
            String queryInsert = "INSERT INTO public.users(name,address, phone, date_entry,user_type_id) VALUES ('"+User.name+"','"+User.address+"','"+User.phone+"','"+User.date_entry+"','"+User.user_type.id+"') RETURNING *";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject use = JObject.Parse(Convert.ToString(array[0]));
            User.id = Convert.ToString(use["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(User),"");
        }
    }
}
