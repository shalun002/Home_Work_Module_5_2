using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Module
{
    public class CreateArray
    {
        public void setArray()
        {
            try
            {
                int[] arr = new int[5];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[5]);
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
