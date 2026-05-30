using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_2
{
    internal class Bai4
    {
        public void Main(string[] args)
        {
            //nhập vào số nguyên n, in ra n!
            Console.OutputEncoding = Encoding.UTF8; 
            int n;
            int gt = 1;
            Console.Write("Nhập vào số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            //tính n giai thừa
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("i = ", +i);
                gt *= i;
            }
            Console.Writeline("Giá trị của giai thừa {0}! la: {1}", n, gt);
            Console.ReadKey();  
    }
}
