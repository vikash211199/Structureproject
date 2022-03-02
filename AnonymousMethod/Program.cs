using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{

    class AnonymousTypesEx
    {
        static public void Main()
        {
            //Creating and initializing anonymous object
            var trainee = new
            {
                t_id = 1813007,
                t_name = "Bharath",
                t_course = ".NET",
                t_score = 98,
                t1_id = 1813086,
                t1_name = "Vikash",
                t1_course = "Java",
                t1_score = 99

            };

            //Accessing the object properties
            Console.WriteLine("Trainee ID  :{0}", trainee.t_id);
            Console.WriteLine("Name        :{0}", trainee.t_name);
            Console.WriteLine("Course      :{0}", trainee.t_course);
            Console.WriteLine("Score       :{0}", trainee.t_score);

            //Passing anonymous types to methods
            DisplayTrainee(trainee);

            Console.ReadKey();
        }

        static public void DisplayTrainee(dynamic trainee1)
        {
            Console.WriteLine("Trainee ID  :{0}", trainee1.t1_id);
            Console.WriteLine("Name        :{0}", trainee1.t1_name);
            Console.WriteLine("Course      :{0}", trainee1.t1_course);
            Console.WriteLine("Score       :{0}", trainee1.t1_score);
        }
    }
}