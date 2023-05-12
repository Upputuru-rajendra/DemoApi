using demoapiweb.Dto;
using demoapiweb.Models;
using demoapiweb.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Numerics;

namespace demoapiweb.Controllers
{
    [ApiController]
    [Route("/User")]
    public class UserController:ControllerBase
    {

        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet(Name ="getusers")]
        public User getallusers()
        {
            return _userRepository.getall();

        }
        [HttpPost(Name ="insertusers")]

        public User insertallusers(UserDto userDto)
        {
            User u1 = new();
            u1.Email = userDto.Email;
            u1.Phone = userDto.Phone;
            u1.Lastname = userDto.Lastname;  
            u1.Firstname = userDto.Firstname;
            u1.Updated = userDto.Updated;
            u1.Id=userDto.Id;
            u1.CompanyId=userDto.CompanyId;
            u1.CreatedAt=userDto.CreatedAt;
            u1.CreatedBy=userDto.CreatedBy;
           
            u1.TimeZone=userDto.TimeZone;
            return _userRepository.insert(u1);
        }
    }
};
