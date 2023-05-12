namespace demoapiweb.Dto
{
    public class CompanyDto
    {
        public int Companyid { get; set; }

        public string Legalname { get; set; } 

        public string Businessname { get; set; } 

        public string ParentCompany { get; set; } 

        public string CompanyStatus { get; set; } 

        public string TimeZone { get; set; } 

        public string Country { get; set; } 

        public string Email { get; set; } 

        public string Phone { get; set; } 

        public DateTime CreatedAt { get; set; }

        public DateTime Updated { get; set; }

        public string? CreatedBy { get; set; }

        public string? UpdateBy { get; set; }
    }
}
