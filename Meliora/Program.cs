using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meliora
{
    class Program
    {
        static void Main(string[] args)
        {
            //assuming counts from 1 to 50 means inclusively
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 7 == 0)
                        //using "Write" instead of "WriteLine" and adding a tab to the end
                        Console.Out.WriteLine("Library Meliora");
                    else
                        Console.Out.WriteLine("Library");
                }
                else if (i % 7 == 0)
                {
                    Console.Out.WriteLine("Meliora");
                }
                else
                {
                    Console.Out.WriteLine(i);
                }
            }
            Console.Out.WriteLine("Press enter to exit..");
            Console.Read();
        }
    }
}
/*
Produced Output:

1
2
Library
4
5
Library
Meliora
8
Library
10
11
Library
13
Meliora
Library
16
17
Library
19
20
Library Meliora
22
23
Library
25
26
Library
Meliora
29
Library
31
32
Library
34
Meliora
Library
37
38
Library
40
41
Library Meliora
43
44
Library
46
47
Library
Meliora
50
*/