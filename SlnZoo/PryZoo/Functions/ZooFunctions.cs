using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Functions
{

    public class ZooFunctions
    {
        public Dictionary<string, string> GenerateList(Object Jobject)
        {
            Dictionary<string, string> listTemp = new Dictionary<string, string>();
            JObject obj = JObject.Parse(Convert.ToString(Jobject));

            foreach (var item in obj)
            {
                listTemp.Add(item.Key, obj[item.Key].ToString());
            }

            return listTemp;
        }

        public string GenerateUpdateQuery(string tableName, int recordId, Dictionary<string, string> fieldsDict)
        {
            // Build the SET clause with the fields and values
            List<string> setClauses = new List<string>();
            foreach (KeyValuePair<string, string> field in fieldsDict)
            {
                if (!String.IsNullOrEmpty(Convert.ToString(field.Value)))
                {
                    setClauses.Add($"{field.Key} = '{field.Value}'");
                }
            }
            string setClause = string.Join(", ", setClauses);

            // Build the full SQL query
            string query = $"UPDATE {tableName} SET {setClause} WHERE id = {recordId}";

            return query;

        }
    }


}