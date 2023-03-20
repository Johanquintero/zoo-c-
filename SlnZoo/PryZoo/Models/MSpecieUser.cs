using Zoo.DTO;
using Zoo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Models
{
    public class MSpecieUser
    {
        public MSpecieUser()
        {

        }

        public ResponseDTO AddSpecieUser(SpecieUserDTO SpecieUser)
        {
            String queryInsert = "INSERT INTO public.specie_users(specie_id, user_id) VALUES ('"+SpecieUser.specie.id+"','"+SpecieUser.user.id+"') RETURNING *";
            Console.WriteLine(queryInsert);
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);

            JArray array = JArray.Parse(responseBD.data);
            JObject su = JObject.Parse(Convert.ToString(array[0]));
            SpecieUser.id = Convert.ToString(su["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(SpecieUser),"");
        }
    }
}
