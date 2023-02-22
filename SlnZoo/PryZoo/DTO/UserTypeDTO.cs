namespace Zoo.DTO
{
    public class UserTypeDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public UserTypeDTO(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}