using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_query
{
    class Program
    {
         #region
         /// <summary>
         /// simple Querey Expression
         /// </summary>
         /// <param name="args"></param>
         static void Main(string[] args)
         {
             IList<String> stringList = new List<string>()
             {
                 "C# Tutorials",
                 "Asp.Net",
                 "Learn C++",
                 "Java",
                 "Mvc Tutorials"
             };
             foreach (var str in stringList)
             {
                 Console.WriteLine(str);
             }
             var Result = from list in stringList
                          where list.Contains("a")
                          select list;
             foreach (var str in Result)
                 Console.WriteLine(str);
             Console.ReadLine();
         }
         #endregion


         /*#region
         /// <summary>
         /// Lambda Expression
         /// </summary>
         /// <param name="args"></param>
         static void Main(string[] args)
         {
             int[] scores = { 90, 71, 82, 93, 75, 82 };
             int hightScore_count = scores.Where(n => n > 80).Count();
             Console.WriteLine("{0} Scores are greater than 80", hightScore_count);
             Console.ReadLine();
         }
         #endregion */

       /* #region
        static void Main(string[] args)
        {
            // This query retrieves the total scores for First Year students, Second Years, and so on.
            // The outer Sum method uses a lambda in order to specify which numbers to add together.
            var categories =
        from student in students
        group student by student.Year into studentGroup
        select new { GradeLevel = studentGroup.Key, TotalScore = studentGroup.Sum(s => s.ExamScores.Sum()) };

            // Execute the query.   
            foreach (var cat in categories)
            {
                Console.WriteLine("Key = {0} Sum = {1}", cat.GradeLevel, cat.TotalScore);
            }
}
    #endregion*/
}
}
