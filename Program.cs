using System;


namespace Basic_C__Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell the total number of students");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[studentCount];
            Console.WriteLine("Type The Names of the students");
            for (int i = 0; i < studentCount; i++)
            {
                students[i] = Console.ReadLine();
            }
            
            Console.WriteLine("---------------------");

            Array.Sort(students);



            for (int i = 0; i < studentCount; i++)
            {   
                Console.WriteLine(students[i]);
            }

            Console.ReadKey();
        
        }
    }
}
