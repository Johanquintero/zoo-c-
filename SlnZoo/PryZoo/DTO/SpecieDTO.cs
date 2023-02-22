namespace Zoo.DTO
{
    public class SpecieDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string scientific_name { get; set; }
        public string description { get; set; }
        public ZoneDTO zone_id { get; set; }
        public SpecieDTO(int id, string name,string scientific_name, string description, ZoneDTO zone_id)
        {
            this.id = id;
            this.name = name;
            this.scientific_name = scientific_name;
            this.description = description;
            this.zone_id = zone_id;
        }
    }

}