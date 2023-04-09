namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class UnitTest1
{
    [Fact]
    public void GetHabitatSuccess()
    {
        MHabitat habitat = new MHabitat();
        ResponseDTO response = habitat.GetHabitat();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddHabitatSucess()
    {
        VegetationTypeDTO vegetationType = new VegetationTypeDTO("1","prueba", "prueba");
        HabitatDTO Habitat = new HabitatDTO(null,"prueba","prueba",vegetationType);
        MHabitat mHabitat = new MHabitat();
        ResponseDTO response = mHabitat.AddHabitat(Habitat);
        Assert.Equal(true, response.response);

        JObject habitat = JObject.Parse(Convert.ToString(response.data));
        string id = Convert.ToString(habitat["id"]);

        Assert.Equal("texto", id);

        
    }
}