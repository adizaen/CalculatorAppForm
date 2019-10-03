using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMachine;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan nilai a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b : ");
            var b = Convert.ToInt32(Console.ReadLine());

            var cal = new Calculator();

            Console.WriteLine();
            Console.WriteLine("Hasil penambahan   : {0} + {1} = {2}", a, b, cal.Penambahan(a, b));
            Console.WriteLine("Hasil pengurangan  : {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            Console.WriteLine("Hasil perkalian    : {0} * {1} = {2}", a, b, cal.Perkalian(a, b));
            Console.WriteLine("Hasil pembagian    : {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b));
            Console.WriteLine("Hasil perpangkatan : {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b));
            Console.WriteLine("Hasil modulo       : {0} % {1} = {2}", a, b, Calculator.Modulo(a, b));

            Console.ReadKey();
        }
    }
}
