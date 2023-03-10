namespace Zoo.DTO
{
    public class UserDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public DateTime date_entry { get; set; }
        public UserTypeDTO user_type { get; set; }
        public UserDTO(int id, string name, string address, string phone, DateTime date_entry, UserTypeDTO user_type)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.date_entry = date_entry;
            this.user_type = user_type;
        }
    }
}