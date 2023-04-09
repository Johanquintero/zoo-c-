namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class HabitatTest
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
        VegetationTypeDTO vegetationType = new VegetationTypeDTO("1", "prueba", "prueba");
        HabitatDTO Habitat = new HabitatDTO(null, "prueba", "prueba", vegetationType);
        MHabitat mHabitat = new MHabitat();
        ResponseDTO response = mHabitat.AddHabitat(Habitat);
        Assert.Equal(true, response.response);

        JObject habitat = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(habitat["id"]);
        response = mHabitat.DeleteHabitat(id);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void UpdateHabitatSucess()
    {
        HabitatUpdateDTO Habitat = new HabitatUpdateDTO("actTest10", null, null);
        MHabitat mHabitat = new MHabitat();
        ResponseDTO response = mHabitat.UpdateHabitat(1, Habitat);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteHabitatSucess()
    {
        MHabitat mHabitat = new MHabitat();
        // ResponseDTO response = mHabitat.DeleteHabitat(9);
        // Assert.Equal(true, response.response);
    }
}