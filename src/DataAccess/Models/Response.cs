namespace DataAccess.Models
{
   public class Response<T>
    {
        public T data { get; set; }

        public bool hasError { get; set; }

        public string error { get; set; }
    }
}
