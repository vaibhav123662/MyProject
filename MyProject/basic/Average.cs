using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class Average
    {
        static void Main(string[] args)
        {
            int marathi, hindi, english, math, bio;
            marathi = 60;
            hindi = 55;
            english = 65;
            math = 73;
            bio = 56;
            float avg;

            avg = (marathi + hindi + english + math + bio) / 5;
            Console.WriteLine(avg);
        } 
    }
}
