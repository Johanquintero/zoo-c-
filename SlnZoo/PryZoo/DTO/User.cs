namespace Zoo.DTO
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public Datetime date_entry { get; set; }
        public UserType user_type_id { get; set; }
        public User(int id, string name, string address, string phone, Datime date_entry, UserType user_type_id)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.date_entry = date_entry;
            this.user_type_id = user_type_id;
        }
    }
}