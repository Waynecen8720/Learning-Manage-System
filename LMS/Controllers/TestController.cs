using BL.Managers.Interfaces;
using Data.Database;
using Data.Repositories;
using LMS.filters;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LMS.Controllers
{
    //[Authorize]
    public class TestController : ApiController
    {

       
        
            private readonly IUserManager _userManager;

            public TestController(IUserManager userManager)
            {
                _userManager = userManager;
            }

            [AllowAnonymous]
            [HttpPost]
            [Route("api/test/createuser")]
            public IHttpActionResult Post(UserRegisterDto user)
            {
                var userDisplay = _userManager.CreateUser(user);
                return Ok(userDisplay);
            }


            [HttpGet]
            [Route("api/test")]
            public IHttpActionResult Test()
            {
                using (LMSEntities context = new LMSEntities())
                {
                    var studentRepo = new StudentRepository(context);
                    var students = studentRepo.Records;
                    return Ok(students);
                }
            }

        }

}
