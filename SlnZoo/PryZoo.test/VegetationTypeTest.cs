namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class VegetationTypeTest
{
    [Fact]
    public void GetVegetationType()
    {
        MVegetationType mVegetationType = new MVegetationType();
        ResponseDTO response = mVegetationType.GetVegetationType();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddVegetationTypeSucess()
    {
        VegetationTypeDTO vegetationTypeDTO = new VegetationTypeDTO(null, "prueba", "prueba");
        MVegetationType mVegetationType = new MVegetationType();
        ResponseDTO response = mVegetationType.AddVegetationType(vegetationTypeDTO);
        Assert.Equal(true, response.response);

        JObject vegetationType = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(vegetationType["id"]);
        response = mVegetationType.DeleteVegetationType(id);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void UpdateVegetationTypeSucess()
    {
        VegetationTypeUpdateDTO vegetationTypeDTO = new VegetationTypeUpdateDTO("text","descripiton");
        MVegetationType mVegetationType = new MVegetationType();
        ResponseDTO response = mVegetationType.UpdateVegetationType(1, vegetationTypeDTO);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteVegetationTypeSucess()
    {
        MVegetationType mVegetationType = new MVegetationType();
        // ResponseDTO response = mVegetationType.DeleteVegetationType(9);
        // Assert.Equal(true, response.response);
    }
}