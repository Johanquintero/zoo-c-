namespace Zoo.DTO
{
    public class SpecieDTO
    {
        public string? id { get; set; }
        public string scientific_name { get; set; }
        public string description { get; set; }
        public ZoneDTO zone { get; set; }
        public SpecieDTO(string? id, string scientific_name, string description, ZoneDTO zone)
        {
            this.id = id;
            this.scientific_name = scientific_name;
            this.description = description;
            this.zone = zone;
        }
    }
    public class SpecieUpdateDTO
    {
        public string? scientific_name { get; set; }
        public string? description { get; set; }
        public string? zone_id { get; set; }
        public SpecieUpdateDTO(string scientific_name, string description, string? zone_id)
        {
            this.scientific_name = scientific_name;
            this.description = description;
            this.zone_id = zone_id;
        }
    }

}