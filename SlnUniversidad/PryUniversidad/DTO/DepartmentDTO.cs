namespace Universidad.DTO
{
    public class DepartmentDTO
    {
        public string id {get; set;}
        public string name {get; set;}
        public DepartmentDTO(string id,string name){
            this.id = id;
            this.name = name;
        }
    }

}