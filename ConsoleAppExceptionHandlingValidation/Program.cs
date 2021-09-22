using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using classlibrary;

namespace ConsoleAppExceptionHandlingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 objBL = new Class1();
            objBL.Name = Console.ReadLine();
            objBL.Age = Int32.Parse(Console.ReadLine());

            ValidationResults results = Validation.Validate(objBL);

            if(!results.IsValid)
            {
                foreach (ValidationResult obj in results)
                {
                    Console.WriteLine(obj.Message);
                }
            }
            Console.ReadLine();

        }
    }
}
