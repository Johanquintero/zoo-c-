namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class SpecieTest
{
    [Fact]
    public void GetSpecieSuccess()
    {
        MSpecie mSpecie = new MSpecie();
        ResponseDTO response = mSpecie.GetSpecie();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddSpecieSucess()
    {
        ZoneDTO zoneDTO = new ZoneDTO("1","test",54);
        SpecieDTO Specie = new SpecieDTO(null,"cientifico","description",zoneDTO);

        MSpecie mSpecie = new MSpecie();
        ResponseDTO response = mSpecie.AddSpecie(Specie);
        Assert.Equal(true, response.response);

        JObject specie = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(specie["id"]);
        response = mSpecie.DeleteSpecie(id);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void UpdateSpecieSucess()
    {
        SpecieUpdateDTO Specie = new SpecieUpdateDTO("test",null,null);
        MSpecie mSpecie = new MSpecie();
        ResponseDTO response = mSpecie.UpdateSpecie(1, Specie);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteSpecieSucess()
    {
        MSpecie mSpecie = new MSpecie();
        // ResponseDTO response = mSpecie.DeleteSpecie(9);
        // Assert.Equal(true, response.response);
    }
}