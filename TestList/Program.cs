using System;
using System.Collections.Generic;
using TestList.Models;

namespace TestList
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var list = new List<int>() { 0, 1, 700, 0 };

        //    // Find index of element 100 or greater.
        //    int result = list.FindIndex(element => element >= 100);
        //    Console.WriteLine("FINDINDEX: {0}", result);
        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            var personList = new List<PersonModel>();
            var personModel = new PersonModel();

            //first person data
            personModel.PId = 111;
            personModel.PName = "JOHN";

            personList.Add(personModel);

            //second person data
            personModel = new PersonModel();
            personModel.PId = 222;
            personModel.PName = "Sara";

            personList.Add(personModel);

            //third person data
            personModel = new PersonModel();
            personModel.PId = 333;
            personModel.PName = "Gale";

            personList.Add(personModel);

            // Find index of element 100 or greater.
            int result = personList.FindIndex(person => person.PName == "Sara");
            Console.WriteLine("FINDINDEX: {0}", result);
            Console.ReadKey();
        }
    }
}

//Reference: https://www.dotnetperls.com/list-find