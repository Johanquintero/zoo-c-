namespace Zoo.DTO
{
    public class HabitatDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string weather { get; set; }
        public VegetationTypeDTO vegetation { get; set; }
        public HabitatDTO(int id, string name, string weather, VegetationTypeDTO vegetation)
        {
            this.id = id;
            this.name = name;
            this.weather = weather;
            this.vegetation = vegetation;
        }

    }
}