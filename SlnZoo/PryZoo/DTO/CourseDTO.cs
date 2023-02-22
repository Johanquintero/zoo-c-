namespace Zoo.DTO
{
    public class SpeciesDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public int credits { get; set; }
        public ZoneDTO department { get; set; }
        public SpeciesDTO(string id, string name, int credits, ZoneDTO department)
        {
            this.id = id;
            this.name = name;
            this.credits = credits;
            this.department = department;
        }
    }

}