using Domain.Gateway;
using Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataF.Repository.StudentRepository
{
    public class StudentRepositoryy : IStudentRepository
    {
        public void AddStudent(Student Std)
        {
            Console.WriteLine("O Seu Nome completo é :"+ Std.FristName+ " "+ Std.Lastname);
        }

        public void DeleteStude(Student std)
        {
            throw new NotImplementedException();
        }
        public void EditStudent(Student std)
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
