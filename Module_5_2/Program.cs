using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Module;


/// <summary>
/// 2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
/// </summary>


namespace Module_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateArray arr = new CreateArray();
            arr.setArray();

            Console.ReadKey();
        }
    }
}
