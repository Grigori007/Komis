namespace Komis.Models
{
    public class Opinion
    {
        public int Id { get; set; }
        public  string UserName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool WaitingForResponse { get; set; }
    }
}
