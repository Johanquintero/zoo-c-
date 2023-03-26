using Zoo.DTO;
using Zoo.Functions;
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
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryInsert);
            JArray array = JArray.Parse(responseBD.data);
            JObject su = JObject.Parse(Convert.ToString(array[0]));
            SpecieUser.id = Convert.ToString(su["id"]);
            return new ResponseDTO(true,JsonConvert.SerializeObject(SpecieUser),"");
        }

        public ResponseDTO UpdateSpecieUsers(int id, SpecieUserUpdateDTO specieUserUpdateDTO)
        {
            ZooFunctions zF = new ZooFunctions();

            Dictionary<string, string> listTemp = zF.GenerateList(JsonConvert.SerializeObject(specieUserUpdateDTO));
            String queryUpdate = zF.GenerateUpdateQuery("specie_users", id, listTemp);

            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryUpdate);
            return new ResponseDTO(true, JsonConvert.SerializeObject(specieUserUpdateDTO), "");
        }

        public ResponseDTO DeleteSpecieUsers(int id)
        {
            String queryDelete = "DELETE FROM public.specie_users WHERE id = '" + id + "' ";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(queryDelete);
            return new ResponseDTO(true, "", "");
        }
    }
}
