using Domain.Gateway;
using System;
using System.Collections.Generic;
using System.Text;
 

namespace Domain.Entidade
{
    public class Student
    {
        public int Studentid { get; set; }
        public string FristName { get; set; }
        public string Lastname { get; set; }
        public DateTime Dob { get; set; }

        private IStudentRepository _stdRepo;

        public Student(IStudentRepository stdRepo)
        {
            _stdRepo = stdRepo;
        }
        public void Save()
        {
            _stdRepo.AddStudent(this);
        }
        public void edite()
        {
            _stdRepo.EditStudent(this);
        }
        public void get()
        {
            _stdRepo.GetStudents();
        }
        public void delit()
        {
            _stdRepo.DeleteStude(this);
        }
    }
}
