namespace Zoo.DTO
{
    public class SpecieUserDTO
    {
        public string? id { get; set; }
        public SpecieDTO specie { get; set; }
        public UserDTO user { get; set; }
        public SpecieUserDTO(string? id, SpecieDTO specie, UserDTO user)
        {
            this.id = id;
            this.specie = specie;
            this.user = user;
        }
    }

    public class SpecieUserUpdateDTO
    {
        public string? specie_id { get; set; }
        public string? user_id { get; set; }
        public SpecieUserUpdateDTO(string? specie_id, string? user_id)
        {
            this.specie_id = specie_id;
            this.user_id = user_id;
        }
    }
}