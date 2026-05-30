using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_1
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            //Tính chu vi và diện tích HCN
            float a, b;
            Console.WriteLine("Nhap vao chieu dai cua hinh chu nhat a:");
            Console.WriteLine("Nhap vao chieu rong cua hinh chu nhat b:");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            float chuVi, dienTich;
            chuVi = (a + b) * 2;
            dienTich = a * b;
            Console.WriteLine("Chu vi hinh chu nhat la: " + chuVi);
            Console.WriteLine("Dien tich hinh chu nhat la: " + dienTich);
            Console.ReadKey();
        }
    }
}
