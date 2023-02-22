namespace Zoo.DTO
{
    public class VegetationTypeDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public VegetationTypeDTO(int id, string name,string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }

}