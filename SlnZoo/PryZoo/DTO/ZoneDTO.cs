namespace Zoo.DTO
{
    public class ZoneDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public float extention { get; set; }
        public ZoneDTO(int id, string name, float extention)
        {
            this.id = id;
            this.name = name;
            this.extention = extention;
        }
    }

}