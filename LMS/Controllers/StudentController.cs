using BL;
using BL.Managers.Interfaces;
using LMS.filters;
using Model.Dto;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LMS.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentManager _studentManager;

        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }
        [HttpGet]
        [Route("api/student/getbyid/{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(_studentManager.GetById(id));
        }

        public IHttpActionResult Get(string sortString = "id", string sortOrder = "asc", string searchValue = "", int pageSize = 10, int pageNumber = 1)
        {
            SearchAttribute search = new SearchAttribute()
            {
                SearchValue = searchValue,
                SortOrder = sortOrder,
                SortString = sortString,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            StudentSearchDto students = _studentManager.SearchStudent(search);

            return Ok(students);
            //List<StudentDto> students = _studentManager.GetAll();
            //return Ok(students);
        }
        [Route("api/searchstudent/{sortString}/{sortOrder}/{searchValue}/{pageSize}/{pageNumber}")]
        public IHttpActionResult SearchStudent(string sortString = "id", string sortOrder = "asc", string searchValue = "", int pageSize = 10, int pageNumber = 1)
        {
            SearchAttribute search = new SearchAttribute()
            {
                SearchValue = searchValue,
                SortOrder = sortOrder,
                SortString = sortString,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            StudentSearchDto students = _studentManager.SearchStudent(search);

            return Ok(students);
        }

        // GET: api/Student/5
        public IHttpActionResult GetResult(int id)
        {
            return Ok(_studentManager.GetByIdWithDetail(id));
        }

        // POST: api/Student
        public void Post([FromBody]Student student)
        {
            _studentManager.Create(student);
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }

    }
}
