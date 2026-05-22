using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai1
    {
        static void Main()
        {
            int x = 15;
            int y = 25;

            // Gọi hàm TinhTong và truyền vào 2 số cụ thể
            int tong = TinhTong(x, y);

            Console.WriteLine("--- BAI 1 ---");
            Console.WriteLine($"Tong cua {x} va {y} la: {tong}");
        }

        // Hàm tính tổng hai số nguyên
        static int TinhTong(int a, int b)
        {
            return a + b; // Trả về tổng của chúng
        }
    }
}
