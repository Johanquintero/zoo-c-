namespace Zoo.DTO
{
    public class ItineraryDTO
    {
        public string id { get; set; }
        public DateTime init_DateTime { get; set; }
        public DateTime end_DateTime { get; set; }
        public float distance { get; set; }
        public string visitors { get; set; }
        public UserDTO user { get; set; }

        public ItineraryDTO(string id, DateTime init_datetime, DateTime end_datetime, float distance, string visitors, UserDTO user)
        {
            this.id = id;
            this.init_DateTime = init_datetime;
            this.end_DateTime = end_datetime;
            this.distance = distance;
            this.visitors = visitors;
            this.user = user;
        }
    }

}