namespace SaitynoLab.Server.Dto
{
    public class OrderUpdateDto
    {
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
    }
}
