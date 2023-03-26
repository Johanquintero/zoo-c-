namespace Zoo.DTO
{
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