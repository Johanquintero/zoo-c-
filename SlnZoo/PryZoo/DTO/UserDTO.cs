namespace Zoo.DTO
{
    public class UserDTO
    {
        public string? id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string date_entry { get; set; }
        public UserTypeDTO user_type { get; set; }
        public UserDTO(string? id, string name, string address, string phone, string date_entry, UserTypeDTO user_type)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.date_entry = date_entry;
            this.user_type = user_type;
        }
    }


    public class UserUpdateDTO
    {
        public string? name { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
        public string? date_entry { get; set; }
        public string? user_type_id { get; set; }
        public UserUpdateDTO(string? name, string? address, string? phone, string? date_entry, string? user_type_id)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.date_entry = date_entry;
            this.user_type_id = user_type_id;
        }
    }
}