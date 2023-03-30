using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OData6Demo.Api.Models;
using OData6Demo.Api.Services;

namespace OData6Demo.Api.Controllers
{
    // changed it to odata controller from controllerBase
    public class StudentsController : ODataController
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService) =>
            this.studentService = studentService;

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<Student>> Get()
        {
            IQueryable<Student> retrievedStudents =
                this.studentService.RetrieveAllStudents();

            return Ok(retrievedStudents);
        }
    }
}
