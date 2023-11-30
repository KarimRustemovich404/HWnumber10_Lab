using HWnumber10_Lab.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber10_Lab
{
    internal class Program
    {
        static void DZ_12_1()
        {
            var library = new Library();

            library.AddBook(new Book("Солярис", "С. Лем", "Правая нога"));
            library.AddBook(new Book("Сборник задач и упражнений по математическому анализу", "Б.П. Демидович", "АСТ Астрель"));
            library.AddBook(new Book("Мы", "Е. Замятин", "ЁлкиПалки"));

            Console.WriteLine("Do sortitovki\n");
            library.DisplayLibrary();

            

            Console.WriteLine("Posle sortitovki\n");
            library.DisplayLibrary();

        }

        static void DZ_12_2()
        {
            ComplexNumber complexNumber1 = new ComplexNumber(2, 8);
            ComplexNumber complexNumber2 = new ComplexNumber(4, 10);
            ComplexNumber complexnumber3 = complexNumber1 + complexNumber2;

            Console.WriteLine(complexNumber1);
            Console.WriteLine(complexNumber2);
            Console.WriteLine("Total: " + complexnumber3); 
        }
        static void Main(string[] args)
        {
            DZ_12_1();
            DZ_12_2();
            Console.ReadKey();
        }
    }
}
