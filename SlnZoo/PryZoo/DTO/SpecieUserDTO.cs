namespace Zoo.DTO
{
    public class SpecieUserDTO
    {
        public int id { get; set; }
        public SpecieDTO specie_id { get; set; }
        public User user_id { get; set; }
        public SpecieUserDTO(int id, SpecieDTO specie_id, User user_id)
        {
            this.id = id;
            this.specie_id = specie_id;
            this.user_id = user_id;

        }
}
}