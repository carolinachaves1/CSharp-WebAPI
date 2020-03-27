using EFCoreCodeFirstSample_CodeMazedotCom.Entities;
using EFCoreCodeFirstSample_CodeMazedotCom.Models;


namespace ApiEmployeeUnitTests
{
    public class DBUnitTestsMockInicializer
    {

        public DBUnitTestsMockInicializer()
        { }

        public void Seed(EmployeeContext context)
        {
            context.Employees.Add
                (new Employee { EmployeeId = 7, FirstName = "Darth", LastName = "Silva", Email = "dv@gmail.com", DateOfBirth = new System.DateTime(1955, 04, 23), PhoneNumber = "998-995-885" });
            
            context.Employees.Add
                 (new Employee { EmployeeId = 8, FirstName = "Leia", LastName = "Silva", Email = "ls@gmail.com", DateOfBirth = new System.DateTime(1970, 03, 03), PhoneNumber = "222-333-555" });

            context.Employees.Add
                 (new Employee { EmployeeId = 9, FirstName = "Zé", LastName = "Soares", Email = "zs@gmail.com", DateOfBirth = new System.DateTime(1970, 03, 03), PhoneNumber = "999-888-555" });

        }
    }

    
}


            
                