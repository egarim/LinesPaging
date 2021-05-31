using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinesPaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lines = new List<string>();
            string aLine = "";
            StringReader strReader = new StringReader(File.ReadAllText("Data.txt"));
            while (true)
            {
                aLine = strReader.ReadLine();
                if (aLine != null)
                {
                    Lines.Add(aLine);
                }
                else
                {

                    break;
                }
            }
            var LinesCount = Lines.Count();
            //int pageNumber = 0;
            int numberOfObjectsPerPage = 10;
            var PageTotalDouble = (double)LinesCount / numberOfObjectsPerPage;
            var PageTotal = LinesCount / numberOfObjectsPerPage;
            if ((PageTotalDouble % 1) != 0)
            {
                PageTotal = PageTotal + 1;
            }



            for (int pageNumber = 0; pageNumber < PageTotal; pageNumber++)
            {
                var queryResultPage = Lines
                    .Skip(numberOfObjectsPerPage * pageNumber)
                    .Take(numberOfObjectsPerPage);


                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"WritingPage:{pageNumber}");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
                foreach (var item in queryResultPage)
                {
                    Console.WriteLine(item);
                }
              
             
            }
            Console.ReadKey();
        }

            
     
        
    }
}
