namespace Zoo.DTO
{
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