using DataF.Repository;
using Domain.Entidade;
using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isso é um Espetaculo!");
            Student std = new Student(Repositoryfactory.GetStudentRepository())
            {
                FristName = "Alexandre ",
                Lastname = "Lisboa"
            } ;
            std.edite();
             
        }
    }
}
