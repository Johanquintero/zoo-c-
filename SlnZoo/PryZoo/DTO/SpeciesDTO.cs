namespace Zoo.DTO
{
    public class SpeciesDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string scientific_name { get; set; }
        public string description { get; set; }
        public ZoneDTO zone { get; set; }
        public SpeciesDTO(string id, string name,string scientific_name, string description, ZoneDTO zone)
        {
            this.id = id;
            this.name = name;
            this.scientific_name = scientific_name;
            this.description = description;
            this.zone = zone;
        }
    }

}