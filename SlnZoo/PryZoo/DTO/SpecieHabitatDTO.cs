namespace Zoo.DTO
{
    public class SpecieHabitatDTO
    {
        public int id { get; set; }
        public SpecieDTO specie_id { get; set; }
        public HabitatDTO habitat_id { get; set; }
        public SpecieHabitatDTO(int id, SpecieDTO specie_id, HabitatDTO habitat_id)
        {
            this.id = id;
            this.specie_id = specie_id;
            this.habitat_id = habitat_id;

        }
}
}