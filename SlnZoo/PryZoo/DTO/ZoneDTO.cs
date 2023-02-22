namespace Zoo.DTO
{
    public class ZoneDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public float extension { get; set; }

        public ZoneDTO(string id, string name, float extension)
        {
            this.id = id;
            this.name = name;
            this.extension = extension;
        }
    }

}