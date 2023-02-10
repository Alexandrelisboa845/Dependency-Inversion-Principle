using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entidade;

namespace Domain.Gateway
{
    public interface IStudentRepository
    {
        void AddStudent(Student Std);
        void EditStudent(Student std);
        void DeleteStude(Student std);
        IList<Student> GetStudents();
    }
}
