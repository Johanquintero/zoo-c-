namespace Zoo.DTO
{
    public class ItineraryDTO
    {
        public int id { get; set; }
        public DateTime init_DateTime { get; set; }
        public DateTime end_DateTime { get; set; }
        public float distance { get; set; }
        public int visitors { get; set; }
        public UserDTO user { get; set; }

        public ItineraryDTO(int id, DateTime init_datetime, DateTime end_datetime, float distance, int visitors, UserDTO user)
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