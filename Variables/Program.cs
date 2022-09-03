using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            // Declaration { <datatype> - <identifire> }
            int num;

            // 2. Assignment { <identifire> = <Value> }
            num = 7;

            // 3. Initialization {<datatype> <identifire> = < Initial Value>
            int num2 = 7;

            //string  Refrence Type 
            string s1;
            s1 = "Younis";

            string s2 = "Y.";

            //Regular concatination {plus sign}
            string s3 = s1 + " " + s2;
            //Console.WriteLine(s3);

            string s4 = $"{s1} {s2}";
            //Console.WriteLine(s4);
            //---------------------------------------

            //Limit Value Type
            Console.WriteLine();
            Console.WriteLine($"byte    [Min {byte.MinValue}]    ==> [Max {byte.MaxValue}]");
            Console.WriteLine($"short   [Min {short.MinValue}]   ==> [Max {short.MaxValue}]");
            Console.WriteLine($"Ushort  [Min {ushort.MinValue}]  ==> [Max {ushort.MaxValue}]");
            Console.WriteLine($"int     [Min {int.MinValue}]     ==> [Max {int.MaxValue}]");
            Console.WriteLine($"uint    [Min {uint.MinValue}]    ==> [Max {uint.MaxValue}]");
            Console.WriteLine($"long    [Min {long.MinValue}]    ==> [Max {long.MaxValue}]");
            Console.WriteLine($"ulong   [Min {ulong.MinValue}]   ==> [Max {ulong.MaxValue}]");
                                       
            Console.WriteLine($"float   [Min {float.MinValue}]   ==> [Max {float.MaxValue}]");
            Console.WriteLine($"double  [Min {double.MinValue}]  ==> [Max {double.MaxValue}]");
            Console.WriteLine($"decimal [Min {decimal.MinValue}] ==> [Max {decimal.MaxValue}]");


        }


    }
}
