using demoapiweb.Dto;
using demoapiweb.Models;
using demoapiweb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace demoapiweb.Controllers
{
    [ApiController]
    [Route("/CompantTicket")]
    public class CompanyController:Controller
    {
        private ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            this._companyRepository = companyRepository;
        }

        [HttpGet(Name = "getCompany")]
        public Company GetCompany()
        {
            return _companyRepository.getall();
        }


        [HttpPost(Name ="insert")]
        public Company insert(CompanyDto companyDto)
        {
            Company c=new Company();
            c.Companyid = companyDto.Companyid;
            c.UpdateBy=companyDto.UpdateBy;
            c.Updated = companyDto.Updated;
            c.Businessname=companyDto.Businessname;
            c.CompanyStatus=companyDto.CompanyStatus;
            c.Country=companyDto.Country;
            c.Email=companyDto.Email;
            c.CreatedAt=companyDto.CreatedAt;
            c.CreatedBy=companyDto.CreatedBy;
            return _companyRepository.insertcompany(c);
        }
    }
}
