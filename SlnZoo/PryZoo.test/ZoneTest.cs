using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace PryZoo.test;

public class ZoneTest
{
    [Fact]
    public void GetZoneSuccess()
    {
        MZone mZone = new MZone();
        ResponseDTO response = mZone.GetZone();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddZoneSucess()
    {
        ZoneDTO zoneDTO = new ZoneDTO(null, "test", 55);
        MZone mZone = new MZone();
        ResponseDTO response = mZone.AddZone(zoneDTO);
        Assert.Equal(true, response.response);

        JObject zone = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(zone["id"]);
        response = mZone.DeleteZone(id);
        Assert.Equal(true, response.response);

    }
    [Fact]
    public void UpdateZoneSucess()
    {
        ZoneUpdateDTO Zone = new ZoneUpdateDTO("test",null);
        MZone mZone = new MZone();
        ResponseDTO response = mZone.UpdateZone(1, Zone);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteHabitatSucess()
    {
        MZone mZone = new MZone();
        // ResponseDTO response = mZone.DeleteZone(9);
        // Assert.Equal(true, response.response);
    }
}