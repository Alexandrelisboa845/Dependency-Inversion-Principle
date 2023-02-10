using DataF.Repository.StudentRepository;
using Domain.Gateway;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataF.Repository
{
    public  class Repositoryfactory
    {
        public static IStudentRepository GetStudentRepository()
        {
            return new StudentRepositoryy();
        } 
    }
}
