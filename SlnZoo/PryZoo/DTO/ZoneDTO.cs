namespace Zoo.DTO
{
    public class ZoneDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public float extension { get; set; }

        public ZoneDTO(int id, string name, float extension)
        {
            this.id = id;
            this.name = name;
            this.extension = extension;
        }
    }

}