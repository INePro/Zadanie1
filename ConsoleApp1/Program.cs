using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работает только со строчными буквами.");

            Console.WriteLine("Введите словво - ");

            String s = Console.ReadLine();

            Console.WriteLine("Введите число для вычета - ");

            int a = Convert.ToInt32(Console.ReadLine());
            char[] m = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] chArray = s.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                for (int j = 0; j < m.Length; j++)
                {
                    if (chArray[i] == m[j])
                    {
                        if (j-a<0)
                        {
                            chArray[i] = m[m.Length-j-a];
                            break;
                        }
                        else
                        { 
                            chArray[i] = m[j - a];
                            break;
                        }
                    }
                }
            }
            foreach (var item in chArray)
            {
                Console.Write(item);
            }
        }
    }
}