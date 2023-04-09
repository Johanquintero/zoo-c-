namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class SpecieUsersTest
{
    [Fact]
    public void GetSpecieUserSuccess()
    {
        MSpecieUser mSpecieUser = new MSpecieUser();
        ResponseDTO response = mSpecieUser.GetSpecieUsers();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddSpecieUserSucess()
    {

        ZoneDTO zoneDTO = new ZoneDTO("1", "test", 54);
        SpecieDTO SpecieDTO = new SpecieDTO("1", "cientifico", "description", zoneDTO);

        UserTypeDTO userTypeDTO = new UserTypeDTO("1", "test");
        UserDTO userDTO = new UserDTO("1", "test", "direccion", "322124521", "25/12/2022", userTypeDTO);

        SpecieUserDTO SpecieUser = new SpecieUserDTO(null, SpecieDTO, userDTO);

        MSpecieUser mSpecieUser = new MSpecieUser();
        ResponseDTO response = mSpecieUser.AddSpecieUser(SpecieUser);
        Assert.Equal(true, response.response);

        JObject specieUser = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(specieUser["id"]);
        response = mSpecieUser.DeleteSpecieUsers(id);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void UpdateSpecieUserSucess()
    {
        SpecieUserUpdateDTO SpecieUser = new SpecieUserUpdateDTO("2", null);
        MSpecieUser mSpecieUser = new MSpecieUser();
        ResponseDTO response = mSpecieUser.UpdateSpecieUsers(1, SpecieUser);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteSpecieUserSucess()
    {
        MSpecieUser mSpecieUser = new MSpecieUser();
        // ResponseDTO response = mSpecieUser.DeleteSpecieUser(9);
        // Assert.Equal(true, response.response);
    }
}