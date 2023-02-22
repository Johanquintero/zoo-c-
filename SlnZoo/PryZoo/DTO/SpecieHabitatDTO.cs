namespace Zoo.DTO
{
    public class SpecieHabitatDTO
    {
        public int id { get; set; }
        public SpecieDTO specie { get; set; }
        public HabitatDTO habitat { get; set; }
        public SpecieHabitatDTO(int id, SpecieDTO specie, HabitatDTO habitat)
        {
            this.id = id;
            this.specie = specie;
            this.habitat = habitat;

        }
}
}