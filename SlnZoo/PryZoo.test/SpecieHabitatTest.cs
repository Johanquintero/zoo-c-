namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class SpecieHabitatTest
{
    [Fact]
    public void GetSpecieHabitatSuccess()
    {
        MSpecieHabitat mSpecieHabitat = new MSpecieHabitat();
        ResponseDTO response = mSpecieHabitat.GetSpecieHabitat();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddSpecieHabitatSucess()
    {

        ZoneDTO zoneDTO = new ZoneDTO("1", "test", 54);
        SpecieDTO Specie = new SpecieDTO("1", "cientifico", "description", zoneDTO);

        VegetationTypeDTO vegetationType = new VegetationTypeDTO("1", "prueba", "prueba");
        HabitatDTO Habitat = new HabitatDTO("1", "prueba", "prueba", vegetationType);

        SpecieHabitatDTO SpecieHabitat = new SpecieHabitatDTO(null,Specie,Habitat);

        MSpecieHabitat mSpecieHabitat = new MSpecieHabitat();
        ResponseDTO response = mSpecieHabitat.AddSpecieHabitat(SpecieHabitat);
        Assert.Equal(true, response.response);

        JObject specieHabitat = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(specieHabitat["id"]);
        response = mSpecieHabitat.DeleteSpecieHabitat(id);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void UpdateSpecieHabitatSucess()
    {
        SpecieHabitatUpdateDTO SpecieHabitat = new SpecieHabitatUpdateDTO("2", null);
        MSpecieHabitat mSpecieHabitat = new MSpecieHabitat();
        ResponseDTO response = mSpecieHabitat.UpdateSpecieHabitat(1, SpecieHabitat);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteSpecieHabitatSucess()
    {
        MSpecieHabitat mSpecieHabitat = new MSpecieHabitat();
        // ResponseDTO response = mSpecieHabitat.DeleteSpecieHabitat(9);
        // Assert.Equal(true, response.response);
    }
}