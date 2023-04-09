namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class UserTypeTest
{
    [Fact]
    public void GetUserTypeSuccess()
    {
        MUserType mUserType = new MUserType();
        ResponseDTO response = mUserType.GetUserType();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddUserTypeSucess()
    {
        UserTypeDTO userTypeDTO = new UserTypeDTO(null, "test");

        MUserType mUserType = new MUserType();
        ResponseDTO response = mUserType.AddUserType(userTypeDTO);
        Assert.Equal(true, response.response);

        JObject userType = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(userType["id"]);
        response = mUserType.DeleteUserType(id);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void UpdateUserTypeSucess()
    {
        UserTypeDTO UserType = new UserTypeDTO(null,"test");
        MUserType mUserType = new MUserType();
        ResponseDTO response = mUserType.UpdateUserType(1, UserType);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteUserSucess()
    {
        MUserType mUserType = new MUserType();
        // ResponseDTO response = mUserType.DeleteUserType(9);
        // Assert.Equal(true, response.response);
    }
}