using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            var s1 = "Younis";

            var f = 0f;
            var d = 0d;
            var m = 0m;
            var u = 0u;
            var l = 0l;
            var ul = 0ul;

            int onemillion = 1_000_000;

            var result = 200 / 3.0;

            //dynamic
            dynamic x = 9;
            x = "abc";
            x = 10m;

            char letter = 'A';
            Console.WriteLine(letter);

            //------------------------- For Example ----------------------
            var id = 1000;
            var fname = "Younis";
            var lname = "Y.";
            var salary = 1000d;
            var gender = 'M';
            var address = "Libya, Tripoli";

            Console.WriteLine("Employee");
            Console.WriteLine("--------");
            Console.WriteLine($"Id: ${id}");
            Console.WriteLine($"Name: {fname} {lname}");
            Console.WriteLine($"Salary: ${salary}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Address:{address}");
        }
    }
}
