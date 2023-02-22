namespace Zoo.DTO
{
    public class SpecieUserDTO
    {
        public int id { get; set; }
        public SpecieDTO specie { get; set; }
        public UserDTO user { get; set; }
        public SpecieUserDTO(int id, SpecieDTO specie, UserDTO user)
        {
            this.id = id;
            this.specie = specie;
            this.user = user;

        }
}
}