namespace Zoo.DTO
{
    public class ItineraryDTO
    {
        public int id { get; set; }
        public Datetime init_datetime { get; set; }
        public Datetime end_datetime { get; set; }
        public float distance { get; set; }
        public int visitors { get; set; }
        public User user_id { get; set; }

        public ItineraryDTO(int id, Datetime init_datetime, Datetime end_datetime, float distance, int visitors, User user_id)
        {
            this.id = id;
            this.init_datetime = init_datetime;
            this.end_datetime = end_datetime;
            this.distance = distance;
            this.visitors = visitors;
            this.user_id = user_id;
        }
    }

}