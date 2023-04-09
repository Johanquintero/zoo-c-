namespace PryZoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class ItineraryTest
{
    [Fact]
    public void GetItinerarySuccess()
    {
        MItinerary itinerary = new MItinerary();
        ResponseDTO response = itinerary.GetItinerary();
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void AddItinerarySucess()
    {
        UserTypeDTO userTypeDTO = new UserTypeDTO("1", "test");
        UserDTO userDTO = new UserDTO("1", "test", "direccion", "322124521", "25/12/2022", userTypeDTO);
        ItineraryDTO Itinerary = new ItineraryDTO(null, "20/05/2023", "20/05/2023", 55, 40, userDTO);

        MItinerary mItinerary = new MItinerary();
        ResponseDTO response = mItinerary.AddItinerary(Itinerary);
        Assert.Equal(true, response.response);

        JObject itinerary = JObject.Parse(Convert.ToString(response.data));
        int id = Convert.ToInt16(itinerary["id"]);
        response = mItinerary.DeleteItinerary(id);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void UpdateItinerarySucess()
    {
        ItineraryUpdateDTO Itinerary = new ItineraryUpdateDTO("20/05/2023", "20/05/2023",null,null,null);
        MItinerary mItinerary = new MItinerary();
        ResponseDTO response = mItinerary.UpdateItinerary(1, Itinerary);
        Assert.Equal(true, response.response);
    }
    [Fact]
    public void DeleteItineraryucess()
    {
        MItinerary mItinerary = new MItinerary();
        // ResponseDTO response = mHabitat.DeleteItinerary(9);
        // Assert.Equal(true, response.response);
    }
}