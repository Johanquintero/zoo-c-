namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class UserTest
{
    [Fact]
    public void GetUserSuccess()
    {
        MUser mUser = new MUser();
        ResponseDTO response = mUser.GetUser();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddUserSucess()
    {

        UserTypeDTO userTypeDTO = new UserTypeDTO("1", "test");
        UserDTO userDTO = new UserDTO(null, "test", "direccion", "322124521", "25/12/2022", userTypeDTO);

        MUser mUser = new MUser();
        ResponseDTO response = mUser.AddUser(userDTO);
        Assert.Equal(true, response.response);

        JObject user = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(user["id"]);
        response = mUser.DeleteUser(id);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void UpdateUserSucess()
    {
        UserUpdateDTO User = new UserUpdateDTO("test",null,null,null,null);
        MUser mUser = new MUser();
        ResponseDTO response = mUser.UpdateUser(1, User);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteUserSucess()
    {
        MUser mUser = new MUser();
        // ResponseDTO response = mSpecieUser.DeleteSpecieUser(9);
        // Assert.Equal(true, response.response);
    }
}