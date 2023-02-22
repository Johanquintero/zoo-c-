namespace Universidad.DTO
{
    public class CourseDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public int credits { get; set; }
        public DepartmentDTO department { get; set; }
        public CourseDTO(string id, string name, int credits, DepartmentDTO department)
        {
            this.id = id;
            this.name = name;
            this.credits = credits;
            this.department = department;
        }
    }

}