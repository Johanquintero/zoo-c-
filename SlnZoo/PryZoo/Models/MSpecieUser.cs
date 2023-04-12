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
        public ResponseDTO GetSpecieUsers(int id=0)
        {
            String query_condition = "";
            if (id != 0)
            {
                query_condition = "WHERE specie_users.id = " + id + "";
            }
            String query = "SELECT specie_users.id, users.name as habitat, species.scientific_name, species.description FROM PUBLIC.specie_users INNER JOIN species ON species.ID = specie_users.specie_id INNER JOIN users ON specie_users.user_id = users.ID "+query_condition+";";
            MData data = new MData();
            ResponseDTO responseBD = data.execute(query);
            return responseBD;
        }
    }
}
