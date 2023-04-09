using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace PryZoo.test;

public class UnitTest1
{
    [Fact]
    public void AddZonesSucess()
    {
        ZoneDTO zoneDTO = new ZoneDTO(null, "test", 55);
        MZone mZone = new MZone();
        ResponseDTO response = mZone.AddZone(zoneDTO);
        Assert.Equal(true, response.response);

        JArray array = JArray.Parse(response.data);
        JObject zon = JObject.Parse(Convert.ToString(array[0]));
        int id = Convert.ToInt16(zon["id"]);
        response = mZone.DeleteZone(id);
        Assert.Equal(true, response.response);

    }
}