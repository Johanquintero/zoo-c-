namespace Zoo.DTO
{
    public class SpecieHabitatDTO
    {
        public string? id { get; set; }
        public SpecieDTO specie { get; set; }
        public HabitatDTO habitat { get; set; }
        public SpecieHabitatDTO(string? id, SpecieDTO specie, HabitatDTO habitat)
        {
            this.id = id;
            this.specie = specie;
            this.habitat = habitat;
        }
    }
    public class SpecieHabitatUpdateDTO
    {
        public string? specie_id { get; set; }
        public string? habitat_id { get; set; }
        public SpecieHabitatUpdateDTO(string? specie_id, string? habitat_id)
        {
            this.specie_id = specie_id;
            this.habitat_id = habitat_id;
        }
    }
}