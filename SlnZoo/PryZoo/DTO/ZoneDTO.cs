namespace Zoo.DTO
{
    public class ZoneDTO
    {
        public string? id { get; set; }
        public string name { get; set; }
        public float extention { get; set; }
        public ZoneDTO(string? id, string name, float extention)
        {
            this.id = id;
            this.name = name;
            this.extention = extention;
        }
    }

    public class ZoneUpdateDTO
    {
        public string? name { get; set; }
        public float? extention { get; set; }
        public ZoneUpdateDTO(string? name, float? extention)
        {
            this.name = name;
            this.extention = extention;
        }
    }


}