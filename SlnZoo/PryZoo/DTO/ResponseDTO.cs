namespace Zoo.DTO
{
    public class ResponseDTO
    {
        public bool response { get; set; }
        public string data {get;set;}
        public string? error {get;set;}
        public ResponseDTO(bool response,string data, string error)
        {
            this.response = response;
            this.data = data;
            this.error = error;
        }
    }

}