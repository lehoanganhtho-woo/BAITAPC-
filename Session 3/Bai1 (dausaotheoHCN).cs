using System;

public class Class1
{
	public Class1()
	{
        using System;

class Program
    {
        public static void Bai_1()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chiều cao: ");
            int cao = int.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng: ");
            int rong = int.Parse(Console.ReadLine());

            for (int i = 0; i < cao; i++)
            {
                for (int j = 0; j < rong; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
}
