﻿namespace konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "Data.txt";

            Methods.GetData(path);

            Console.WriteLine(Methods.DisplayData());
        }
    }
}
