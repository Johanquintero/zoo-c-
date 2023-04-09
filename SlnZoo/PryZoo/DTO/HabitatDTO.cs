namespace Zoo.DTO
{
    public class HabitatDTO
    {
        public string? id { get; set; }
        public string name { get; set; }
        public string? weather { get; set; }
        public VegetationTypeDTO? vegetation_type { get; set; }
        public HabitatDTO(string? id, string name, string? weather, VegetationTypeDTO? vegetation_type)
        {
            this.id = id;
            this.name = name;
            this.weather = weather;
            this.vegetation_type = vegetation_type;
        }

    }
    public class HabitatUpdateDTO
    {
        public string? name { get; set; }
        public string? weather { get; set; }
        public string? vegetation_type_id { get; set; }
        public HabitatUpdateDTO(string name, string? weather, string vegetation_type_id)
        {
            this.name = name;
            this.weather = weather;
            this.vegetation_type_id = vegetation_type_id;

        }
    }
}