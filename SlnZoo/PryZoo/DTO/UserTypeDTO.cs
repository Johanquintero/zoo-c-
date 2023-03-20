namespace Zoo.DTO
{
    public class UserTypeDTO
    {
        public string? id { get; set; }
        public string name { get; set; }
        public UserTypeDTO(string? id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}