using System;
using Dotnet_OData_Demo.Models;
using Dotnet_OData_Demo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace Dotnet_OData_Demo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class StudentController:ControllerBase
	{
		private readonly IStudentService studentService;

		public StudentController(IStudentService studentService) => this.studentService = studentService;

		[EnableQuery]
		[HttpGet]
		public ActionResult<IQueryable<Students>> GetAllStudents()
		{
			IQueryable<Students> students = this.studentService.RetriveAllStudents();
			return Ok(students);
		}
	}
}

