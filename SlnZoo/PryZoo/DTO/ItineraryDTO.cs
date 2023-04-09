namespace Zoo.DTO
{
    public class ItineraryDTO
    {
        public string? id { get; set; }
        public string init_datetime { get; set; }
        public string end_datetime { get; set; }
        public float distance { get; set; }
        public int visitors { get; set; }
        public UserDTO user { get; set; }

        public ItineraryDTO(string? id, string init_datetime, string end_datetime, float distance, int visitors, UserDTO user)
        {
            this.id = id;
            this.init_datetime = init_datetime;
            this.end_datetime = end_datetime;
            this.distance = distance;
            this.visitors = visitors;
            this.user = user;
        }
    }

    public class ItineraryUpdateDTO
    {
        public string? init_datetime { get; set; }
        public string? end_datetime { get; set; }
        public float? distance { get; set; }
        public int? visitors { get; set; }
        public string? user_id { get; set; }
        public ItineraryUpdateDTO(string? init_datetime, string? end_datetime, float? distance, int? visitors, string? user_id)
        {
            this.init_datetime = init_datetime;
            this.end_datetime = end_datetime;
            this.distance = distance;
            this.visitors = visitors;
            this.user_id = user_id;

        }
    }

}