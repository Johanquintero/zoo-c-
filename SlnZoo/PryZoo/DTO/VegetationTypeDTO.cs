namespace Zoo.DTO
{
    public class VegetationTypeDTO
    {
        public string? id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public VegetationTypeDTO(string? id, string name,string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }

    public class VegetationTypeUpdateDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public VegetationTypeUpdateDTO(string? name,string? description)
        {
            this.name = name;
            this.description = description;
        }
    }

}