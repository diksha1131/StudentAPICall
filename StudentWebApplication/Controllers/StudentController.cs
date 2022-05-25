using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebApplication.Models;
using StudentWebApplication.StudentRequest;

namespace StudentWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/Student
        private readonly NewDatabaseContext _newdatabasecontext;

       public StudentController(NewDatabaseContext Studentinfo)
        {
            _newdatabasecontext = Studentinfo;
        }
        // GET: api/Country
        [HttpGet]
        public IActionResult Get()
        {
            var getstudent = _newdatabasecontext.NewStudent.ToList();
            return Ok(getstudent);
        }
        //[HttpGet("{}",Name ="Get")]

        //public string Get(int id)
        //{
        //    return "value";
        //}
        // POST: api/Student
        [HttpGet ("{id:int}")]
        public IActionResult Get2(int id)
        {
            try
            {
                var res = _newdatabasecontext.NewStudent.First(obj => obj.Studentid == id);
                if (res == null)
                    return NotFound();
                return Ok(res);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error!");
            }
        }
        // POST: api/CustomerAddress
        [HttpPost]
        public void Post([FromBody] sudentRequest value)
        {
           NewStudent  obje = new NewStudent();
            obje.StudentName = value.StudentName;
            obje.Age = value.Age;
            obje.Gender = value.Gender;
            obje.University = value.University;
            obje.City = value.City;
            
            _newdatabasecontext.NewStudent.Add(obje);
            _newdatabasecontext.SaveChanges();
        }


        //public IActionResult Post(NewDatabaseContext newDatabaseContext)
        //{

        //}
        //public void Post([FromBody] string value)
        //{

        //}

        //// PUT: api/Student/5
        //[HttpPut("{id}")] 
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
