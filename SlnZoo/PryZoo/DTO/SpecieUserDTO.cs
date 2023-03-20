namespace Zoo.DTO
{
    public class SpecieUserDTO
    {
        public string id { get; set; }
        public SpecieDTO specie { get; set; }
        public UserDTO user { get; set; }
        public SpecieUserDTO(string id, SpecieDTO specie, UserDTO user)
        {
            this.id = id;
            this.specie = specie;
            this.user = user;
        }
    }
}