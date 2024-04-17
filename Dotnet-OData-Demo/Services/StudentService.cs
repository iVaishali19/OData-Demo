using System;
using Dotnet_OData_Demo.Models;

namespace Dotnet_OData_Demo.Services
{
	public class StudentService:IStudentService
	{
		public StudentService()
		{
		}

        public IQueryable<Students> RetriveAllStudents()
        {
            List<Students> students = new List<Students>()
            {
                new Students()
                {
                    Id = Guid.NewGuid(),
                    Name = "Vaishu",
                    Score = 83
                },
                new Students()
                {
                    Id = Guid.NewGuid(),
                    Name = "Aashu",
                    Score = 80
                },
                new Students()
                {
                    Id = Guid.NewGuid(),
                    Name = "Vanshu",
                    Score = 90
                }
            };

            return students.AsQueryable();
        }
    }
}

