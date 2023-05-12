namespace demoapiweb.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string Phone { get; set; } 

        public int CompanyId { get; set; }

        public string Email { get; set; }

        public string? TimeZone { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime Updated { get; set; }

        public string? CreatedBy { get; set; }

        public string? UpdateBy { get; set; }
    }
}
