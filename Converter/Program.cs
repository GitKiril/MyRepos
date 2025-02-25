﻿using System;

namespace Converter
{
    class Converter
    {
        private double HryvniaCal { get; set; }

        private readonly double usd;

        private readonly double eur;


        public Converter(double Usd, double Eur)
        {
            this.usd = Usd;
            this.eur = Eur;
        }

        public double convert()
        {
            int choice;
            int number;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You choice a convert USD to Hryvnia");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = number * usd;
                    Console.WriteLine($"You'll get {HryvniaCal} Hryvnia");
                    break;

                case 2:
                    Console.WriteLine("You choice a convert Eur to Hryvnia");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = number * eur;
                    Console.WriteLine($"You'll get {HryvniaCal} Hryvnia");
                    break;

                case 3:
                    Console.WriteLine("You choice a convert Hryvnia to USD");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    double UsD = number / 36.95;
                    Console.WriteLine($"You'll get {UsD} USD");
                    break;

                case 4:
                    Console.WriteLine("You choice a convert Hryvnia to Eur");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    double EuR = number / 36.93;
                    Console.WriteLine($"You'll get {EuR} Eur");
                    break;

                default:
                    Console.WriteLine("Try Again");
                    break;
            }
            return HryvniaCal;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Which exchage you want to choice");
            Console.WriteLine("Write 1 to choice convert USD to Hryvnia \f" +
                "Write 2 to choice convert Eur to Hryvnia \f" +
                "Write 3 to choice convert Hryvnia to USD \f" +
                "Write 4 to choice convert Hryvnia to Eur");
            Converter converter = new Converter(36.95, 36.93);
            converter.convert();
        }
    }

}