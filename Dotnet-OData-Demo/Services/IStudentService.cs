using System;
using Dotnet_OData_Demo.Models;

namespace Dotnet_OData_Demo.Services
{
	public interface IStudentService
	{
		IQueryable<Students> RetriveAllStudents();
	}
}

