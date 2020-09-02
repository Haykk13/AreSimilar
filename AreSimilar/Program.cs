using System;
using System.Runtime.InteropServices.ComTypes;

namespace AreSimilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first array length: ");
            int firstLength = int.Parse(Console.ReadLine());
            Console.Write("Enter second array length: ");
            int secondLength = int.Parse(Console.ReadLine());
            int[] first = new int[firstLength];
            int[] second = new int[secondLength];
            Console.WriteLine("Elements for the first array!");
            for (int i = 0; i < first.Length; i++)
            {
                Console.Write("Enter an element: ");
                first[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Element for the second array!");
            for (int i = 0; i < second.Length; i++)
            {
                Console.Write("Enter an element: ");
                second[i] = int.Parse(Console.ReadLine());
            }
            if(areSimilar(first, second))
            {
                Console.WriteLine("The arrays are similiar!");
            }
            else
            {
                Console.WriteLine("The arrays are NOT similiar!");
            }
            Console.ReadLine();
        }
        static bool areSimilar(int[] a, int[] b)
        {
            bool areSim = true;
            int count = 0;
            int index = -1;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if(a[i] != b[i])
                    {
                        if (count < 1)
                        {
                            areSim = false;
                            count++;
                            for (int j = i + 1; j < a.Length; j++)
                            {
                                if (a[i] == b[j] && a[j] == b[i])
                                {
                                    areSim = true;
                                    index = j;
                                    break;
                                }
                            }
                        }
                        else if(i != index)
                        {
                            areSim = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                areSim = false;
            }
            return areSim;
        }
    }
}
