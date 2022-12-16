using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Файлы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа: ");
            string[] t = Console.ReadLine().Split(' ');
            double[] num = new double[t.Length];
            FileStream f = new FileStream("..\\..\\..\\out.dat", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(f);
            Console.Write("Введите ограничитель: ");
            double stop = 0;
            try
            {
                stop = Convert.ToDouble(Console.ReadLine());
            }
            catch { Console.WriteLine("Ошибка"); }
            for (int i = 0; i < t.Length; i++)
            {
                num[i] = Convert.ToDouble(t[i]);
                writer.Write((i + 1) + ") " + num[i] + "\n");
            }
            writer.Close();
            using (FileStream z = new FileStream("..\\..\\..\\out.dat", FileMode.Open))
            {
                int j = 0;
                byte[] bb = new byte[z.Length];
                z.Read(bb, 0, bb.Length);
                string[] n = Encoding.UTF8.GetString(bb).Split('\n');
                do
                {
                    if (j == num.Length) break;
                    if (num[j] < stop & ((j + 1) % 2 == 0 | (j + 1) % 2 == 2))
                    {
                        Console.WriteLine(n[j]);
                    }
                    j++;
                } while (true);
            }

        }
    }
}
