namespace Zoo.DTO
{
    public class SpecieHabitatDTO
    {
        public string? id { get; set; }
        public SpecieDTO specie { get; set; }
        public HabitatDTO habitat { get; set; }
        public SpecieHabitatDTO(string? id, SpecieDTO? specie, HabitatDTO habitat)
        {
            this.id = id;
            this.specie = specie;
            this.habitat = habitat;

        }
}
}