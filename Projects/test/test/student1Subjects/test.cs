using System;
using System.Collections.Generic;

namespace test
{
    public class test
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Dictionary<String, List<String>> studentSubjectMap = new Dictionary<String, List<String>>();

            List<String> student1Subjects = new List<String>();

            student1Subjects.Add("English");
            student1Subjects.Add("Hindi");

            List<String> student2Subjects = new List<String>();

            student2Subjects.Add("Hindi");
            student2Subjects.Add("Kannada");

            List<String> student3Subjects = new List<String>();

            student3Subjects.Add("Maths");
            student3Subjects.Add("Science");

            List<String> student4Subjects = new List<String>();

            student4Subjects.Add("Kannada");
            student4Subjects.Add("Social");
            student4Subjects.Add("Science");

            studentSubjectMap.Add("StudentA", student1Subjects);
            studentSubjectMap.Add("StudentB", student2Subjects);
            studentSubjectMap.Add("StudentC", student3Subjects);
            studentSubjectMap.Add("StudentD", student4Subjects);

            Dictionary<List<String>, List<String>> studentSubjectMapOutput = new Dictionary<List<String>, List<String>>();


            //Console.WriteLine(studentSubjectMap);
            //foreach (KeyValuePair<String, List<String>> kvp in studentSubjectMap)
            //{
            //    Console.WriteLine(kvp.Key);

            //    foreach (string value in kvp.Value)
            //    {

            //        Console.WriteLine(value+" ");

            //    }

            //}

            foreach (var value in studentSubjectMapOutput)
            {
                Console.WriteLine("values are " + value.Value);
            }
        }
    }
}
