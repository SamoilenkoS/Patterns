﻿using System;

namespace Template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            University university = new University();

            school.Learn();
            university.Learn();

            Console.ReadKey();
        }
    }
}
